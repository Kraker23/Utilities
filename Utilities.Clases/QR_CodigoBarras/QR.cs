using System.Drawing;
using System;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Utilities.Clases.QR_CodigoBarras
{
    /// <summary> Generador de QR mas avanzado</summary>
    public static class QR
    {
        


        /// <summary> Generar un QR </summary>
        /// <param name="texto">Texto del valor que contiene el QR</param>
        /// <param name="insertarImagen">Si se quiere insertar la imagen por defecto en el centro</param>
        /// <returns>La imagen del QR generada</returns>
        public static Image GenerarQR(string texto)
        {
            return GenerarQRImagen(texto,  null, Brushes.White, Brushes.Black, 200, 0);           
        }

        /// <summary> Generar un QR </summary>
        /// <param name="texto">Texto del valor que contiene el QR</param>
        /// <param name="tamañoQR">Tamaño del QR</param>
        /// <param name="insertarImagen">Si se quiere insertar la imagen por defecto en el centro</param>
        /// <returns>La imagen del QR generada</returns>
        public static Image GenerarQR(string texto, int tamañoQR)
        {
            return GenerarQRImagen(texto,  null , Brushes.White, Brushes.Black, tamañoQR,  0);           
        }

        /// <summary> Generar un QR </summary>
        /// <param name="texto">Texto del valor que contiene el QR</param>
        /// <param name="imagenInterna">Imagen interna a introducir</param>
        /// <param name="colorFondo">El color de Fondo del QR</param>
        /// <param name="colorCuadrados">El color que tendran los cuadrados del QR</param>
        /// <param name="tamañoQR">Tamaño del QR</param>
        /// <param name="tamañoImagenInterna">Tamaño de la Imagen interna, nunca sera superior al 30% del tamaño del QR</param>
        /// <returns>La imagen del QR generada</returns>
        public static Image GenerarQRImagen(string texto, Image imagenInterna, Brush colorFondo, Brush colorCuadrados, int tamañoQR = 200, int tamañoImagenInterna = 50)
        {
            if (colorCuadrados == null)
            {
                colorCuadrados = Brushes.Black;
            }
            if (colorFondo == null)
            {
                colorFondo = Brushes.White;
            }

            var qrcoder = new QrEncoder(ErrorCorrectionLevel.H);
            var qrCode = qrcoder.Encode(texto);

            var render = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Four), colorCuadrados, colorFondo);

            using (Stream stream = new MemoryStream())
            {
                tamañoQR = tamañoQR > 0 ? tamañoQR : 200;

                render.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream, new Point(10, 10));

                var be = new Bitmap(stream);
                be = ResizeImage(be, tamañoQR, tamañoQR);
                Graphics ge = Graphics.FromImage(be);

                if (imagenInterna != null)
                {

                    tamañoImagenInterna = tamañoImagenInterna > 0 ? tamañoImagenInterna : 50;
                    //Aseguramos que el Tamaño de la imagen interior no supera el 30% del tamañao del QR
                    if (tamañoQR * 30 / 100 < tamañoImagenInterna)
                    {
                        tamañoImagenInterna = tamañoQR * 30 / 100;
                    }
                    imagenInterna = ResizeImage(imagenInterna, tamañoImagenInterna, tamañoImagenInterna);


                    var bi = new Bitmap(tamañoImagenInterna + 10, tamañoImagenInterna + 10);
                    Graphics gi = Graphics.FromImage(bi);
                    gi.Clear(Color.White);
                    gi.DrawImage(imagenInterna, 5, 5, tamañoImagenInterna, tamañoImagenInterna);


                    ge.DrawImage(bi, (tamañoQR - tamañoImagenInterna) / 2, (tamañoQR - tamañoImagenInterna) / 2, tamañoImagenInterna, tamañoImagenInterna);
                }
                return be;
            }
        }

        /// <summary>Rescalar una imagen </summary>
        /// <param name="imagen">Imagen a Rescalar</param>
        /// <param name="ancho">Ancho de la imagen que se quiere poner</param>
        /// <param name="alto">alto de la imagen que se quiere poner</param>
        /// <returns>Imagen Rescalada</returns>
        private static Bitmap ResizeImage(Image imagen, int ancho, int alto)
        {
            Graphics graphics = null;
            try
            {
                var b = new Bitmap(ancho, alto);
                graphics = Graphics.FromImage(b);

                graphics.CompositingQuality = CompositingQuality.HighQuality;
                
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.Clear(Color.Transparent);

                graphics.DrawImage(imagen, new Rectangle(0, 0, ancho, alto),
                                   new Rectangle(0, 0, imagen.Width, imagen.Height), GraphicsUnit.Pixel);
                return b;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (graphics != null)
                    graphics.Dispose();
            }
        }


    }

}
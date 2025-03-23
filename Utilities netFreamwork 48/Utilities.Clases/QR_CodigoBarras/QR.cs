using System.Drawing;
using System;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Utilities.Clases.QR_CodigoBarras
{
    /// <summary> Generador de QR mas avanzado</summary>
    public static class QR
    {
        public readonly static char firstChar = '<';
        public readonly static char separatorChar = '-';
        public readonly static char lastChar = '>';
        public static Bitmap imagenPorDefecto = null;// Properties.Resources.TUV_R;

        #region Qr Linea

        //Generar el Texto con el formato adecuado '<texto1-texto2-texto3>'
        public static string GenerarTexto(string[] valores)
        {
            string textResultado = string.Empty;

            textResultado += firstChar;
            foreach (string valor in valores)
            {
                if (!string.IsNullOrEmpty(textResultado))
                {
                    textResultado += separatorChar + valor;
                }
                else
                {
                    textResultado += valor;
                }
            }
            textResultado = firstChar + textResultado + lastChar;
            return textResultado;
        }

        //Generar el Texto con el formato adecuado para Matricula y codigo Anulacion '<matricula-codAnulacion>'
        public static string GenerarTexto(string matricula, string codAnulacion)
        {
            if (!string.IsNullOrEmpty(codAnulacion))
            {
                return GenerarTexto(matricula + ' ' + codAnulacion);
            }
            else
            {
                return GenerarTexto(matricula);
            }
        }

        //Generar el Texto con el formato adecuado '<texto1-texto2-texto3>'
        public static string GenerarTexto(string valor)
        {
            string textResultado = string.Empty;

            string[] valores = valor.Split(' ');
            foreach (string valorAux in valores)
            {
                if (!string.IsNullOrEmpty(textResultado))
                {
                    textResultado += separatorChar + valorAux;
                }
                else
                {
                    textResultado += valorAux;
                }
            }
            textResultado = firstChar + textResultado + lastChar;
            return textResultado;
        }

        //Recuperar listado de textos a partir del formato '<texto1-texto2-texto3>'
        public static List<string> GetTexto(string texto)
        {
            List<string> resultado = new List<string>();
            if (texto.First() == firstChar)
            {
                texto = texto.Substring(1);
            }
            if (texto.Last() == lastChar)
            {
                texto = texto.Substring(0, texto.Length - 1);
            }
            string[] valores = texto.Split(separatorChar);

            foreach (string valor in valores)
            {
                resultado.Add(valor);
            }

            return resultado;
        }

        //Recuperar listado de textos a partir del formato '<texto1-texto2-texto3>' y la matricula y codAnulacion por separado
        public static List<string> GetTextoMatriculaCodAnulacion(string texto, out string matricula, out string codAnulacion)
        {
            List<string> resultado = GetTexto(texto);
            matricula = string.Empty;
            codAnulacion = string.Empty;

            if (resultado.Count() >= 1)
            {
                matricula = resultado.First();
            }
            if (resultado.Count() >= 2)
            {
                codAnulacion = resultado[1];
            }

            return resultado;
        }

        private static string RevisarFormatoTexto(string texto)
        {
            if (texto.First() == firstChar && texto.Last() == lastChar)
            {
                return texto;
            }
            return GenerarTexto(texto);
        }

        /// <summary>Generar QR ( el que se usa en Linea)</summary>
        /// <param name="Texto">Texto del cual se va a generar el QR</param>
        /// <returns>Bitmap del QR generado</returns>
        public static Bitmap GenerarQr(string Texto)
        {
            Bitmap bmp = null;
            try
            {
                QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
                QrCode qrCode = qrEncoder.Encode(Texto);

                int moduleSizeInPixels = 2;
                GraphicsRenderer renderer = new GraphicsRenderer(
                    new FixedModuleSize(moduleSizeInPixels, QuietZoneModules.Two),
                    Brushes.Black,
                    Brushes.White);
                DrawingSize dSize = renderer.SizeCalculator.GetSize(qrCode.Matrix.Width);

                bmp = new Bitmap(dSize.CodeWidth, dSize.CodeWidth);

                using (Graphics graphics = Graphics.FromImage(bmp))
                {
                    renderer.Draw(graphics, qrCode.Matrix);
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message, ex.InnerException);
            }
            return bmp;
        }

        #endregion

        /// <summary> Generar un QR </summary>
        /// <param name="texto">Texto del valor que contiene el QR</param>
        /// <param name="insertarImagen">Si se quiere insertar la imagen por defecto en el centro</param>
        /// <returns>La imagen del QR generada</returns>
        public static Image GenerarQRImagen(string texto, bool insertarImagen = true)
        {
            return GenerarQRImagen(texto, insertarImagen ? imagenPorDefecto : null, Brushes.White, Brushes.Black, 200, insertarImagen ? 50 : 0);
        }

        /// <summary> Generar un QR </summary>
        /// <param name="texto">Texto del valor que contiene el QR</param>
        /// <param name="tamañoQR">Tamaño del QR</param>
        /// <param name="insertarImagen">Si se quiere insertar la imagen por defecto en el centro</param>
        /// <returns>La imagen del QR generada</returns>
        public static Image GenerarQRImagen(string texto, int tamañoQR, bool insertarImagen = true)
        {
            return GenerarQRImagen(texto, insertarImagen ? imagenPorDefecto : null, Brushes.White, Brushes.Black, tamañoQR, insertarImagen ? 50 : 0);
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
            texto = RevisarFormatoTexto(texto);
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
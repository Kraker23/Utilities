using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Clases.ConversorImagenes
{
    public class ConvertirImagen
    {
        /// <summary>
        /// Tipos de formato de imagen
        /// </summary>
        public enum Formatos
        {
            jpeg,
            png,
            svg,
            bmp,
            icon
        }
        #region Descargar imagenes

        /// <summary>
        /// Descarga una imagen de Internet
        /// </summary>
        /// <param name="url"> Direccion URL de la imagen </param>
        /// <returns> Array de bytes de la imagen </returns>
        public static byte[] getImagenBytes(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadData(url);
            }
        }

        /// <summary>
        /// Descarga una imagen a partir de una URL y la guarda en un directorio de manera asincrona
        /// </summary>
        /// <param name="url"> URL de la imagen </param>
        /// <param name="pathDestino"> Ruta donde se guardara la imagen (ruta del directorio + nombre de la imagen) </param>
        public static void GuardarImagenFromUrl(string url, string pathDestino)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFileAsync(new Uri(url), pathDestino);
            }
        }

        #endregion

        #region Convertir formato imagenes

        /// <summary>
        /// Convierte una imagen de un formato a otro formato especifico
        /// </summary>
        /// <param name="convertir"> Formato al que queremos convertir la imagen </param>
        /// <param name="img"> Array de bytes de la imagen </param>
        /// <returns> Imagen convertida al formato selecionado </returns>
        public static Image ConvertirImagenTo(Formatos convertir, byte[] img)
        {
            Stream result = null;

            using (MemoryStream stream = new MemoryStream(img))
            {

                Bitmap bitmap = new Bitmap(stream);


                switch (convertir)
                {
                    case Formatos.jpeg:
                        bitmap.Save(result, ImageFormat.Jpeg);
                        break;

                    case Formatos.png:
                        bitmap.Save(result, ImageFormat.Png);
                        break;

                    case Formatos.bmp:
                        bitmap.Save(result, ImageFormat.Bmp);
                        break;

                    case Formatos.icon:
                        bitmap.Save(result, ImageFormat.Icon);
                        break;
                }


            }

            return Image.FromStream(result);
        }

        #endregion

    }
}

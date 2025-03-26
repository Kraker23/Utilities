using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesNet.Objetos.ConversorImagenes
{
    public static class ConverterImage
    {

        /// <summary>
        /// Convierte una imagen de un formato a otro formato especifico
        /// </summary>
        /// <param name="img"> Array de bytes de la imagen </param>
        /// <param name="format"> Formate Image (Jpeg,Png,Bmp,Icon,.)  </param>
        /// <returns> Imagen convertida al formato selecionado </returns>
        public static Image ImageTo(byte[] img, ImageFormat format)
        {
            Stream result = null;
            using (MemoryStream stream = new MemoryStream(img))
            {
                Bitmap bitmap = new Bitmap(stream);
                bitmap.Save(result, format);
            }
            return Image.FromStream(result);
        }

    }
}

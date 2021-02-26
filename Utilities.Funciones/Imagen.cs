using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Utilities.Funciones
{
    public class Imagen
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Image FromByteArray(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(Image data)
        {
            MemoryStream ms = new MemoryStream();
            data.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}

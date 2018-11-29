using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Clases.PortaPapeles
{
    public class PortaPapeles
    {
        /// <summary>
        /// Get Audio del Portapapeles
        /// </summary>
        /// <returns>System.IO.Stream </returns>
        public static System.IO.Stream getClipboardAudio()//(System.IO.Stream replacementAudioStream)
        {
            System.IO.Stream returnAudioStream = null;
            if (Clipboard.ContainsAudio())
            {
                returnAudioStream = Clipboard.GetAudioStream();
                //Clipboard.SetAudio(replacementAudioStream);
            }
            return returnAudioStream;
        }

        /// <summary>
        /// Get StringCollection del Portapapeles
        /// </summary>
        /// <returns>System.Collections.Specialized.StringCollection </returns>
        public static System.Collections.Specialized.StringCollection getClipboardFileDropList()//(System.Collections.Specialized.StringCollection replacementList)
        {
            System.Collections.Specialized.StringCollection returnList = null;
            if (Clipboard.ContainsFileDropList())
            {
                returnList = Clipboard.GetFileDropList();
               // Clipboard.SetFileDropList(replacementList);
            }
            return returnList;
        }

        /// <summary>
        /// Get Imagen del Portapapeles
        /// </summary>
        /// <returns>System.Drawing.Image </returns>
        public static System.Drawing.Image getClipboardImage()//(System.Drawing.Image replacementImage)
        {
            System.Drawing.Image returnImage = null;
            if (Clipboard.ContainsImage())
            {
                returnImage = Clipboard.GetImage();
               // Clipboard.SetImage(replacementImage);
            }
            return returnImage;
        }

        /// <summary>
        /// Get HtmlText del Portapapeles
        /// </summary>
        /// <returns>String </returns>
        public static String getClipboardHtmlText()//(String replacementHtmlText)
        {
            String returnHtmlText = null;
            if (Clipboard.ContainsText(TextDataFormat.Html))
            {
                returnHtmlText = Clipboard.GetText(TextDataFormat.Html);
                //Clipboard.SetText(replacementHtmlText, TextDataFormat.Html);
            }
            return returnHtmlText;
        }

        
    }
}

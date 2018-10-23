using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Clases.Vectores
{
    internal class Vectores
    {

        #region ·   P r o p i e d a d e s   p r i v a d a s

        private static byte[] _bClave = Encoding.UTF8.GetBytes("Y~a!x@W#c$b%`^x&A*M-e^L_");
        private static byte[] _bClaveHTML = Encoding.UTF8.GetBytes("Yax@WcbxAM-eL_blXC€n1G5d");

        private static byte[] _bVector = Encoding.UTF8.GetBytes("WiX^s$f%");
        //private static byte[] _bVectorHTML = Encoding.UTF8.GetBytes("WiX^s$f%");

        #endregion


        #region ·   P r o p i e d a d e s   p ú b l i c a s

        public static byte[] bClave { get { return Vectores._bClave; } }
        public static byte[] bClaveHTML { get { return Vectores._bClaveHTML; } }
        public static byte[] bVector { get { return Vectores._bVector; } }

        #endregion

    }


    internal class AESEncryptionVectores
    {

        private static byte[] _bClave = Encoding.UTF8.GetBytes("&%$#EskPe127aDmiN@$%@#");
        private static byte[] _bVector = new byte[] { 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x49, 0x6e, 0x20, 0x76, 0x61, 0x4d, 0x76 };


        public static byte[] Clave
        {
            get { return AESEncryptionVectores._bClave; }
        }


        public static byte[] Vector
        {
            get { return AESEncryptionVectores._bVector; }
        }

    }
}

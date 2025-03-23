using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Utilities.Test
{
    public class Encriptacion
    {
        const string initV = "7.#@7hF9Lñ.;@/3V";
        const string passF = "G7JkT3FdR#4(gjEw$";
        const string saltV = "8jfD@3&2%vJk";
        const string hashAlg = "SHA1";
        const int passIter = 2;
        const int keySize = 256;

        /// <summary>
        /// Encripta una cadena mediante una clave prefijada.
        /// </summary>
        /// <param name="cadena">Cadena a encriptar.</param>
        /// <returns>Cadena encriptada.</returns>
        public static string Encripta(string cadena)
        {
            return Encripta(cadena, passF);
        }
        /// <summary>
        /// Encripta una cadena mediante una clave no prefijada.
        /// </summary>
        /// <param name="cadena">Cadena a encriptar.</param>
        /// <param name="clave">Clave para la realizar la encriptación.</param>
        /// <returns>Cadena encriptada.</returns>
        public static string Encripta(string cadena, string clave)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initV);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltV);
            byte[] textoPlanoBytes = Encoding.UTF8.GetBytes(cadena);

            PasswordDeriveBytes password = new PasswordDeriveBytes(clave, saltValueBytes, hashAlg, passIter);
            byte[] keyBytes = password.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(textoPlanoBytes, 0, textoPlanoBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            string cipherText = Convert.ToBase64String(cipherTextBytes);
            return cipherText;
        }
        /// <summary>
        /// Desencripta una cadena mediante una clave prefijada.
        /// </summary>
        /// <param name="cadena">Cadena a desencriptar.</param>
        /// <returns>Cadena desencriptada.</returns>
        public static string DesEncripta(string cadena)
        {
            return DesEncripta(cadena, passF);
        }
        /// <summary>
        /// Desencripta una cadena mediante una variable sin prefijar.
        /// </summary>
        /// <param name="cadena">Cadena a desencriptar.</param>
        /// <param name="clave">Clave para realizar la desencriptación.</param>
        /// <returns>Cadena desencriptada.</returns>
        public static string DesEncripta(string cadena, string clave)
        {
            try
            {
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(initV);
                byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltV);
                byte[] cipherTextBytes = Convert.FromBase64String(cadena);
                PasswordDeriveBytes password = new PasswordDeriveBytes(clave, saltValueBytes, hashAlg, passIter);
                byte[] keyBytes = password.GetBytes(keySize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] textoPlanoBytes = new byte[cipherTextBytes.Length];
                int decrypedByteCount = cryptoStream.Read(textoPlanoBytes, 0, textoPlanoBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                string textoPlano = Encoding.UTF8.GetString(textoPlanoBytes, 0, decrypedByteCount);
                return textoPlano;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}

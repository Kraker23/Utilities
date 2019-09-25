using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Utilities.Extensions.Vectores;
using System.Web;

namespace Utilities.Extensions
{
    public static class StringExtensions
    {   
        /// <summary> Recortar un string hasta una determinada posicion</summary>
        /// <param name="value"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string cutString(this string value, int count)
        {
            string res=string.Empty;
            if (!string.IsNullOrEmpty(value))
            {
                if (value.Length > count)
                {
                    res = value.Substring(0, count);
                }
                else
                {
                    res = value;
                }
            }
            else
            {
                res = null;
            }
            return res;
        }

        /// <summary>
        /// Acortar un string por la longitud requerida
        /// </summary>
        /// <param name="value">String a modificar</param>
        /// <param name="count">Posicion maxima querida</param>
        /// <returns></returns>
        public static string ToSafeSubString(this string value, int count)
        {
            //string res = string.Empty;

            //if (value != null && value.Length > count)
            //{
            //    res = value.Substring(0, count) + " . . . ";
            //}
            //else
            //{
            //    res = value;
            //}
            return value != null && value.Length > count ?
                                                      value.Substring(0, count) + " . . . " : value;
            //return res;
        }

        /// <summary>
        /// Acortar un Fecha en formato String
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string cutDateString(this string value)
        {
            return value.Substring(0, 26);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string cutFromString(this string value)
        {
            string res = string.Empty;
            if (!string.IsNullOrEmpty(value))
            {
                string[] correos = value.Split(';');
                foreach (string correo in correos)
                {
                    res += correo + ";";
                }
            }
            return res;
        }
        public static string cutFromString(this string value, string cc, string cco)
        {
            string res = string.Empty;

            if (!string.IsNullOrEmpty(value))
            {
                string[] correos = value.Split(';');
                foreach (string correo in correos)
                {
                    res += correo + ";";
                }
            }
            if (!string.IsNullOrEmpty(cc))
            {
                string[] ccSplit = cc.Split(';');
                foreach (string correo in ccSplit)
                {
                    res += correo + ";";
                }
            }
            if (!string.IsNullOrEmpty(cco))
            {
                string[] ccoSplit = cco.Split(';');
                foreach (string correo in ccoSplit)
                {
                    res += correo + ";";
                }
            }

            return res;
        }

        /// <summary>
        /// Unir Asunto y texto de un correo para una vista y dando formato HTML
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static string unionSubjectBody(this string subject, string body)
        {
            string res = string.Empty;// "<b>" + subject + "</b> " + body.ToSafeSubString(100);
                                      //if (subject.Length + body.Length> 100)
                                      //{
                                      //   body= body.ToSafeSubString(100-subject.Length);
                                      //}

            return "<b>" + subject + "</b> <p style = \"color:#A9A9A9;\" > " + body.ToSafeSubString(120) + ". . . </p>";
        }


        /// <summary>
        /// Obtener texto sin formatos de Mayusculas, espacios, accentos, y '\n', '\r'
        /// </summary>
        /// <param name="texto">Texto a modificar</param>
        /// <returns></returns>
        public static string getSinFormato(this string texto)
        {
            string textoSinEspacios = string.Empty;
            textoSinEspacios = texto.ToUpper().Trim();

            textoSinEspacios = textoSinEspacios.Replace("\n", "");
            textoSinEspacios = textoSinEspacios.Replace("\r", "");
            textoSinEspacios = textoSinEspacios.Replace(" ", "");

            var normalizedString = textoSinEspacios.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < normalizedString.Length; i++)
            {
                var uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(normalizedString[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(normalizedString[i]);
                }
            }
            return (sb.ToString().Normalize(NormalizationForm.FormC));
        }

        /// <summary>
        /// Obtener el usuario de un correo
        /// </summary>
        /// <param name="email">Correo </param>
        /// <returns></returns>
        public static string getrUsuarioCorreo(this string email)
        {
            string res = string.Empty;
            if (!string.IsNullOrEmpty(email))
            {
                if (email.Contains("@"))
                {
                    int pos = email.IndexOf("@");
                    res = email.Substring(0, pos);
                }
            }
            return res;
        }

        /// <summary>
        /// Obtener el Dominio de un correo
        /// </summary>
        /// <param name="email">Correo </param>
        /// <returns></returns>
        public static string getDominioCorreo(this string email)
        {
            string res = string.Empty;
            if (!string.IsNullOrEmpty(email))
            {
                if (email.Contains("@"))
                {
                    int pos = email.IndexOf("@");
                    res = email.Substring(pos + 1, email.Length - pos - 1);
                }
            }
            return res;
        }


        /// <summary> Añadir un String a otro, seprandolo por un separador si se requiere </summary>
        /// <param name="value">Valor del string Principal</param>
        /// <param name="segundoString">Valor del string a incluir en el primero</param>
        /// <param name="separador">Separador si es requerido, sino null</param>
        /// <returns></returns>
        public static string añadirString(this string value, string segundoString, char? separador=',')
        {
            string res = string.Empty;
            if (!string.IsNullOrEmpty(segundoString))
            {
                if (string.IsNullOrEmpty(value))
                {
                    if (separador.HasValue)
                    {
                        res = segundoString + separador;
                    }
                    else
                    {
                        res = segundoString;
                    }
                }
                else
                {
                    if (separador.HasValue)
                    {
                        if (value.EndsWith(separador.Value.ToString()))
                        {
                            res = value + segundoString;
                        }
                        else if  (value.Substring(value.Length-1).Equals(separador.Value))
                        {
                            res = value + segundoString;
                        }
                        else
                        {
                            res = value + separador + segundoString;
                        }
                    }
                    else
                    {
                        res = value + segundoString;
                    }
                }

                value = res;
            }
            else
            {
                res = value;
            }
            return res;
        }

        /// <summary> Añadir un String a otro, seprandolo por un separador si se requiere </summary>
        /// <param name="value">Valor del string Principal</param>
        /// <param name="segundoString">Valor del string a incluir en el primero</param>
        /// <param name="separador">Separador si es requerido, sino null</param>
        /// <returns></returns>
        public static string añadirString(this string value, string segundoString, string separador = ",")
        {
            string res = string.Empty;
            if (!string.IsNullOrEmpty(segundoString))
            {
                if (string.IsNullOrEmpty(value))
                {
                    if (!string.IsNullOrEmpty(separador))
                    {
                        res = segundoString + separador;
                    }
                    else
                    {
                        res = segundoString;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(separador))
                    {
                        if (value.EndsWith(separador.ToString()))
                        {
                            res = value + segundoString;
                        }
                        else if (value.Substring(value.Length - 1).Equals(separador))
                        {
                            res = value + segundoString;
                        }
                        else
                        {
                            res = value + separador + segundoString;
                        }
                    }
                    else
                    {
                        res = value + segundoString;
                    }
                }

                value = res;
            }
            else
            {
                res = value;
            }
            return res;
        }

        /// <summary>Spliter por otro string</summary>
        /// <param name="str"></param>
        /// <param name="splitter"></param>
        /// <returns></returns>
        public static string[] Split(this string str, string splitter)
        {
            return str.Split(new[] { splitter }, StringSplitOptions.None);
        }

        /// <summary> Obtener el numero de apariciones de un texto en un texto mas grande</summary>
        /// <param name="texto">Texto en donde buscar</param>
        /// <param name="textoBuscar">Texto a buscar</param>
        /// <returns></returns>
        public static int getNumeroDeApariciones(this string texto, string textoBuscar)
        {
            if (textoBuscar.Length > texto.Length || textoBuscar.Equals("")) { return 0; }
            int lengthDifference = texto.Length - textoBuscar.Length;
            int occurencies = 0;
            for (int i = 0; i < lengthDifference; i++)
            {
                if (texto.Substring(i, textoBuscar.Length).Equals(textoBuscar)) { occurencies++; i += textoBuscar.Length - 1; }
            }
            return occurencies;
        }

        /// <summary>
        /// Duplicar el Texto X Veces 
        /// </summary>
        /// <param name="texto">texto que se va a dulicar</param>
        /// <param name="veces">Cuantas veces se va a Duplicar</param>
        /// <returns></returns>
        public static string DuplicarTexto(this string texto, int veces)
        {
            string resultado = string.Empty;
            if (veces > 1)
            {
                for (int i = 1; i <= veces; i++)
                {
                    resultado += texto;
                }
                return resultado;
            }
            else if (veces == 1)
            {
                return texto;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary> Obtener el nombre del archivo de una ruta</summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string getNameArchive(this string path)
        {
            string res = string.Empty;
            if (!string.IsNullOrEmpty(path))
            {
                res = Path.GetFileName(path);
            }
            return res;
        }

        /// <summary> Saber si el string NO es nulo o No esta vacio </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool HasContent(this string source)
        {
            bool resultado = false;
            if (!string.IsNullOrEmpty(source))
            {
                resultado = true;
            }
            return resultado;
        }

        /// <summary>
        /// comprueba si el formato es correcto de un correo
        /// </summary>
        /// <param name="email">Correo a comprobar</param>
        /// <returns></returns>
        public static bool FormatoCorreoValido(this string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        #region AndresC.

        /// <summary xml:lang="es">
        /// Concatena los textos dentro de la colección, separando los items por líneas
        /// </summary>
        /// <param name="x"></param>
        /// <returns>string concatenado</returns>
        public static string ConcatText(this List<string> x)
        {
            StringBuilder sb = new StringBuilder();

            x.ForEach(a => sb.AppendLine(a));

            if (x != null)
            {
                return sb.ToString();
            }
            else
            {
                return string.Empty;
            }
        }


        /// <summary xml:lang="es">
        /// Concatena los textos dentro de la colección, separando los items por líneas.
        /// Los mensajes iguales no se repiten
        /// </summary>
        /// <param name="x">List&gt;string&lt;</param>
        /// <returns>string concatenado</returns>
        public static string ConcatTextDistint(this List<string> x)
        {
            StringBuilder sb = new StringBuilder();

            if (x != null)
            {
                foreach (string s in x.Distinct())
                {
                    sb.AppendLine(s);
                }
            }

            return sb.ToString();
        }


        /// <summary xml:lang="es">
        /// Concatena los textos dentro de la colección, separando los items por líneas.
        /// Los mensajes iguales no se repiten
        /// </summary>
        /// <param name="x">List&gt;string&lt;</param>
        /// <param name="nodeTag">nombre para los diferentes elementos del xml</param>
        /// <returns>string concatenado</returns>
        public static string ConcatTextDistintXML(this List<string> x, string nodeTag)
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine(string.Format("<{0}>", rootNode));

            if (x != null)
            {
                foreach (string s in x.Distinct())
                {
                    sb.AppendLine(string.Format("<{0}>{1}</{0}>", nodeTag, s));
                }
            }

            //sb.AppendLine(string.Format("</{0}>", rootNode));

            return sb.ToString();
        }

        /// <summary>
        /// Método extensor asociado a un string que devuelve un entero
        /// </summary>
        /// <param name="cadena">this string</param>
        /// <param name="valorXdefecto">int</param>
        /// <returns>int</returns>
        public static int ToInteger(this string cadena, int valorXdefecto)
        {
            int result = valorXdefecto;

            try
            {
                result = Convert.ToInt32(cadena);
            }
            catch { }

            return result;
        }


        /// <summary>
        /// Sobrecarga del método extensor. Si no pasamos el 2º parámetro, se asume 0
        /// </summary>
        /// <param name="cadena">this string</param>
        /// <returns>int</returns>
        public static int ToInteger(this string cadena)
        {
            return ToInteger(cadena, 0);
        }

        public static bool SePuedeParsear(this string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                if (str.Contains("[a-zA-Z]+") == false)
                {
                    return true;
                }
            }
            return false;
        }

        public static int Parsear(string str)
        {
            if (str.SePuedeParsear())
            {
                int entero;
                if (int.TryParse(str, out entero))
                {
                    return entero;
                }
            }

            return 0;
        }

        /// <summary>
        /// Encripta una cadena de texto.
        /// </summary>
        /// <param name="sValor">this string: cadena a encriptar</param>
        /// <returns>string encriptado</returns>
        [Obsolete]
        public static string Encriptar(this string sValor)
        {
            string sResultado = string.Empty;
            TripleDESCryptoServiceProvider oTripleDESC = new TripleDESCryptoServiceProvider();

            try
            {
                byte[] bIN = Encoding.UTF8.GetBytes(sValor);

                using (MemoryStream oOutStream = new MemoryStream())
                {
                    CryptoStream oCryptoStream =
                        new CryptoStream(oOutStream, oTripleDESC.CreateEncryptor(Vectores.Vectores.bClave, Vectores.Vectores.bVector), CryptoStreamMode.Write);

                    oCryptoStream.Write(bIN, 0, bIN.Length);
                    oCryptoStream.FlushFinalBlock();

                    sResultado = Convert.ToBase64String(oOutStream.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message, ex.InnerException);
            }

            return sResultado;
        }


        /// <summary>
        /// Descifra un valor encriptado anteriormente con la función Encriptar.
        /// </summary>
        /// <param name="sValor">this string: valor encriptado</param>
        /// <returns>string con el valor</returns>
        [Obsolete]
        public static string Desencriptar(this string sValor)
        {
            string sResultado = string.Empty;
            TripleDESCryptoServiceProvider oTripleDESC = new TripleDESCryptoServiceProvider();

            try
            {
                byte[] bIN = Convert.FromBase64String(sValor);

                using (MemoryStream oOutStream = new MemoryStream())
                {
                    CryptoStream oCryptoStream =
                        new CryptoStream(oOutStream, oTripleDESC.CreateDecryptor(Vectores.Vectores.bClave, Vectores.Vectores.bVector), CryptoStreamMode.Write);

                    oCryptoStream.Write(bIN, 0, bIN.Length);
                    oCryptoStream.FlushFinalBlock();

                    sResultado = Encoding.UTF8.GetString(oOutStream.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message, ex.InnerException);
            }

            return sResultado;
        }


        /// <summary>
        /// Encripta una cadena de texto.
        /// </summary>
        /// <param name="sValor">this string: cadena a encriptar</param>
        /// <returns>string encriptado</returns>
        public static string EncriptarForURL(this string sValor)
        {
            string sResultado = string.Empty;
            TripleDESCryptoServiceProvider oTripleDESC = new TripleDESCryptoServiceProvider();

            try
            {
                byte[] bIN = Encoding.UTF8.GetBytes(sValor);

                using (MemoryStream oOutStream = new MemoryStream())
                {
                    CryptoStream oCryptoStream =
                        new CryptoStream(oOutStream, oTripleDESC.CreateEncryptor(Vectores.Vectores.bClave, Vectores.Vectores.bVector), CryptoStreamMode.Write);

                    oCryptoStream.Write(bIN, 0, bIN.Length);
                    oCryptoStream.FlushFinalBlock();

                    sResultado = Convert.ToBase64String(oOutStream.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message, ex.InnerException);
            }

            return HttpUtility.UrlEncode(sResultado);
        }


        /// <summary>
        /// Descifra un valor encriptado anteriormente con la función Encriptar.
        /// </summary>
        /// <param name="sValor">this string: valor encriptado</param>
        /// <returns>string con el valor</returns>
        public static string DesencriptarFromUrl(this string sValor)
        {
            sValor = HttpUtility.UrlDecode(sValor);

            string sResultado = string.Empty;
            TripleDESCryptoServiceProvider oTripleDESC = new TripleDESCryptoServiceProvider();

            try
            {
                byte[] bIN = Convert.FromBase64String(sValor);

                using (MemoryStream oOutStream = new MemoryStream())
                {
                    CryptoStream oCryptoStream =
                        new CryptoStream(oOutStream, oTripleDESC.CreateDecryptor(Vectores.Vectores.bClave, Vectores.Vectores.bVector), CryptoStreamMode.Write);

                    oCryptoStream.Write(bIN, 0, bIN.Length);
                    oCryptoStream.FlushFinalBlock();

                    sResultado = Encoding.UTF8.GetString(oOutStream.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message, ex.InnerException);
            }

            return sResultado;
        }


        #region ·   E n c r i p t a c i ó n   A E S

        /// <summary>
        /// Encripta una cadena de texto.
        /// </summary>
        /// <param name="clearText">this string: cadena a encriptar</param>
        /// <returns>string encriptado</returns>
        public static string EncryptAES(this string clearText)
        {
            byte[] encryptedData;
            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(clearText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(AESCryptoVectores.Clave, AESCryptoVectores.Vector);

            using (MemoryStream memorystream = new MemoryStream())
            {
                Rijndael algoritmo = Rijndael.Create();

                algoritmo.Key = pdb.GetBytes(32);
                algoritmo.IV = pdb.GetBytes(16);

                using (CryptoStream cryptostream = new CryptoStream(memorystream, algoritmo.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptostream.Write(clearBytes, 0, clearBytes.Length);
                }

                encryptedData = memorystream.ToArray();
            }

            return Convert.ToBase64String(encryptedData);
        }


        /// <summary>
        /// Descifra un valor encriptado anteriormente con la función EncryptAES.
        /// </summary>
        /// <param name="cipherText">this string: valor encriptado</param>
        /// <returns>string con el valor</returns>
        public static string DecryptAES(this string cipherText)
        {
            byte[] decryptedData;
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(AESCryptoVectores.Clave, AESCryptoVectores.Vector);

            using (MemoryStream memorystream = new MemoryStream())
            {
                Rijndael algortimo = Rijndael.Create();

                algortimo.Key = pdb.GetBytes(32);
                algortimo.IV = pdb.GetBytes(16);

                using (CryptoStream cryptostream = new CryptoStream(memorystream, algortimo.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cryptostream.Write(cipherBytes, 0, cipherBytes.Length);
                }

                decryptedData = memorystream.ToArray();
            }

            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }

        #endregion


        /// <summary>
        /// Valida si un string cumple una expresión regular
        /// </summary>
        /// <param name="x">string a validar</param>
        /// <param name="expresion">expresion regular a usar en la validación</param>
        /// <returns>bool: si cumple o no la expresión regular</returns>
        public static bool ValidarRegularExpresion(this string x, string expresion)
        {
            return Regex.IsMatch(x, expresion);
        }


        /// <summary>
        /// Valida que la cadena es un correo electrónico
        /// </summary>
        /// <param name="x">cadena a validar</param>
        /// <returns>bool indicando si es un correo</returns>
        public static bool EsCorreoElectronico(this string x)
        {
            return Regex.IsMatch(x, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
        }


        /// <summary>
        /// Valida que la cadena es un teléfono (españa)
        /// </summary>
        /// <param name="x">cadena a validar</param>
        /// <returns>bool indicando si es un telefono</returns>
        public static bool EsTelefono(this string x)
        {
            return Regex.IsMatch(x, @"^((\+34)?([6]|[7]|[9])[0-9]{8})|((\+376)[0-9]{6})$");
        }


        /// <summary>
        /// Convierte el string en una lista de clave-valor
        /// </summary>
        /// <param name="objectSeparator">separador entre objetos</param>
        /// <param name="valueSeparator">separador entre clave y valor</param>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> ToListKeyValue(this string x, string objectSeparator = "|", string valueSeparator = ":")
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();

            x.Split(objectSeparator.ToCharArray()).ToList().ForEach(o =>
            {
                if (o.Contains(valueSeparator))
                {
                    string[] data = o.Split(valueSeparator.ToCharArray());
                    list.Add(new KeyValuePair<string, string>(data[0].Trim(), data[1].Trim()));
                }

            });

            return list;
        }

        internal class AESCryptoVectores
        {

            private static byte[] _bClave = Encoding.UTF8.GetBytes("&%$#EskPe127aDmiN@$%@#");
            private static byte[] _bVector = new byte[] { 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x49, 0x6e, 0x20, 0x76, 0x61, 0x4d, 0x76 };


            public static byte[] Clave
            {
                get { return AESCryptoVectores._bClave; }
            }


            public static byte[] Vector
            {
                get { return AESCryptoVectores._bVector; }
            }

        }

        #endregion
    }

}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Utilities.Clases.XML
{
    public sealed class ExtentedStringWriter : StringWriter
    {
        private readonly Encoding stringWriterEncoding;
        public ExtentedStringWriter(StringBuilder builder, Encoding desiredEncoding)
            : base(builder)
        {
            this.stringWriterEncoding = desiredEncoding;
        }

        public override Encoding Encoding
        {
            get
            {
                return this.stringWriterEncoding;
            }
        }
    }

    /// <summary> Clase para agrupar funciones de serialización de cadenas </summary>
    public static class SerializerXML
    {
        /// <summary>
        /// Recibe un objeto y lo serializa en XML
        /// </summary>
        /// <param name=”_oObjetoToSerialize”>Objeto que será serializado</param>
        /// <returns>String con la información del objeto en formato XML</returns>
        public static string getObjectSerialized(object _oObjetoToSerialize)
        {
            string sRes = string.Empty;

            try
            {
                StringBuilder sbStringBuilder = new StringBuilder();

                using (StringWriter swStringWriter = new StringWriter(sbStringBuilder))
                {
                    XmlSerializer oXmlSerializer = new XmlSerializer(_oObjetoToSerialize.GetType());
                    oXmlSerializer.Serialize(swStringWriter, _oObjetoToSerialize);
                    sRes = swStringWriter.ToString();
                }

                return sRes;
            }
            catch (Exception e)
            {
                //– Gestor de errores
                throw e;
            }
        }


        /// <summary>
        /// Recibe un objeto y lo serializa en XML
        /// </summary>
        /// <param name=”_oObjetoToSerialize”>Objeto que será serializado</param>
        /// <returns>String con la información del objeto en formato XML</returns>
        public static string getObjectSerialized(object _oObjetoToSerialize, Encoding encoding)
        {
            string sRes = string.Empty;

            try
            {
                Encoding xml = Encoding.UTF8;
                StringBuilder sbStringBuilder = new StringBuilder();

                using (StringWriter swStringWriter = new StringWriter(sbStringBuilder))
                {
                    XmlSerializer oXmlSerializer = new XmlSerializer(_oObjetoToSerialize.GetType());
                    oXmlSerializer.Serialize(swStringWriter, _oObjetoToSerialize);
                    sRes = swStringWriter.ToString();
                }

                byte[] unicodeBytes = xml.GetBytes(sRes);

                return encoding.GetString(unicodeBytes);
            }
            catch (Exception e)
            {
                //– Gestor de errores
                throw e;
            }
        }



        /// <summary>
        /// Recibe un objeto y lo serializa en XML
        /// </summary>
        /// <param name=”_oObjetoToSerialize”>Objeto que será serializado</param>
        /// <returns>String con la información del objeto en formato XML</returns>
        public static string getObjectSerializedUTF8(object _oObjetoToSerialize)
        {
            string sRes = string.Empty;

            try
            {
                Encoding xml = Encoding.UTF8;
                StringBuilder sbStringBuilder = new StringBuilder();

                using (ExtentedStringWriter swStringWriter = new ExtentedStringWriter(sbStringBuilder,xml))
                {
                    XmlSerializer oXmlSerializer = new XmlSerializer(_oObjetoToSerialize.GetType());
                    oXmlSerializer.Serialize(swStringWriter, _oObjetoToSerialize);
                    sRes = swStringWriter.ToString();
                }
                return sRes;
            }
            catch (Exception e)
            {
                //– Gestor de errores
                throw e;
            }
        }


        /// <summary>
        /// Recibe un archivo XML y lo transforma en un string.
        /// </summary>
        /// <param name="_sXML_Load">string: ruta completa del archivo</param>
        /// <returns>string</returns>
        public static string getObjectSerialized(string _sXML_Load)
        {
            XmlDocument xDoc = new XmlDocument();
            XDocument xD = XDocument.Load(_sXML_Load);

            xDoc.Load(_sXML_Load);
            string sResultado = xDoc.InnerXml;
            xDoc = null;

            return sResultado;
        }


        /// <summary>
        /// Devuelve el objeto recibido dentro del XML.
        /// </summary>
        /// <param name="oToDeserializeObjectoType">object</param>
        /// <param name="sXML">string</param>
        /// <returns>object</returns>
        public static object getObjectDeserialized(object oToDeserializeObjectoType, string sXML)
        {
            object oObject = null;

            try
            {
                using (XmlTextReader oReader = new XmlTextReader(new StringReader(sXML)))
                {
                    //-- Deserializa Objetos con XML
                    XmlSerializer oSerializer = new XmlSerializer(oToDeserializeObjectoType.GetType());
                    oObject = oSerializer.Deserialize(oReader);
                }
            }
            catch
            {
                //--  Gestor de errores
            }

            return oObject;
        }


        /// <summary>
        /// Devuelve el objeto recibido dentro del XML.
        /// </summary>
        /// <param name="oToDeserializeObjectoType">object</param>
        /// <param name="sXML">string</param>
        /// <param name="defNamespace">string</param>
        /// <returns>object</returns>
        public static object getObjectDeserialized(object oToDeserializeObjectoType, string sXML, string defNamespace)
        {
            object oObject = null;

            try
            {
                using (XmlTextReader oReader = new XmlTextReader(new StringReader(sXML)))
                {
                    //-- Deserializa Objetos con XML
                    XmlSerializer oSerializer = new XmlSerializer(oToDeserializeObjectoType.GetType(), defNamespace);
                    oObject = oSerializer.Deserialize(oReader);
                }
            }
            catch
            {
                //--  Gestor de errores
            }

            return oObject;
        }


        /// <summary>
        /// Devuelve un string con el archivo xml recibido por parámetro.
        /// </summary>
        /// <param name="_sPathFile">string</param>
        /// <returns>string</returns>
        public static string getXMLFile(string _sPathFile)
        {
            string sXML = string.Empty;

            try
            {
                using (StreamReader sFile = File.OpenText(_sPathFile))
                {
                    sXML = sFile.ReadToEnd();
                    sFile.Close();
                }

                return sXML;
            }
            catch
            {
                return sXML;
            }
        }


        /// <summary>
        /// Realiza el volcado de un string contra un fichero de texto
        /// </summary>
        /// <param name="_sPathFile">string</param>
        /// <param name="_sMensaje">string</param>
        /// <param name="_bAppend">bool</param>
        public static void SaveXMLFile(string _sPathFile, string _sMensaje, bool _bAppend)
        {
            using (TextWriter sFile = new StreamWriter(_sPathFile, _bAppend))
            {
                sFile.Write(_sMensaje);
                sFile.Close();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_Src">string</param>
        /// <returns>string</returns>
        public static string getUnicode_Iso8859(string _Src)
        {
            Encoding iso = Encoding.GetEncoding("iso8859-1");
            Encoding unicode = Encoding.UTF8;
            byte[] unicodeBytes = unicode.GetBytes(_Src);

            return iso.GetString(unicodeBytes);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sText"></param>
        /// <returns></returns>
        public static string HTMLEncodeSpecialChars(string sText)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (char ca in sText)
            {
                if (ca > 127) // special chars
                {
                    sb.Append(String.Format("&#{0};", (int)ca));
                }
                else
                {
                    sb.Append(ca);
                }
            }

            return sb.ToString();
        }


        /// <summary>
        /// Eliminar los códigos html
        /// </summary>
        /// <param name="HTMLCode">string</param>
        /// <returns>string</returns>
        public static string RemoveHTMLTags(string HTMLCode)
        {
            return System.Text.RegularExpressions.Regex.Replace(HTMLCode, "<[^>]*>", "");
        }



        //NUEVO

        /// <summary>
        /// Convertir un XML en un objecto cuando es una lista de objectos (Opcion 1)
        /// </summary>
        /// <typeparam name="T">Objecto a Conseguir</typeparam>
        /// <param name="xml">XMl del archivo</param>
        /// <returns></returns>
        public static T Deserialize_Opcion1<T>(string xml) where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(xml))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        /// <summary>
        /// Convertir un XML en un objecto cuando es una lista de objectos (Opcion 2)
        /// </summary>
        /// <typeparam name="T">Objecto a Conseguir</typeparam>
        /// <param name="rutaArchivo">Ruta del archivo para leer lo</param>
        /// <returns></returns>
        public static T Deserialize_Opcion2<T>(string rutaArchivo) where T : class
        {
            System.Xml.Serialization.XmlSerializer reader2 = new System.Xml.Serialization.XmlSerializer(typeof(T));
            System.IO.StreamReader file = new System.IO.StreamReader(rutaArchivo);
            //Proyectos overview = (Proyectos)reader2.Deserialize(file);
            //file.Close();
            return (T)reader2.Deserialize(file);
        }

        /// <summary>
        /// Convertir un XML en un objecto cuando es una lista de objectos (Opcion 3)
        /// </summary>
        /// <typeparam name="T">Objecto a Conseguir</typeparam>
        /// <param name="xml">XMl del archivo</param>
        /// <returns></returns>
        public static T Deserialize_Opcion3<T>(string xml) where T : class
        {
            T result;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                result = (T)serializer.Deserialize(reader);
            }
            return result;
        }

       /* 
        * ///EJEMPLO DE COMO DESERIALIZAR
        * public static void EjemploDeserializar()
        {
            //Proyectos = new List<Proyecto>();
            string  NombreArchivo = ConfigurationManager.AppSettings["ArchivoConfig"].ToString();

            string rutaArchivo = string.Format("{0}\\{1}", System.Windows.Forms.Application.StartupPath.ToString(), NombreArchivo);

            string xml = SerializerXML.getXMLFile(rutaArchivo);

            
            Proyectos p1 = SerializerXML.Deserialize_Opcion1<Proyectos>(xml);


        }
        */
    }
}

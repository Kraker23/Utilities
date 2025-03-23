using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Utilities.Extensions.DataService
{
    [XmlRoot("mensaje")]
    public class MensajesDataServiceError
    {

        [XmlElement("error")]
        public List<MensajesDataServiceErrorData> Errores { get; set; }


        [XmlElement("alerta")]
        public List<MensajesDataServiceErrorData> Alertas { get; set; }

    }


    public class MensajesDataServiceErrorData
    {

        [XmlElement("tipo")]
        public string Tipo { get; set; }


        [XmlElement("msg")]
        public string Msg { get; set; }

    }


    [XmlRoot("MensajesBLError")]
    public class MensajesBLError
    {

        [XmlElement("CampoPK")]
        public string CampoPK { get; set; }


        [XmlElement("CampoPKValor")]
        public long CampoPKValor { get; set; }


        [XmlElement("CampoError")]
        public string CampoError { get; set; }


        [XmlElement("MensajeTitulo")]
        public string MensajeTitulo { get; set; }


        [XmlElement("MensajeError")]
        public string MensajeError { get; set; }

    }

    public static class MensajesBLErrorExtendders
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="errores"></param>
        /// <returns></returns>
        public static string ConcatenarListaErrores(this List<MensajesBLError> errores)
        {
            //StringBuilder listaStrings = new StringBuilder();

            //errores.ForEach(e => listaStrings.AppendLine(e.MensajeError));

            //return listaStrings.ToString();

            //convertiomos en List<string>
            List<string> x;
            StringBuilder sb = new StringBuilder();

            if (errores != null)
            {
                x = new List<string>();

                foreach (MensajesBLError s in errores.Distinct())
                {
                    x.Add(s.MensajeError);
                }

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
        public static string ConcatTextDistintXML(this List<MensajesBLError> data, string nodeTag)
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine(string.Format("<{0}>", rootNode));
            List<string> x = new List<string>();

            /*data.ForEach(d => x.Add(d.MensajeError));

            if (x != null)
            {
                foreach (string s in x.Distinct())
                {
                    sb.AppendLine(string.Format("<{0}>{1}</{0}>", nodeTag, s));
                }
            }
            */

            //TODO -- Comentar con Andrés
            data.ForEach(s => sb.AppendLine(string.Format("<{0}><tipo>{1}</tipo><msg>{2}</msg></{0}>", nodeTag == null ? string.Empty : nodeTag, s.MensajeTitulo, s.MensajeError)));
            //sb.AppendLine(string.Format("</{0}>", rootNode));

            return sb.ToString();
        }

    }
}

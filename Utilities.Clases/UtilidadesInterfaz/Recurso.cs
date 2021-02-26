using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Utilities.Clases.UtilidadesInterfaz
{
    /// <summary>
    /// Objeto recurso
    /// </summary>
    [XmlRoot("Recurso")]
    public class Recurso
    {

        /// <summary>
        /// string: idioma del recurso
        /// </summary>
        [XmlElement("Idioma")]
        public string Idioma { get; set; }


        /// <summary>
        /// string: clave del recurso, por la que se encontrará el registro
        /// </summary>
        [XmlElement("Key")]
        public string Key { get; set; }


        /// <summary>
        /// string: recurso
        /// </summary>
        [XmlElement("Texto")]
        public string Texto { get; set; }


        public override string ToString()
        {
            return string.Format("[{0}] - {1} : {2}", Idioma, Key, Texto);
        }
    }


    /// <summary>
    /// Colección de recursos
    /// </summary>
    [XmlRoot("RecursoCollection")]
    public class RecursoCollection
    {

        /// <summary>
        /// Recursos
        /// </summary>
        [XmlElement("Recursos")]
        public List<Recurso> Recursos;


        public RecursoCollection()
        {
            Recursos = new List<Recurso>();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;


namespace Utilities.Extensions.DataService
{

    /// <summary>
    /// Listado de traducciones
    /// </summary>
    [XmlRoot("TraduccionCollection")]
    public class TraduccionCollection
    {
        [XmlElement("Traducciones")]
        public List<Traduccion> Traducciones { get; set; }


        public TraduccionCollection()
        {
            Traducciones = new List<Traduccion>();
        }

    }


    /// <summary>
    /// Traduccion de un elemento
    /// </summary>
    [XmlRoot("Traduccion")]
    [DataContract]
    public class Traduccion : INotifyCollectionChanged
    {

        #region · Propiedades

            [XmlElement("IdTraduccion")]
            [DataMember]
            public long? IdTraduccion { get; set; }


            [XmlElement("Idioma")]
            [DataMember]
            public long Idioma { get; set; }


            [XmlElement("IdTabla")]
            [DataMember]
            public long? IdTabla { get; set; }


            [XmlElement("Tabla")]
            [DataMember]
            public string Tabla { get; set; }


            [XmlElement("IdColumna")]
            [DataMember]
            public long? IdColumna { get; set; }


            [XmlElement("Columna")]
            [DataMember]
            public string Columna { get; set; }


            [XmlElement("IdDato")]
            [DataMember]
            public long IdDato { get; set; }


            [XmlElement("Texto")]
            [DataMember]
            public string Texto { get; set; }


            /// <summary>
            /// A: Añadir,
            /// M: Modificar,
            /// B: Borrar
            /// </summary>
            [XmlElement("Accion")]
            [DataMember]
            public string Accion { get; set; }

        #endregion


        #region · Contructores

            public Traduccion()
            {
                IdTraduccion = null;
                Idioma = 1;
                Tabla = Columna = Texto = string.Empty;
            }


            public Traduccion(long? idTraduccion, long idioma, string tabla, string columna, long idDato, string texto, string accion)
            {
                IdTraduccion = idTraduccion;
                Idioma = idioma;
                Tabla = tabla;
                Columna = columna;
                IdDato = idDato;
                Texto = texto;
                Accion = accion;
            }


            public Traduccion(long? idTraduccion, long idioma, long tabla, long columna, long idDato, string texto, string accion)
            {
                IdTraduccion = idTraduccion;
                Idioma = idioma;
                IdTabla = tabla;
                IdColumna = columna;
                IdDato = idDato;
                Texto = texto;
                Accion = accion;
            }


            public Traduccion(long? idTraduccion, long idioma, string tabla, string columna, long idDato, string texto, string accion, long idtabla, long idcolumna)
            {
                IdTraduccion = idTraduccion;
                Idioma = idioma;
                Tabla = tabla;
                Columna = columna;
                IdDato = idDato;
                Texto = texto;
                Accion = accion;
                IdTabla = idtabla;
                IdColumna = idcolumna;
            }

        #endregion


        #region Miembros de INotifyCollectionChanged

            public event NotifyCollectionChangedEventHandler CollectionChanged;

        #endregion

    }

}

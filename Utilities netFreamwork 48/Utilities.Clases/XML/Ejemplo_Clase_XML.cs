using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Utilities.Clases.XML
{

    [XmlRoot("Proyectos")]
    public class Proyectos
    {
        public Proyectos() { proyectoItems = new List<Proyecto>(); }

        [XmlElement("Proyecto")]
        public List<Proyecto> proyectoItems { get; set; }
    }

    public class Proyecto
    {
        [XmlElement("ProyectoName")]
        public string ProyectoName { get; set; }
        [XmlElement("PathOrigen")]
        public string PathOrigen { get; set; }
        [XmlElement("PathDestino")]
        public string PathDestino { get; set; }
        [XmlElement("PathsExcluidos")]
        public List<PathFile> PathsExcluidos { get; set; }
        [XmlElement("FicherosExcluidos")]
        // public List<string> PathsExcluidos { get; set; }
        public List<FicheroFile> FicherosExcluidos { get; set; }


        //public List<Tuple<string, bool>> pathExcluidos { get; set; }
        //public List<Tuple<string, bool>> ficherosExcluidos { get; set; }
        public Proyecto()
        {

        }

        public Proyecto(string ProyectoName, string PathOrigen, string PathDestino, List<PathFile> PathsExcluidos, List<FicheroFile> FicherosExcluidos)
        {
            this.ProyectoName = ProyectoName;
            this.PathOrigen = PathOrigen;
            this.PathDestino = PathDestino;
            this.PathsExcluidos = PathsExcluidos;
            this.FicherosExcluidos = FicherosExcluidos;
        }
    }
    public class PathFile
    {
        public string Path { get; set; }
    }

    public class FicheroFile
    {
        public string Fichero { get; set; }
    }
}

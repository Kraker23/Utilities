using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Clases.PortaPapeles;
using Utilities.Controls.AutoUpdate;
using Utilities.Controls.EditarImagen;

namespace Utilities.Test
{
    static class ProgramMergeObjects
    {
        public static void Main()
        {
            Objeto a = new Objeto { entero = 1, enteroNulo = null, textoNulo = null, texto = "texto A", fecha = new DateTime(2023, 01, 25), bit = false, enteroRepetido = 3, textoRepetido = "texto Repetido", };
            Objeto b = new Objeto { entero = 2, enteroNulo = null, textoNulo = "fhg", texto = "texto B", fecha = new DateTime(2023, 01, 01), bit = true, enteroRepetido = 3, textoRepetido = "texto Repetido", };

            Utilities.Controls.MergeObjects.frmMergeObjects frmMergeObjects = new Utilities.Controls.MergeObjects.frmMergeObjects("objeto A", "Objeto B");
            frmMergeObjects.MergeObjects(a, b);
            frmMergeObjects.ShowDialog();
        }
    }

    public class Objeto
    {
        public int entero { get; set; }
        public int? enteroNulo { get; set; }
        public string texto { get; set; }
        public string textoNulo { get; set; }
        public DateTime fecha { get; set; }
        public bool bit { get; set; }
        public int enteroRepetido { get; set; }
        public string textoRepetido { get; set; }
    }
}

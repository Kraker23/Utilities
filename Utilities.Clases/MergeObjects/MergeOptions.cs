using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Clases.MergeObjects
{
    public class MergeOptions
    {
        /// <summary>Seleccion del Valor de una propiedad si la otra propiedad es Nula </summary>
        public bool ValueOverNull { get; set; } = false;

        /// <summary>Seleccion por Defecto de una Propiedad X o Y</summary>
        public PropMergeSelection SelectOverNone { get; set; } = PropMergeSelection.None;
    }
}

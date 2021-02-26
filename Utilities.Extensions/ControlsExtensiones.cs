using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Extensions
{
    /// <summary>
    /// Clase estatica para almacenar los metodos extensores para elementos de la UI (Windows)
    /// </summary>
    public static class ControlsExtensiones
    {
        /// <summary>
        /// Recupera una lista de todos los controles del tipo especiicado que se encuentran dentro del control
        /// </summary>
        /// <typeparam name="T">Tipo del control a recuperar</typeparam>
        /// <param name="container">Control donde se encuentran los controles</param>
        /// <returns>Lista de controles</returns>
        public static List<T> getControls<T>(this System.Windows.Forms.Control container) where T : System.Windows.Forms.Control
        {
            List<T> controls = new List<T>();

            foreach (System.Windows.Forms.Control c in container.Controls)
            {
                if (c is T)
                {
                    controls.Add((T)c);
                }

                controls.AddRange(getControls<T>(c));
            }

            return controls;
        }


        /// <summary>
        /// Recupera una lista de todos los controles del tipo especiicado que se encuentran dentro del ToolStrip
        /// </summary>
        /// <typeparam name="T">Tipo del control a recuperar</typeparam>
        /// <param name="container">ToolStrip donde se encuentran los controles</param>
        /// <returns>Lista de controles</returns>
        public static List<T> getToolStripButtons<T>(this System.Windows.Forms.ToolStrip container) where T : System.Windows.Forms.ToolStripButton
        {
            List<T> controls = new List<T>();

            foreach (System.Windows.Forms.ToolStripItem c in container.Items)
            {
                if (c is T)
                {
                    controls.Add((T)c);
                }
            }

            return controls;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Extensions;

namespace Utilities.Clases.UtilidadesInterfaz
{ /// <summary>
  /// Conjunto de funciones utiles para la interfaz de usuario (Windows)
  /// </summary>
    public class UtilidadesUI
    {
        /// <summary>
        /// Activar / Desactivar los ToolStripButton de la barra.
        /// </summary>
        /// <param name="ts">ToolStrip</param>
        /// <param name="enabled">bool</param>
        public static void changeEnableToolStripButtons(System.Windows.Forms.ToolStrip ts, bool enabled)
        {
            ts.getToolStripButtons<System.Windows.Forms.ToolStripButton>().ForEach(c => c.Enabled = enabled);
        }


        /// <summary>
        /// Establece los recursos para el formulario y sus controles
        /// </summary>
        /// <param name="f">Formulario</param>
        /// <param name="rec">Gestor de recursos de donde se recuperan los recursos</param>
        public static void SetRecursosForm(Form f, GestorRecursos rec)
        {
            rec.AllowSave = false;

            f.Text = rec.GetText(string.Format("{0}.Text", f.Name), f.Text);

            foreach (Control c in f.Controls)
            {
                SetRecursosControl(c, rec, f.Name);
            }

            rec.AllowSave = true;
            rec.SaveChanges();
        }


        /// <summary>
        /// Establece los recursos para el control y sus sub-controles
        /// </summary>
        /// <param name="c">Control a configurar</param>
        /// <param name="rec">Gestor de recursos de donde se recuperan los recursos</param>
        /// <param name="formName">Nombre del formulario para la agrupación de los recursos</param>
        private static void SetRecursosControl(Control c, GestorRecursos rec, string formName)
        {
            if (c is Form)
            {

            }
            else if (c is ToolStrip)
            {
                SetRecursosToolStrip(((ToolStrip)c).Items, rec, formName);
            }
            else if (c is MenuStrip)
            {
                SetRecursosToolStrip(((MenuStrip)c).Items, rec, formName);
            }
            else if (c is TextBox )//|| c is ucTextBoxMultiIdioma || c is UltraTextEditor || c is UltraComboEditor || c is UltraDateTimeEditor || c is UltraCurrencyEditor)
            {

            }
            //else if (c is Tools.Controls.ctlPanelGrupoPrueba)
            //{
            //    ((Tools.Controls.ctlPanelGrupoPrueba)c).Title = rec.GetText(string.Format("{0}.{1}.Title", formName, c.Name), ((Tools.Controls.ctlPanelGrupoPrueba)c).Title);

            //    if (c.ContextMenuStrip != null)
            //    {
            //        SetRecursosToolStrip(c.ContextMenuStrip.Items, rec, formName);
            //    }

            //    foreach (Control cont in c.Controls)
            //    {
            //        SetRecursosControl(cont, rec, formName);
            //    }
            //}
            else
            {
                c.Text = rec.GetText(string.Format("{0}.{1}.Text", formName, c.Name), c.Text);

                if (c.ContextMenuStrip != null)
                {
                    SetRecursosToolStrip(c.ContextMenuStrip.Items, rec, formName);
                }

                foreach (Control cont in c.Controls)
                {
                    SetRecursosControl(cont, rec, formName);
                }
            }
        }


        /// <summary>
        /// Establece los recursos para el control y sus sub-controles
        /// </summary>
        /// <param name="ts">Control a configurar</param>
        /// <param name="rec">Gestor de recursos de donde se recuperan los recursos</param>
        /// <param name="formName">Nombre del formulario para la agrupación de los recursos</param>
        private static void SetRecursosToolStrip(ToolStripItemCollection tsItms, GestorRecursos rec, string formName)
        {
            foreach (ToolStripItem tsi in tsItms)
            {
                tsi.Text = rec.GetText(string.Format("{0}.{1}.Text", formName, tsi.Name), tsi.Text);
                tsi.ToolTipText = rec.GetText(string.Format("{0}.{1}.ToolTipText", formName, tsi.Name), tsi.ToolTipText);

                if (tsi is ToolStripMenuItem)
                {
                    SetRecursosToolStrip(((ToolStripMenuItem)tsi).DropDownItems, rec, formName);
                }
                else if (tsi is ToolStripDropDownButton)
                {
                    SetRecursosToolStrip(((ToolStripDropDownButton)tsi).DropDownItems, rec, formName);
                }
            }
        }


        /// <summary>
        /// Establece los recursos para el control y sus sub-controles
        /// </summary>
        /// <param name="trad">Control a configurar</param>
        /// <param name="rec">Gestor de recursos de donde se recuperan los recursos</param>
        /// <param name="formName">Nombre del formulario para la agrupación de los recursos</param>
        public static void SetRecursosTraducciones(Traducciones.Traducciones trad, GestorRecursos rec)
        {
            rec.AllowSave = false;

            foreach (Traducciones.TextoLocalizable tl in trad.Textos)
            {
                tl.Texto = rec.GetText(string.Format("{0}.Text", tl.Key), tl.Texto);
            }

            rec.AllowSave = true;
            rec.SaveChanges();
        }
    }
}

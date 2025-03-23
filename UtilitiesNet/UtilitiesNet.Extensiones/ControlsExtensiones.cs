using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UtilitiesNet.Extensiones
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

            foreach (Control c in container.Controls)
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


        public static void Filtrar(this System.Windows.Forms.DataGridView grid, string texto, bool marcarCeldas)
        {
            grid.CurrentCell = null;

            if (string.IsNullOrEmpty(texto))
            {
                foreach (System.Windows.Forms.DataGridViewRow row in grid.Rows)
                {
                    row.Visible = true;
                    foreach (System.Windows.Forms.DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Empty;
                    }
                }
            }
            else
            {
                //DataGridViewRow row;
                //for(int i = grdTabla.Rows.Count-1; i>=0; i--)
                //{
                foreach (System.Windows.Forms.DataGridViewRow row in grid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        //row = grdTabla.Rows[i];
                        int numeroCeldas = 0;

                        foreach (System.Windows.Forms.DataGridViewCell cell in row.Cells)
                        {
                            cell.Style.BackColor = Color.Empty;

                            if (cell.Value != null && cell.Value.ToString().Contains(texto))
                            {
                                if (marcarCeldas) { cell.Style.BackColor = Color.Coral; }
                                numeroCeldas++;
                            }

                        }



                        if (numeroCeldas > 0)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }

                    }
                }
            }
        }



        public static void SetImageFilters(this OpenFileDialog ofd)
        {
            ofd.Filter = "Archivos de imagenes|*.jpg;*.jpeg;*.bmp;*.png;*.gif|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|BMP Files (*.bmp)|*.bmp";
            ofd.FilterIndex = 0;
        }


        /// <summary>Crea una imagen en memoria del control en el estado actual</summary>
        /// <param name="self">Control a realizar la imagen</param>
        /// <returns>Imagen</returns>
        public static Bitmap ToImage(this Control self, string path = null)
        {
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(self.Width, self.Height);
            self.DrawToBitmap(bmp, new Rectangle(new Point(0, 0), self.Size));

            if (path != null)
            {
                string lowpath = path.ToLower();
                if (lowpath.EndsWith(".bmp")) bmp.Save(path, System.Drawing.Imaging.ImageFormat.Bmp);
                else if (lowpath.EndsWith(".png")) bmp.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                else if (lowpath.EndsWith(".jpg")) bmp.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                else if (lowpath.EndsWith(".jpeg")) bmp.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                else if (lowpath.EndsWith(".gif")) bmp.Save(path, System.Drawing.Imaging.ImageFormat.Gif);
            }

            return bmp;
        }




        /// <summary> Proceso para actuar sobre el control dentro de un subproceso 
        /// Ejemplo de Uso :
        ///    textBox.InvokeIfRequired(c => { c.Visible = true; c.Text=""; });
        /// </summary>
        /// <param name="control">Control en el que se quiere hacer una accion</param>
        /// <param name="action">la accion que se quiere efectuar</param>
        public static void InvokeIfRequired(this Control control, Action<Control> action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)));
            }
            else
            {
                action(control);
            }
        }


    }
}

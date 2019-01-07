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
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new frmEditarImg());

           //Application.Run(new frmUpdate("\\\\172.18.2.159\\Software\\AutoUpdate\\AppBase", "\\\\172.18.2.159\\Software\\AutoUpdate\\AppRepositorio"));
           //Application.Run(new frmUpdate("C:\\Users\\Andres\\Desktop\\Gestor utilidades", "\\\\172.18.2.159\\Software\\Programacion\\Cristian\\MiniGestorCodigo"));
           //Application.Run(new frmUpdate("C:\\Users\\Andres\\Desktop\\pruebas Borrado archivos\\Archivo Cliente", "C:\\Users\\Andres\\Desktop\\pruebas Borrado archivos\\Archivos", "AdPlanningSharp.Planificador.Starter.exe.config"));

            //Image img = new Bitmap(Screen.AllScreens[0].WorkingArea.Width, Screen.AllScreens[0].WorkingArea.Height);
            //Application.Run(new frmCaptura(new Bitmap(img)));
            Application.Run(new frmCaptura());
            

            //Image img = PortaPapeles.getClipboardImage();
            //if (img != null)
            //{
            //    Application.Run(new frmEditarImg(new Bitmap(img)));
            //}
        }
    }
}

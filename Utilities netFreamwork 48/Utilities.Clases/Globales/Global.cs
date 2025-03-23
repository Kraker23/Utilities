using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Clases.Globales
{
    public static class Global
    {
        /// <summary> Ejecutar un .Exe</summary>
        /// <param name="ruta">Ruta donde se encuentra el Archivo .Exe</param>
        private static void RunApp(string ruta)
        {
            try
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = ruta;
                //'startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg"
                process.StartInfo = startInfo;
                process.Start();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        /// <summary> Cerrar Aplicacion en ejecucion a partir del nombre </summary>
        /// <param name="NameApp">Nombre del proceso que tiene la aplicacion</param>
        private static void CloseApp(string NameApp)
        {
            foreach (Process proceso in Process.GetProcesses())
            {
                if (proceso.ProcessName == NameApp)
                {
                    proceso.Kill();
                }
            }
        }

        /// <summary> Cerrar Aplicacion en ejecucion a partir del Id </summary>
        /// <param name="NameApp">Id del proceso que tiene la aplicacion</param>
        private static void CloseApp(int idProcessApp)
        {
            foreach (Process proceso in Process.GetProcesses())
            {
                if (proceso.Id == idProcessApp)
                {
                    proceso.Kill();
                }
            }
        }
    }
}

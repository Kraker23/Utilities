using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Consola
{
    public class Program
    {
        public static string ruta = @"C:\Program Files (x86)\GROUPM\Adplanning";

        public static void Main(string[] args)
        {
            AccesoPrueba();
        }

        private static void AccesoOriginal()
        {
            if (System.IO.Directory.Exists(ruta))
            {
                try
                {
                    AuthorizationRuleCollection collection =
                    Directory.GetAccessControl(ruta).GetAccessRules(true,
                     true, typeof(System.Security.Principal.NTAccount));
                    foreach (FileSystemAccessRule rule in collection)
                    {
                        if (rule.AccessControlType == AccessControlType.Allow)
                        {
                            break;
                        }
                    }

                    Console.WriteLine("Acceso de Lectura");
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                try
                {
                    using (FileStream fs = File.Create(Path.Combine(ruta,
                     "AccessTemp.txt"), 1, FileOptions.DeleteOnClose))
                    {
                        fs.Close();
                    }

                    Console.WriteLine("Acceso de Escritura");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("No existe la ruta");
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void AccesoPrueba()
        {
            string rutaLog = "\\\\madappp01113\\Aplicaciones\\GRM\\AdPlanning\\Produccion\\Accesos";

            bool existe = false;
            bool lectura = false;
            bool escritura = false;
            string error = string.Empty;

            if (System.IO.Directory.Exists(ruta))
            {
                existe = true;
                try
                {
                    AuthorizationRuleCollection collection =
                            Directory.GetAccessControl(ruta).GetAccessRules(true,
                                            true, typeof(System.Security.Principal.NTAccount));

                    foreach (FileSystemAccessRule rule in collection)
                    {
                        if (rule.AccessControlType == AccessControlType.Allow)
                        {
                            break;
                        }
                    }
                    lectura = true;
                    Console.WriteLine("Acceso de Lectura");
                }
                catch (UnauthorizedAccessException ex)
                {
                    error = string.IsNullOrEmpty(error) ? "Al mirar Accesos ->" + ex.Message : error + Environment.NewLine + "Al mirar Accesos ->" + ex.Message;
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    error = string.IsNullOrEmpty(error) ? "Al mirar Accesos ->" + ex.Message : error + Environment.NewLine + "Al mirar Accesos ->" + ex.Message;
                    Console.WriteLine(ex.Message);
                }


                try
                {
                    using (FileStream fs = File.Create(Path.Combine(ruta,
                     "AccessTemp.txt"), 1, FileOptions.DeleteOnClose))
                    {
                        fs.Close();
                    }
                    escritura = true;
                    Console.WriteLine("Acceso de Escritura");
                }
                catch (Exception ex)
                {
                    error = string.IsNullOrEmpty(error) ? "Al mirar Accesos ->" + ex.Message : error + Environment.NewLine + "Al mirar Accesos ->" + ex.Message;
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {

                error = string.IsNullOrEmpty(error) ? "Al mirar Accesos ->" + "No existe la ruta : ->" + ruta : error + Environment.NewLine + "Al mirar Accesos ->" + "No existe la ruta : ->" + ruta;
                Console.WriteLine("No existe la ruta");
            }

            if (System.IO.Directory.Exists(rutaLog))
            {

                try
                {
                    System.IO.Directory.CreateDirectory(rutaLog);

                    //using (FileStream fs = File.Create(Path.Combine(rutaLog, "Access.txt")))
                    using (FileStream fs = new FileStream(Path.Combine(rutaLog, "Access.txt"), FileMode.Append, FileAccess.Write))
                    {
                        string textAnterior;
                        StreamWriter sw = new StreamWriter(fs);

                        string Texto = string.Format("Dia : {0} -> Persona : {1} -> Existe : {2} -> Lectura : {3} -> Escritura : {4} -> Error :{5}",
                            DateTime.Now.ToString(),
                            Environment.UserName,
                            existe == true ? "Si" : "No",
                            lectura == true ? "Si" : "No",
                            escritura == true ? "Si" : "No",
                            error);

                        sw.WriteLine(Texto);
                        sw.WriteLine("**********************************************************************");
                        
                        sw.Close();
                        fs.Close();

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al crear el Log de Accesos   : -> " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Error al crear el Log de Accesos   : -> " + "No existe la carpeta");
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

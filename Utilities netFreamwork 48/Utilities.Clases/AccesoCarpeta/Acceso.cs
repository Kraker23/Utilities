using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Clases.AccesoCarpeta
{
    public class Acceso
    {
        private string Ruta { get; set; }
        private string Error { get; set; }
        private string rutaLog { get; set; }

        private bool existe { get; set; }
        private bool lectura { get; set; }
        private bool escritura { get; set; }

        public Acceso(string ruta)
        {
            this.Ruta = ruta;
        }

        public bool ExisteRuta()
        {
            if (System.IO.Directory.Exists(Ruta))
            {
                existe = true;
                return true;
            }
            Error = string.IsNullOrEmpty(Error) ? "No existe la ruta o no hay Acceso " : Error + Environment.NewLine + "No existe la ruta o no hay Acceso ";

            return false;
        }

        public bool TienePermisosLectura()
        {
            if (ExisteRuta())
            {
                try
                {
                    AuthorizationRuleCollection collection =
                            Directory.GetAccessControl(Ruta).GetAccessRules(true,
                                            true, typeof(System.Security.Principal.NTAccount));

                    foreach (FileSystemAccessRule rule in collection)
                    {
                        if (rule.AccessControlType == AccessControlType.Allow)
                        {
                            break;
                        }
                    }
                    lectura = true;
                    return true;

                }
                catch (UnauthorizedAccessException ex)
                {
                    Error = string.IsNullOrEmpty(Error) ? "Error Lectura ->" + ex.Message : Error + Environment.NewLine + "Error Lectura ->" + ex.Message;
                    //Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Error = string.IsNullOrEmpty(Error) ? "Error Lectura ->" + ex.Message : Error + Environment.NewLine + "Error Lectura ->" + ex.Message;
                    //Console.WriteLine(ex.Message);
                }
            }
            return false;
        }

        public bool TienePermisosEscritura()
        {
            if (ExisteRuta())
            {
                try
                {
                    using (FileStream fs = File.Create(Path.Combine(Ruta,
                     "AccessTemp.txt"), 1, FileOptions.DeleteOnClose))
                    {
                        fs.Close();
                    }
                    escritura = true;
                    return true;

                }
                catch (Exception ex)
                {
                    Error = string.IsNullOrEmpty(Error) ? "Error Escritura ->" + ex.Message : Error + Environment.NewLine + "Error Escritura ->" + ex.Message;
                    //Console.WriteLine(ex.Message);
                }
            }
            return false;
        }
        
        public bool escribirAccesoLog(string rutalog)
        {
            rutaLog = rutalog;

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
                            GetError());

                        sw.WriteLine(Texto);
                        sw.WriteLine("**********************************************************************");

                        sw.Close();
                        fs.Close();
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al Modificar el Log de Accesos   : -> " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Error al crear el Log de Accesos   : -> " + "No existe : " + rutaLog);
            }
            return false;
        }

        public string GetError()
        {
            return Error;
        }

    }
}

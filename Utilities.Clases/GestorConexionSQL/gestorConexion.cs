using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Clases.GestorConexionSQL
{
    
        //public static class DatosConexion
        //{
        //    public static TipoConexion SelTipoConexion = TipoConexion.Pruebas;

        //    public enum TipoConexion
        //    {
        //        Produccion,
        //        Desarrollo,
        //        Pruebas
        //    }

        //    public static string getBBDD()
        //    {
        //        switch (SelTipoConexion)
        //        {
        //            case TipoConexion.Produccion:
        //                return "madsqlp01116";
        //            case TipoConexion.Desarrollo:
        //                return "madsqlS01108";
        //            case TipoConexion.Pruebas:
        //                return "madsqlt01104";
        //            default:
        //                return string.Empty;
        //        }

        //    }
        //}

        //Clase que tiene la conexxion a la BBDD 
        public class Conexion
        {
            private string urlConexion;

            public Conexion(string urlconexion)
            {
                this.urlConexion= urlconexion;
            }

            public SqlConnection conexion = new SqlConnection();

            public SqlConnection ObtenerConexion()
            {
                //string url = "Password=EskapeUser;Persist Security Info=True;User ID=EskapeUser;Initial Catalog=AdPlanning;Data Source=madsqlt01104";
                //string url = string.Format("Password=EskapeUser;Persist Security Info=True;User ID=EskapeUser;Initial Catalog=AdPlanning;Data Source={0}", DatosConexion.getBBDD());

                string url = string.Format(urlConexion);
                conexion = new SqlConnection(url);
                try
                {
                    conexion.Open();
                    return conexion;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public bool DescargarConexion()
            {
                conexion.Dispose();
                return true;
            }
        }


        public class GestorConexion
        {
            public Conexion objConexion;


            public GestorConexion(string UrlConexion)
            {
                objConexion = new Conexion(UrlConexion);
            }

            public DataTable Consulta(string query,int timeout=0)//(string Cedula)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = objConexion.ObtenerConexion();
                    cmd.CommandTimeout = 0;
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.CommandText = "NombreProcedimiento";
                    //cmd.Parameters.Add("@Cedula", SqlDbType.NVarChar).Value = Cedula;
                    //cmd.CommandType = CommandType.TableDirect;
                    cmd.CommandText = query;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    objConexion.DescargarConexion();
                }
            }


        }
    
}

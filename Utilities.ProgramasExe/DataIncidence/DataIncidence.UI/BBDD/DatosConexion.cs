using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIncidence.UI.BBDD
{
    public static class DatosConexion
    {
        public static TipoConexion SelTipoConexion = TipoConexion.Pruebas;
        private static string urlBase = "Password=EskapeUser;Persist Security Info=True;User ID=EskapeUser;Initial Catalog=AdPlanning;Data Source= {0}";
        //private static string urlBase = "Password=111111;Persist Security Info=True;User ID=EskapeUser;Initial Catalog=AdPlanning;Data Source= {0}";

        public enum TipoConexion
        {
            Produccion,
            Desarrollo,
            Pruebas
        }

        public static string getBBDD()
        {
            switch (SelTipoConexion)
            {
                case TipoConexion.Produccion:
                    return "madsqlp01116";
                case TipoConexion.Desarrollo:
                    return "madsqlS01108";
                case TipoConexion.Pruebas:
                    return "madsqlt01104";
                default:
                    return string.Empty;
            }

        }
        public static string GetUrlConexion()
        {
            return string.Format(urlBase, getBBDD());
        }
    }
}

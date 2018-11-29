using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Extensions
{
    public static class ListasExtensiones
    {
        // Ex: lista.getUltimos(5);
        public static List<T> getUltimos<T>(this List<T> source, int ultimos)
        {
            return source.Skip(Math.Max(0, source.Count() - ultimos)).ToList();
        }

        public static string getListaToString<T>(this List<T> source)
        {
            string resultado = string.Empty;
            if (source != null && source.Count > 0)
            {
                foreach (var item in source)
                {
                    resultado += resultado + ", " + item.ToString();
                }
            }
            return resultado;
        }

        //public static bool ContieneString<T>(this List<T> source,string str)
        //{
        //    bool resultado = false;
        //    if (source.HasContent()  && str.HasContent())
        //    {
        //        foreach (var item in source)
        //        {
        //            if(item.ToString().Contains(str) || str.Contains(item.ToString()))
        //            {
        //                resultado = true;
        //            }
        //        }
        //    }
        //    return resultado;
        //}

        public static bool HasContent<T>(this List<T> source)
        {
            bool resultado = false;
            if (source != null && source.Count > 0)
            {
                resultado = true;
            }
            return resultado;
        }

        public static List<T> getPrimeros<T>(this List<T> source, int primeros)
        {
            return source.GetRange(0, source.Count > primeros ? primeros : source.Count);
        }
    }
}

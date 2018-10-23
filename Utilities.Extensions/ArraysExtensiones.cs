using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Extensions
{
    public static class ArraysExtensiones
    {
        public static T[] Append<T>(this T[] dst, T[] src)
        {
            Array.Resize(ref dst, dst.Length + src.Length);
            Array.Copy(src, 0, dst, dst.Length - src.Length, src.Length);
            return dst;
        }

        public static string getArrayToString(this string[] source)
        {
            string resultado = string.Empty;
            if (source != null && source.Count() > 0)
            {
                //foreach (string item in source)
                //{
                //    resultado += resultado + ", " + item.ToString();
                //}
                resultado = source.toOneString();
            }
            return resultado;
        }

        /// <summary> Convertir un Array en un unico String separado por ;  </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static string toOneString(this string[] lista)
        {
            string res = string.Empty;
            if (lista != null && lista.Count() > 1)
            {
                foreach (string item in lista)
                {
                    res = res.añadirString(item, ';');
                    //if(string.IsNullOrEmpty(res))
                    //{
                    //    res = item + ";";
                    //}
                    //else
                    //{
                    //    res = res + item + ";";
                    //}
                }
            }
            return res;
        }

        public static bool HasContent(this string[] source)
        {
            bool resultado = false;
            if (source != null && source.Count() > 0)
            {
                resultado = true;
            }
            return resultado;
        }

        public static bool ContieneString(this string[] source, string str)
        {
            bool resultado = false;
            if (source.HasContent() && str.HasContent())
            {
                foreach (var item in source)
                {
                    if (item.Contains(str) || str.Contains(item))
                    {
                        resultado = true;
                    }
                }
            }
            return resultado;
        }
    }

}

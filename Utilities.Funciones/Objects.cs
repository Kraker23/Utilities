using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities.Extensions;

namespace Utilities.Funciones
{
    /// <summary> Clase para agrupar funciones matemáticas </summary>
    public class Objects
    {
        ///Comprobacion de Si existen nulos
        public static bool TieneNulos(params object[] args)
        {
            foreach (var item in args)
            {
                if (item == null)
                {
                    return true;
                }
            }
            return false;
        }

        ///Comprobacion de Si existen nulos
        public static bool  TieneNulos(string nombres, out string mensaje, params object[] args)//
        {
            string[] nombresSplit=null;
            bool hayNombres = false; 
            if (!string.IsNullOrEmpty(nombres))
            {
                hayNombres = true;
                nombresSplit = nombres.Split(',');
            }

            string nombresNulos = string.Empty;
            bool existeNulos = false;
            mensaje = null; ;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == null)
                {
                    existeNulos = true;
                    if (hayNombres)
                    {
                        if (nombresSplit.Length > i)
                        {
                            nombresNulos = nombresNulos.añadirString( nombresSplit[i],", ");
                        }
                    }
                }
            }

            if (existeNulos)
            {
                mensaje = "Existen Variables con Nulos";
                if (!string.IsNullOrEmpty(nombresNulos))
                {
                    mensaje = mensaje.añadirString(nombresNulos, " : ");
                }
                return true;
            }
            return false;
        }

        ///Funcion que recorre un Objeto Recursivamente, y setea los strings.
        public static voir RecorrerPropiedadesRecursivo(object objeto, ref int contador)
        {
            PropertyInfo[] lst = objeto.GetType().GetProperties();
            foreach (PropertyInfo oProperty in lst)
            {
                string NombreAtributo = oProperty.Name;
                if (oProperty.PropertyType == typeof(string))
                {
                    oProperty.SetValue(objeto, contador.ToString());
                    contador = contador + 1;
                }
                else if (oProperty.PropertyType.BaseType == typeof(object))
                {
                    RecorrerPropiedades(oProperty.GetValue(objeto), ref contador);
                }
            }
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesNet.Extensiones
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
                    resultado = resultado + ", " + item.ToString();
                }
            }
            return resultado;
        }

        public static string getListaToString<T>(this List<T> source,string separador)
        {
            string resultado = string.Empty;
            if (source != null && source.Count > 0)
            {
                foreach (var item in source)
                {
                    if (string.IsNullOrEmpty(resultado))
                    {
                        resultado = item.ToString();
                    }
                    else
                    {
                        resultado = resultado + separador + item.ToString();
                    }
                }
            }
            return resultado;
        }


        /// <summary xml:lang="es">
        /// Concatena los textos dentro de la colección, separando los items por líneas.
        /// Los mensajes iguales no se repiten
        /// </summary>
        /// <param name="x">List&gt;string&lt;</param>
        /// <returns>string concatenado</returns>
        public static string getListaToStringDistint(this List<string> x)
        {
            StringBuilder sb = new StringBuilder();

            if (x != null)
            {
                foreach (string s in x.Distinct())
                {
                    sb.AppendLine(s);
                }
            }

            return sb.ToString();
        }


        /// <summary xml:lang="es">
        /// Concatena los textos dentro de la colección, separando los items por líneas.
        /// Los mensajes iguales no se repiten
        /// </summary>
        /// <param name="x">List&gt;string&lt;</param>
        /// <param name="nodeTag">nombre para los diferentes elementos del xml</param>
        /// <returns>string concatenado</returns>
        public static string getListaToStringDistintXML(this List<string> x, string nodeTag)
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine(string.Format("<{0}>", rootNode));

            if (x != null)
            {
                foreach (string s in x.Distinct())
                {
                    sb.AppendLine(string.Format("<{0}>{1}</{0}>", nodeTag, s));
                }
            }

            //sb.AppendLine(string.Format("</{0}>", rootNode));

            return sb.ToString();
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

        /// <summary>
        /// Obtener los Primeros X Elementos de una lista
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="primeros"></param>
        /// <returns></returns>
        public static List<T> getPrimeros<T>(this List<T> source, int primeros)
        {
            return source.GetRange(0, source.Count > primeros ? primeros : source.Count);
        }

        //public DataTable ConvertToDataTable<T>(IList<T> data)
        public static DataTable ConvertToDataTable<T>(this List<T> data)
        {
            PropertyDescriptorCollection propiedades = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in propiedades)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in propiedades)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;

        }

        public static DataTable ConvertirListaToDataTable(this List<object> items, string nameService)
        {
            // Instancia del objeto a devolver
            var returnValue = new DataTable();
            // Información del tipo de datos de los elementos del List
            Type itemsType = items.First().GetType();
            /*Se Recorren las propiedades para crear las columnas del datatable y
            pregunta si el objeto tiene estrcutra.Si tiene entra.*/
            if (itemsType.GetProperties().Any())
            {
                foreach (PropertyInfo prop in itemsType.GetProperties())
                {
                    //Se Crea y agrega una columna por cada propiedad de la entidad
                    var column = new DataColumn(prop.Name);

                    var propType = Nullable.GetUnderlyingType(prop.PropertyType)
                      ?? prop.PropertyType;

                    column.DataType = propType;
                    returnValue.Columns.Add(column);
                }
                int j;
                /* Se recorre la colección para guardar los datos
                 en el DataTable*/
                foreach (var item in items)
                {
                    j = 0;
                    object[] newRow = new object[returnValue.Columns.Count];
                    /* Se vuelve a recorrer las propiedades de cada item para
                     obtener su valor y guardarlo en la fila de la tabla*/
                    foreach (PropertyInfo prop in itemsType.GetProperties())
                    {
                        newRow[j] = prop.GetValue(item, null);
                        j++;
                    }
                    returnValue.Rows.Add(newRow);
                }
            }
            //si el objeto no tiene estructura, se arma una.
            else
            {
                var newRow = new object[items.Count];
                for (int i = 0; i < items.Count; i++)
                {
                    var colName = nameService + i;
                    var column = new DataColumn(colName);
                    column.DataType = typeof(string);
                    returnValue.Columns.Add(column);
                }
                for (int i = 0; i < items.Count; i++)
                {
                    newRow[i] = items[i].ToString();
                }
                returnValue.Rows.Add(newRow);
            }
            // devolución del DataTable
            return returnValue;
        }

    }
}

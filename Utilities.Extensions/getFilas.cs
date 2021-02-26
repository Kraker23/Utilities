using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Utilities.Extensions
{
    public static class getFilas
    {

        /// <summary> Encuentra una fila con los mismos valores y las mismas columnas a partir de una fila </summary>
        /// <param name="row">fila a buscar igual</param>
        /// <param name="dtDato">tabla donde buscar</param>
        /// <returns></returns>
        public static DataRow getRow(DataRow row, DataTable dtDato)
        {
            bool coincide;

            foreach (DataRow d in dtDato.Rows)
            {
                coincide = true;
                foreach (DataColumn c in dtDato.Columns)
                {
                    if (!c.AutoIncrement && row.Table.Columns.Contains(c.ColumnName))
                    {
                        coincide = coincide && d[c].Equals(row[c.ColumnName]);
                    }
                }

                if (coincide)
                {
                    return d;
                }
            }

            return null;
        }

        /// <summary>Añadir una nueva fila con la estructura de la tabla para traspasar datos entre dos tablas</summary>
        /// <param name="origen">tabla de origen de datos</param>
        /// <param name="destino">tabla de destino de los datos</param>
        /// <param name="dr">fila</param>
        /// <returns></returns>
        public static DataRow getNewData(DataTable origen, DataTable destino, DataRow dr)
        {
            var r = destino.NewRow();
            foreach (DataColumn col in destino.Columns)
            {
                if (origen.Columns.Contains(col.ColumnName))
                {
                    r[col.ColumnName] = dr[col.ColumnName];
                }
            }
            return r;
        }


        /// <summary> Buscar filas iguales a partir de una posicion</summary>
        /// <param name="row"> fila a comparar </param>
        /// <param name="dt"> tabla donde comparar </param>
        /// <param name="pos"> posicion de la fila donde debe empezar a buscar </param>
        /// <returns></returns>
        public static DataRow getRow(DataRow row, DataTable dt, int pos)
        {
            bool coincide;

            foreach (DataRow d in dt.Rows)
            {
                if (pos < dt.Rows.IndexOf(d))
                {
                    coincide = true;
                    foreach (DataColumn c in dt.Columns)
                    {
                        if (!c.AutoIncrement && row.Table.Columns.Contains(c.ColumnName) && !c.ColumnName.Equals("Id"))
                        {
                            coincide = coincide && d[c].Equals(row[c.ColumnName]);
                        }
                    }

                    if (coincide)
                    {
                        return d;
                    }
                }
            }

            return null;
        }

    }
}

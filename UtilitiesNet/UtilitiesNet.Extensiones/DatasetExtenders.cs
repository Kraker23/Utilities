using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace UtilitiesNet.Extensiones
{
    public static class DatasetExtenders
    {
        /// <summary>
        /// Conver the list into a simple DataTable
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Data to convert</param>
        /// <returns>DataTable</returns>
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }


        /// <summary>
        /// Insert a list into a DataTable
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Data to convert</param>
        /// <param name="table">Destination table</param>
        public static void ToDataTable<T>(this IList<T> data, DataTable table)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<T> ToList<T>(this DataTable table)
        {
            List<T> data = new List<T>();

            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));

            T item;

            foreach (DataRow row in table.Rows)
            {
                item = (T)Activator.CreateInstance(typeof(T), new object[] { });

                foreach (PropertyDescriptor prop in properties)
                {
                    prop.SetValue(item, row[prop.Name]);
                }

                data.Add(item);
            }

            return data;

        }


        /*public DataSet ToDataSet<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));

            DataSet ds = new DataSet();
            DataTable table = ds.Tables.Add(typeof(T).Name);

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }


            return ds;
        }*/
    }
}

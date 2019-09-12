using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Extensions
{
    public static class ObjectosExtensiones
    {
        /// <summary>
        /// Funciona para pasar datos de un objeto a otro, con las mismas propiedades
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="origen"></param>
        /// <returns></returns>
        public static T ObjectToObject<T, T2>(T2 origen) where T : new()
        {
            T res = new T();

            var tipoRes = typeof(T);
            var tipoIn = typeof(T2);

            var props = tipoIn.GetProperties().FindAllToList(x => tipoRes.GetProperties().Any(y => y.Name == x.Name && y.PropertyType == x.PropertyType));
            foreach (var p in props)
            {
                var dp = tipoRes.GetProperty(p.Name);
                dp.SetValue(res, p.GetValue(origen, null), null);
            }

            return res;
        }
    }
}

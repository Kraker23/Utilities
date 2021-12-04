using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace Utilities.Extensions
{
    public static class ObjectosExtensiones
    {
        /// <summary>
        /// Funciona para pasar datos de un objeto a otro, con las mismas propiedades
        /// Crea y traspasa los datos de las propiedades con el mismo nombre y tipo
        /// </summary>
        /// <typeparam name="T">Tipo destino</typeparam>
        /// <typeparam name="T2">Tipo origen</typeparam>
        /// <param name="origen">Objeto de donde se trasparán los datos</param>
        /// <returns>Nuevo objeto de tipo "T2" con los valores del origen</returns>
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

        /// <summary> Para recuperar el nombre del Objeto, uso --> objeto.GetName()</summary>
        /// <param name="obj">Objeto a recuperar el nombre</param>
        /// <returns></returns>
        public static string GetName(this object obj)
        {
            return ((MemberExpression)obj).Member.Name;
        }

        /// <summary> Para recuperar el nombre del Objeto por Expressiones, uso --> GetName(()=>objeto1)</summary>
        /// <param name="obj">Objeto a recuperar el nombre</param>
        /// <returns></returns>
        public static string GetName<T>(Expression<Func<T>> obj)
        {
            return ((MemberExpression)obj.Body).Member.Name;
        }

        // public static T ObjectToObject<T, T2>(T2 origen) where T : new()

        public static object IsNull(this object source, object objetoAlternativo)
        {
            return source == null ? objetoAlternativo : source;
        }

        /// <summary>
        /// Indica si el contexto tiene objetos con cambios
        /// </summary>
        /// <param name="oc"></param>
        /// <returns></returns>
        public static bool HasChanges(this ObjectContext oc)
        {
            int count = oc.ObjectStateManager.GetObjectStateEntries(EntityState.Added |
                                                                    EntityState.Deleted |
                                                                    EntityState.Modified).Count();
            return (count > 0);
        }

        public static bool CompareAllSameProperties<T, T2>(T a, T2 b)
        {
            bool res = true;
            var tipoA = typeof(T);
            var tipoB = typeof(T2);
            var props = tipoA.GetProperties().FindAllToList(x => tipoB.GetProperties().Any(y => y.Name == x.Name && y.PropertyType == x.PropertyType));
            foreach (var p in props)
            {
                var valA = tipoA.GetProperty(p.Name).GetValue(a);
                var valB = tipoB.GetProperty(p.Name).GetValue(b);
                res = (valA == valB);
                if (!res) break;
            }
            return res;
        }

        
    }
}

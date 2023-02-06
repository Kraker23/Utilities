using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Clases.MergeObjects
{

    public class ObjectMerger<T> : IObjectMerger where T : new()
    {
        /// <summary>Opciones de Merge</summary>
        public MergeOptions mergeOptions { get;  set; }

        T ObjX;
        T ObjY;
        List<PropMerge> properties = null;
        Type tipo;
        PropertyInfo[] props;

        /// <summary>Lista de Nombres de propiedades a Excluir</summary>
        List<string> exclusions;

        /// <summary>Constructor del Merge object</summary>
        public ObjectMerger()
        {
            tipo = typeof(T);
            props = tipo.GetProperties();
            this.exclusions = new List<string>();
        }

        /// <summary>Constructor del Merge object</summary>
        /// <param name="objX">Primer Objeto a comparar</param>
        /// <param name="objY">Segundo Objeto a comparar</param>
        public ObjectMerger(T objX, T objY) : this()
        {
            ObjX = objX;
            ObjY = objY;
        }

        /// <summary>Constructor del Merge object</summary>
        /// <param name="objX">Primer Objeto a comparar</param>
        /// <param name="objY">Segundo Objeto a comparar</param>
        /// <param name="exclusions">Lista de nombres de propiedades a Excluir</param>
        public ObjectMerger(T objX, T objY, List<string> exclusions) : this()
        {
            ObjX = objX;
            ObjY = objY;
            this.exclusions = exclusions;
        }

        /// <summary>Comprar los dos Objetos</summary>
        /// <param name="objX">Primer Objeto a comparar</param>
        /// <param name="objY">Segundo Objeto a comparar</param>
        /// <returns>Lista de propiedades a comparar</returns>
        public List<PropMerge> Compare(object objX, object objY)
        {
            ObjX = (T)objX;
            ObjY = (T)objY;

            return Compare();
        }

        /// <summary>Comprar los dos Objetos</summary>
        /// <param name="objX">Primer Objeto a comparar</param>
        /// <param name="objY">Segundo Objeto a comparar</param>
        /// <param name="exclusions">Lista de nombres de propiedades a Excluir</param>
        /// <returns>Lista de propiedades a comparar</returns>
        public List<PropMerge> Compare(object objX, object objY, List<string> exclusions)
        {
            ObjX = (T)objX;
            ObjY = (T)objY;
            this.exclusions = exclusions;

            return Compare();
        }

        /// <summary>Funciones para comparar</summary>
        /// <returns>Lista de propiedades a comparar</returns>
        public List<PropMerge> Compare()
        {
            properties = new List<PropMerge>();
            foreach (var p in props)
            {
                if (!exclusions.Any(x => x == p.Name))
                {
                    var pm = new PropMerge(p, p.GetValue(ObjX, null), p.GetValue(ObjY, null),this.mergeOptions);

                    if (mergeOptions?.ValueOverNull ?? false)
                    {
                        if (pm.ValueX == null && pm.ValueY != null) pm.Selection = PropMergeSelection.Y;
                        else if (pm.ValueX != null && pm.ValueY == null) pm.Selection = PropMergeSelection.X;
                    }

                    properties.Add(pm);
                }
            }

            return properties;
        }


        /// <summary>Merge de los dos objetos </summary>
        /// <returns>Devolver el objeto generado del Merge</returns>
        public object MergeObjects()
        {
            T res = new T();
            foreach (var p in properties)
            {
                p.PropertyInfo.SetValue(res, p.ValueResult, null);
            }
            return res;
        }
    }
}

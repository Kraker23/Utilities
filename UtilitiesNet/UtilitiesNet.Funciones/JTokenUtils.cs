using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesNet.Funciones
{

    public static class JTokenUtils
    {


        public static List<T> JTokenToList<T>(JToken token)
        {
            if (token == null)
                return new List<T>();

            // Si el token es un array, deserializa directamente
            if (token.Type == JTokenType.Array)
                return token.ToObject<List<T>>();

            // Si el token es un objeto con una propiedad que contiene el array
            if (token.Type == JTokenType.Object)
            {
                foreach (var prop in token.Children<JProperty>())
                {
                    if (prop.Value.Type == JTokenType.Array)
                        return prop.Value.ToObject<List<T>>();
                }
            }

            // Si no es un array, intenta deserializar como un solo objeto
            var single = token.ToObject<T>();
            return single != null ? new List<T> { single } : new List<T>();
        }


        public static T JTokenToObject<T>(JToken token)
        {
            if (token == null)
                return default(T);

            // Si el token es un objeto, deserializa directamente
            if (token.Type == JTokenType.Object)
                return token.ToObject<T>();

            // Si el token es un array con un solo elemento, deserializa el primero
            if (token.Type == JTokenType.Array && token.HasValues)
                return token.First.ToObject<T>();

            // Si el token es un valor simple, intenta deserializarlo
            return token.ToObject<T>();
        }


        public static TDestino JTokenToOtherNamespaceObject<TOrigen, TDestino>(JToken token)
            where TDestino : new()
        {
            if (token == null)
                return default(TDestino);

            // Deserializa el token al tipo de origen
            TOrigen origen = token.ToObject<TOrigen>();
            if (origen == null)
                return default(TDestino);

            // Crea el objeto destino y copia las propiedades
            TDestino destino = new TDestino();
            foreach (PropertyInfo propOrigen in typeof(TOrigen).GetProperties())
            {
                PropertyInfo propDestino = typeof(TDestino).GetProperty(propOrigen.Name);
                if (propDestino != null && propDestino.CanWrite)
                {
                    object valor = propOrigen.GetValue(origen);
                    if (propDestino.PropertyType == propOrigen.PropertyType)
                    {
                        propDestino.SetValue(destino, valor);
                    }
                }
            }
            return destino;
        }

        public static List<TDestino> JTokenToOtherNamespaceList<TOrigen, TDestino>(JToken token)
    where TDestino : new()
        {
            var result = new List<TDestino>();
            if (token == null)
                return result;

            // Si el token es un array, deserializa cada elemento
            if (token.Type == JTokenType.Array)
            {
                foreach (var item in token)
                {
                    TOrigen origen = item.ToObject<TOrigen>();
                    if (origen != null)
                    {
                        TDestino destino = new TDestino();
                        foreach (PropertyInfo propOrigen in typeof(TOrigen).GetProperties())
                        {
                            PropertyInfo propDestino = typeof(TDestino).GetProperty(propOrigen.Name);
                            if (propDestino != null && propDestino.CanWrite)
                            {
                                object valor = propOrigen.GetValue(origen);
                                if (propDestino.PropertyType == propOrigen.PropertyType)
                                {
                                    propDestino.SetValue(destino, valor);
                                }
                            }
                        }
                        result.Add(destino);
                    }
                }
                return result;
            }

            // Si no es un array, intenta deserializar como un solo objeto
            var single = JTokenToOtherNamespaceObject<TOrigen, TDestino>(token);
            if (single != null)
                result.Add(single);

            return result;
        }

    }
}

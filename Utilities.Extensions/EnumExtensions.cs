using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Extensions
{
    /// <summary>
    /// Extensiones para <ver cref="Enum" />.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Parsear un valor de enumeración de un tipo dado de una cadena.
        /// </summary>
        public static TEnum ParseEnum<TEnum>(this string valor, bool ignorarCaseSensitive = true) where TEnum : struct, Enum
        {
            return (TEnum)Enum.Parse(typeof(TEnum), valor, ignorarCaseSensitive);
        }
        
    }
}

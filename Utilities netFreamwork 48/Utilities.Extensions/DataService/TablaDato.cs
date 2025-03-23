using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;


namespace Utilities.Extensions.DataService
{

    /// <summary>
    /// Clase base para los elementos recueperados de la base de datos
    /// </summary>
    [DataContract(IsReference=true)]
    public class TablaDato
    {

        public List<Traduccion> Traducciones = new List<Traduccion>();
        public List<MensajesBLError> Errores = new List<MensajesBLError>();
        public List<MensajesBLError> Alertas = new List<MensajesBLError>();

        public enum EstadoDato
        {
            Detached = 1,
            Unchanged = 2,
            Added = 4,
            Deleted = 8,
            Modified = 16,
        }

        /// <summary>
        /// Valida los datos del objeto
        /// </summary>
        /// <param name="err">List&lt;string&gt;: Lista de errores encontrados en la validación de los datos. El objeto será null si no hay errores</param>
        /// <returns>bool: Indica si la validación ha sido correcta o no</returns>
        public virtual bool Validate(ref List<MensajesBLError> err, ref List<MensajesBLError> alerts, EstadoDato ed = EstadoDato.Unchanged)
        {
            err = null;
            alerts = null;
            return true;
        }


        /// <summary>
        /// Obtener la primary key del objeto
        /// </summary>
        /// <returns>int</returns>
        public virtual long GetTablaID()
        {
            return long.MinValue;
        }

    }

}

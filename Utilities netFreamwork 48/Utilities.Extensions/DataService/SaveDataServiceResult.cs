using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Text;
using System.Xml.Serialization;



namespace Utilities.Extensions.DataService
{

   /* /// <summary>
    /// Clase con los errores devueltos por el Data service 
    /// </summary>
    [XmlRoot(Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata", ElementName = "error")]
    public class DataServiceErrorMessage
    {
        /// <summary>
        /// Código del error
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// Mensaje de error
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// Error interno
        /// </summary>
        [XmlElement("innererror")]
        public DataServiceErrorInnerMessage innerError { get; set; }


        /// <summary>
        /// Get last recursive inner error message
        /// </summary>
        /// <returns>string</returns>
        public string GetLastErrorMessage()
        {
            if (innerError == null)
            {
                return Message;
            }
            else
            {
                return getInternalMessage(innerError);
            }
        }


        /// <summary>
        /// Get last recursive inner error message
        /// </summary>
        /// <returns>string</returns>
        private string getInternalMessage(DataServiceErrorInnerMessage inner)
        {
            if (inner.innerError == null)
            {
                return inner.Message;
            }
            else
            {
                return getInternalMessage(inner.innerError);
            }
        }
    }


    [XmlRoot("innererror")]
    public class DataServiceErrorInnerMessage
    {
        /// <summary>
        /// Mensaje de error
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }


        /// <summary>
        /// Error interno
        /// </summary>
        [XmlElement("internalexception")]
        public DataServiceErrorInnerMessage innerError { get; set; }
    }

    
    public static class DataServiceContextExtender
    {
        /// <summary>
        /// Guarda los datos e informa de los errores
        /// </summary>
        /// <param name="ent">DataServiceContext</param>
        /// <param name="opt">Opcion de guardado</param>
        /// <param name="errores">Lista de erroes</param>
        /// <returns>bool: indica si los datos se han guardado correctamente</returns>
        public static bool SaveAndGetErrors(this System.Data.Services.Client.DataServiceContext ent, SaveChangesOptions opt, long idUsuario, out List<MensajesBLError> errores, out List<MensajesBLError> alerts, bool validacionesCliente = true)
        {
            try
            {
                MensajesBLError error;
                MensajesBLError alerta;
                MutiIdiomaSrv.MergeTraduccionesRequest traducciones = new MutiIdiomaSrv.MergeTraduccionesRequest();
                traducciones.traducciones = new List<MutiIdiomaSrv.Traduccion>();
                System.Reflection.PropertyInfo prop;

                errores = null;
                alerts = null;
                
                foreach (EntityDescriptor ed in ent.Entities)
                {
                    if ((ed.State == EntityStates.Added || ed.State == EntityStates.Modified) && ed.Entity is TablaDato)
                    {
                        // update security properties
                        prop = ed.Entity.GetType().GetProperty("fechaModificacion");
                        if (prop != null) prop.SetValue(ed.Entity, DateTime.Now, null);

                        prop = ed.Entity.GetType().GetProperty("usuarioModificacion");
                        if (prop != null) prop.SetValue(ed.Entity, idUsuario, null);

                        // validate data
                        if (validacionesCliente)
                        {
                            ((TablaDato)ed.Entity).Validate(ref errores, ref alerts, (TablaDato.EstadoDato)ed.State);
                        }
                    }
                    else if (ed.State == EntityStates.Deleted)
                    {
                        //agregamos todas sus traducciones y las marcamos como eliminar
                        if (ed.Entity is TablaDato)
                        {
                            // validate data
                            if (validacionesCliente)
                            {
                                if (((TablaDato)ed.Entity).Validate(ref errores, ref alerts, (TablaDato.EstadoDato)ed.State))
                                {
                                    foreach (Traduccion t in ((TablaDato)ed.Entity).Traducciones)
                                    {
                                        if (!string.IsNullOrEmpty(t.Accion))
                                        {
                                            traducciones.traducciones.Add(
                                                new MutiIdiomaSrv.Traduccion()
                                                {
                                                    Accion = "B",
                                                    Columna = t.Columna,
                                                    IdDato = ((TablaDato)ed.Entity).GetTablaID(),
                                                    Idioma = t.Idioma,
                                                    IdTraduccion = t.IdTraduccion,
                                                    Tabla = t.Tabla,
                                                    Texto = t.Texto,
                                                    IdTabla = t.IdTabla,
                                                    IdColumna = t.IdColumna
                                                });
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
                if (errores == null || errores.Count == 0)
                {
                    // guardar datos
                    ent.SaveChanges(opt);
                   
                    // Guardar traducciones a través de un servicio
                    foreach (EntityDescriptor ed in ent.Entities)
                    {
                        if (ed.Entity is TablaDato)
                        {
                            foreach (Traduccion t in ((TablaDato)ed.Entity).Traducciones)
                            {
                                if (!string.IsNullOrEmpty(t.Accion))
                                {
                                    traducciones.traducciones.Add(
                                        new MutiIdiomaSrv.Traduccion()
                                        {
                                            Accion = t.Accion,
                                            Columna = t.Columna,
                                            IdDato = ((TablaDato)ed.Entity).GetTablaID(),
                                            Idioma = t.Idioma,
                                            IdTraduccion = t.IdTraduccion,
                                            Tabla = t.Tabla,
                                            Texto = t.Texto,
                                            IdTabla = t.IdTabla,
                                            IdColumna = t.IdColumna
                                        });
                                }
                            }
                        }
                    }

                     if (traducciones.traducciones.Count() > 0)
                    {
                        // TODO: Enviar traducciones
                        using (MutiIdiomaSrv.MultiIdiomaClient mcli = new MutiIdiomaSrv.MultiIdiomaClient())
                        {
                            string strErr = mcli.MergeTraducciones(traducciones).MergeTraduccionesResult;

                            if (!string.IsNullOrEmpty(strErr))
                            {
                                errores = new List<MensajesBLError>();                                

                                error = new MensajesBLError();
                                error.MensajeError = strErr;
                                errores.Add(error);
                                //errores.Add(strErr);
                            }
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (DataServiceRequestException ex)
            {
                bool res = false;
                MensajesBLError error;
                MensajesBLError alerta;

                errores = new List<MensajesBLError>();
                alerts = new List<MensajesBLError>();

                if (ex.Response.IsBatchResponse)
                {
                    foreach (var x in ex.Response)
                    {
                        if (x.Error != null)
                        {
                            if (x.StatusCode == 404)
                            {
                                string typeName = ((EntityDescriptor)((ChangeOperationResponse)x).Descriptor).ServerTypeName;
                                
                                error = new MensajesBLError();
                                error.MensajeError = string.Format("El objeto {0} ha sido borrado y no se puede localizar.", typeName);
                                errores.Add(error);

                                //errores.Add(string.Format("El objeto {0} ha sido borrado y no se puede localizar.", typeName));
                            }
                            else
                            {
                                DataServiceErrorMessage a = (DataServiceErrorMessage)Funciones.Serializer.getObjectDeserialized(new DataServiceErrorMessage(), x.Error.Message);

                                if (x.StatusCode == 666)
                                {
                                    MensajesDataServiceError m = (MensajesDataServiceError)Funciones.Serializer.getObjectDeserialized(new MensajesDataServiceError(), a.Message);
                                    
                                    if (m != null)
                                    {
                                        if (m.Errores != null && m.Errores.Count > 0)
                                        {
                                            foreach (MensajesDataServiceErrorData aux in m.Errores)
                                            {
                                                error = new MensajesBLError();
                                                error.MensajeError = aux.Msg;
                                                error.MensajeTitulo = aux.Tipo;
                                                //error = (MensajesBLError)Tools.Funciones.Serializer.getObjectDeserialized(error, aux);
                                                errores.Add(error);
                                            }
                                            //errores = m.Errores;
                                        }
                                        else
                                        {
                                            res = true;
                                        }

                                        foreach (MensajesDataServiceErrorData aux in m.Alertas)
                                        {
                                            alerta = new MensajesBLError();
                                            alerta.MensajeError = aux.Msg;
                                            alerta.MensajeTitulo = aux.Tipo;
                                            //alerta = (MensajesBLError)Tools.Funciones.Serializer.getObjectDeserialized(alerta, aux);
                                            //alerta.MensajeError = aux;
                                            alerts.Add(alerta);
                                        }
                                    }
                                }
                                else
                                {
                                    error = new MensajesBLError();
                                    error.MensajeError = a.GetLastErrorMessage();
                                    errores.Add(error);

                                    //errores.Add(a.GetLastErrorMessage());

                                    /////f (a.innerError != null)
                                    ////{
                                    ////    errores.Add(a.innerError.Message);
                                    ////}
                                    ////else
                                    ////{
                                    ////    errores.Add(a.Message);
                                    ////}
                                }
                            }
                        }
                    }
                }
                else
                {
                    error = new MensajesBLError();
                    error.MensajeError = ex.Message;
                    errores.Add(error);

                    //errores.Add(ex.Message);
                }

                if (errores == null || errores.Count == 0)
                {
                    // update entities state 
                    foreach (EntityDescriptor ed in ent.Entities)
                    {
                        //ed.State = EntityStates.Unchanged;
                        string objeto = Funciones.Serializer.getObjectSerialized(ed);
                    }
                }

                return res;
            }
            catch (Exception ex2)
            {
                MensajesBLError error;

                error = new MensajesBLError();
                error.MensajeError = ex2.Message;
                errores = new List<MensajesBLError>();
                errores.Add(error);

                //errores = new List<string>();
                //errores.Add(ex2.Message);
                alerts = null;

                return false;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ent"></param>
        /// <returns></returns>
        public static bool HasChanges(this System.Data.Services.Client.DataServiceContext ent)
        {
            bool res = false;

            foreach (EntityDescriptor ed in ent.Entities)
            {
                if (ed.State != EntityStates.Unchanged)
                {
                    res = true;
                    break;
                }
            } 

            return res;
        }

    }
*/
}

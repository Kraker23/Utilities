using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Utilities.AppTraza
{

    /// <summary>
    /// Tipo de dato introducido en la traza
    /// </summary>
    public enum TipoTraza { App, Funcion, Linea, SQL, WebService, Mensaje, Error }


    /// <summary> Objeto traza </summary>
    public class Traza
    {

        #region · Variables y Delegados

            internal int idTraza;
            internal TipoTraza tipo;
            internal DateTime fechaIni;
            internal DateTime? fechaFin;
            internal String mensaje;
            internal List<Traza> subTrazas;
            internal Traza trazaPadre;
        
            internal delegate void CambioEnTrazaHandler(Traza sender);
            internal event CambioEnTrazaHandler CambioEnTraza;

        #endregion


        #region · Propiedades

            /// <summary>
            /// Fecha de introducción de los datos
            /// </summary>
            public DateTime FechaInicio
            {
                get { return fechaIni; }
            }


            /// <summary>
            /// Fecha de finalización de proceso
            /// </summary>
            public DateTime? FechaFinal
            {
                get { return fechaFin; }
            }
        

            /// <summary>
            /// Mensaje de los datos
            /// </summary>
            public String Mensaje
            {
                get { return mensaje; }
            }

        #endregion 
    

        #region Constructores

            private Traza()
            {
                tipo = TipoTraza.Mensaje;
                fechaIni = DateTime.Now;
                fechaFin = null;
                mensaje = string.Empty;
                subTrazas = new List<Traza>();
            }


            public Traza(TipoTraza _tipo, String _mensaje)
                : this()
            {
                tipo = _tipo;
                mensaje = _mensaje;
            }

        #endregion


        #region Funciones

            /// <summary>
            /// Finalizar 
            /// </summary>
            public void FinalizarTraza()
            {
                fechaFin = DateTime.Now;

                if (CambioEnTraza != null)
                {
                    CambioEnTraza(this);
                }
            }

            
            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                if (fechaFin.HasValue)
                {
                    return string.Format("{0} [{1}-{2}] : [{3}]", mensaje, fechaIni.ToString(), fechaFin.ToString(), (fechaFin - fechaIni).ToString());
                }
                else
                {
                    return string.Format("{0} [{1}]", mensaje, fechaIni.ToString());
                }
            }


            /// <summary>
            /// {msg} : Mensaje /n
            /// {fini} : Fecha Inicio/n
            /// {ffin} : Fecha Final/n
            /// {fdiff} : Diferencia entre fechas/n
            /// </summary>
            /// <param name="format"> Platilla con el formato especificado/param>
            /// <returns>String con los datos en la plantilla</returns>
            public string ToString(string format)
            {
                format.Replace("{msg}", mensaje);
                format.Replace("{fini}", fechaIni.ToString());
                format.Replace("{ffin}", fechaFin.ToString());
                format.Replace("{fdiff}", (fechaFin - fechaIni).ToString());

                return format;
            }


            /// <summary>
            /// Convierte la colección de Trazas en un xml
            /// </summary>
            /// <returns>string con formato xml</returns>
            public string ToXML()
            {
                StringBuilder res = new StringBuilder();

                res.AppendLine("<Traza>");

                res.AppendLine(string.Format("<Tipo>{0}</Tipo>", tipo.ToString()));
                res.AppendLine(string.Format("<Mensaje>{0}</Mensaje>", mensaje));
                res.AppendLine(string.Format("<FechaIni>{0}</FechaIni>", fechaIni.ToString()));
                res.AppendLine(string.Format("<FechaFin>{0}</FechaFin>", fechaFin.HasValue ? fechaFin.Value.ToString() : string.Empty));
                
                res.AppendLine("<Trazas>");
                subTrazas.ForEach(t => res.AppendLine(t.ToXML()));                
                res.AppendLine("</Trazas>");

                res.AppendLine("</Traza>");

                return res.ToString();
            }


            /// <summary>
            /// Convierte la colección de Trazas en un csv
            /// </summary>
            /// <returns>string con formato csv</returns>
            public string ToCSV()
            {
                string idPadre = string.Empty;

                if (trazaPadre != null) { idPadre = trazaPadre.idTraza.ToString(); }

                return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", 
                    idTraza.ToString(),idPadre, tipo.ToString(), mensaje, 
                    fechaIni.ToString(), fechaFin.HasValue ? fechaFin.Value.ToString() : string.Empty);
            }
        
        #endregion

    }
}

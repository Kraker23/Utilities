using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;


namespace Utilities.Funciones
{
    /// <summary> Clase para agrupar funciones de fechas </summary>
    public class Fechas
    {

        #region Estructuras de datos
        
            /// <summary> Objeto periodo </summary>
            public class PeriodoData
            {

                #region · Constructores

                    public PeriodoData()
                    {
                        Key = null;
                        FechaIni = null;
                        FechaFin = null;
                        Tag = null;
                    }


                    public PeriodoData(long key, DateTime fechaIni, DateTime fechaFin)
                        : this()
                    {
                        Key = key;
                        FechaIni = fechaIni;
                        FechaFin = fechaFin;
                    }


                    public PeriodoData(long key, DateTime fechaIni, DateTime fechaFin, object tag)
                        : this(key, fechaIni, fechaFin)
                    {
                        Tag = tag;
                    }

                #endregion


                public long? Key { get; set; }
            

                public DateTime? FechaIni { get; set; }


                public DateTime? FechaFin { get; set; }


                public object Tag { get; set; }


                public override string ToString()
                {
                    return string.Format("[{0}] {1}  -  {2}",Key.ToString(), FechaIni.Value.ToShortDateString(), FechaFin.Value.ToShortDateString());
                }

            }


            /// <summary> Tipo de error de periodo </summary>
            public enum PeriodoTipoError
            {
                Solapamiento,
                Continuidad,
                Caducidad
            }


            /// <summary> Error de periodo </summary>
            public class PeriodoError
            {

                #region · Constructores

                    public PeriodoError()
                    {
                    }


                    internal PeriodoError(PeriodoTipoError _tipoError, PeriodoData _periodo)
                        : this()
                    {
                        tipoError = _tipoError;
                        periodo = _periodo;
                    }


                    internal PeriodoError(PeriodoTipoError _tipoError, PeriodoData _periodo, List<PeriodoData> _periodosSolapados)
                        : this(_tipoError, _periodo)
                    {
                        periodosSolapados = _periodosSolapados;
                    }

                #endregion


                private PeriodoTipoError tipoError;
                public PeriodoTipoError TipoError { get { return tipoError; } }

                private PeriodoData periodo;
                public PeriodoData Periodo { get { return periodo; } }

                private List<PeriodoData> periodosSolapados;
                public List<PeriodoData> PeriodosSolapados { get { return periodosSolapados; } }


                public override string ToString()
                {
                    return string.Format("{0}: {1}", periodo.ToString(), tipoError.ToString());
                }

            }

        #endregion


        #region Funciones

            /// <summary>
            /// Validacion de periodos. Solapes, huecos, caducidades...
            /// </summary>
            /// <param name="periodos">Periodos a validar</param>
            /// <param name="fechaIniPorperty">Nombre de la propiedad de fecha inicio del objeto</param>
            /// <param name="fechaFinPorperty">Nombre de la propiedad de fecha fin del objeto</param>
            /// <param name="mismaKey">Indica si la validación se realiza entre elementos con la misma key o entre keys diferentes</param>
            /// <returns>Lista de errores de los periodos</returns>
            public static List<PeriodoError> ValidarPeriodos(List<object> periodos, string fechaIniPorperty, string fechaFinPorperty, bool mismaKey = false)
            {
                List<PeriodoData> per = new List<PeriodoData>();
                int i = 0;

                foreach (object o in periodos)
                {
                    per.Add( new PeriodoData(
                        i,
                        (DateTime)o.GetType().GetProperty(fechaIniPorperty).GetValue(o,null),
                        (DateTime)o.GetType().GetProperty(fechaFinPorperty).GetValue(o,null)
                        )
                    );

                    i++;
                }

                return ValidarPeriodos(per, mismaKey);
            }


            /// <summary>
            /// Validacion de periodos. Solapes, huecos, caducidades...
            /// </summary>
            /// <param name="periodos">Periodos a validar</param>
            /// <param name="mismaKey">Indica si la validación se realiza entre elementos con la misma key o entre keys diferentes</param>
            /// <returns>Lista de errores de los periodos</returns>
            public static List<PeriodoError> ValidarPeriodos(List<PeriodoData> periodos, bool mismaKey = false)
            {
                return ValidarPeriodos(periodos, DateTime.Now, mismaKey);
            }


            /// <summary>
            /// Validacion de periodos. Solapes, huecos, caducidades...
            /// </summary>
            /// <param name="periodos">Periodos a validar</param>
            /// <param name="fechaCaducidad">Fecha de validacion de la caducidad de fechas</param>
            /// <param name="mismaKey">Indica si la validación se realiza entre elementos con la misma key o entre keys diferentes</param>
            /// <returns>Lista de errores de los periodos</returns>
            public static List<PeriodoError> ValidarPeriodos(List<PeriodoData> periodos, DateTime fechaCaducidad, bool mismaKey = false)
            {
                
                List<PeriodoError> res = new List<PeriodoError>();
                List<PeriodoData> errores;
                DateTime fechaContinuidad, maxDate;

                if (periodos.Count > 1)
                {
                    maxDate = periodos.AsParallel().Select(x => x.FechaFin).Max().Value;

                    periodos.OrderBy(p => p.FechaIni).ThenBy(p => p.FechaFin).ToList<PeriodoData>().ForEach(x =>
                        {
                            // periodos solapados
                            if (mismaKey)
                            {
                                errores = periodos.AsParallel().Where(p => p != x && p.Key == x.Key && ((p.FechaIni >= x.FechaIni && p.FechaIni <= x.FechaFin) || (p.FechaFin >= x.FechaIni && p.FechaFin <= x.FechaFin))).ToList<PeriodoData>();
                            }
                            else
                            {
                                errores = periodos.AsParallel().Where(p => p != x && p.Key != x.Key && ((p.FechaIni >= x.FechaIni && p.FechaIni <= x.FechaFin) || (p.FechaFin >= x.FechaIni && p.FechaFin <= x.FechaFin))).ToList<PeriodoData>();
                            }

                            if (errores.Count > 0) { res.Add(new PeriodoError(PeriodoTipoError.Solapamiento, x, errores)); }

                            // comprobar continuidad
                            if (x.FechaFin.HasValue && maxDate != x.FechaFin.Value)
                            {
                                fechaContinuidad = x.FechaFin.Value.AddDays(1);
                                errores = periodos.AsParallel().Where(p => p.Key != x.Key && (fechaContinuidad >= p.FechaIni && fechaContinuidad < p.FechaFin)).ToList<PeriodoData>();

                                if (errores.Count == 0)
                                {
                                    res.Add(new PeriodoError(PeriodoTipoError.Continuidad, x));
                                }
                            }

                            if (x.FechaFin.HasValue)
                            {
                                //caducidad
                                if (x.FechaFin.Value < fechaCaducidad)
                                {
                                    res.Add(new PeriodoError(PeriodoTipoError.Caducidad, x));
                                }
                            }
                        }
                    );
                }
                
                return res;
            }


            /// <summary>
            /// Calcula la validez en funcion de un parametro
            /// 1A añade 1 año a la fecha
            /// 1T añade 1 trimmestre a la fecha
            /// 1M añade 1 mes a la fecha
            /// 1W añade 1 semana a la fecha
            /// 1D añade 1 dia a la fecha
            /// </summary>
            /// <param name="fecha"></param>
            /// <param name="param"></param>
            /// <returns></returns>
            public static DateTime CalcularValidez(DateTime fecha, string param)
            {
                DateTime fechaerror = fecha.AddYears(1);

                int pos = param.LastIndexOf("A");
                if (pos < 0) { pos = param.LastIndexOf("T"); }
                if (pos < 0) { pos = param.LastIndexOf("M"); }
                if (pos < 0) { pos = param.LastIndexOf("W"); }
                if (pos < 0) { pos = param.LastIndexOf("D"); }

                if (pos > 0)
                {
                    try
                    {

                        int numero = Convert.ToInt32(param.Substring(0, pos));
                        string tipo = param.Substring(pos);
                        switch (tipo)
                        {
                            case "A":
                                fecha = fecha.AddYears(numero);
                                break;

                            case "T":
                                fecha = fecha.AddMonths(numero * 3);
                                break;

                            case "M":
                                fecha = fecha.AddMonths(numero);
                                break;

                            case "W":
                                fecha = fecha.AddDays(numero * 7);
                                break;

                            case "D":
                                fecha = fecha.AddDays(numero);
                                break;

                            default:
                                fecha = fechaerror;
                                break;

                        }
                    }
                    catch
                    {
                        fecha = fechaerror;
                    }
                }
                else
                {
                    fecha = fechaerror;
                }

                return fecha.Date;
            }

            public static List<DiaSemana> getDiasSemana(CultureInfo cultureInfo =null)
        {
            List<DiaSemana> dias = new List<DiaSemana>();
           
            dias.Add(new DiaSemana(DayOfWeek.Monday   ,cultureInfo));
            dias.Add(new DiaSemana(DayOfWeek.Tuesday  ,cultureInfo));
            dias.Add(new DiaSemana(DayOfWeek.Wednesday,cultureInfo));
            dias.Add(new DiaSemana(DayOfWeek.Thursday ,cultureInfo));
            dias.Add(new DiaSemana(DayOfWeek.Friday   , cultureInfo));
            dias.Add(new DiaSemana(DayOfWeek.Saturday, cultureInfo));
            dias.Add(new DiaSemana(DayOfWeek.Sunday, cultureInfo));

            return dias;
        }

       

        #endregion

    }
}

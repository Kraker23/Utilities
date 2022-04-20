using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Comprobar si una fecha esta entre otras
        /// </summary>
        /// <param name="input">fecha a comprobar</param>
        /// <param name="desde">fecha minima</param>
        /// <param name="hasta">fecha maxima</param>
        /// <param name="inclusive">Inluir fechas en la comparacion</param>
        /// <returns></returns>
        public static bool Between(this DateTime input, DateTime desde, DateTime hasta,bool inclusive=true)
        {
            if (inclusive)
            {
                return (input >= desde && input <= hasta);
            }
            else
            {
                return (input > desde && input < hasta);
            }
        }

        /// <summary>
        /// Devolver Año + Quincena en formato string del año
        /// </summary>
        /// <param name="input">fecha a calcular quincena</param>
        /// <returns>Resultado de Año+Quincena</returns>
        public static string Quincena(this DateTime fecha)
        {
            if (fecha != null)
            {
                string resultado = fecha.Year.ToString();
                int mes = 0;
                int quincena = 0;
                if (fecha.Month == 1)
                {
                    mes = 0;
                }
                else
                {
                    mes = ((fecha.Month) - 1) * 2;
                }
                if (fecha.Day <= 15)
                {
                    quincena = 1;
                }
                else
                {
                    quincena = 2;
                }
                int suma = mes + quincena;

                resultado = resultado + String.Format("{0, 0:D2}", suma);
                return resultado;
            }
            return null;
        }

        public static int GetSemanaDelAnyo(this DateTime fecha)
        {
            CultureInfo cultureInfo = new CultureInfo("es-ES");
            Calendar calendar = cultureInfo.Calendar;

            CalendarWeekRule calendarWeekRule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek dayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;

            int week = calendar.GetWeekOfYear(fecha, calendarWeekRule, dayOfWeek);
            return week;
        }
    }
}

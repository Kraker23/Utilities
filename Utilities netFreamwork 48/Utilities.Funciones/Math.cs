using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Utilities.Funciones
{
    /// <summary> Clase para agrupar funciones matemáticas </summary>
    public class Matematicas
    {

        /// <summary>
        /// Redondea el valor pasado al menor valor multimo de 0.05 (36.6799 => 36.65)
        /// </summary>
        /// <param name="val">double: valor a redondear</param>
        /// <returns>double: redondeo (36.6799 => 36.65) </returns>
        public static double RedondeoA5CentimosMenor(double val)
        {
           /* double dec = val * 10 - Math.Floor(val * 10);

            if (dec >= 0.5d)
            {
                dec = 0.5d;
            }
            else
            {
                dec = 0.0d;
            }

            return (Math.Floor(val * 10d) + dec) / 10d;*/
            return Math.Round(Math.Floor((float)val / 0.05f) * 0.05f, 2);
        }


        /// <summary>
        /// Redondea el valor pasado al menor valor multimo de 0.10 (36.6799 => 36.60)
        /// </summary>
        /// <param name="val">double: valor a redondear</param>
        /// <returns>double: redondeo (36.6799 => 36.60) </returns>
        public static double RedondeoA10CentimosMenor(double val)
        {
            return Math.Floor((float)val * 10f) / 10f;
        }


        /// <summary>
        /// Redondea el valor pasado al menor valor multimo de 0.10 (36.6799 => 36.60)
        /// </summary>
        /// <param name="val">double: valor a redondear</param>
        /// <param name="valorRedonde">double: valor por el cual se redondea</param>
        /// <returns>double </returns>
        public static double RedondeoMenor(double val, double valorRedondeo)
        {
            decimal dVal, dValRed;
            dVal = (decimal)val;
            dValRed = (decimal)valorRedondeo;

            decimal floor = dVal / dValRed;
            floor = Math.Floor(floor);

            decimal round = floor * dValRed;
            round = Math.Round(round,2);

            //return Math.Round(Math.Floor((float)val / (float)valorRedondeo) * (float)valorRedondeo, 2);
            //return (double)Math.Round((decimal)(Math.Floor((decimal)(dVal / dValRed)) * dValRed), 2);
            return (double)round;
        }

    }
}

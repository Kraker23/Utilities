using System;
using System.Globalization;

namespace Utilities.Funciones
{
    public partial class Fechas
    {
       

        public class DiaSemana
        {
            public int numeroDia { get { return ((int)dayOfWeek); } }
            public string dia { get { return cultureInfo.DateTimeFormat.DayNames[numeroDia].ToUpper(); } }
            public DayOfWeek dayOfWeek { get; set; }
            public CultureInfo cultureInfo { get; set; }


            public DiaSemana(DayOfWeek dayOfWeek, CultureInfo cultureInfo=null)
            {
                this.dayOfWeek = dayOfWeek;
                if (cultureInfo == null)
                {
                    cultureInfo = new CultureInfo("es-ES");
                }
                this.cultureInfo = cultureInfo;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Clases.Rendimiento
{

    public class Rendimiento
    {
        public DateTime inicio { get; set; }
        public DateTime inicioGlobal { get; set; }
        public List<string> logs { get; set; }
        public List<Tuple<string,TimeSpan>> logsf { get; set; }

        public Rendimiento()
        {
            inicio = DateTime.Now;
            inicioGlobal = DateTime.Now;
            logs = new List<string>();
            logsf = new List<Tuple<string, TimeSpan>>();
        }

        public void ResetearTiempo()
        {
            inicio = DateTime.Now;
        }

        //public string GetDiferencia(string funcion)
        //{
        //    string res = string.Empty;
        //    TimeSpan ts = DateTime.Now - inicio;
        //    res = "La funcion " + funcion + " a tardado " + ts.TotalMilliseconds.ToString() + " miliSegundos." + Environment.NewLine +
        //            "Hora Inicio" + inicio.ToLongTimeString() + "--> Hora Actual " + DateTime.Now.ToLongTimeString();
        //    //MessageBox.Show(res);
        //    logs.Add(res);
        //    logsf.Add(new Tuple<string,TimeSpan>(funcion,ts));
        //    return res;
        //}

        public string GetDiferencia(string funcion,bool resetarTiempo=false)
        {
            string res = string.Empty;
            TimeSpan ts = DateTime.Now - inicio;
            res = "La funcion " + funcion + " a tardado " + ts.TotalMilliseconds.ToString() + " miliSegundos." + Environment.NewLine +
                    "Hora Inicio" + inicio.ToLongTimeString() + "--> Hora Actual " + DateTime.Now.ToLongTimeString();
            //MessageBox.Show(res);
            logs.Add(res);
            logsf.Add(new Tuple<string, TimeSpan>(funcion, ts));

            if (resetarTiempo)
            {
                this.ResetearTiempo();
            }
            return res;
        }

        

        public void GetDiferenciaMessage(string funcion)
        {
            string res = string.Empty;
            TimeSpan ts = DateTime.Now - inicio;
            res = "La funcion " + funcion + " a tardado " + ts.TotalMilliseconds.ToString() + " miliSegundos." + Environment.NewLine +
                    "Hora Inicio" + inicio.ToLongTimeString() + "--> Hora Actual " + DateTime.Now.ToLongTimeString();
            logs.Add(res);
            logsf.Add(new Tuple<string, TimeSpan>(funcion, ts));
            MessageBox.Show(res);
            
            //return res;
        }

        public string getLog()
        {
            string res = string.Empty;
            foreach (string log in logs)
            {
                res = res + Environment.NewLine + log;
            }

            TimeSpan ts = DateTime.Now - inicioGlobal;
            return "La diferencia global es " + ts.TotalMilliseconds.ToString() + Environment.NewLine +
                "Hora Inicio Global -> " + inicioGlobal.ToLongTimeString() + "--> Hora Actual " + DateTime.Now.ToLongTimeString()
                + Environment.NewLine + res;

        }

        public void getLogMessage()
        {
            string res = string.Empty;
            foreach (string log in logs)
            {
                res = res + Environment.NewLine + log;
            }

            TimeSpan ts = DateTime.Now - inicioGlobal;
            MessageBox.Show("La diferencia global es " + ts.TotalMilliseconds.ToString() + Environment.NewLine +
                "Hora Inicio Global -> " + inicioGlobal.ToLongTimeString() + "--> Hora Actual " + DateTime.Now.ToLongTimeString()
                + Environment.NewLine + res);

        }

        
    }
}

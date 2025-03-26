using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesNet.Objetos.Error
{
    public class Error
    {
        private bool tieneError;
        private string Mensaje;

        public Error()
        {
            this.tieneError = false;
        }

        public Error(string error)
        {
            setError(error);
        }

        public void setError(string error)
        {
            this.tieneError = true;
            this.Mensaje = error;
        }

        public string getError()
        {
            return this.Mensaje;
        }
        public bool HasError()
        {
            return this.tieneError;
        }

        public void getMessageError(string AddTexto="")
        {
            MessageBox.Show(Mensaje+", "+AddTexto);
        }

    }
}

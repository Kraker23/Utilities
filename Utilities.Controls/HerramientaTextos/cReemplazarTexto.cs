using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Controls.HerramientaTextos
{
    public partial class cReemplazarTexto : UserControl
    {
        public cReemplazarTexto()
        {
            InitializeComponent();
            Orden = -1;
        }

        public int Orden { get; set; }

        public string Buscar { 
            get { return txtBuscar.Text; }
            set { txtBuscar.Text = value; }
        }

        public string Reemplazar { 
            get { return txtReeplazar.Text; }
            set { txtReeplazar.Text = value; }
        }


        public string ReemplazarTextos(string texto)
        {
            return texto.Replace(getText(Buscar), getText(Reemplazar));
        }


        private string getText(string texto)
        {
            return texto.Replace("{#nl}",System.Environment.NewLine);
        }
    }
}

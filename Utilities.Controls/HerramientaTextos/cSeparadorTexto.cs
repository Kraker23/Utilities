using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Extensions;

namespace Utilities.Controls.HerramientaTextos
{
    public partial class cSeparadorTexto : UserControl
    {
        public string SeparadorDefecto = ",";
        public string TextoRemplazr = "\r\n";

        public cSeparadorTexto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty( txtCadena.Text))
            {
                if (!string.IsNullOrEmpty(txtSeparador.Text))
                {
                    SeparadorDefecto = txtSeparador.Text;
                }
                if (!string.IsNullOrEmpty(txtCadenaSeparar.Text))
                {
                    TextoRemplazr = txtCadenaSeparar.Text;
                }
                string resultado = string.Empty;
                string[] textoSeparado = txtCadena.Text.Split(TextoRemplazr );
                
                foreach (var item in textoSeparado)
                {
                    resultado=resultado.añadirString(item, SeparadorDefecto);
                }
                txtResultado.Text = resultado;
            }
            else
            {
                MessageBox.Show("Introduce texto para concatenar");
            }
        }

        private void btCopiarClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResultado.Text);
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtCadena.Text = string.Empty;
        }

        private void txtCadena_TextChanged(object sender, EventArgs e)
        {
            if (txtCadena.Text.Length>2147483645)
            {
                MessageBox.Show("El texto introducido es mas grande de lo que se puede controlar");
            }
        }
    }
}

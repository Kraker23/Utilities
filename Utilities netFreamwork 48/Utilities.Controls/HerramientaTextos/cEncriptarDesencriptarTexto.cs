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
    public partial class cEncriptarDesencriptarTexto : UserControl
    {
        public cEncriptarDesencriptarTexto()
        {
            InitializeComponent();
        }


        private void btEncriptar_Click(object sender, EventArgs e)
        {
            txtResultadoEncriptar.Text = txtParaEncriptar.Text.EncryptAES();
            if (chkDobleFuncion.Checked)
                CopiarEncriptado();
        }

        private void btDesencriptar_Click(object sender, EventArgs e)
        {

            txtResultadoDesencriptar.Text = txtParaDesencriptar.Text.DecryptAES();
            if (chkDobleFuncion.Checked)
                CopiarDesncriptado();
        }

        private void btCopiarEncriptado_Click(object sender, EventArgs e)
        {
            CopiarEncriptado();
        }

        private void CopiarEncriptado()
        {
            if (!string.IsNullOrEmpty(txtResultadoEncriptar.Text))
            {
                Clipboard.SetText(txtResultadoEncriptar.Text);
            }
        }

        private void btCopiarDesencriptado_Click(object sender, EventArgs e)
        {
            CopiarDesncriptado();
        }

        private void CopiarDesncriptado()
        {
            if (!string.IsNullOrEmpty(txtResultadoDesencriptar.Text))
            {
                Clipboard.SetText(txtResultadoDesencriptar.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btLimpiarEncriptar_Click(object sender, EventArgs e)
        {
            txtResultadoEncriptar.Clear();
                txtParaEncriptar.Clear();
        }

        private void btLimpiarDesencriptar_Click(object sender, EventArgs e)
        {
            txtResultadoDesencriptar.Clear();
            txtParaDesencriptar.Clear();
        }
    }
}

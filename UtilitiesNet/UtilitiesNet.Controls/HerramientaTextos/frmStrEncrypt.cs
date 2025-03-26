using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;
using UtilitiesNet.Extensiones;

namespace UtilitiesNet.Controls.HerramientaTextos
{
    public partial class frmStrEncrypt : Form
    {
        public frmStrEncrypt()
        {
            InitializeComponent();
        }

        private void tbbEncrypt_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtOrigin.Text.Encriptar(); 
        }

        private void tbbDecrypt_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtOrigin.Text.Desencriptar();
        }

        private void tbbToUrlEncoding_Click(object sender, EventArgs e)
        {
            
            txtResult.Text = HttpUtility.UrlEncode(txtOrigin.Text);
        }

        private void tbbToUrlDecoding_Click(object sender, EventArgs e)
        {
            txtResult.Text = HttpUtility.UrlDecode(txtOrigin.Text);

        }

        private void tbbEncryptURL_Click(object sender, EventArgs e)
        {

            txtResult.Text = txtOrigin.Text.EncriptarForURL();
        }

        private void tbbDecryptUrl_Click(object sender, EventArgs e)
        {

            txtResult.Text = txtOrigin.Text.DesencriptarFromUrl();
        }

        private void tbbEncryptAES_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtOrigin.Text.EncryptAES(); 
        }

        private void tbbDecryptAES_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtOrigin.Text.DecryptAES();
        }

    }
}

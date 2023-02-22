
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Windows.Forms;
using Utilities.Clases.QR_CodigoBarras;

namespace Utilities.Test
{
    public partial class frmQRCodigoBarras : Form
    {
        public frmQRCodigoBarras()
        {
            InitializeComponent();
            txtQR.Text = "C98GHGH 1234ABC";
            txtCodigoBarras.Text = "C98GHGH 1234ABC";
        }

        #region QR
        private void GenerarQR()
        {
            if (!string.IsNullOrEmpty(txtQR.Text))
            {
                Image img = QR.GenerarQr(txtQR.Text);
                if (img != null)
                {
                    pbQR.Image = img;
                }
                else
                {
                    MessageBox.Show("No se ha podido generar el QR");
                }
            }
            else
            {
                MessageBox.Show("El texto del QR no puede estar vacio");
            }
        }
        private void btGenerarQR_Click(object sender, EventArgs e)
        {
            GenerarQR();
        }
        private void txtQR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                GenerarQR();
            }
        }

        #endregion

        #region CodigoBarras

        private void GenerarCodigoBarras()
        {
            if (!string.IsNullOrEmpty(txtCodigoBarras.Text))
            {
                string errorValidacion = CodigoBarras.ValidarTexto(txtCodigoBarras.Text);
                if (string.IsNullOrEmpty(errorValidacion))
                {
                    Image img = CodigoBarras.GenerarCodigoBarrasTipoCODE128(txtCodigoBarras.Text);
                    if (img != null)
                    {
                        pbCodigoBarras.Image = img;
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido generar el Codigo Barras");
                    }
                }
                else
                {
                    MessageBox.Show(errorValidacion);
                }

            }
            else
            {
                MessageBox.Show("El texto del Codigo Barras no puede estar vacio");
            }
        }

        private void btGenerarCodigoBarras_Click(object sender, EventArgs e)
        {
            GenerarCodigoBarras();            
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                GenerarCodigoBarras();
            }
        }

        #endregion

        #region QrImagen

        private void btGenerarQrImagen_Click(object sender, EventArgs e)
        {
            GenerarQrImagen();
        }

        private void GenerarQrImagen()
        {
            if (!string.IsNullOrEmpty(txtMatricula.Text))
            {
                string txt = QR.GenerarTexto(txtMatricula.Text, txtCodigoAnulacion.Text);
                txtQR.Text = txt;
                //pbQrImagen.Image = QR_New.GenerarQRImagen(txtQR.Text, 200);
                pbQrImagen.Image = QR.GenerarQRImagen(txt, (int)nTamanyo.Value);
            }
            else
            {
                MessageBox.Show("El texto del Matricula  no puede estar vacio");
            }
        }

        #endregion
    }

}
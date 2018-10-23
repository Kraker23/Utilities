using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Controls.IntroducirTexto
{
    public partial class frmIntroducirTexto : Form
    {
        public string resultado;

        public frmIntroducirTexto(string lbl,string tituloVentana)
        {
            InitializeComponent();
            this.lbl.Text = lbl;
            this.Text = tituloVentana;
        }

        private void frmIntroducirTexto_Load(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)
        {
            resultado = txt.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                resultado = txt.Text;
                this.DialogResult = DialogResult.OK;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.DialogResult=DialogResult.Cancel;
            }
        }

    }
}

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
        private bool contrasenaVisible = false;

        public frmIntroducirTexto(string lbl,string tituloVentana,bool esPassword=false)
        {
            InitializeComponent();
            this.lbl.Text = lbl;
            this.Text = tituloVentana;
            if (!esPassword)
            {
                this.btMostrar.Visible = false;
                this.bt.Location= new Point(290, 23);
                this.Size = new Size(396, 106);
            }
            else
            {
                txt.UseSystemPasswordChar = true;
                this.btMostrar.Visible = true;
                this.bt.Location = new Point(293, 54);
                this.Size= new Size(396, 123);
                
            }
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

        private void btMostrar_Click(object sender, EventArgs e)
        {
            contrasenaVisible = !contrasenaVisible;

            txt.UseSystemPasswordChar = !contrasenaVisible;
            if (!contrasenaVisible)
            {
                this.btMostrar.Image = global::Utilities.Controls.Properties.Resources.visibilidad_1_;
            }
            else
            {
                this.btMostrar.Image = global::Utilities.Controls.Properties.Resources.ocultar_2_;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesNet.Controls.HerramientaTextos
{
    public partial class frmIntroducirTexto : Form
    {
        public string resultado;
        private bool contrasenaVisible = false;

        //TODO : mejoras -> hacer que puedas darle un tamaño maximo de caracteres al escribir
        //TODO : Mejoras -> que los componentes no se puedan modificar desde fuera, pero que puedas modificar propiedades, desde un constructor o metodo
        //TODO : Mejoras -> contolar que el texto cuando pulsas el boton de OK, que el texto no sea vacio
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
            resultado = txt.Text.Trim();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                resultado = txt.Text.Trim();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.DialogResult=DialogResult.Cancel;
                Close();
            }
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            contrasenaVisible = !contrasenaVisible;

            txt.UseSystemPasswordChar = !contrasenaVisible;
            if (!contrasenaVisible)
            {
                this.btMostrar.Image = global::UtilitiesNet.Controls.Properties.Resources.visibilidad_1_;
            }
            else
            {
                this.btMostrar.Image = global::UtilitiesNet.Controls.Properties.Resources.ocultar_2_;
            }
        }
    }
}

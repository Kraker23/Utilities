using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Controls.Correo;
using Utilities.Controls;
using Utilities.Controls.HerramientaTextos;
using Utilities.Controls.EditarImagen;
using Utilities.Controls.SqlExecMultiple;
using Utilities.Controls.TCP;

namespace Utilities.Test
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbCorreo_Click(object sender, EventArgs e)
        {
            frmIntroducirTexto frmUsuarioCorreo = new frmIntroducirTexto("Correo Emisor", "Usuario Correo");
            frmIntroducirTexto frmPass = new frmIntroducirTexto("Password Correo", "Password Correo",true);

            if (frmUsuarioCorreo.ShowDialog() == DialogResult.OK)
            {
                if (frmPass.ShowDialog() == DialogResult.OK)
                {
                    cNewCorreo cNewCorreo = new cNewCorreo(frmUsuarioCorreo.resultado, frmPass.resultado);
                    cNewCorreo.Dock = DockStyle.Fill;
                    Form form = new Form();
                    form.Size = cNewCorreo.Size;
                    form.Controls.Add(cNewCorreo);

                    form.MdiParent = this;
                    form.Show();
                }
            }
        }

        private void tsbEditarImagen_Click(object sender, EventArgs e)
        {
            frmCaptura frmCaptura = new frmCaptura();
            frmCaptura.MdiParent = this;
            frmCaptura.Show();
        }

        private void tsbAyuda_Click(object sender, EventArgs e)
        {
            /// hacer que dependiendo la ventana abierta/control, te salga una ventana de informacion sobre info del control,
            /// se puede hacer que cada control o formulario tenga una propiedad que contenga descripcion de funcionamientos
            ///  
            /// crear una interefaz para todas y que ponga mas info, como propiedad de descripcion, autor y fechas.

        }

        private void tsbEncriptadorString_Click(object sender, EventArgs e)
        {
            cEncriptarDesencriptarTexto cEncriptar = new cEncriptarDesencriptarTexto();
            cEncriptar.Dock = DockStyle.Fill;
            Form form = new Form();
            form.Size = cEncriptar.Size;
            form.Controls.Add(cEncriptar);

            form.MdiParent = this;
            form.Show();
        }

        private void tsbSeparadorTexto_Click(object sender, EventArgs e)
        {
            cSeparadorTexto cSeparador = new cSeparadorTexto();
            cSeparador.Dock = DockStyle.Fill;
            Form form = new Form();
            form.Size = cSeparador.Size;
            form.Controls.Add(cSeparador);

            form.MdiParent = this;
            form.Show();
        }

        private void tsbRegularExpresion_Click(object sender, EventArgs e)
        {
            frmRegExpr frm = new frmRegExpr();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbEncriptarTexto_Click(object sender, EventArgs e)
        {
            frmStrEncrypt frm = new frmStrEncrypt();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbRemplazarTexto_Click(object sender, EventArgs e)
        {
            frmTextReplace frm = new frmTextReplace();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbEjecucionSql_Click(object sender, EventArgs e)
        {
            frmSqlExecMultiple frm = new frmSqlExecMultiple();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbTcpCliente_Click(object sender, EventArgs e)
        {
            frmTCPClient frm = new frmTCPClient();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbTcpServer_Click(object sender, EventArgs e)
        {
            frmTCPServer frm = new frmTCPServer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbTraza_Click(object sender, EventArgs e)
        {
        }
    }
}

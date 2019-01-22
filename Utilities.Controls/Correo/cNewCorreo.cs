using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Utilities.Clases.Correo;
using Utilities.Extensions;
using System.IO;
using Utilities.Clases.MessageTemporal;

namespace Utilities.Controls.Correo
{
    public partial class cNewCorreo : UserControl
    {
        #region Propiedades

        private string asunto;
        private string codcompania;
        private string idCliente;
        private string CodCliente;
        private string CodProducto;
        private string IdCampCompra;
        private string CodCampanaMaestra;
        private string IdTVCampana;
        private string idCampanaMaestra;
        private string estado;
        private string usuarioADP;
        private string idUsuarioADP;
        private string usuarioAD;
        private string version;
        private string crearMensajeEstadoMBS;
        private bool Incidencia = false;
        private bool Toolerancia = false;
        //private Correo cr = new Correo();
        private string correoAntiguo;
        private bool selCorreo = false;
        private List<Email> emails = new List<Email>();
        private List<string> adjuntos = new List<string>();
        private List<string> adjuntostemp = new List<string>();
        private string correoQuienEnvia;
        private string Password;
        public class Email
        {
            public string correo { get; set; }
            public string grupo { get; set; }
            public bool principal { get; set; }
        }

        #endregion

        #region Constructor

        public cNewCorreo(string CorreoQuienEnvia,string Password )
        {
            InitializeComponent();
            this.correoQuienEnvia = CorreoQuienEnvia;
            this.Password = Password;
            ListViewGroup gPara = new ListViewGroup("Para");
            gPara.Name = "Para";
            ListViewGroup vCC = new ListViewGroup("CC");
            vCC.Name = "CC";
            ListViewGroup vCCO = new ListViewGroup("CCO");
            vCCO.Name = "CCO";
            lVcorreos.Groups.Add(gPara);
            lVcorreos.Groups.Add(vCC);
            lVcorreos.Groups.Add(vCCO);


            lVcorreos.Columns.Add("Correo", lVcorreos.Width);
        }

        #endregion


        #region Eventos

        private void btEnviar_Click(object sender, EventArgs e)
        {
            //EJEMPLO DE ENVIO
            //GestorCorreo gc = new GestorCorreo("c.ramirez@eskape.es", "Eskpe1234", GestorCorreo.TipoServidor.Otro);
            //gc.NuevoCorreo("cristianjavier23@gmail.com", "Asuntooo", "Cuerpo del menesja", false);
            //MessageBox.Show(gc.EnviarCorreo());

            GestorCorreo gc = new GestorCorreo(correoQuienEnvia, Password, GestorCorreo.TipoServidor.Otro);

            List<string> archivos = new List<string>();

            archivos = adjuntos.Union(adjuntostemp).ToList();

            gc.NuevoCorreo(emails.Where(x => x.grupo == "Para").Select(x => x.correo).ToList(),
                            emails.Where(x => x.grupo == "CC").Select(x => x.correo).ToList(),
                            emails.Where(x => x.grupo == "CCO").Select(x => x.correo).ToList(),
                            txtAsunto.Text, txtDescripcion.Text, chkContenidoHTML.Checked, archivos);
            MessageBox.Show(gc.EnviarCorreo());
            


        }
        
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lVcorreos.SelectedItems.Count == 1)
            {
                if (!emails.Exists(x => x.correo == lVcorreos.SelectedItems[0].Text && x.principal == true))
                {
                    Email eAux = emails.First(x => x.correo == lVcorreos.SelectedItems[0].Text);
                    Utilities.Controls.IntroducirTexto.frmIntroducirTexto frm = new Utilities.Controls.IntroducirTexto.frmIntroducirTexto("Correo a Modificar", "Modificar Correo");
                    frm.txt.Text = eAux.correo;
                    DialogResult d = frm.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        eAux.correo = frm.resultado;
                        actualizarListView();
                    }
                }
                else
                {
                    MessageBox.Show("Este correo no se puede modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccionar solo un correo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lVcorreos.SelectedItems.Count > 0)
            {
                if (!emails.Exists(x => x.correo == lVcorreos.SelectedItems[0].Text && x.principal == true))
                {
                    emails.Remove(emails.First(x => x.correo == lVcorreos.SelectedItems[0].Text));

                    actualizarListView();
                }
                else
                {
                    MessageBox.Show("este correo no se puede modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lVcorreos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVcorreos.SelectedItems.Count == 1)
            {
                if (!emails.Exists(x => x.correo == lVcorreos.SelectedItems[0].Text && x.principal == true))
                {
                    for (int i = 0; i < MenuEliminar.Items.Count; i++)
                    {
                        MenuEliminar.Items[i].Visible = true;
                    }

                }
                else
                {
                    for (int i = 0; i < MenuEliminar.Items.Count; i++)
                    {
                        MenuEliminar.Items[i].Visible = false;
                    }
                }
            }
        }

        private void btEliminarImagenes_Click(object sender, EventArgs e)
        {
            adjuntos.Clear();
            txtImagenes.Clear();
            txtImagenes.Visible = false;
            btEliminarImagenes.Visible = false;
        }
        
        private void btImgClipBoard_Click(object sender, EventArgs e)
        {
            Image img = ClipboardImage();
            if (img != null)
            {
                string nombreArchivo = "ImagenClipboard_" + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "_").Replace(":", "") + ".jpg";
                img.Save(nombreArchivo);

                adjuntostemp.Add(Application.StartupPath + "\\" + nombreArchivo);
                txtImagenes.Text = nombreArchivo + " ; " + txtImagenes.Text;


                txtImagenes.Visible = true;
                btEliminarImagenes.Visible = true;
            }
            else
            {
                MessageBoxTemporal.Show("El portapapeles no contiene una imagen.", "Error Portapeles", 2);
            }
        }

        private void btInsertarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog attachment = new OpenFileDialog();
            attachment.Title = "Select a file to send";
            DialogResult dr = attachment.ShowDialog();

            if (dr == DialogResult.OK && attachment.FileName.Length > 0)
            {
                for (int i = 0; i < attachment.FileNames.Count(); i++)
                {
                    adjuntos.Add(attachment.FileNames[i]);
                    txtImagenes.Text = attachment.SafeFileNames[i] + " ; " + txtImagenes.Text;

                }
                txtImagenes.Visible = true;
                btEliminarImagenes.Visible = true;
            }
        }

        private void btCC_Click(object sender, EventArgs e)
        {
            añadirCorreo("CC");
        }

        private void btCCO_Click(object sender, EventArgs e)
        {
            añadirCorreo("CCO");
        }
        
        private void tbDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                añadirCorreo("Para");
            }
        }
        
        private void bAñadirCorreo_Click(object sender, EventArgs e)
        {
            añadirCorreo("Para");
        }

        #endregion

        #region Funciones

        public void AddCorreoPorDefecto(string correo)
        {
            Email e = new Email();
            e.correo = correo;
            e.principal = true;
            e.grupo = "Para";
            emails.Add(e);

            actualizarListView();
        }

        private void actualizarListView()
        {
            lVcorreos.Items.Clear();
            foreach (Email item in emails)
            {
                lVcorreos.Items.Add(item.correo);
                lVcorreos.Items[lVcorreos.Items.Count - 1].Group = lVcorreos.Groups[item.grupo];
                if (item.principal)
                {
                    lVcorreos.Items[lVcorreos.Items.Count - 1].Selected = false;
                    lVcorreos.Items[lVcorreos.Items.Count - 1].ForeColor = Color.Gray;
                }
            }
        }

        private System.Drawing.Image ClipboardImage()
        {
            System.Drawing.Image returnImage = null;
            if (Clipboard.ContainsImage())
            {
                returnImage = Clipboard.GetImage();
            }
            return returnImage;
        }

        private void añadirCorreo(string Grupo)
        {
            if (string.IsNullOrEmpty(tbDestino.Text))
            {
                MessageBox.Show("escribe un correo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbDestino.Text.FormatoCorreoValido())
            {
                if (!emails.Exists(x => x.correo == tbDestino.Text))
                {

                    Email e = new Email();
                    e.correo = tbDestino.Text;
                    e.principal = false;
                    e.grupo = Grupo;
                    emails.Add(e);

                    actualizarListView();
                }
                else
                {
                    MessageBox.Show("el correo ya existe en la lista", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                tbDestino.Clear();
            }
            else { MessageBox.Show("el correo no esta escrito en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
        private void BorrarArchivosTemporales()
        {
            try
            {
                if (adjuntostemp.HasContent())
                {
                    foreach (string archivo in adjuntostemp)
                    {
                        File.Delete(archivo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion







    }
}

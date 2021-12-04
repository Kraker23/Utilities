using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Clases.GestorConexionSQL;
using DataIncidence.UI.BBDD;
using Utilities.Extensions;

namespace DataIncidence.UI.View
{
    public partial class cPases : UserControl
    {
        public delegate void DatosEvento(DataTable dt, string Control); //si no necesitas parametros dejar vacio los (), sino poner el tipo de dato a pasar
        public event DatosEvento CargarDatosEvento;//poner esto  = delegate { }; si da problemas de nulo en esta misma linea, el probl

        public delegate void IniciarCargaEvento();
        public event IniciarCargaEvento IniciarCarga;

        public delegate void FinCargaEvento();
        public event FinCargaEvento FinCarga;

        private DataTable dtResult;


        public cPases()
        {
            InitializeComponent();
        }

        #region CopiaBase

        int height = 200;
        int width = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            ManageCheckGroupBox(chkActivar, group);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Height == height)
            {
                panel1.Height = btExpan.Height;
                btExpan.Text = "+";
                foreach (Control item in group.Controls)
                {
                    if (item.Tag != "chkActivar" && item.Tag != "btExpandable")
                    {
                        item.Visible = false;
                    }
                }
            }
            else
            {
                panel1.Height = height;// Convert.ToInt32(panel1.Tag.ToString());
                btExpan.Text = "-";
                foreach (Control item in group.Controls)
                {
                    item.Visible = true;
                }
            }
        }

        private void cBase_Load(object sender, EventArgs e)
        {
            ManageExpandableLoad();

            ManageCheckGroupBox(chkActivar, group);
        }
        
        private void ManageExpandableLoad()
        {
            panel1.Height = btExpan.Height;
            btExpan.Text = "-";
            if (panel1.Dock == DockStyle.Fill)
            {
                width = panel1.Width;
                height = panel1.Height;
                panel1.Dock = DockStyle.None;
                panel1.Width = width;
                panel1.Height = height;
            }
        }

        private void ManageCheckGroupBox(CheckBox chk, GroupBox grp)
        {
            // Make sure the CheckBox isn't in the GroupBox.
            // This will only happen the first time.
            if (chk.Parent == grp)
            {
                // Reparent the CheckBox so it's not in the GroupBox.
                grp.Parent.Controls.Add(chk);

                // Adjust the CheckBox's location.
                chk.Location = new Point(
                    chk.Left + grp.Left,
                    chk.Top + grp.Top);

                // Move the CheckBox to the top of the stacking order.
                chk.BringToFront();
            }

            // Enable or disable the GroupBox.
            //grp.Enabled = chk.Checked;//Habilitar todo/Nada, pero esto tambien deshabilita el boton Expandible y con el foreach eso lo excluyo
            foreach (Control c in grp.Controls)
            {
                if (c.Tag != "btExpandable")
                {
                    c.Enabled = chk.Checked;
                }
            }
        }
        
        private void panel1_SizeChanged_1(object sender, EventArgs e)
        {
            if (panel1.Height > btExpan.Height)
            {
                height = panel1.Height;
            }
        }


        public void btCargar_Click(object sender, EventArgs e)
        {
            CargarDatos(GetQuery(), "Pltvpases");
        }

        public void EventoCargarDatos(DataTable dt, string nombre)
        {
            CargarDatosEvento?.Invoke(dt, nombre);
        }

        private void CargarDatos(string query, string NombreProceso)
        {
            IniciarCarga?.Invoke();
            CheckForIllegalCrossThreadCalls = false;
            Task.Factory.StartNew(() =>
            {
                Cargar(query);
            }).ContinueWith((t) =>
            {
                if (dtResult != null)
                {
                    EventoCargarDatos(dtResult, NombreProceso);
                    FinCarga?.Invoke();
                }
                CheckForIllegalCrossThreadCalls = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        #endregion

        public void btLimpiar_Click(object sender, EventArgs e)
        {
            txtAbrevCampanaMaestra.Text = string.Empty;
            chkFechas.Checked = true;
            dtDesde.Value = DateTime.Now;
            dtHasta.Value = DateTime.Now;
            nTipologiaEstado.Value = -1;
            nTipologiaVersion.Value =2;
            nCierre.Value = -1;
            chkQuitarAnulados.Checked = false;
            chkAuxi3.Checked = false;

            txtAnuncioId.Text = string.Empty;
            txtidPase.Text = string.Empty;
            txtPaseVt.Text = string.Empty;
            txtCodCadena.Text = string.Empty;
            txtCodCadenaAlias.Text = string.Empty;
            txtCodgescopy.Text = string.Empty;
            txtGrupoSoporte.Text = string.Empty;

            txtAbrevCampanaMaestra.Focus();
        }

        private void Cargar(string Query)
        {
            dtResult = null;

            GestorConexion gc = new GestorConexion(DatosConexion.GetUrlConexion());
            DataTable dt = gc.Consulta(Query);
            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("No se encontraron Resultados para la consulta");
                dt = new DataTable("SinDatos");
                dt.Columns.Add("Informacion");
                dt.Rows.Add("No hay datos");
                dtResult = dt;
            }
            //else if (dt.Rows.Count == 1)
            //{
            ////    txtidCompania.Text = dt.Rows[0].ItemArray[0].ToString();
            ////    txtCodCompania.Text = dt.Rows[0].ItemArray[1].ToString();
            ////    txtCompania.Text = dt.Rows[0].ItemArray[2].ToString();
            //}
            else
            {
                dtResult = dt;
                //EventoCargarDatos(dt, "Pltvpases");

                //gridCampana.DataSource = dt;
                //gridCampana.AutoResizeColumns();
                //gridCampana.Refresh();
                //sContainer.Panel2Collapsed = false;
            }
        }

        private string GetQuery()
        {
            string resultado = string.Empty;
            resultado = "select idtipologiaversion,idtipologiaestado est,anuncioid_mpp mpp,cierre c,idpasevt,* from pltvpases ";
            //if (!string.IsNullOrEmpty(txtAbrevCampanaMaestra.Text) ||
            //    chkFechas.Checked ||
            //    !string.IsNullOrEmpty(txtCodCompania.Text) ||
            //    !string.IsNullOrEmpty(txtCompania.Text))
            //{
            

            string param = string.Empty;


            if (!string.IsNullOrEmpty(txtAbrevCampanaMaestra.Text))
            {
                param = param.añadirString("abrevcampmaestra ='" + txtAbrevCampanaMaestra.Text + "'", ';');
            }
            if (chkFechas.Checked)
            {
                param = param.añadirString("cast(fechacorte as date) between '" + dtDesde.Value.ToShortDateString() + "' and '" + dtHasta.Value.ToShortDateString() + "'", ';');
            }
            if (nTipologiaVersion.Value > 0)
            {
                param = param.añadirString("idtipologiaversion=" + nTipologiaVersion.Value, ';');
            }
            if (nTipologiaEstado.Value > 0)
            {
                param = param.añadirString("idtipologiaestado=" + nTipologiaEstado.Value, ';');
            }
            if (chkQuitarAnulados.Checked)
            {
                param = param.añadirString("idtipologiaestado not in (7, 8)", ';');
            }
            if (chkConAnuncioMPP.Checked)
            {
                param = param.añadirString("anuncioid_mpp is not null ", ';');
            }
            if (nCierre.Value > -1)
            {
                param = param.añadirString("cierre=" + nCierre.Value, ';');
            }
            if (!string.IsNullOrEmpty(txtCodCadena.Text))
            {
                param = param.añadirString("codcadena like '%" + txtCodCadena.Text + "%'", ';');
            }
            if (!string.IsNullOrEmpty(txtCodCadenaAlias.Text))
            {
                param = param.añadirString("codcadenaalias like '%" + txtCodCadenaAlias.Text + "%'", ';');
            }
            if (!string.IsNullOrEmpty(txtCodgescopy.Text))
            {
                param = param.añadirString("codgescopy like '%" + txtCodgescopy.Text + "%'", ';');
            }
            if (!string.IsNullOrEmpty(txtGrupoSoporte.Text))
            {
                param = param.añadirString("codgruposoporte like '%" + txtGrupoSoporte.Text + "%'", ';');
            }
            if (chkAuxi3.Checked)
            {
                param = param.añadirString("auxi3 is not null", ';');
            }

            if (!string.IsNullOrEmpty(txtAnuncioId.Text))
            {
                param = param.añadirString("anuncioid_mpp=" + txtAnuncioId.Text, ';');
            }
            if (chkPaseConcreto.Checked)
            {
                param = param.añadirString("idpltvpase =" + txtidPase.Text + "or idpasevt =" + txtidPase.Text, ';');
            }
            else
            {
                if (!string.IsNullOrEmpty(txtidPase.Text))
                {
                    param = param.añadirString("idpltvpase=" + txtidPase.Text, ';');
                }
                if (!string.IsNullOrEmpty(txtPaseVt.Text))
                {
                    param = param.añadirString("idpasevt=" + txtPaseVt.Text, ';');
                }
            }

            if (!string.IsNullOrEmpty(param))
            {
                resultado = resultado + " where ";
                if (param.Substring(param.Length - 1) == ";")
                {
                    param = param.Substring(0, param.Length - 1).Replace(";", " And ");
                }
                param = param.Replace(";", " And ");
                resultado = resultado + " " + param;
            }
            //}


            return resultado;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            dtDesde.Enabled = chkFechas.Checked;
            dtHasta.Enabled = chkFechas.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

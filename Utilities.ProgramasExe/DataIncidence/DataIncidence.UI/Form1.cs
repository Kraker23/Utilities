using DataIncidence.UI.BBDD;
using DataIncidence.UI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Clases.GestorConexionSQL;

namespace DataIncidence.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Gestion de Conexion

        private void tsDesarrollo_Click(object sender, EventArgs e)
        {
            lblConexion.Text = CambiarConexion(DatosConexion.TipoConexion.Desarrollo);
            foreach (ToolStripMenuItem item in tsddbSelectorConexion.DropDownItems)
            {
                item.Enabled = item == sender ? false : true;
            }
        }

        private void tsProduccion_Click(object sender, EventArgs e)
        {
            lblConexion.Text = CambiarConexion(DatosConexion.TipoConexion.Produccion);
            foreach (ToolStripMenuItem item in tsddbSelectorConexion.DropDownItems)
            {
                item.Enabled = item == sender ? false : true;
            }
        }

        private void tsPruebas_Click(object sender, EventArgs e)
        {
            lblConexion.Text = CambiarConexion(DatosConexion.TipoConexion.Pruebas);
            foreach (ToolStripMenuItem item in tsddbSelectorConexion.DropDownItems)
            {
                item.Enabled = item == sender ? false : true;
            }
        }

        private string CambiarConexion(DatosConexion.TipoConexion tConexion)
        {
            switch (tConexion)
            {
                case DatosConexion.TipoConexion.Produccion:
                    DatosConexion.SelTipoConexion = tConexion;
                    return DatosConexion.getBBDD();
                case DatosConexion.TipoConexion.Desarrollo:
                    DatosConexion.SelTipoConexion = tConexion;
                    return DatosConexion.getBBDD();
                case DatosConexion.TipoConexion.Pruebas:
                    DatosConexion.SelTipoConexion = tConexion;
                    return DatosConexion.getBBDD();
                default: return string.Empty;
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            lblConexion.Text = CambiarConexion(DatosConexion.TipoConexion.Produccion);
            DescheckearControles();
            //GestorConexion gc = new GestorConexion(DatosConexion.GetUrlConexion());


            //cCliente cliente = new cCliente();
            //cliente.Dock = DockStyle.Top;
            //cliente.CargarDatosEvento += C_CargarDatosEvento;
            //this.Controls.Add(cliente);


            ////ultimo
            //cCampana c = new cCampana();
            //c.Dock = DockStyle.Top;
            //c.CargarDatosEvento += C_CargarDatosEvento;
            //this.Controls.Add(c);
        }

        private void C_CargarDatosEvento(DataTable dt, string Control)
        {
            int pageIndice = -1;
            int numeroFilas = dt.Rows.Count;
            for (int i = 0; i < tabDatosTablas.TabPages.Count; i++)
            {
                if (tabDatosTablas.TabPages[i].Tag.ToString() == Control)
                {
                    pageIndice = i;
                    break;
                }
            }
            if (pageIndice < 0)
            {
                //TabPage tb = new TabPage(Control);
                TabPage tb = new TabPage();
                tb.Text = Control + " (" + numeroFilas + ")";
                tb.Tag = Control;
                DataGridView grid = new DataGridView();
                grid.CellFormatting += Grid_CellFormatting;
                grid.Dock = DockStyle.Fill;
                grid.DataSource = dt;
                grid.Name = Control;
                grid.AutoResizeColumns();
                grid.Refresh();
                if (Control == "Cargas Diarias")
                {
                    grid = PonerColor(grid);
                }
                tb.Controls.Add(grid);
                tabDatosTablas.TabPages.Add(tb);
                tabDatosTablas.SelectedTab = tabDatosTablas.TabPages[tabDatosTablas.TabPages.Count - 1];

            }
            else
            {
                tabDatosTablas.TabPages[pageIndice].Controls.Clear();
                tabDatosTablas.TabPages[pageIndice].Text = Control + " (" + numeroFilas + ")";
                DataGridView grid = new DataGridView();
                grid.Dock = DockStyle.Fill;
                grid.CellFormatting += Grid_CellFormatting;
                grid.DataSource = dt;
                grid.Name = Control;
                grid.AutoResizeColumns();
                grid.Refresh();

                if (Control == "Cargas Diarias")
                {
                    grid = PonerColor(grid);
                }
                tabDatosTablas.TabPages[pageIndice].Controls.Add(grid);
                tabDatosTablas.SelectedTab = tabDatosTablas.TabPages[pageIndice];
            }


        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DataGridView grid = (DataGridView)sender;
                int i = e.RowIndex;
                //    if (grid.Rows[i].Cells["audiencia"].Value.ToString() == "AR1")
                //    {

                //    e.CellStyle.BackColor = Color.PaleGreen;

                //}

                bool audiencia = false;
                bool servidor = false;

                if (grid.Name == "Cargas Diarias")
                { audiencia = true; servidor = true; }
                else
                {
                    foreach (DataGridViewColumn col in grid.Columns)
                    {
                        if (col.Name == "audiencia")
                        { audiencia = true; }
                        if (col.Name == "servidor")
                        { servidor = true; }
                    }
                }
                if (grid.Rows[i].Cells.Count > 1)
                {
                    if (audiencia)
                    {
                        if (grid.Rows[i].Cells["audiencia"].Value != null)
                        {
                            if (grid.Rows[i].Cells["audiencia"].Value.ToString() == "AR1")
                            {
                                grid.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                            }
                            else if (grid.Rows[i].Cells["audiencia"].Value.ToString() == "AR3")
                            {
                                grid.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                            }
                            else if (grid.Rows[i].Cells["audiencia"].Value.ToString() == "AR4")
                            {
                                grid.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            }
                        }
                    }
                    if (servidor)
                    {
                        if (grid.Rows[i].Cells["servidor"].Value != null)
                        {
                            if (grid.Rows[i].Cells["servidor"].Value.ToString() == "madgrmpc384")
                            {
                                grid.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                            }
                            else if (grid.Rows[i].Cells["servidor"].Value.ToString() == "madmdspc411")
                            {
                                grid.Rows[i].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                            }
                            else if (grid.Rows[i].Cells["servidor"].Value.ToString() == "Madssau01101")
                            {
                                grid.Rows[i].DefaultCellStyle.BackColor = Color.PaleGreen;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private DataGridView PonerColor(DataGridView grid)
        {
            foreach (DataGridViewRow rowp in grid.Rows)
            {
                int i = rowp.Index;

                if (grid.Rows[i].Cells["audiencia"].Value.ToString() == "AR1")
                {
                    grid.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (grid.Rows[i].Cells["audiencia"].Value.ToString() == "AR3")
                {
                    grid.Rows[i].DefaultCellStyle.ForeColor = Color.Orange;
                }
                else if (grid.Rows[i].Cells["audiencia"].Value.ToString() == "AR4")
                {
                    grid.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }

                if (grid.Rows[i].Cells["servidor"].Value.ToString() == "madgrmpc384")
                {
                    grid.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                }
                else if (grid.Rows[i].Cells["servidor"].Value.ToString() == "madmdspc411")
                {
                    grid.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (grid.Rows[i].Cells["servidor"].Value.ToString() == "Madssau01101")
                {
                    grid.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }

            }
            return grid;
        }

        public bool Cargando = false;

        private void cCargasDiarias1_IniciarCarga()
        {
            Cargando = true;
            progress.Visible = true;
            progress.Value = 1;
        }

        private void cCargasDiarias1_FinCarga()
        {
            Cargando = false;
            progress.Visible = false;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Cargando)
            {
                if (progress.Value >= 100)
                {
                    progress.Value = 1;
                }
                else
                {
                    progress.PerformStep();
                }
            }
        }

        private void tsbLimpiarTablas_Click(object sender, EventArgs e)
        {
            tabDatosTablas.TabPages.Clear();
        }

        private void tsbBorrarDatos_Click(object sender, EventArgs e)
        {
            LimpiarControles(tabControles.SelectedTab.Text);
        }

        private void LimpiarControles(string selTab)
        {
            if (selTab == "Datos Generales")
            {
                cCadena1.btLimpiar_Click(null, null);
                cCampana1.btLimpiar_Click(null, null);
                cUsuario1.btLimpiar_Click(null, null);
                cCompania1.btLimpiar_Click(null, null);
                cCliente1.btLimpiar_Click(null, null);
                cCadenaAlias2.btLimpiar_Click(null, null);
                cCadena1.btLimpiar_Click(null, null);
                cTarget1.btLimpiar_Click(null, null);
            }
            else if (selTab == "Busqueda Pases")
            {
                cPases1.btLimpiar_Click(null, null);
                cAnunciosEnviados1.btLimpiar_Click(null, null);
                cCambiosPendientes1.btLimpiar_Click(null, null);
            }
            else if (selTab == "Cargas Diarias")
            {
                cCargasDiarias1.btLimpiar_Click(null, null);
            }
            else if (selTab == "Todo")
            {
                cCadena1.btLimpiar_Click(null, null);
                cCampana1.btLimpiar_Click(null, null);
                cUsuario1.btLimpiar_Click(null, null);
                cCompania1.btLimpiar_Click(null, null);
                cCliente1.btLimpiar_Click(null, null);
                cCadenaAlias2.btLimpiar_Click(null, null);
                cCadena1.btLimpiar_Click(null, null);
                cTarget1.btLimpiar_Click(null, null);
                cPases1.btLimpiar_Click(null, null);
                cAnunciosEnviados1.btLimpiar_Click(null, null);
                cCambiosPendientes1.btLimpiar_Click(null, null);
                cCargasDiarias1.btLimpiar_Click(null, null);
            }
        }

        private void tsbBorrarTodo_Click(object sender, EventArgs e)
        {
            tabDatosTablas.TabPages.Clear();
            LimpiarControles("Todo");
        }

        private void tsbEjecutarTodo_Click(object sender, EventArgs e)
        {
            if (cCadena1.chkActivar.Checked = true)
            {
                cCadena1.btCargar_Click(null, null);
            }
            if (cCampana1.chkActivar.Checked = true)
            {
                cCampana1.btCargar_Click(null, null);
            }
            if (cUsuario1.chkActivar.Checked = true)
            {
                cUsuario1.btCargar_Click(null, null);
            }
            if (cCompania1.chkActivar.Checked = true)
            {
                cCompania1.btCargar_Click(null, null);
            }
            if (cCliente1.chkActivar.Checked = true)
            {
                cCliente1.btCargar_Click(null, null);
            }
            if (cCadenaAlias2.chkActivar.Checked = true)
            {
                cCadenaAlias2.btCargar_Click(null, null);
            }
            if (cCadena1.chkActivar.Checked = true)
            {
                cCadena1.btCargar_Click(null, null);
            }
            if (cTarget1.chkActivar.Checked = true)
            {
                cTarget1.btCargar_Click(null, null);
            }
            if (cPases1.chkActivar.Checked = true)
            {
                cPases1.btCargar_Click(null, null);
            }
            if (cAnunciosEnviados1.chkActivar.Checked = true)
            {
                cAnunciosEnviados1.btCargar_Click(null, null);
            }
            if (cCambiosPendientes1.chkActivar.Checked = true)
            {
                cCambiosPendientes1.btCargar_Click(null, null);
            }
            if (cCargasDiarias1.chkActivar.Checked = true)
            {
                cCargasDiarias1.btCargar_Click(null, null);
            }
        }

        private void tsbDeschekear_Click(object sender, EventArgs e)
        {
            DescheckearControles();
        }

        private void DescheckearControles()
        {
            cCadena1.chkActivar.Checked = false;
            cCampana1.chkActivar.Checked = false;
            cUsuario1.chkActivar.Checked = false;
            cCompania1.chkActivar.Checked = false;
            cCliente1.chkActivar.Checked = false;
            cCadenaAlias2.chkActivar.Checked = false;
            cCadena1.chkActivar.Checked = false;
            cTarget1.chkActivar.Checked = false;
            cPases1.chkActivar.Checked = false;
            cAnunciosEnviados1.chkActivar.Checked = false;
            cCambiosPendientes1.chkActivar.Checked = false;
            cCargasDiarias1.chkActivar.Checked = false;
        }

        private void tabControles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.TabControl)sender).SelectedIndex==2)
            {
                if (gridLeyenda.Rows.Count==1)
                {
                    gridLeyenda.Rows.Add("AR1", "madmdspc411");
                    gridLeyenda.Rows.Add("AR3", "Madssau01101");
                    gridLeyenda.Rows.Add("AR4", "madgrmpc384");
                }
            }
        }

        private void gridLeyenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            int i = e.RowIndex;

            if (grid.Rows[i].Cells.Count > 1)
            {
                if (grid.Rows[i].Cells["TipoAudiencia"].Value != null)
                {
                    if (grid.Rows[i].Cells["TipoAudiencia"].Value.ToString() == "AR1")
                    {
                        grid.Rows[i].Cells["TipoAudiencia"].Style.ForeColor = Color.Green;
                    }
                    else if (grid.Rows[i].Cells["TipoAudiencia"].Value.ToString() == "AR3")
                    {
                        grid.Rows[i].Cells["TipoAudiencia"].Style.ForeColor = Color.Black;
                    }
                    else if (grid.Rows[i].Cells["TipoAudiencia"].Value.ToString() == "AR4")
                    {
                        grid.Rows[i].Cells["TipoAudiencia"].Style.ForeColor = Color.Red;
                    }
                }


                if (grid.Rows[i].Cells["Servidor"].Value != null)
                {
                    if (grid.Rows[i].Cells["Servidor"].Value.ToString() == "madgrmpc384")
                    {
                        grid.Rows[i].Cells["Servidor"].Style.BackColor = Color.LightBlue;
                    }
                    else if (grid.Rows[i].Cells["Servidor"].Value.ToString() == "madmdspc411")
                    {
                        grid.Rows[i].Cells["Servidor"].Style.BackColor = Color.LightGoldenrodYellow;
                    }
                    else if (grid.Rows[i].Cells["Servidor"].Value.ToString() == "Madssau01101")
                    {
                        grid.Rows[i].Cells["Servidor"].Style.BackColor = Color.PaleGreen;
                    }
                }
            }
        }
    }
}
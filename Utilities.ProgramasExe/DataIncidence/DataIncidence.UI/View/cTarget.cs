﻿using System;
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
    public partial class cTarget : UserControl
    {
        public delegate void DatosEvento(DataTable dt, string Control); //si no necesitas parametros dejar vacio los (), sino poner el tipo de dato a pasar
        public event DatosEvento CargarDatosEvento;//poner esto  = delegate { }; si da problemas de nulo en esta misma linea, el probl

        public delegate void IniciarCargaEvento();
        public event IniciarCargaEvento IniciarCarga;

        public delegate void FinCargaEvento();
        public event FinCargaEvento FinCarga;

        private DataTable dtResult;


        public cTarget()
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
            CargarDatos(GetQuery(), "Targets");
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
            txtIdtarget.Text = string.Empty;
            txtCodTargetAdp.Text = string.Empty;
            chkActivo.Checked = false;
            txtCodTargetInfosis.Text = string.Empty;
            txtNameInfosys.Text = string.Empty;
            txtIdtarget.Focus();
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
            else if (dt.Rows.Count == 1)
            {
                txtIdtarget.Text = dt.Rows[0].ItemArray[0].ToString();
                txtCodTargetAdp.Text = dt.Rows[0].ItemArray[1].ToString();
                chkActivo.Checked = bool.Parse(dt.Rows[0].ItemArray[2].ToString());
                txtCodTargetInfosis.Text = dt.Rows[0].ItemArray[3].ToString();
                txtNameInfosys.Text = dt.Rows[0].ItemArray[4].ToString();
            }
            else
            {
                dtResult = dt;
                //EventoCargarDatos(dt, "Compania");

                //gridCampana.DataSource = dt;
                //gridCampana.AutoResizeColumns();
                //gridCampana.Refresh();
                //sContainer.Panel2Collapsed = false;
            }
        }

        private string GetQuery()
        {
            string resultado = string.Empty;
            resultado = "  select tadp.idtarget,tadp.codtarget,tInfo.activo,tInfo.codtarget,tInfo.name "+
                                "  from[dbo].[vi_TvTargets] tadp"+
                                " inner join[vi_InfosysTargets] tInfo on tadp.codfuente = tInfo.name";
            if (!string.IsNullOrEmpty(txtIdtarget.Text) ||
                !string.IsNullOrEmpty(txtCodTargetAdp.Text) ||
                chkActivo.Checked || !chkActivo.Checked ||
                !string.IsNullOrEmpty(txtCodTargetInfosis.Text) ||
                !string.IsNullOrEmpty(txtNameInfosys.Text))
            {
                resultado = resultado + " where ";


                string param = string.Empty;
                int activo = chkActivo.Checked ? 1 : 0;
                param = param.añadirString("tInfo.activo =" + activo , ';');

                if (!string.IsNullOrEmpty(txtIdtarget.Text))
                {
                    param = param.añadirString("tadp.idtarget ='" + txtIdtarget.Text + "'", ';');
                }
                if (!string.IsNullOrEmpty(txtCodTargetAdp.Text))
                {
                    param = param.añadirString("tadp.codtarget like '%" + txtCodTargetAdp.Text + "%'", ';');
                }
                if (!string.IsNullOrEmpty(txtCodTargetInfosis.Text))
                {
                    param = param.añadirString("tInfo.codtarget ='" + txtCodTargetInfosis.Text + "'", ';');
                }
                if (!string.IsNullOrEmpty(txtNameInfosys.Text))
                {
                    param = param.añadirString("tInfo.name like '%" + txtNameInfosys.Text + "%'", ';');
                }


                if (param.Substring(param.Length - 1) == ";")
                {
                    param = param.Substring(0, param.Length - 1).Replace(";", " And ");
                }
                param = param.Replace(";", " And ");
                resultado = resultado + " " + param;
            }


            return resultado;
        }
    }
}

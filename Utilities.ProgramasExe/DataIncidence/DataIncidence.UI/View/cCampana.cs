using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Extensions;
using Utilities.Clases.GestorConexionSQL;
using DataIncidence.UI.BBDD;

namespace DataIncidence.UI.View
{
    public partial class cCampana : UserControl
    {
        public delegate void DatosEvento(DataTable dt, string Control); //si no necesitas parametros dejar vacio los (), sino poner el tipo de dato a pasar
        public event DatosEvento CargarDatosEvento;//poner esto  = delegate { }; si da problemas de nulo en esta misma linea, el probl


        public delegate void IniciarCargaEvento();
        public event IniciarCargaEvento IniciarCarga;

        public delegate void FinCargaEvento();
        public event FinCargaEvento FinCarga;

        private DataTable dtResult;

        public cCampana()
        {
            InitializeComponent();
        }

        private void chkActivado_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (Control item in this.Controls)
            foreach (Control item in this.Controls)
            {
                item.Enabled = item == sender ? true : chkActivar.Checked;
            }
        }

        public string GetQuery()
        {
            string resultado = string.Empty;
            resultado = "select pm.idcampcompra ,pm.idcampanamaestra ,cm.idcampanamedio,pv.idtvcampana,pm.codcampanamaestra " +
                            "from plcampanamaestra pm " +
                            "inner join plcampanamedio cm on pm.idcampanamaestra=cm.idcampanamaestra " +
                            "inner join pltvcampana pv on pv.idcampanamedio=cm.idcampanamedio";
            if (!string.IsNullOrEmpty(txtCampanaCompra.Text) ||
                !string.IsNullOrEmpty(txtCampanaMaestra.Text) ||
                !string.IsNullOrEmpty(txtCampanaMedio.Text) ||
                !string.IsNullOrEmpty(txtCodCampanaMaestra.Text) ||
                !string.IsNullOrEmpty(txtTvCampana.Text))
            {
                resultado = resultado + " where ";

                string param = string.Empty;
                if (!string.IsNullOrEmpty(txtCampanaCompra.Text))
                {
                    param = param.añadirString("pm.idcampcompra ='" + txtCampanaCompra.Text + "'", ';');
                }
                if (!string.IsNullOrEmpty(txtCampanaMaestra.Text))
                {
                    param = param.añadirString("pm.idcampanamaestra =" + txtCampanaMaestra.Text, ';');
                }
                if (!string.IsNullOrEmpty(txtCampanaMedio.Text))
                {
                    param = param.añadirString("cm.idcampanamedio =" + txtCampanaMedio.Text, ';');
                }
                if (!string.IsNullOrEmpty(txtCodCampanaMaestra.Text))
                {
                    param = param.añadirString("pm.codcampanamaestra like '%" + txtCodCampanaMaestra.Text + "%'", ';');
                }
                if (!string.IsNullOrEmpty(txtTvCampana.Text))
                {
                    param = param.añadirString("pv.idtvcampana =" + txtTvCampana.Text, ';');
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

        public void btCargar_Click(object sender, EventArgs e)
        {
            CargarDatos(GetQuery(), "Campañas");
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
                txtCampanaCompra.Text = dt.Rows[0].ItemArray[0].ToString();
                txtCampanaMaestra.Text = dt.Rows[0].ItemArray[1].ToString();
                txtCampanaMedio.Text = dt.Rows[0].ItemArray[2].ToString();
                txtCodCampanaMaestra.Text = dt.Rows[0].ItemArray[4].ToString();
                txtTvCampana.Text = dt.Rows[0].ItemArray[3].ToString();
            }
            else
            {
                dtResult = dt;
                //EventoCargarDatos(dt, "Campañas");

                //gridCampana.DataSource = dt;
                //gridCampana.AutoResizeColumns();
                //gridCampana.Refresh();
                //sContainer.Panel2Collapsed = false;
            }
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
        private void txtCampanaCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarDatos(GetQuery(), "Campañas");
            }
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txtCampanaMaestra.Focus();
            }
        }

        private void txtCampanaMaestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarDatos(GetQuery(), "Campañas");
            }
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txtCampanaMedio.Focus();
            }
        }

        private void txtCampanaMedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarDatos(GetQuery(), "Campañas");
            }
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txtTvCampana.Focus();
            }
        }

        private void txtTvCampana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarDatos(GetQuery(), "Campañas");
            }
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                txtCodCampanaMaestra.Focus();
            }
        }

        private void txtCodCampanaMaestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarDatos(GetQuery(), "Campañas");
            }
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                btCargar.Focus();
            }
        }

        public void btLimpiar_Click(object sender, EventArgs e)
        {
            txtCampanaCompra.Text = string.Empty;
            txtCampanaMaestra.Text = string.Empty;
            txtCampanaMedio.Text = string.Empty;
            txtCodCampanaMaestra.Text = string.Empty;
            txtTvCampana.Text = string.Empty;
            txtTvCampana.Focus();
        }

        public void EventoCargarDatos(DataTable dt, string nombre)
        {
            CargarDatosEvento?.Invoke(dt, nombre);
        }
    }
}

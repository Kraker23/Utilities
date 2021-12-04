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
    public partial class cCargasDiarias : UserControl
    {
        public delegate void DatosEvento(DataTable dt, string Control); //si no necesitas parametros dejar vacio los (), sino poner el tipo de dato a pasar
        public event DatosEvento CargarDatosEvento;//poner esto  = delegate { }; si da problemas de nulo en esta misma linea, el probl

        public delegate void IniciarCargaEvento();
        public event IniciarCargaEvento IniciarCarga;

        public delegate void FinCargaEvento();
        public event FinCargaEvento FinCarga;

        private DataTable dtResult;

        public cCargasDiarias()
        {
            InitializeComponent();
        }

        #region CopiaBase

        int height = 200;
        int width = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            ManageCheckGroupBox(chkActivar, group);
            if (chkActivar.Checked)
            {
                CambiarFechasCarga();
            }
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
            CargarDatos(GetQuery(), "Cargas Diarias");
        }

        private void CargarDatos(string query,string NombreProceso)
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
                FinCarga?.Invoke();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        #endregion

        public void btLimpiar_Click(object sender, EventArgs e)
        {
            txtGrupo.Text = string.Empty;
            chkFechaLanzamiento.Checked = false;
            chkFechasCarga.Checked = true;
            dtDesde.Value = DateTime.Now;
            dtDesdeLanzamiento.Value = DateTime.Now;
            dtHasta.Value = DateTime.Now;
            dtHastaLanzamiento.Value = DateTime.Now;
            nProcesado.Value = -1;
            nPrioridad.Value = -1;
            nTop.Value = 10;
            cbAudiencia.SelectedIndex = 0;
            cbServidor.SelectedIndex = 0;
        }

        private void Cargar(string query)
        {
            dtResult = null;
            GestorConexion gc = new GestorConexion(DatosConexion.GetUrlConexion());
            DataTable dt = gc.Consulta(query);

            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("No se encontraron Resultados para la consulta");
                dt = new DataTable("SinDatos");
                dt.Columns.Add("Informacion");
                dt.Rows.Add("No hay datos");
                dtResult = dt;
            }
            else
            {
                dtResult = dt;
                //EventoCargarDatos(dt, "Cargas Diarias");
            }
        }

        private string GetQuery()
        {
            string resultado = "select";
            if (nTop.Value>0)
            {
                resultado = resultado + " Top " + nTop.Value;
            }
            if (!chkConXML.Checked)
            {
                resultado =  resultado + " p.fecha, SUBSTRING(p.batch, len(p.batch)-24, 17) fechalanzamiento ,SUBSTRING(p.batch, 55, 3) audiencia , p.batch,p.procesado,p.servidor,p.prioridad,p.grupo,p.IdGNDiaProcesado " +
                               "  from[GNFEDiaProcesado] p " ;
            }
            else
            {
                resultado =  resultado + " p.fecha,SUBSTRING(p.batch,  len(p.batch)-24, 17) fechaLanzamiento,SUBSTRING(p.batch, 55, 3) audiencia , p.batch,p.procesado,p.servidor,p.prioridad,p.grupo,p.IdGNDiaProcesado, " +
                                "x.fecha,x.pathdatos,x.pathist,x.nombreist,x.xmloutput " +
                               "  from[GNFEDiaProcesado] p " +
                                " inner join[GNFEXML_Peticiones] x on p.grupo = x.grupo ";
            }
            // where p.grupo = 'F55CF5E3-A173-435D-B01F-AC5DA3316CE5'"

            
            string param = string.Empty;
            if (nProcesado.Value>-1)
            {
                if (chkNulos.Checked)
                {
                    param = param.añadirString("(p.procesado =" + nProcesado.Value + " or p.procesado is null)", ';');
                }
                else
                {
                    param = param.añadirString("p.procesado =" + nProcesado.Value, ';');
                }
                
            }
            
            if (chkFechasCarga.Checked)
            {
                param = param.añadirString("cast(p.fecha as date) between '" + dtDesde.Value.ToShortDateString() + "' and '" + dtHasta.Value.ToShortDateString() + "'", ';');
            }
            if (chkFechaLanzamiento.Checked)
            {
                param = param.añadirString("cast(replace(isnull(SUBSTRING(p.batch, len(p.batch)-24, 10),'20150101'),'-','') as date) between '" + dtDesdeLanzamiento.Value.ToShortDateString() + "' and '" + dtHastaLanzamiento.Value.ToShortDateString() + "'", ';');
            }
            if (nPrioridad.Value > -1)
            {
                param = param.añadirString("p.prioridad =" + nPrioridad.Value, ';');
            }
            if (!string.IsNullOrEmpty(txtGrupo.Text))
            {
                param = param.añadirString("p.Grupo like '%" + txtGrupo.Text + "%'", ';');
            }
            if (cbServidor.SelectedIndex>-1 && !string.IsNullOrEmpty(cbServidor.SelectedItem.ToString()))
            {
                param = param.añadirString("p.servidor like '%" + cbServidor.SelectedItem.ToString() + "%'", ';');
            }
            if (cbAudiencia.SelectedIndex > -1 && !string.IsNullOrEmpty(cbAudiencia.SelectedItem.ToString()))
            {
                param = param.añadirString("SUBSTRING(p.batch, 55, 3) audiencia like '%" + cbAudiencia.SelectedItem.ToString() + "%'", ';');
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

        public void EventoCargarDatos(DataTable dt ,string nombre)
        {
            CargarDatosEvento?.Invoke(dt, nombre);
        }

        private void btDetalles_Click(object sender, EventArgs e)
        {
            //select* from[dbo].[GNFE_ConfigurarRutasBatch] order by 1 desc
            //select* from[dbo].[GNFEServidores]
            //select* from[dbo].[GNFEParametrizacion] order by 1 desc
            #region ConfigurarRutasBatch
                CargarDatos("select* from[dbo].[GNFE_ConfigurarRutasBatch] order by 1 desc", "ConfigurarRutasBatch");
            #endregion
            #region Servidores
                CargarDatos("select* from[dbo].[GNFEServidores]", "Servidores");
            #endregion
            #region Parametrizacio
                CargarDatos("select* from[dbo].[GNFEParametrizacion] order by 1 desc", "Parametrizacio");
            #endregion
        }

        private void chkFechasCarga_CheckedChanged(object sender, EventArgs e)
        {
            dtDesde.Enabled = chkFechasCarga.Checked;
            dtHasta.Enabled = chkFechasCarga.Checked;
        }

        private void chkFechaLanzamiento_CheckedChanged(object sender, EventArgs e)
        {
            dtDesdeLanzamiento.Enabled = chkFechaLanzamiento.Checked;
            dtHastaLanzamiento.Enabled = chkFechaLanzamiento.Checked;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CargarDatos("select servidor,count(*) from [dbo].[GNFEDiaProcesado] where procesado=0 group by servidor order by 1 desc", "ConfigurarRutasBatch");
        }

        private void btArchivosPendientes_Click(object sender, EventArgs e)
        {
            CargarDatos(GetQueryArchivosPendientes(), "Archivos Pendientes");
        }

        private string GetQueryArchivosPendientes()
        {
            string resultado = string.Empty;

            resultado = " SELECT[AudienceDate],  count(*) " +
                           " FROM[SvrAudiencias].[loadv3].[cnf].[FilePaths] where[ProcessStateID] in (1, 2) ";
                           //" FROM[SvrAudiencias].[loadv3].[cnf].[FilePaths] where[ProcessStateID] = 1";
                        //" where[ProcessStateID] = 1 and year([AudienceDate]) = 2019 " +
                        //" group by[AudienceDate] " +
                        //" order by 1 asc";



            string param = string.Empty;

            if (chkFechasCarga.Checked)
            {
                param = param.añadirString("and cast(AudienceDate as date) between '" + dtDesde.Value.ToShortDateString() + "' and '" + dtHasta.Value.ToShortDateString() + "'", ';');
            }
           


            if (!string.IsNullOrEmpty(param))
            {
                if (param.Substring(param.Length - 1) == ";")
                {
                    param = param.Substring(0, param.Length - 1).Replace(";", " And ");
                }
                param = param.Replace(";", " And ");
                resultado = resultado + " " + param;
            }
            
            resultado= resultado + " group by[AudienceDate] order by 1 asc";




            return resultado;
        }

        private void btEstadoCargasDiarias_Click(object sender, EventArgs e)
        {
            if (chkFechasCarga.Checked || chkFechaLanzamiento.Checked)
            {
                string resultado = string.Empty;
                //exec [dbo].[EstadoCargasAudiencias] '20190301','20190310'
                resultado = "exec [dbo].[EstadoCargasAudiencias]";
                //" where[ProcessStateID] = 1 and year([AudienceDate]) = 2019 " +
                //" group by[AudienceDate] " +
                //" order by 1 asc";



                string param = string.Empty;

                if (chkFechasCarga.Checked)
                {
                    param = param.añadirString("'" + dtDesde.Value.ToShortDateString() + "' , '" + dtHasta.Value.ToShortDateString() + "'", ';');
                }
                else if (chkFechaLanzamiento.Checked)
                {
                    param = param.añadirString("'" + dtDesdeLanzamiento.Value.ToShortDateString() + "' , '" + dtHastaLanzamiento.Value.ToShortDateString() + "'", ';');
                }


                if (!string.IsNullOrEmpty(param))
                {
                    if (param.Substring(param.Length - 1) == ";")
                    {
                        param = param.Substring(0, param.Length - 1).Replace(";", " And ");
                    }
                    param = param.Replace(";", " And ");
                    resultado = resultado + " " + param;
                }
                
                

                CargarDatos(resultado, "Estado Cargas Diarias");
            }
            else
            {
                MessageBox.Show("Activar y Seleccionar Fechas de carga");
            }
        }

        private void btCargaServidores_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            resultado =
                    "select max(loaddate)FechaCarga,servername Servidor,max(audiencedate)FechaAudiencia " +
                    
                    " from("+
                    " SELECT cast(loaddate as date)loaddate, servername, audiencedate " +
                    " FROM [SvrAudiencias].[loadv3].[cnf].[vFileTrackingPathDetails] " +
                    " where year(audiencedate) > 2018 "+
                    " )t"+
                    " group by servername "+
                    " order by max(loaddate) ";
            
            CargarDatos(resultado, "Carga Servidores");
        }

        private void btCosasCargadas_Click(object sender, EventArgs e)
        {

            CargarDatos(GetQueryCargasHoy(), "Cargado Hoy");
        }

        private string GetQueryCargasHoy()
        {
            string resultado = string.Empty;

            resultado = "SELECT TOP (1000) [Fecha de Audiencia]"
                        +" ,[Tipo de Audiencia]" 
                        + " ,[Estado]"
                        + " ,[Nº Ficheros]"
                        + " ,[Ultimo Procesado]"
                        + "   FROM SvrAudiencias.[loadv3].[cnf].[vDailyProcessState] " +
                           "";

            return resultado;
        }


        private void CambiarFechasCarga()
        {
            DateTime desde = dtDesde.Value;
            if (desde.DayOfWeek == DayOfWeek.Monday)
            {
                dtDesde.Value = desde.AddDays(-4);
                dtHasta.Value = DateTime.Now.AddDays(-1);
            }
            else
            {
                dtDesde.Value = desde.AddDays(-2);
                dtHasta.Value = DateTime.Now.AddDays(-1);
            }
        }
    }
}
/*
select * from [dbo].[GNFE_ConfigurarRutasBatch] order by 1 desc


select * from [dbo].[GNFEServidores]

select * from [dbo].[GNFEParametrizacion] order by 1 desc



--select batch [Real],SUBSTRING(batch, length(batch)-25, 17) fecha ,SUBSTRING(batch, 55, 3) aud ,SUBSTRING(batch, 77, 10) ,replace(SUBSTRING(batch, 77, 10),'-',''),isnull(SUBSTRING(batch, 77, 10),'20150101')
select batch [Real],SUBSTRING(batch, len(batch)-24, 17) fecha ,SUBSTRING(batch, 55, 3) aud ,SUBSTRING(batch, 77, 10) ,replace(SUBSTRING(batch, 77, 10),'-',''),isnull(SUBSTRING(batch, 77, 10),'20150101'),len(batch)
from [dbo].[GNFEDiaProcesado] 
--where idgndiaprocesado=62917 
where cast(replace(isnull(SUBSTRING(batch, len(batch)-24, 10),'20150101'),'-','') as date)=cast('20190129'as date)
order by 1 desc


\\madgrm-pc306\InfosysPlus\Batch\cargas8\ARA_20171220_20171220_2017-12-20 200117.573.ibt
\\madssau01101\Infosysplus\Batch\Cargas8\AR1_20190129_20190129_2019-01-29 200046.713.ibt

2019-01-29 20 02 09

select top 100 * from [dbo].[GNFEDiaProcesado] order by 1 desc



select top 5 * from [dbo].[GNFEXML_Peticiones] where grupo='F55CF5E3-A173-435D-B01F-AC5DA3316CE5' order by 1 desc

select top 5 p.fecha,SUBSTRING(p.batch, 77, 17) fechaLanzamiento,SUBSTRING(batch, 55, 3) aud , p.batch,p.procesado,p.servidor,p.prioridad,p.grupo,
x.fecha,x.pathdatos,x.pathist,x.nombreist--,x.xmloutput
 from [GNFEDiaProcesado] p
inner join [GNFEXML_Peticiones] x on p.grupo=x.grupo
where p.grupo='F55CF5E3-A173-435D-B01F-AC5DA3316CE5'
 */

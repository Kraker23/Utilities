using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Controls.SqlExecMultiple
{
    public partial class frmSqlExecMultiple : Form
    {
        Dictionary<string, StringBuilder> mensajes;

        public frmSqlExecMultiple()
        {
            InitializeComponent();
            txtSQL.MaxLength = int.MaxValue;

            cargarConexiones();
        }


        private void tsbExecute_Click(object sender, EventArgs e)
        {
            ejecutarTodos(false);
        }


        /// <summary> Carga las conexiones existentes en el fichero de configuración de la aplicación</summary>
        private void cargarConexiones()
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            tree.Nodes.Clear();
            tree.CheckBoxes = true;

            chkConexiones.Items.Clear();

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    if (!string.IsNullOrWhiteSpace(cs.Name) && !string.IsNullOrWhiteSpace(cs.ConnectionString)) {
                        if (cs.Name.Split(';').Count()==2)
                        {
                            var splitn = cs.Name.Split(';');
                            var padre = tree.Nodes[splitn[0]];
                            if (padre == null) { padre = tree.Nodes.Add(splitn[0], splitn[0]); }
                            padre.Nodes.Add(cs.Name, splitn[1]);

                            chkConexiones.Items.Add(splitn[1], true);
                        }
                        else
                        {
                            tree.Nodes.Add(cs.Name, cs.Name);
                            chkConexiones.Items.Add(cs.Name, true);
                        }
                    }
                }

            }

        }


        private void ejecutarTodos(bool nonquery)
        {
            tabResult.TabPages.Clear();
            mensajes = new Dictionary<string, StringBuilder>();
            
            /*
            foreach (string connName in chkConexiones.CheckedItems)
            {
                ejecutarSQL(connName, nonquery);
            }*/

            foreach (TreeNode n in tree.Nodes)
            {
                if (n.Nodes.Count == 0 && n.Checked)
                {
                    ejecutarSQL(n.Name, nonquery);
                }
                else
                {
                    foreach (TreeNode n2 in n.Nodes)
                    {
                        if (n2.Checked)
                        {
                            ejecutarSQL(n2.Name, nonquery);
                        }
                    }
                }
            }

        }


        /// <summary>  </summary>
        /// <param name="connName"></param>
        private void ejecutarSQL(string connName, bool nonquery)
        {
            DataTable dt = null;
            string connMsgs = string.Empty;

            Task tSql = new Task(() =>
                {
                    string comando = txtSQL.Text;

                    using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[connName].ConnectionString))
                    {
                        conn.InfoMessage += conn_InfoMessage;
                        
                        conn.Open();

                        SqlCommand comand = new SqlCommand(comando, conn);
                        comand.CommandTimeout = 0;


                        if (nonquery)
                        {
                            StringBuilder sbErr = new StringBuilder();

                            var scripts = Regex.Split(comando, @"(\s+|;|\n|\r)(GO|go|Go)", RegexOptions.Multiline);
                            foreach (var splitScript in scripts)
                            {
                                if (!string.IsNullOrWhiteSpace(splitScript) && !Regex.Match(splitScript, @"((\s+|;|\n|\r)(GO|go|Go))|(^(GO|go|Go)$)").Success)
                                {
                                    try
                                    {
                                        comand.CommandText = splitScript;
                                        comand.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        sbErr.Append(ex.Message);
                                    }
                                }
                            }

                            if (sbErr != null && !string.IsNullOrEmpty(sbErr.ToString()))
                            {
                                throw new Exception(sbErr.ToString());
                            }
                        }
                        else
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter(comando, conn))
                            {
                                dt = new DataTable();
                                da.Fill(dt);
                            }
                        }
                        conn.Close();
                        conn.Dispose();
                    }
                });

            tSql.ContinueWith((t) =>
                {
                    try
                    {
                        TabPage tab;

                        if (tabResult.TabPages.ContainsKey(connName))
                        {
                            tab = tabResult.TabPages[connName];
                        }
                        else
                        {
                            tab = new TabPage(connName);
                            tab.Text = connName;
                            tabResult.TabPages.Add(tab);
                        }


                        if (t.Exception != null)
                        {
                            TextBox txt = new TextBox();
                            txt.Dock = DockStyle.Fill;
                            txt.Multiline = true;
                            txt.MaxLength = int.MaxValue;
                            txt.ScrollBars = ScrollBars.Both;

                            txt.Text = t.Exception.ToString();

                            tab.Controls.Add(txt);
                        }
                        else if (dt.Rows.Count > 0)
                        {

                            

                            List<string> remCol = new List<string>();
                            foreach (DataColumn c in dt.Columns)
                            {
                                if (c.DataType.Name == "Byte[]") { remCol.Add(c.ColumnName); }
                            }
                            remCol.ForEach(c => dt.Columns.Remove(c));
                            remCol.Clear();
                            remCol = null;

                            DataGridView g = new DataGridView();
                            g.Dock = DockStyle.Fill;
                            g.DataSource = dt;
                            g.AllowUserToAddRows = false;
                            g.AllowUserToDeleteRows = false;
                            g.AllowUserToResizeColumns = true;

                            if (mensajes.ContainsKey(ConfigurationManager.ConnectionStrings[connName].ConnectionString))
                            {
                                TabControl tabC = new TabControl();
                                tabC.Dock = DockStyle.Fill;
                                tabC.TabPages.Add("Data");
                                tabC.TabPages.Add("Msj");

                                tabC.TabPages[0].Controls.Add(g);

                                TextBox txt = new TextBox();
                                txt.Dock = DockStyle.Fill;
                                txt.Multiline = true;
                                txt.MaxLength = int.MaxValue;
                                txt.ScrollBars = ScrollBars.Both;

                                if (mensajes.ContainsKey(ConfigurationManager.ConnectionStrings[connName].ConnectionString))
                                {
                                    txt.Text = mensajes[ConfigurationManager.ConnectionStrings[connName].ConnectionString].ToString();
                                }

                                tabC.TabPages[1].Controls.Add(txt);
                            }
                            else
                            {
                                tab.Controls.Add(g);
                            }
                        }
                        else
                        {
                            TextBox txt = new TextBox();
                            txt.Dock = DockStyle.Fill;
                            txt.Multiline = true;
                            txt.MaxLength = int.MaxValue;
                            txt.ScrollBars = ScrollBars.Both;

                            if(mensajes.ContainsKey(ConfigurationManager.ConnectionStrings[connName].ConnectionString))
                            {
                                txt.Text = mensajes[ConfigurationManager.ConnectionStrings[connName].ConnectionString].ToString();
                            }

                            tab.Controls.Add(txt);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());

            tSql.Start();
        }

        void conn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            if (sender is SqlConnection)
            {
                SqlConnection con = sender as SqlConnection;
                StringBuilder sb;
                if (mensajes.ContainsKey(con.ConnectionString))
                {
                    sb = mensajes[con.ConnectionString];
                }
                else
                {
                    sb = new StringBuilder();
                    mensajes.Add(con.ConnectionString, sb);
                }

                if (sb == null) { sb = new StringBuilder(); }

                sb.AppendLine(e.Message);
                sb.AppendLine();

                
                mensajes[con.ConnectionString] = sb;
            }
        }

        private void tsbCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkConexiones.Items.Count; i++)
            {
                chkConexiones.SetItemChecked(i, true);
            }
        }

        private void tsbUnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkConexiones.Items.Count; i++)
            {
                chkConexiones.SetItemChecked(i, false);
            }
        }

        private void tsbEjecucionNonQ_Click(object sender, EventArgs e)
        {
            ejecutarTodos(true);
        }

        private void frmSqlExecMultiple_Load(object sender, EventArgs e)
        {

        }

        private void tree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if(e.Action == TreeViewAction.ByKeyboard || e.Action == TreeViewAction.ByMouse)
            {
                foreach (TreeNode n in e.Node.Nodes)
                {
                    n.Checked = e.Node.Checked;
                }
            }
        }

        private void tsbCheck_Click(object sender, EventArgs e)
        {

        }

    }
}

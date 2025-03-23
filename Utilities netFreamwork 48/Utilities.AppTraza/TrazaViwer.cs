using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Utilities.AppTraza
{

    internal partial class TrazaViwer : Form
    {
        GestorTraza gestor;
        private delegate void AddNode(TreeNodeCollection tnc, TreeNode node);
        private delegate void UpdateNode(TreeNode node, Traza t, string text);


        #region · Constructores
        
            private TrazaViwer()
            {
                InitializeComponent();
            }


            internal TrazaViwer(GestorTraza gestorTrazas)
                : this()
            {
                gestor = gestorTrazas;

                if (gestor.Apariencias.ViewerImgList != null)
                {
                    tree.ImageList = gestor.Apariencias.ViewerImgList;
                }

                RefreshActiveState();
            }
        
        #endregion


        #region Eventos
        
            private void TrazaViwer_Load(object sender, EventArgs e)
            {
                RefreshData();
            }


            private void tsbPlay_Click(object sender, EventArgs e)
            {
                gestor.Activar();
            }


            private void tsbStop_Click(object sender, EventArgs e)
            {
                gestor.Desactivar();
            }


            private void tsbDelete_Click(object sender, EventArgs e)
            {
                gestor.LimpiarTraza();
                RefreshData();
            }


            private void tsbExport_Click(object sender, EventArgs e)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML file|*.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("<root>");

                    gestor.Trazas.Where(t => t.trazaPadre == null).ToList().ForEach(t =>
                        {
                            sb.AppendLine(t.ToXML());
                        });

                    sb.AppendLine("</root>");

                    System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                }
            }


            private void tsbExportCSV_Click(object sender, EventArgs e)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV file|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Id\tPadre\tTipo\tMensaje\tFecha Ini\tFecha Fin");

                    gestor.Trazas.ForEach(t =>
                        {
                            sb.AppendLine(t.ToCSV());
                        });

                    System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                }
            }

        #endregion


        #region Funciones

            private void AddNodeFunc(TreeNodeCollection tnc, TreeNode node)
            {
                tnc.Add(node);
            }


            private void UpdateNodeFunc(TreeNode node, Traza t, string text)
            {
                node.Tag = t;
                node.Text = text;
            }


            internal void RefreshData()
            {
                tree.Nodes.Clear();

                gestor.Trazas.ForEach(x =>
                    {
                        if (x.trazaPadre == null)
                        {
                            createNode(x, tree.Nodes);
                        }
                    });
            }


            internal void RefreshTraza(Traza traza)
            {
                TreeNode[] nc = tree.Nodes.Find(traza.idTraza.ToString(), true);

                if (nc.Length > 0)
                {
                    tree.Invoke(new UpdateNode(UpdateNodeFunc), new object[] { nc[0], traza, traza.ToString() });
                    //nc[0].Tag = traza;
                    //nc[0].Text = traza.ToString();
                }
                else
                {
                    if (traza.trazaPadre == null)
                    {
                        createNode(traza, tree.Nodes);
                    }
                    else
                    {
                        TreeNode[] ncp = tree.Nodes.Find(traza.trazaPadre.idTraza.ToString(), true);

                        if (ncp.Length > 0)
                        {
                            createNode(traza, ncp[0].Nodes);
                        }
                        else
                        {
                            createNode(traza, tree.Nodes);
                        }
                    }
                }
            }


            internal void createNode(Traza t, TreeNodeCollection tnc)
            {
                TreeNode nodo;

                nodo = new TreeNode(t.ToString());

                nodo.Tag = t;
                nodo.Name = t.idTraza.ToString();
                nodo.ImageIndex = t.tipo.GetHashCode();
                nodo.StateImageIndex = t.tipo.GetHashCode();
                nodo.SelectedImageIndex = t.tipo.GetHashCode();
                
                setAparienciaNodo(nodo,t);

                tree.Invoke(new AddNode(AddNodeFunc), new object[] { tnc, nodo });
                //tnc.Invoke(new AddNode(nodo),);
                //tnc.Add(nodo);

                t.subTrazas.ForEach(x => createNode(x, nodo.Nodes));
            }


            internal void RefreshActiveState()
            {
                tsbPlay.Enabled = !gestor.Activo;
                tsbStop.Enabled = gestor.Activo;
            }


            internal void setAparienciaNodo(TreeNode n, Traza t)
            {
                switch (t.tipo)
                {
                    case TipoTraza.App: 
                        setAparienciaNodo(n,gestor.Apariencias.ViewerTrazaAplicacion);
                        break;

                    case TipoTraza.Funcion: 
                        setAparienciaNodo(n,gestor.Apariencias.ViewerTrazaFuncion);
                        break;

                   case TipoTraza.Linea: 
                        setAparienciaNodo(n,gestor.Apariencias.ViewerTrazaLinea);
                        break;

                   case TipoTraza.SQL: 
                        setAparienciaNodo(n,gestor.Apariencias.ViewerTrazaSql);
                        break;

                   case TipoTraza.WebService: 
                        setAparienciaNodo(n,gestor.Apariencias.ViewerTrazaWebService);
                        break;

                   case TipoTraza.Mensaje: 
                        setAparienciaNodo(n,gestor.Apariencias.ViewerTrazaMensaje);
                        break;

                   case TipoTraza.Error: 
                        setAparienciaNodo(n,gestor.Apariencias.ViewerTrazaError);
                        break;
                }
            }


            internal void setAparienciaNodo(TreeNode n, TrazaApariencia tapp)
            {
                if (tapp.BackColor != Color.Empty)  { n.BackColor = tapp.BackColor; }
                if (tapp.ForeColor != Color.Empty)  { n.ForeColor = tapp.ForeColor; }
               
                if (tapp.ImageIndex.HasValue) 
                { 
                    n.ImageIndex = tapp.ImageIndex.Value;
                    n.StateImageIndex = tapp.ImageIndex.Value;
                    n.SelectedImageIndex = tapp.ImageIndex.Value; 
                }
            }

        #endregion

    }
}


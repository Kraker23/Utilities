using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities.Controls.HerramientaTextos
{
    public partial class frmTextReplace : Form
    {

        List<cReemplazarTexto> reemplazos = new List<cReemplazarTexto>();

        public frmTextReplace()
        {
            InitializeComponent();
            txtTexto.MaxLength = int.MaxValue;

            reemplazos.Add(cReemplazarTexto);
        }

        private void frmTextReplace_Load(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var c = new cReemplazarTexto();
            c.Dock = DockStyle.Top;
            reemplazos.Add(c);
            pReemplazos.Controls.Add(c);
            c.BringToFront();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (reemplazos.Count > 1)
            {
                var c = reemplazos.Last();

                pReemplazos.Controls.Remove(c);
                reemplazos.Remove(c);
                c.Dispose();
            }
        }



        private void btnEliminarFilasBlancas_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var l in txtTexto.Lines)
            {
                if (!string.IsNullOrWhiteSpace(l))
                {
                    sb.AppendLine(l);
                }
            }

            txtTexto.Text = sb.ToString();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var l in txtTexto.Lines)
            {
                sb.AppendLine(l.Trim());
            }

            txtTexto.Text = sb.ToString();
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            reemplazos.ForEach(r => 
                txtTexto.Text = r.ReemplazarTextos(txtTexto.Text)
                );
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            string text = txtTexto.Text;
            txtTexto.Text = string.Empty;

            reemplazos.ForEach(r =>
                txtTexto.Text += r.ReemplazarTextos(text)
                );

        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.Control)
            {
                if (e.KeyData == Keys.A) { txtTexto.SelectAll(); }
            }*/
        }

        private void btpPasteReplace_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string txt = Clipboard.GetText();
                bool first = true;
                if (reemplazos.Count > 1) { first = false; }

                foreach (string l in txt.Split('\n'))
                {
                    if (first)
                    {
                        first = false;
                        reemplazos[0].Reemplazar = l.Replace("\r", string.Empty);
                    }
                    else
                    {
                        btnAdd_Click(null,null);
                        var r = reemplazos.Last();
                        r.Buscar = reemplazos[0].Buscar;
                        r.Reemplazar = l.Replace("\r", string.Empty);
                    }
                }
            }
        }

        private void txtTexto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.V)
                {
                    if (Clipboard.ContainsFileDropList())
                    {
                        var files = Clipboard.GetFileDropList();
                        foreach (var f in files)
                        {
                            txtTexto.Text += f + Environment.NewLine;
                        }
                    }
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbDataService_Click(object sender, EventArgs e)
        {
            string str = txtTexto.Text;
            
            string resultado = string.Empty;
            string propName = string.Empty;
            string preProp = string.Empty;
            int indxPos = str.IndexOf("public ", 0);
            int aux, aux2;

            while (indxPos >= 0)
            {
                indxPos = str.IndexOf(" ", indxPos); //global::System.Nullable
                indxPos++;
                aux = str.IndexOf(" ", indxPos);
                preProp = str.Substring(indxPos, aux - indxPos);
                if (preProp != "partial" && preProp != "static" && preProp != "void" && 
                    (
                        preProp.StartsWith("global::System.Nullable") ||
                        preProp.StartsWith("global::System.DateTime") ||
                        !preProp.StartsWith("global::System.Data.Services.Client.DataServiceQuery")
                    ))
                {
                    indxPos = aux+1;

                    aux = str.IndexOf(Environment.NewLine, indxPos);

                    propName = str.Substring(indxPos, aux - indxPos);

                    if (propName.IndexOf(" ") == -1)
                    {
                        indxPos = str.IndexOf("set", indxPos);
                        indxPos = str.IndexOf("{", indxPos);
                        indxPos++;
                        str = str.Insert(indxPos, "if (_" + propName + " != value) {");
                        indxPos = str.IndexOf("}", indxPos);
                        indxPos++;
                        str = str.Insert(indxPos, "}");
                    }
                }

                indxPos = str.IndexOf("public ", indxPos);
            }

            txtTexto.Text = str;
        }

    }
}

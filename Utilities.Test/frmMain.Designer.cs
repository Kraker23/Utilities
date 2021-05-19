
namespace Utilities.Test
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCorreo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditarImagen = new System.Windows.Forms.ToolStripButton();
            this.tsbEjecucionSql = new System.Windows.Forms.ToolStripButton();
            this.tsbTraza = new System.Windows.Forms.ToolStripButton();
            this.tsbAyuda = new System.Windows.Forms.ToolStripButton();
            this.tsbTCP = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbTcpCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbTcpServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbHerramientasTextos = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbEncriptadorString = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSeparadorTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRegularExpresion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbEncriptarTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRemplazarTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCorreo,
            this.tsbEditarImagen,
            this.tsbEjecucionSql,
            this.tsbTraza,
            this.tsbAyuda,
            this.tsbTCP,
            this.tsbHerramientasTextos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCorreo
            // 
            this.tsbCorreo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCorreo.Image = ((System.Drawing.Image)(resources.GetObject("tsbCorreo.Image")));
            this.tsbCorreo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCorreo.Name = "tsbCorreo";
            this.tsbCorreo.Size = new System.Drawing.Size(47, 22);
            this.tsbCorreo.Text = "Correo";
            this.tsbCorreo.ToolTipText = "Enviar Un Correo";
            this.tsbCorreo.Click += new System.EventHandler(this.tsbCorreo_Click);
            // 
            // tsbEditarImagen
            // 
            this.tsbEditarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEditarImagen.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditarImagen.Image")));
            this.tsbEditarImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarImagen.Name = "tsbEditarImagen";
            this.tsbEditarImagen.Size = new System.Drawing.Size(84, 22);
            this.tsbEditarImagen.Text = "Editar Imagen";
            this.tsbEditarImagen.ToolTipText = "Editar Imagen";
            this.tsbEditarImagen.Click += new System.EventHandler(this.tsbEditarImagen_Click);
            // 
            // tsbEjecucionSql
            // 
            this.tsbEjecucionSql.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEjecucionSql.Image = ((System.Drawing.Image)(resources.GetObject("tsbEjecucionSql.Image")));
            this.tsbEjecucionSql.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEjecucionSql.Name = "tsbEjecucionSql";
            this.tsbEjecucionSql.Size = new System.Drawing.Size(81, 22);
            this.tsbEjecucionSql.Text = "Ejecucion Sql";
            this.tsbEjecucionSql.ToolTipText = "Ejemplo";
            this.tsbEjecucionSql.Click += new System.EventHandler(this.tsbEjecucionSql_Click);
            // 
            // tsbTraza
            // 
            this.tsbTraza.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTraza.Image = ((System.Drawing.Image)(resources.GetObject("tsbTraza.Image")));
            this.tsbTraza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTraza.Name = "tsbTraza";
            this.tsbTraza.Size = new System.Drawing.Size(37, 22);
            this.tsbTraza.Text = "Traza";
            this.tsbTraza.ToolTipText = "Traza";
            this.tsbTraza.Click += new System.EventHandler(this.tsbTraza_Click);
            // 
            // tsbAyuda
            // 
            this.tsbAyuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAyuda.Image = ((System.Drawing.Image)(resources.GetObject("tsbAyuda.Image")));
            this.tsbAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAyuda.Name = "tsbAyuda";
            this.tsbAyuda.Size = new System.Drawing.Size(23, 22);
            this.tsbAyuda.Text = "Ayuda";
            this.tsbAyuda.Click += new System.EventHandler(this.tsbAyuda_Click);
            // 
            // tsbTCP
            // 
            this.tsbTCP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTCP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTcpCliente,
            this.tsbTcpServer});
            this.tsbTCP.Image = ((System.Drawing.Image)(resources.GetObject("tsbTCP.Image")));
            this.tsbTCP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTCP.Name = "tsbTCP";
            this.tsbTCP.Size = new System.Drawing.Size(40, 22);
            this.tsbTCP.Text = "TCP";
            // 
            // tsbTcpCliente
            // 
            this.tsbTcpCliente.Name = "tsbTcpCliente";
            this.tsbTcpCliente.Size = new System.Drawing.Size(180, 22);
            this.tsbTcpCliente.Text = "TCP Cliente";
            this.tsbTcpCliente.Click += new System.EventHandler(this.tsbTcpCliente_Click);
            // 
            // tsbTcpServer
            // 
            this.tsbTcpServer.Name = "tsbTcpServer";
            this.tsbTcpServer.Size = new System.Drawing.Size(180, 22);
            this.tsbTcpServer.Text = "TCP Server";
            this.tsbTcpServer.Click += new System.EventHandler(this.tsbTcpServer_Click);
            // 
            // tsbHerramientasTextos
            // 
            this.tsbHerramientasTextos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbHerramientasTextos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEncriptadorString,
            this.tsbSeparadorTexto,
            this.tsbRegularExpresion,
            this.tsbEncriptarTexto,
            this.tsbRemplazarTexto});
            this.tsbHerramientasTextos.Image = ((System.Drawing.Image)(resources.GetObject("tsbHerramientasTextos.Image")));
            this.tsbHerramientasTextos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHerramientasTextos.Name = "tsbHerramientasTextos";
            this.tsbHerramientasTextos.Size = new System.Drawing.Size(127, 22);
            this.tsbHerramientasTextos.Text = "Herramientas Textos";
            // 
            // tsbEncriptadorString
            // 
            this.tsbEncriptadorString.Name = "tsbEncriptadorString";
            this.tsbEncriptadorString.Size = new System.Drawing.Size(180, 22);
            this.tsbEncriptadorString.Text = "Encriptador String";
            this.tsbEncriptadorString.Click += new System.EventHandler(this.tsbEncriptadorString_Click);
            // 
            // tsbSeparadorTexto
            // 
            this.tsbSeparadorTexto.Name = "tsbSeparadorTexto";
            this.tsbSeparadorTexto.Size = new System.Drawing.Size(180, 22);
            this.tsbSeparadorTexto.Text = "Separador Texto";
            this.tsbSeparadorTexto.Click += new System.EventHandler(this.tsbSeparadorTexto_Click);
            // 
            // tsbRegularExpresion
            // 
            this.tsbRegularExpresion.Name = "tsbRegularExpresion";
            this.tsbRegularExpresion.Size = new System.Drawing.Size(180, 22);
            this.tsbRegularExpresion.Text = "Regular Expresion";
            this.tsbRegularExpresion.Click += new System.EventHandler(this.tsbRegularExpresion_Click);
            // 
            // tsbEncriptarTexto
            // 
            this.tsbEncriptarTexto.Name = "tsbEncriptarTexto";
            this.tsbEncriptarTexto.Size = new System.Drawing.Size(180, 22);
            this.tsbEncriptarTexto.Text = "Encriptar Texto";
            this.tsbEncriptarTexto.Click += new System.EventHandler(this.tsbEncriptarTexto_Click);
            // 
            // tsbRemplazarTexto
            // 
            this.tsbRemplazarTexto.Name = "tsbRemplazarTexto";
            this.tsbRemplazarTexto.Size = new System.Drawing.Size(180, 22);
            this.tsbRemplazarTexto.Text = "Remplazar Texto";
            this.tsbRemplazarTexto.Click += new System.EventHandler(this.tsbRemplazarTexto_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Utilidades";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbTraza;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton tsbCorreo;
        private System.Windows.Forms.ToolStripButton tsbEditarImagen;
        private System.Windows.Forms.ToolStripButton tsbAyuda;
        private System.Windows.Forms.ToolStripDropDownButton tsbHerramientasTextos;
        private System.Windows.Forms.ToolStripMenuItem tsbEncriptadorString;
        private System.Windows.Forms.ToolStripMenuItem tsbSeparadorTexto;
        private System.Windows.Forms.ToolStripMenuItem tsbRegularExpresion;
        private System.Windows.Forms.ToolStripMenuItem tsbEncriptarTexto;
        private System.Windows.Forms.ToolStripMenuItem tsbRemplazarTexto;
        private System.Windows.Forms.ToolStripButton tsbEjecucionSql;
        private System.Windows.Forms.ToolStripDropDownButton tsbTCP;
        private System.Windows.Forms.ToolStripMenuItem tsbTcpCliente;
        private System.Windows.Forms.ToolStripMenuItem tsbTcpServer;
    }
}
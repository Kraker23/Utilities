namespace Utilities.AppTraza
{
    partial class TrazaViwer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrazaViwer));
            this.tree = new System.Windows.Forms.TreeView();
            this.imglTree = new System.Windows.Forms.ImageList(this.components);
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbExportCSV = new System.Windows.Forms.ToolStripButton();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.ImageIndex = 0;
            this.tree.ImageList = this.imglTree;
            this.tree.Location = new System.Drawing.Point(0, 25);
            this.tree.Name = "tree";
            this.tree.SelectedImageIndex = 0;
            this.tree.Size = new System.Drawing.Size(591, 395);
            this.tree.TabIndex = 0;
            // 
            // imglTree
            // 
            this.imglTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglTree.ImageStream")));
            this.imglTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imglTree.Images.SetKeyName(0, "window.png");
            this.imglTree.Images.SetKeyName(1, "text_code.png");
            this.imglTree.Images.SetKeyName(2, "document_into.png");
            this.imglTree.Images.SetKeyName(3, "data.png");
            this.imglTree.Images.SetKeyName(4, "earth.png");
            this.imglTree.Images.SetKeyName(5, "about.png");
            this.imglTree.Images.SetKeyName(6, "delete.png");
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPlay,
            this.tsbStop,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbExport,
            this.tsbExportCSV});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(591, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = global::Utilities.AppTraza.Properties.Resources.media_play_green;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(23, 22);
            this.tsbPlay.Text = "Registrar log";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = global::Utilities.AppTraza.Properties.Resources.media_stop_red;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(23, 22);
            this.tsbStop.Text = "Parar registro de log";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::Utilities.AppTraza.Properties.Resources.delete2;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Limpiar log";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Image = global::Utilities.AppTraza.Properties.Resources.document_into;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(23, 22);
            this.tsbExport.Text = "Exportar a xml";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // tsbExportCSV
            // 
            this.tsbExportCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportCSV.Image = global::Utilities.AppTraza.Properties.Resources.window_sidebar;
            this.tsbExportCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportCSV.Name = "tsbExportCSV";
            this.tsbExportCSV.Size = new System.Drawing.Size(23, 22);
            this.tsbExportCSV.Text = "Exportar a CSV";
            this.tsbExportCSV.Click += new System.EventHandler(this.tsbExportCSV_Click);
            // 
            // TrazaViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 420);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.tsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrazaViwer";
            this.Text = "Traza Viewer";
            this.Load += new System.EventHandler(this.TrazaViwer_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ImageList imglTree;
        private System.Windows.Forms.ToolStripButton tsbExportCSV;


    }
}
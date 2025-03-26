namespace UtilitiesNet.Controls.SqlExecMultiple
{
    partial class frmSqlExecMultiple
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCheckAll = new System.Windows.Forms.ToolStripButton();
            this.tsbUnCheckAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExecute = new System.Windows.Forms.ToolStripButton();
            this.tsbCheck = new System.Windows.Forms.ToolStripButton();
            this.tsbEjecucionNonQ = new System.Windows.Forms.ToolStripButton();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.tree = new System.Windows.Forms.TreeView();
            this.chkConexiones = new System.Windows.Forms.CheckedListBox();
            this.spcExec = new System.Windows.Forms.SplitContainer();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.tabResult = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcExec)).BeginInit();
            this.spcExec.Panel1.SuspendLayout();
            this.spcExec.Panel2.SuspendLayout();
            this.spcExec.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCheckAll,
            this.tsbUnCheckAll,
            this.toolStripSeparator1,
            this.tsbExecute,
            this.tsbCheck,
            this.tsbEjecucionNonQ});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCheckAll
            // 
            this.tsbCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCheckAll.Image = global::UtilitiesNet.Controls.Properties.Resources.checks;
            this.tsbCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckAll.Name = "tsbCheckAll";
            this.tsbCheckAll.Size = new System.Drawing.Size(23, 22);
            this.tsbCheckAll.Text = "toolStripButton1";
            this.tsbCheckAll.Click += new System.EventHandler(this.tsbCheckAll_Click);
            // 
            // tsbUnCheckAll
            // 
            this.tsbUnCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnCheckAll.Image = global::UtilitiesNet.Controls.Properties.Resources.delete2;
            this.tsbUnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnCheckAll.Name = "tsbUnCheckAll";
            this.tsbUnCheckAll.Size = new System.Drawing.Size(23, 22);
            this.tsbUnCheckAll.Text = "toolStripButton2";
            this.tsbUnCheckAll.Click += new System.EventHandler(this.tsbUnCheckAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExecute
            // 
            this.tsbExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExecute.Image = global::UtilitiesNet.Controls.Properties.Resources.scroll_run;
            this.tsbExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExecute.Name = "tsbExecute";
            this.tsbExecute.Size = new System.Drawing.Size(23, 22);
            this.tsbExecute.Text = "Ejecución";
            this.tsbExecute.Click += new System.EventHandler(this.tsbExecute_Click);
            // 
            // tsbCheck
            // 
            this.tsbCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCheck.Image = global::UtilitiesNet.Controls.Properties.Resources.scroll_ok;
            this.tsbCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheck.Name = "tsbCheck";
            this.tsbCheck.Size = new System.Drawing.Size(23, 22);
            this.tsbCheck.Text = "Checkear script";
            this.tsbCheck.Visible = false;
            this.tsbCheck.Click += new System.EventHandler(this.tsbCheck_Click);
            // 
            // tsbEjecucionNonQ
            // 
            this.tsbEjecucionNonQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEjecucionNonQ.Image = global::UtilitiesNet.Controls.Properties.Resources.scroll;
            this.tsbEjecucionNonQ.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEjecucionNonQ.Name = "tsbEjecucionNonQ";
            this.tsbEjecucionNonQ.Size = new System.Drawing.Size(23, 22);
            this.tsbEjecucionNonQ.Text = "Ejecutar NonQuery";
            this.tsbEjecucionNonQ.Click += new System.EventHandler(this.tsbEjecucionNonQ_Click);
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 25);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.tree);
            this.spcMain.Panel1.Controls.Add(this.chkConexiones);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcExec);
            this.spcMain.Size = new System.Drawing.Size(669, 333);
            this.spcMain.SplitterDistance = 168;
            this.spcMain.TabIndex = 1;
            // 
            // tree
            // 
            this.tree.CheckBoxes = true;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(168, 333);
            this.tree.TabIndex = 3;
            this.tree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterCheck);
            // 
            // chkConexiones
            // 
            this.chkConexiones.CheckOnClick = true;
            this.chkConexiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkConexiones.FormattingEnabled = true;
            this.chkConexiones.Location = new System.Drawing.Point(0, 0);
            this.chkConexiones.Name = "chkConexiones";
            this.chkConexiones.Size = new System.Drawing.Size(168, 333);
            this.chkConexiones.TabIndex = 1;
            // 
            // spcExec
            // 
            this.spcExec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcExec.Location = new System.Drawing.Point(0, 0);
            this.spcExec.Name = "spcExec";
            this.spcExec.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcExec.Panel1
            // 
            this.spcExec.Panel1.Controls.Add(this.txtSQL);
            // 
            // spcExec.Panel2
            // 
            this.spcExec.Panel2.Controls.Add(this.tabResult);
            this.spcExec.Size = new System.Drawing.Size(497, 333);
            this.spcExec.SplitterDistance = 193;
            this.spcExec.TabIndex = 0;
            // 
            // txtSQL
            // 
            this.txtSQL.AcceptsReturn = true;
            this.txtSQL.AcceptsTab = true;
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Location = new System.Drawing.Point(0, 0);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQL.Size = new System.Drawing.Size(497, 193);
            this.txtSQL.TabIndex = 0;
            // 
            // tabResult
            // 
            this.tabResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabResult.Location = new System.Drawing.Point(0, 0);
            this.tabResult.Name = "tabResult";
            this.tabResult.SelectedIndex = 0;
            this.tabResult.Size = new System.Drawing.Size(497, 136);
            this.tabResult.TabIndex = 0;
            // 
            // frmSqlExecMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 358);
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSqlExecMultiple";
            this.Text = "Sql Ejecución Múltiple";
            this.Load += new System.EventHandler(this.frmSqlExecMultiple_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcExec.Panel1.ResumeLayout(false);
            this.spcExec.Panel1.PerformLayout();
            this.spcExec.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcExec)).EndInit();
            this.spcExec.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExecute;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.CheckedListBox chkConexiones;
        private System.Windows.Forms.SplitContainer spcExec;
        private System.Windows.Forms.TabControl tabResult;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.ToolStripButton tsbCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCheckAll;
        private System.Windows.Forms.ToolStripButton tsbUnCheckAll;
        private System.Windows.Forms.ToolStripButton tsbEjecucionNonQ;
        private System.Windows.Forms.TreeView tree;
    }
}
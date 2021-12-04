namespace DataIncidence.UI.View
{
    partial class cCompania
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.group = new System.Windows.Forms.GroupBox();
            this.txtbkCompania = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompania = new System.Windows.Forms.Label();
            this.txtidCompania = new System.Windows.Forms.TextBox();
            this.txtCompania = new System.Windows.Forms.TextBox();
            this.lblCodCompania = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCodCompania = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCargar = new System.Windows.Forms.Button();
            this.chkActivar = new System.Windows.Forms.CheckBox();
            this.btExpan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.group);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 82);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged_1);
            // 
            // group
            // 
            this.group.Controls.Add(this.txtbkCompania);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.lblCompania);
            this.group.Controls.Add(this.txtidCompania);
            this.group.Controls.Add(this.txtCompania);
            this.group.Controls.Add(this.lblCodCompania);
            this.group.Controls.Add(this.lblID);
            this.group.Controls.Add(this.txtCodCompania);
            this.group.Controls.Add(this.btLimpiar);
            this.group.Controls.Add(this.btCargar);
            this.group.Controls.Add(this.chkActivar);
            this.group.Controls.Add(this.btExpan);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.MinimumSize = new System.Drawing.Size(447, 83);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(447, 83);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            // 
            // txtbkCompania
            // 
            this.txtbkCompania.Location = new System.Drawing.Point(279, 43);
            this.txtbkCompania.Name = "txtbkCompania";
            this.txtbkCompania.Size = new System.Drawing.Size(66, 20);
            this.txtbkCompania.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "bkCompañia";
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Location = new System.Drawing.Point(134, 27);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(54, 13);
            this.lblCompania.TabIndex = 20;
            this.lblCompania.Text = "Compañia";
            // 
            // txtidCompania
            // 
            this.txtidCompania.Location = new System.Drawing.Point(6, 44);
            this.txtidCompania.Name = "txtidCompania";
            this.txtidCompania.Size = new System.Drawing.Size(34, 20);
            this.txtidCompania.TabIndex = 15;
            // 
            // txtCompania
            // 
            this.txtCompania.Location = new System.Drawing.Point(137, 43);
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.Size = new System.Drawing.Size(136, 20);
            this.txtCompania.TabIndex = 19;
            // 
            // lblCodCompania
            // 
            this.lblCodCompania.AutoSize = true;
            this.lblCodCompania.Location = new System.Drawing.Point(43, 27);
            this.lblCodCompania.Name = "lblCodCompania";
            this.lblCodCompania.Size = new System.Drawing.Size(73, 13);
            this.lblCodCompania.TabIndex = 24;
            this.lblCodCompania.Text = "CodCompañia";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "Id";
            // 
            // txtCodCompania
            // 
            this.txtCodCompania.Location = new System.Drawing.Point(46, 43);
            this.txtCodCompania.Name = "txtCodCompania";
            this.txtCodCompania.Size = new System.Drawing.Size(85, 20);
            this.txtCodCompania.TabIndex = 23;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Location = new System.Drawing.Point(354, 43);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(87, 33);
            this.btLimpiar.TabIndex = 14;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btCargar
            // 
            this.btCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCargar.Location = new System.Drawing.Point(354, 7);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(87, 33);
            this.btCargar.TabIndex = 13;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // chkActivar
            // 
            this.chkActivar.AutoSize = true;
            this.chkActivar.Checked = true;
            this.chkActivar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivar.Location = new System.Drawing.Point(33, 7);
            this.chkActivar.Name = "chkActivar";
            this.chkActivar.Size = new System.Drawing.Size(109, 17);
            this.chkActivar.TabIndex = 1;
            this.chkActivar.Tag = "chkActivar";
            this.chkActivar.Text = "Activar Compañia";
            this.chkActivar.UseVisualStyleBackColor = true;
            this.chkActivar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btExpan
            // 
            this.btExpan.Location = new System.Drawing.Point(3, 3);
            this.btExpan.Name = "btExpan";
            this.btExpan.Size = new System.Drawing.Size(24, 22);
            this.btExpan.TabIndex = 0;
            this.btExpan.Tag = "btExpandable";
            this.btExpan.Text = "-";
            this.btExpan.UseVisualStyleBackColor = true;
            this.btExpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // cCompania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "cCompania";
            this.Size = new System.Drawing.Size(446, 82);
            this.Load += new System.EventHandler(this.cBase_Load);
            this.panel1.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox group;
        public System.Windows.Forms.CheckBox chkActivar;
        private System.Windows.Forms.Button btExpan;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Label lblCompania;
        private System.Windows.Forms.TextBox txtidCompania;
        private System.Windows.Forms.TextBox txtCompania;
        private System.Windows.Forms.Label lblCodCompania;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCodCompania;
        private System.Windows.Forms.TextBox txtbkCompania;
        private System.Windows.Forms.Label label1;
    }
}

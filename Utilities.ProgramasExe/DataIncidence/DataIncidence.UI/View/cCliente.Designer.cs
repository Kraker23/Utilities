namespace DataIncidence.UI.View
{
    partial class cCliente
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
            this.lblCompania = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCompania = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(602, 78);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged_1);
            // 
            // group
            // 
            this.group.Controls.Add(this.lblCompania);
            this.group.Controls.Add(this.txtCliente);
            this.group.Controls.Add(this.txtCompania);
            this.group.Controls.Add(this.lblCodCliente);
            this.group.Controls.Add(this.lbCliente);
            this.group.Controls.Add(this.txtCodCliente);
            this.group.Controls.Add(this.btLimpiar);
            this.group.Controls.Add(this.btCargar);
            this.group.Controls.Add(this.chkActivar);
            this.group.Controls.Add(this.btExpan);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(602, 78);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Location = new System.Drawing.Point(156, 28);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(63, 13);
            this.lblCompania.TabIndex = 20;
            this.lblCompania.Text = "fkCompania";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(33, 44);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 15;
            // 
            // txtCompania
            // 
            this.txtCompania.Location = new System.Drawing.Point(159, 44);
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.Size = new System.Drawing.Size(100, 20);
            this.txtCompania.TabIndex = 19;
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(273, 28);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(58, 13);
            this.lblCodCliente.TabIndex = 24;
            this.lblCodCliente.Text = "CodCliente";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(30, 28);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(39, 13);
            this.lbCliente.TabIndex = 16;
            this.lbCliente.Text = "Cliente";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(276, 44);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(226, 20);
            this.txtCodCliente.TabIndex = 23;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Location = new System.Drawing.Point(509, 43);
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
            this.btCargar.Location = new System.Drawing.Point(509, 7);
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
            this.chkActivar.Size = new System.Drawing.Size(94, 17);
            this.chkActivar.TabIndex = 1;
            this.chkActivar.Tag = "chkActivar";
            this.chkActivar.Text = "Activar Cliente";
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
            // cCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(602, 78);
            this.Name = "cCliente";
            this.Size = new System.Drawing.Size(602, 78);
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
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCompania;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
    }
}

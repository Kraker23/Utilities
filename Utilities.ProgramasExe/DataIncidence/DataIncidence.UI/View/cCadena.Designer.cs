namespace DataIncidence.UI.View
{
    partial class cCadena
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
            this.txtIdSoporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCampanaMaestra = new System.Windows.Forms.Label();
            this.txtIdCadena = new System.Windows.Forms.TextBox();
            this.txtCodCadena = new System.Windows.Forms.TextBox();
            this.lbCampanaCompra = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(476, 78);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged_1);
            // 
            // group
            // 
            this.group.Controls.Add(this.txtIdSoporte);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.lblCampanaMaestra);
            this.group.Controls.Add(this.txtIdCadena);
            this.group.Controls.Add(this.txtCodCadena);
            this.group.Controls.Add(this.lbCampanaCompra);
            this.group.Controls.Add(this.btLimpiar);
            this.group.Controls.Add(this.btCargar);
            this.group.Controls.Add(this.chkActivar);
            this.group.Controls.Add(this.btExpan);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(476, 78);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            // 
            // txtIdSoporte
            // 
            this.txtIdSoporte.Location = new System.Drawing.Point(268, 46);
            this.txtIdSoporte.Name = "txtIdSoporte";
            this.txtIdSoporte.Size = new System.Drawing.Size(100, 20);
            this.txtIdSoporte.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "idSoporte";
            // 
            // lblCampanaMaestra
            // 
            this.lblCampanaMaestra.AutoSize = true;
            this.lblCampanaMaestra.Location = new System.Drawing.Point(142, 30);
            this.lblCampanaMaestra.Name = "lblCampanaMaestra";
            this.lblCampanaMaestra.Size = new System.Drawing.Size(63, 13);
            this.lblCampanaMaestra.TabIndex = 28;
            this.lblCampanaMaestra.Text = "CodCadena";
            // 
            // txtIdCadena
            // 
            this.txtIdCadena.Location = new System.Drawing.Point(19, 46);
            this.txtIdCadena.Name = "txtIdCadena";
            this.txtIdCadena.Size = new System.Drawing.Size(100, 20);
            this.txtIdCadena.TabIndex = 23;
            // 
            // txtCodCadena
            // 
            this.txtCodCadena.Location = new System.Drawing.Point(145, 46);
            this.txtCodCadena.Name = "txtCodCadena";
            this.txtCodCadena.Size = new System.Drawing.Size(100, 20);
            this.txtCodCadena.TabIndex = 27;
            // 
            // lbCampanaCompra
            // 
            this.lbCampanaCompra.AutoSize = true;
            this.lbCampanaCompra.Location = new System.Drawing.Point(16, 30);
            this.lbCampanaCompra.Name = "lbCampanaCompra";
            this.lbCampanaCompra.Size = new System.Drawing.Size(52, 13);
            this.lbCampanaCompra.TabIndex = 24;
            this.lbCampanaCompra.Text = "idCadena";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Location = new System.Drawing.Point(383, 39);
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
            this.btCargar.Location = new System.Drawing.Point(383, 3);
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
            this.chkActivar.Size = new System.Drawing.Size(99, 17);
            this.chkActivar.TabIndex = 1;
            this.chkActivar.Tag = "chkActivar";
            this.chkActivar.Text = "Activar Cadena";
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
            // cCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(476, 78);
            this.Name = "cCadena";
            this.Size = new System.Drawing.Size(476, 78);
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
        private System.Windows.Forms.TextBox txtIdSoporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCampanaMaestra;
        private System.Windows.Forms.TextBox txtIdCadena;
        private System.Windows.Forms.TextBox txtCodCadena;
        private System.Windows.Forms.Label lbCampanaCompra;
    }
}

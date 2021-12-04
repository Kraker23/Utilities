namespace DataIncidence.UI.View
{
    partial class cUsuario
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
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCargar = new System.Windows.Forms.Button();
            this.chkActivar = new System.Windows.Forms.CheckBox();
            this.btExpan = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblCampanaMaestra = new System.Windows.Forms.Label();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.txtCodUser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lbCampanaCompra = new System.Windows.Forms.Label();
            this.lblCampanaMedio = new System.Windows.Forms.Label();
            this.lblTVCampana = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(585, 75);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged_1);
            // 
            // group
            // 
            this.group.Controls.Add(this.txtusername);
            this.group.Controls.Add(this.lblCampanaMaestra);
            this.group.Controls.Add(this.txtIdUser);
            this.group.Controls.Add(this.txtCodUser);
            this.group.Controls.Add(this.txtpassword);
            this.group.Controls.Add(this.lbCampanaCompra);
            this.group.Controls.Add(this.lblCampanaMedio);
            this.group.Controls.Add(this.lblTVCampana);
            this.group.Controls.Add(this.btLimpiar);
            this.group.Controls.Add(this.btCargar);
            this.group.Controls.Add(this.chkActivar);
            this.group.Controls.Add(this.btExpan);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(585, 75);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Location = new System.Drawing.Point(492, 39);
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
            this.btCargar.Location = new System.Drawing.Point(492, 3);
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
            this.chkActivar.Size = new System.Drawing.Size(59, 17);
            this.chkActivar.TabIndex = 1;
            this.chkActivar.Tag = "chkActivar";
            this.chkActivar.Text = "Activar";
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
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(268, 46);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 17;
            // 
            // lblCampanaMaestra
            // 
            this.lblCampanaMaestra.AutoSize = true;
            this.lblCampanaMaestra.Location = new System.Drawing.Point(139, 30);
            this.lblCampanaMaestra.Name = "lblCampanaMaestra";
            this.lblCampanaMaestra.Size = new System.Drawing.Size(62, 13);
            this.lblCampanaMaestra.TabIndex = 20;
            this.lblCampanaMaestra.Text = "CodUsuario";
            // 
            // txtIdUser
            // 
            this.txtIdUser.Location = new System.Drawing.Point(16, 46);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(100, 20);
            this.txtIdUser.TabIndex = 15;
            // 
            // txtCodUser
            // 
            this.txtCodUser.Location = new System.Drawing.Point(142, 46);
            this.txtCodUser.Name = "txtCodUser";
            this.txtCodUser.Size = new System.Drawing.Size(100, 20);
            this.txtCodUser.TabIndex = 19;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(385, 46);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 21;
            // 
            // lbCampanaCompra
            // 
            this.lbCampanaCompra.AutoSize = true;
            this.lbCampanaCompra.Location = new System.Drawing.Point(13, 30);
            this.lbCampanaCompra.Name = "lbCampanaCompra";
            this.lbCampanaCompra.Size = new System.Drawing.Size(37, 13);
            this.lbCampanaCompra.TabIndex = 16;
            this.lbCampanaCompra.Text = "idUser";
            // 
            // lblCampanaMedio
            // 
            this.lblCampanaMedio.AutoSize = true;
            this.lblCampanaMedio.Location = new System.Drawing.Point(265, 30);
            this.lblCampanaMedio.Name = "lblCampanaMedio";
            this.lblCampanaMedio.Size = new System.Drawing.Size(44, 13);
            this.lblCampanaMedio.TabIndex = 18;
            this.lblCampanaMedio.Text = "Nombre";
            // 
            // lblTVCampana
            // 
            this.lblTVCampana.AutoSize = true;
            this.lblTVCampana.Location = new System.Drawing.Point(382, 30);
            this.lblTVCampana.Name = "lblTVCampana";
            this.lblTVCampana.Size = new System.Drawing.Size(53, 13);
            this.lblTVCampana.TabIndex = 22;
            this.lblTVCampana.Text = "Password";
            // 
            // cUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(585, 75);
            this.Name = "cUsuario";
            this.Size = new System.Drawing.Size(585, 75);
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
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblCampanaMaestra;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.TextBox txtCodUser;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lbCampanaCompra;
        private System.Windows.Forms.Label lblCampanaMedio;
        private System.Windows.Forms.Label lblTVCampana;
    }
}

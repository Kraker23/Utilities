namespace DataIncidence.UI.View
{
    partial class cCampana
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
            this.txtCampanaCompra = new System.Windows.Forms.TextBox();
            this.lbCampanaCompra = new System.Windows.Forms.Label();
            this.chkActivar = new System.Windows.Forms.CheckBox();
            this.lblCampanaMedio = new System.Windows.Forms.Label();
            this.txtCampanaMedio = new System.Windows.Forms.TextBox();
            this.lblCampanaMaestra = new System.Windows.Forms.Label();
            this.txtCampanaMaestra = new System.Windows.Forms.TextBox();
            this.lblTVCampana = new System.Windows.Forms.Label();
            this.txtTvCampana = new System.Windows.Forms.TextBox();
            this.txtCodCampanaMaestra = new System.Windows.Forms.TextBox();
            this.lblCodCampanaMaestra = new System.Windows.Forms.Label();
            this.btCargar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCampanaCompra
            // 
            this.txtCampanaCompra.Location = new System.Drawing.Point(28, 39);
            this.txtCampanaCompra.Name = "txtCampanaCompra";
            this.txtCampanaCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCampanaCompra.TabIndex = 0;
            this.txtCampanaCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCampanaCompra_KeyPress);
            // 
            // lbCampanaCompra
            // 
            this.lbCampanaCompra.AutoSize = true;
            this.lbCampanaCompra.Location = new System.Drawing.Point(25, 23);
            this.lbCampanaCompra.Name = "lbCampanaCompra";
            this.lbCampanaCompra.Size = new System.Drawing.Size(120, 13);
            this.lbCampanaCompra.TabIndex = 1;
            this.lbCampanaCompra.Text = "Campana Compra(MBS)";
            // 
            // chkActivado
            // 
            this.chkActivar.AutoSize = true;
            this.chkActivar.Checked = true;
            this.chkActivar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivar.Location = new System.Drawing.Point(9, 3);
            this.chkActivar.Name = "chkActivado";
            this.chkActivar.Size = new System.Drawing.Size(104, 17);
            this.chkActivar.TabIndex = 2;
            this.chkActivar.Text = "Activo Campana";
            this.chkActivar.UseVisualStyleBackColor = true;
            this.chkActivar.CheckedChanged += new System.EventHandler(this.chkActivado_CheckedChanged);
            // 
            // lblCampanaMedio
            // 
            this.lblCampanaMedio.AutoSize = true;
            this.lblCampanaMedio.Location = new System.Drawing.Point(277, 23);
            this.lblCampanaMedio.Name = "lblCampanaMedio";
            this.lblCampanaMedio.Size = new System.Drawing.Size(84, 13);
            this.lblCampanaMedio.TabIndex = 4;
            this.lblCampanaMedio.Text = "Campana Medio";
            // 
            // txtCampanaMedio
            // 
            this.txtCampanaMedio.Location = new System.Drawing.Point(280, 39);
            this.txtCampanaMedio.Name = "txtCampanaMedio";
            this.txtCampanaMedio.Size = new System.Drawing.Size(100, 20);
            this.txtCampanaMedio.TabIndex = 3;
            this.txtCampanaMedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCampanaMedio_KeyPress);
            // 
            // lblCampanaMaestra
            // 
            this.lblCampanaMaestra.AutoSize = true;
            this.lblCampanaMaestra.Location = new System.Drawing.Point(151, 23);
            this.lblCampanaMaestra.Name = "lblCampanaMaestra";
            this.lblCampanaMaestra.Size = new System.Drawing.Size(93, 13);
            this.lblCampanaMaestra.TabIndex = 6;
            this.lblCampanaMaestra.Text = "Campana Maestra";
            // 
            // txtCampanaMaestra
            // 
            this.txtCampanaMaestra.Location = new System.Drawing.Point(154, 39);
            this.txtCampanaMaestra.Name = "txtCampanaMaestra";
            this.txtCampanaMaestra.Size = new System.Drawing.Size(100, 20);
            this.txtCampanaMaestra.TabIndex = 5;
            this.txtCampanaMaestra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCampanaMaestra_KeyPress);
            // 
            // lblTVCampana
            // 
            this.lblTVCampana.AutoSize = true;
            this.lblTVCampana.Location = new System.Drawing.Point(394, 23);
            this.lblTVCampana.Name = "lblTVCampana";
            this.lblTVCampana.Size = new System.Drawing.Size(66, 13);
            this.lblTVCampana.TabIndex = 8;
            this.lblTVCampana.Text = "TVCampana";
            // 
            // txtTvCampana
            // 
            this.txtTvCampana.Location = new System.Drawing.Point(397, 39);
            this.txtTvCampana.Name = "txtTvCampana";
            this.txtTvCampana.Size = new System.Drawing.Size(100, 20);
            this.txtTvCampana.TabIndex = 7;
            this.txtTvCampana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTvCampana_KeyPress);
            // 
            // txtCodCampanaMaestra
            // 
            this.txtCodCampanaMaestra.Location = new System.Drawing.Point(510, 39);
            this.txtCodCampanaMaestra.Name = "txtCodCampanaMaestra";
            this.txtCodCampanaMaestra.Size = new System.Drawing.Size(226, 20);
            this.txtCodCampanaMaestra.TabIndex = 9;
            this.txtCodCampanaMaestra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCampanaMaestra_KeyPress);
            // 
            // lblCodCampanaMaestra
            // 
            this.lblCodCampanaMaestra.AutoSize = true;
            this.lblCodCampanaMaestra.Location = new System.Drawing.Point(507, 23);
            this.lblCodCampanaMaestra.Name = "lblCodCampanaMaestra";
            this.lblCodCampanaMaestra.Size = new System.Drawing.Size(109, 13);
            this.lblCodCampanaMaestra.TabIndex = 10;
            this.lblCodCampanaMaestra.Text = "CodCampanaMaestra";
            // 
            // btCargar
            // 
            this.btCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCargar.Location = new System.Drawing.Point(748, 3);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(87, 33);
            this.btCargar.TabIndex = 11;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Location = new System.Drawing.Point(748, 39);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(87, 33);
            this.btLimpiar.TabIndex = 12;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // cCampana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCampanaMedio);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.chkActivar);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.lblCampanaMaestra);
            this.Controls.Add(this.txtCampanaCompra);
            this.Controls.Add(this.txtCampanaMaestra);
            this.Controls.Add(this.lblCodCampanaMaestra);
            this.Controls.Add(this.txtTvCampana);
            this.Controls.Add(this.lbCampanaCompra);
            this.Controls.Add(this.lblCampanaMedio);
            this.Controls.Add(this.txtCodCampanaMaestra);
            this.Controls.Add(this.lblTVCampana);
            this.MinimumSize = new System.Drawing.Size(841, 84);
            this.Name = "cCampana";
            this.Size = new System.Drawing.Size(841, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCampanaCompra;
        private System.Windows.Forms.Label lbCampanaCompra;
        public System.Windows.Forms.CheckBox chkActivar;
        private System.Windows.Forms.Label lblCampanaMedio;
        private System.Windows.Forms.TextBox txtCampanaMedio;
        private System.Windows.Forms.Label lblCampanaMaestra;
        private System.Windows.Forms.TextBox txtCampanaMaestra;
        private System.Windows.Forms.Label lblTVCampana;
        private System.Windows.Forms.TextBox txtTvCampana;
        private System.Windows.Forms.TextBox txtCodCampanaMaestra;
        private System.Windows.Forms.Label lblCodCampanaMaestra;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btLimpiar;
    }
}

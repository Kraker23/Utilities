namespace DataIncidence.UI.View
{
    partial class cTarget
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
            this.txtIdtarget = new System.Windows.Forms.TextBox();
            this.lbCampanaCompra = new System.Windows.Forms.Label();
            this.txtCodTargetInfosis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblCodCampanaMaestra = new System.Windows.Forms.Label();
            this.txtCodTargetAdp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameInfosys = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(816, 79);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged_1);
            // 
            // group
            // 
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.txtNameInfosys);
            this.group.Controls.Add(this.lblCodCampanaMaestra);
            this.group.Controls.Add(this.txtCodTargetAdp);
            this.group.Controls.Add(this.chkActivo);
            this.group.Controls.Add(this.txtCodTargetInfosis);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.txtIdtarget);
            this.group.Controls.Add(this.lbCampanaCompra);
            this.group.Controls.Add(this.btLimpiar);
            this.group.Controls.Add(this.btCargar);
            this.group.Controls.Add(this.chkActivar);
            this.group.Controls.Add(this.btExpan);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(816, 79);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Location = new System.Drawing.Point(723, 39);
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
            this.btCargar.Location = new System.Drawing.Point(723, 3);
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
            this.chkActivar.Size = new System.Drawing.Size(98, 17);
            this.chkActivar.TabIndex = 1;
            this.chkActivar.Tag = "chkActivar";
            this.chkActivar.Text = "Activar Targets";
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
            // txtIdtarget
            // 
            this.txtIdtarget.Location = new System.Drawing.Point(6, 52);
            this.txtIdtarget.Name = "txtIdtarget";
            this.txtIdtarget.Size = new System.Drawing.Size(49, 20);
            this.txtIdtarget.TabIndex = 25;
            // 
            // lbCampanaCompra
            // 
            this.lbCampanaCompra.AutoSize = true;
            this.lbCampanaCompra.Location = new System.Drawing.Point(3, 36);
            this.lbCampanaCompra.Name = "lbCampanaCompra";
            this.lbCampanaCompra.Size = new System.Drawing.Size(46, 13);
            this.lbCampanaCompra.TabIndex = 26;
            this.lbCampanaCompra.Text = "idTarget";
            // 
            // txtCodTargetInfosis
            // 
            this.txtCodTargetInfosis.Location = new System.Drawing.Point(394, 52);
            this.txtCodTargetInfosis.Name = "txtCodTargetInfosis";
            this.txtCodTargetInfosis.Size = new System.Drawing.Size(84, 20);
            this.txtCodTargetInfosis.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "CodTargetInfosis";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(332, 55);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 29;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblCodCampanaMaestra
            // 
            this.lblCodCampanaMaestra.AutoSize = true;
            this.lblCodCampanaMaestra.Location = new System.Drawing.Point(66, 36);
            this.lblCodCampanaMaestra.Name = "lblCodCampanaMaestra";
            this.lblCodCampanaMaestra.Size = new System.Drawing.Size(76, 13);
            this.lblCodCampanaMaestra.TabIndex = 31;
            this.lblCodCampanaMaestra.Text = "CodTargetAdp";
            // 
            // txtCodTargetAdp
            // 
            this.txtCodTargetAdp.Location = new System.Drawing.Point(69, 52);
            this.txtCodTargetAdp.Name = "txtCodTargetAdp";
            this.txtCodTargetAdp.Size = new System.Drawing.Size(256, 20);
            this.txtCodTargetAdp.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Name Infosys";
            // 
            // txtNameInfosys
            // 
            this.txtNameInfosys.Location = new System.Drawing.Point(484, 52);
            this.txtNameInfosys.Name = "txtNameInfosys";
            this.txtNameInfosys.Size = new System.Drawing.Size(226, 20);
            this.txtNameInfosys.TabIndex = 32;
            // 
            // cTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(816, 79);
            this.Name = "cTarget";
            this.Size = new System.Drawing.Size(816, 79);
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
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtCodTargetInfosis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdtarget;
        private System.Windows.Forms.Label lbCampanaCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameInfosys;
        private System.Windows.Forms.Label lblCodCampanaMaestra;
        private System.Windows.Forms.TextBox txtCodTargetAdp;
    }
}

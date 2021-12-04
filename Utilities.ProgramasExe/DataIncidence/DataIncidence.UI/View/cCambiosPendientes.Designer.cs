namespace DataIncidence.UI.View
{
    partial class cCambiosPendientes
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
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCodCampanaMaestra = new System.Windows.Forms.Label();
            this.txtIdpase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCampMaestra = new System.Windows.Forms.TextBox();
            this.nAbono = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nProcesado = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAbono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nProcesado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.group);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 81);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged_1);
            // 
            // group
            // 
            this.group.Controls.Add(this.nProcesado);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.nAbono);
            this.group.Controls.Add(this.label11);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.txtIdCampMaestra);
            this.group.Controls.Add(this.chkFechas);
            this.group.Controls.Add(this.dtFecha);
            this.group.Controls.Add(this.lblCodCampanaMaestra);
            this.group.Controls.Add(this.txtIdpase);
            this.group.Controls.Add(this.btLimpiar);
            this.group.Controls.Add(this.btCargar);
            this.group.Controls.Add(this.chkActivar);
            this.group.Controls.Add(this.btExpan);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(667, 81);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Location = new System.Drawing.Point(574, 39);
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
            this.btCargar.Location = new System.Drawing.Point(574, 3);
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
            this.chkActivar.Size = new System.Drawing.Size(158, 17);
            this.chkActivar.TabIndex = 1;
            this.chkActivar.Tag = "chkActivar";
            this.chkActivar.Text = "Activar Cambios Pendientes";
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
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Location = new System.Drawing.Point(214, 32);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(98, 17);
            this.chkFechas.TabIndex = 55;
            this.chkFechas.Text = "Utilizar Fechas ";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(213, 52);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(99, 20);
            this.dtFecha.TabIndex = 53;
            // 
            // lblCodCampanaMaestra
            // 
            this.lblCodCampanaMaestra.AutoSize = true;
            this.lblCodCampanaMaestra.Location = new System.Drawing.Point(15, 36);
            this.lblCodCampanaMaestra.Name = "lblCodCampanaMaestra";
            this.lblCodCampanaMaestra.Size = new System.Drawing.Size(56, 13);
            this.lblCodCampanaMaestra.TabIndex = 52;
            this.lblCodCampanaMaestra.Text = "Idpltvpase";
            // 
            // txtIdpase
            // 
            this.txtIdpase.Location = new System.Drawing.Point(18, 52);
            this.txtIdpase.Name = "txtIdpase";
            this.txtIdpase.Size = new System.Drawing.Size(88, 20);
            this.txtIdpase.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "IdCampanaMaestra";
            // 
            // txtIdCampMaestra
            // 
            this.txtIdCampMaestra.Location = new System.Drawing.Point(112, 52);
            this.txtIdCampMaestra.Name = "txtIdCampMaestra";
            this.txtIdCampMaestra.Size = new System.Drawing.Size(96, 20);
            this.txtIdCampMaestra.TabIndex = 56;
            // 
            // nAbono
            // 
            this.nAbono.Location = new System.Drawing.Point(318, 52);
            this.nAbono.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAbono.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nAbono.Name = "nAbono";
            this.nAbono.Size = new System.Drawing.Size(108, 20);
            this.nAbono.TabIndex = 59;
            this.nAbono.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "AbonoCargo";
            // 
            // nProcesado
            // 
            this.nProcesado.Location = new System.Drawing.Point(432, 52);
            this.nProcesado.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nProcesado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nProcesado.Name = "nProcesado";
            this.nProcesado.Size = new System.Drawing.Size(108, 20);
            this.nProcesado.TabIndex = 61;
            this.nProcesado.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Procesado";
            // 
            // cCambiosPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "cCambiosPendientes";
            this.Size = new System.Drawing.Size(667, 81);
            this.Load += new System.EventHandler(this.cBase_Load);
            this.panel1.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAbono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nProcesado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox group;
        public System.Windows.Forms.CheckBox chkActivar;
        private System.Windows.Forms.Button btExpan;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCampMaestra;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label lblCodCampanaMaestra;
        private System.Windows.Forms.TextBox txtIdpase;
        private System.Windows.Forms.NumericUpDown nProcesado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nAbono;
        private System.Windows.Forms.Label label11;
    }
}

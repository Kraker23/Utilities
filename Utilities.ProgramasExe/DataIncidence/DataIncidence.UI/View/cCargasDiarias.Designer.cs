namespace DataIncidence.UI.View
{
    partial class cCargasDiarias
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
            this.btCargaServidores = new System.Windows.Forms.Button();
            this.chkNulos = new System.Windows.Forms.CheckBox();
            this.btEstadoCargasDiarias = new System.Windows.Forms.Button();
            this.btArchivosPendientes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAudiencia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbServidor = new System.Windows.Forms.ComboBox();
            this.lblCodCampanaMaestra = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.nPrioridad = new System.Windows.Forms.NumericUpDown();
            this.nProcesado = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.chkFechaLanzamiento = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtHastaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.dtDesdeLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.chkFechasCarga = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.chkConXML = new System.Windows.Forms.CheckBox();
            this.nTop = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btDetalles = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCargar = new System.Windows.Forms.Button();
            this.chkActivar = new System.Windows.Forms.CheckBox();
            this.btExpan = new System.Windows.Forms.Button();
            this.btCosasCargadas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPrioridad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nProcesado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.group);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 118);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged_1);
            // 
            // group
            // 
            this.group.Controls.Add(this.btCosasCargadas);
            this.group.Controls.Add(this.btCargaServidores);
            this.group.Controls.Add(this.chkNulos);
            this.group.Controls.Add(this.btEstadoCargasDiarias);
            this.group.Controls.Add(this.btArchivosPendientes);
            this.group.Controls.Add(this.label6);
            this.group.Controls.Add(this.button1);
            this.group.Controls.Add(this.label7);
            this.group.Controls.Add(this.cbAudiencia);
            this.group.Controls.Add(this.label10);
            this.group.Controls.Add(this.cbServidor);
            this.group.Controls.Add(this.lblCodCampanaMaestra);
            this.group.Controls.Add(this.txtGrupo);
            this.group.Controls.Add(this.nPrioridad);
            this.group.Controls.Add(this.nProcesado);
            this.group.Controls.Add(this.label11);
            this.group.Controls.Add(this.chkFechaLanzamiento);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.dtHastaLanzamiento);
            this.group.Controls.Add(this.dtDesdeLanzamiento);
            this.group.Controls.Add(this.chkFechasCarga);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.dtHasta);
            this.group.Controls.Add(this.dtDesde);
            this.group.Controls.Add(this.chkConXML);
            this.group.Controls.Add(this.nTop);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.btDetalles);
            this.group.Controls.Add(this.btLimpiar);
            this.group.Controls.Add(this.btCargar);
            this.group.Controls.Add(this.chkActivar);
            this.group.Controls.Add(this.btExpan);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(1007, 118);
            this.group.TabIndex = 0;
            this.group.TabStop = false;
            // 
            // btCargaServidores
            // 
            this.btCargaServidores.Location = new System.Drawing.Point(348, 7);
            this.btCargaServidores.Name = "btCargaServidores";
            this.btCargaServidores.Size = new System.Drawing.Size(99, 23);
            this.btCargaServidores.TabIndex = 81;
            this.btCargaServidores.Text = "Carga Servidores";
            this.btCargaServidores.UseVisualStyleBackColor = true;
            this.btCargaServidores.Click += new System.EventHandler(this.btCargaServidores_Click);
            // 
            // chkNulos
            // 
            this.chkNulos.AutoSize = true;
            this.chkNulos.Checked = true;
            this.chkNulos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNulos.Location = new System.Drawing.Point(431, 57);
            this.chkNulos.Name = "chkNulos";
            this.chkNulos.Size = new System.Drawing.Size(53, 17);
            this.chkNulos.TabIndex = 80;
            this.chkNulos.Text = "Nulos";
            this.chkNulos.UseVisualStyleBackColor = true;
            // 
            // btEstadoCargasDiarias
            // 
            this.btEstadoCargasDiarias.Location = new System.Drawing.Point(214, 7);
            this.btEstadoCargasDiarias.Name = "btEstadoCargasDiarias";
            this.btEstadoCargasDiarias.Size = new System.Drawing.Size(128, 23);
            this.btEstadoCargasDiarias.TabIndex = 79;
            this.btEstadoCargasDiarias.Text = "EstadoCargasDiarias";
            this.btEstadoCargasDiarias.UseVisualStyleBackColor = true;
            this.btEstadoCargasDiarias.Click += new System.EventHandler(this.btEstadoCargasDiarias_Click);
            // 
            // btArchivosPendientes
            // 
            this.btArchivosPendientes.Location = new System.Drawing.Point(607, 7);
            this.btArchivosPendientes.Name = "btArchivosPendientes";
            this.btArchivosPendientes.Size = new System.Drawing.Size(150, 23);
            this.btArchivosPendientes.TabIndex = 78;
            this.btArchivosPendientes.Text = "Ver Archivos Pendientes ";
            this.btArchivosPendientes.UseVisualStyleBackColor = true;
            this.btArchivosPendientes.Click += new System.EventHandler(this.btArchivosPendientes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Prioridad";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(914, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 77;
            this.button1.Text = "Cargar grupo Servidores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(629, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Audiencia";
            // 
            // cbAudiencia
            // 
            this.cbAudiencia.FormattingEnabled = true;
            this.cbAudiencia.Items.AddRange(new object[] {
            "",
            "AR1",
            "AR2",
            "AR3",
            "AR4"});
            this.cbAudiencia.Location = new System.Drawing.Point(630, 88);
            this.cbAudiencia.Name = "cbAudiencia";
            this.cbAudiencia.Size = new System.Drawing.Size(127, 21);
            this.cbAudiencia.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(497, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Servidor";
            // 
            // cbServidor
            // 
            this.cbServidor.FormattingEnabled = true;
            this.cbServidor.Items.AddRange(new object[] {
            "",
            "Madgrm-pc306",
            "Madgrm-pc331",
            "Madssau01101",
            "madgrmpc384",
            "madmdspc411"});
            this.cbServidor.Location = new System.Drawing.Point(497, 54);
            this.cbServidor.Name = "cbServidor";
            this.cbServidor.Size = new System.Drawing.Size(127, 21);
            this.cbServidor.TabIndex = 73;
            // 
            // lblCodCampanaMaestra
            // 
            this.lblCodCampanaMaestra.AutoSize = true;
            this.lblCodCampanaMaestra.Location = new System.Drawing.Point(367, 77);
            this.lblCodCampanaMaestra.Name = "lblCodCampanaMaestra";
            this.lblCodCampanaMaestra.Size = new System.Drawing.Size(36, 13);
            this.lblCodCampanaMaestra.TabIndex = 49;
            this.lblCodCampanaMaestra.Text = "Grupo";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(370, 90);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(254, 20);
            this.txtGrupo.TabIndex = 48;
            // 
            // nPrioridad
            // 
            this.nPrioridad.Location = new System.Drawing.Point(630, 48);
            this.nPrioridad.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nPrioridad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nPrioridad.Name = "nPrioridad";
            this.nPrioridad.Size = new System.Drawing.Size(108, 20);
            this.nPrioridad.TabIndex = 47;
            this.nPrioridad.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nProcesado
            // 
            this.nProcesado.Location = new System.Drawing.Point(370, 54);
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
            this.nProcesado.Size = new System.Drawing.Size(55, 20);
            this.nProcesado.TabIndex = 45;
            this.nProcesado.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Procesado";
            // 
            // chkFechaLanzamiento
            // 
            this.chkFechaLanzamiento.AutoSize = true;
            this.chkFechaLanzamiento.Location = new System.Drawing.Point(188, 36);
            this.chkFechaLanzamiento.Name = "chkFechaLanzamiento";
            this.chkFechaLanzamiento.Size = new System.Drawing.Size(173, 17);
            this.chkFechaLanzamiento.TabIndex = 37;
            this.chkFechaLanzamiento.Text = "Utilizar Fechas de Lanzamiento";
            this.chkFechaLanzamiento.UseVisualStyleBackColor = true;
            this.chkFechaLanzamiento.CheckedChanged += new System.EventHandler(this.chkFechaLanzamiento_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Desde";
            // 
            // dtHastaLanzamiento
            // 
            this.dtHastaLanzamiento.Enabled = false;
            this.dtHastaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHastaLanzamiento.Location = new System.Drawing.Point(221, 85);
            this.dtHastaLanzamiento.Name = "dtHastaLanzamiento";
            this.dtHastaLanzamiento.Size = new System.Drawing.Size(99, 20);
            this.dtHastaLanzamiento.TabIndex = 34;
            // 
            // dtDesdeLanzamiento
            // 
            this.dtDesdeLanzamiento.Enabled = false;
            this.dtDesdeLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesdeLanzamiento.Location = new System.Drawing.Point(221, 59);
            this.dtDesdeLanzamiento.Name = "dtDesdeLanzamiento";
            this.dtDesdeLanzamiento.Size = new System.Drawing.Size(99, 20);
            this.dtDesdeLanzamiento.TabIndex = 33;
            // 
            // chkFechasCarga
            // 
            this.chkFechasCarga.AutoSize = true;
            this.chkFechasCarga.Checked = true;
            this.chkFechasCarga.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechasCarga.Location = new System.Drawing.Point(19, 36);
            this.chkFechasCarga.Name = "chkFechasCarga";
            this.chkFechasCarga.Size = new System.Drawing.Size(141, 17);
            this.chkFechasCarga.TabIndex = 32;
            this.chkFechasCarga.Text = "Utilizar Fechas de Carga";
            this.chkFechasCarga.UseVisualStyleBackColor = true;
            this.chkFechasCarga.CheckedChanged += new System.EventHandler(this.chkFechasCarga_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Desde";
            // 
            // dtHasta
            // 
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHasta.Location = new System.Drawing.Point(52, 85);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(99, 20);
            this.dtHasta.TabIndex = 29;
            // 
            // dtDesde
            // 
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesde.Location = new System.Drawing.Point(52, 59);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(99, 20);
            this.dtDesde.TabIndex = 28;
            // 
            // chkConXML
            // 
            this.chkConXML.AutoSize = true;
            this.chkConXML.Location = new System.Drawing.Point(769, 48);
            this.chkConXML.Name = "chkConXML";
            this.chkConXML.Size = new System.Drawing.Size(70, 17);
            this.chkConXML.TabIndex = 27;
            this.chkConXML.Text = "Con XML";
            this.chkConXML.UseVisualStyleBackColor = true;
            // 
            // nTop
            // 
            this.nTop.Location = new System.Drawing.Point(769, 91);
            this.nTop.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nTop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nTop.Name = "nTop";
            this.nTop.Size = new System.Drawing.Size(108, 20);
            this.nTop.TabIndex = 26;
            this.nTop.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cargar solo un Top X";
            // 
            // btDetalles
            // 
            this.btDetalles.Location = new System.Drawing.Point(453, 7);
            this.btDetalles.Name = "btDetalles";
            this.btDetalles.Size = new System.Drawing.Size(148, 23);
            this.btDetalles.TabIndex = 15;
            this.btDetalles.Text = "Cargar Tablas De Detalles";
            this.btDetalles.UseVisualStyleBackColor = true;
            this.btDetalles.Click += new System.EventHandler(this.btDetalles_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpiar.Location = new System.Drawing.Point(914, 39);
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
            this.btCargar.Location = new System.Drawing.Point(914, 3);
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
            this.chkActivar.Size = new System.Drawing.Size(130, 17);
            this.chkActivar.TabIndex = 1;
            this.chkActivar.Tag = "chkActivar";
            this.chkActivar.Text = "Activar Cargas Diarias";
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
            // btCosasCargadas
            // 
            this.btCosasCargadas.Location = new System.Drawing.Point(763, 7);
            this.btCosasCargadas.Name = "btCosasCargadas";
            this.btCosasCargadas.Size = new System.Drawing.Size(150, 23);
            this.btCosasCargadas.TabIndex = 82;
            this.btCosasCargadas.Text = "Que se ha Cargado Hoy";
            this.btCosasCargadas.UseVisualStyleBackColor = true;
            this.btCosasCargadas.Click += new System.EventHandler(this.btCosasCargadas_Click);
            // 
            // cCargasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1007, 118);
            this.Name = "cCargasDiarias";
            this.Size = new System.Drawing.Size(1007, 118);
            this.Load += new System.EventHandler(this.cBase_Load);
            this.panel1.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPrioridad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nProcesado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox group;
        public System.Windows.Forms.CheckBox chkActivar;
        private System.Windows.Forms.Button btExpan;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btDetalles;
        private System.Windows.Forms.NumericUpDown nTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkConXML;
        private System.Windows.Forms.CheckBox chkFechaLanzamiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtHastaLanzamiento;
        private System.Windows.Forms.DateTimePicker dtDesdeLanzamiento;
        private System.Windows.Forms.CheckBox chkFechasCarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.NumericUpDown nPrioridad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nProcesado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCodCampanaMaestra;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAudiencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbServidor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btArchivosPendientes;
        private System.Windows.Forms.Button btEstadoCargasDiarias;
        private System.Windows.Forms.CheckBox chkNulos;
        private System.Windows.Forms.Button btCargaServidores;
        private System.Windows.Forms.Button btCosasCargadas;
    }
}

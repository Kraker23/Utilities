namespace DataIncidence.UI
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsddbSelectorConexion = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsPruebas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDesarrollo = new System.Windows.Forms.ToolStripMenuItem();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEjecutarTodo = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpiarTablas = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrarDatos = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrarTodo = new System.Windows.Forms.ToolStripButton();
            this.tsbDeschekear = new System.Windows.Forms.ToolStripButton();
            this.scGeneral = new System.Windows.Forms.SplitContainer();
            this.tabControles = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cTarget1 = new DataIncidence.UI.View.cTarget();
            this.cCampana1 = new DataIncidence.UI.View.cCampana();
            this.cCompania1 = new DataIncidence.UI.View.cCompania();
            this.cUsuario1 = new DataIncidence.UI.View.cUsuario();
            this.cCliente1 = new DataIncidence.UI.View.cCliente();
            this.cCadenaAlias2 = new DataIncidence.UI.View.cCadenaAlias();
            this.cCadena1 = new DataIncidence.UI.View.cCadena();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cCambiosPendientes1 = new DataIncidence.UI.View.cCambiosPendientes();
            this.cAnunciosEnviados1 = new DataIncidence.UI.View.cAnunciosEnviados();
            this.cPases1 = new DataIncidence.UI.View.cPases();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridLeyenda = new System.Windows.Forms.DataGridView();
            this.TipoAudiencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCargasDiarias1 = new DataIncidence.UI.View.cCargasDiarias();
            this.tabDatosTablas = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).BeginInit();
            this.scGeneral.Panel1.SuspendLayout();
            this.scGeneral.Panel2.SuspendLayout();
            this.scGeneral.SuspendLayout();
            this.tabControles.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLeyenda)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConexion,
            this.tsddbSelectorConexion,
            this.progress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 642);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1317, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblConexion
            // 
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(57, 17);
            this.lblConexion.Text = "Conexion";
            // 
            // tsddbSelectorConexion
            // 
            this.tsddbSelectorConexion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbSelectorConexion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPruebas,
            this.tsProduccion,
            this.tsDesarrollo});
            this.tsddbSelectorConexion.Image = global::DataIncidence.UI.Properties.Resources.ilimitado;
            this.tsddbSelectorConexion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbSelectorConexion.Name = "tsddbSelectorConexion";
            this.tsddbSelectorConexion.Size = new System.Drawing.Size(29, 20);
            this.tsddbSelectorConexion.Text = "Selector Conexion";
            // 
            // tsPruebas
            // 
            this.tsPruebas.Enabled = false;
            this.tsPruebas.Name = "tsPruebas";
            this.tsPruebas.Size = new System.Drawing.Size(164, 22);
            this.tsPruebas.Text = "Pruebas (104)";
            this.tsPruebas.Click += new System.EventHandler(this.tsPruebas_Click);
            // 
            // tsProduccion
            // 
            this.tsProduccion.Name = "tsProduccion";
            this.tsProduccion.Size = new System.Drawing.Size(164, 22);
            this.tsProduccion.Text = "Produccion (116)";
            this.tsProduccion.Click += new System.EventHandler(this.tsProduccion_Click);
            // 
            // tsDesarrollo
            // 
            this.tsDesarrollo.Name = "tsDesarrollo";
            this.tsDesarrollo.Size = new System.Drawing.Size(164, 22);
            this.tsDesarrollo.Text = "Desarrollo (108)";
            this.tsDesarrollo.Click += new System.EventHandler(this.tsDesarrollo_Click);
            // 
            // progress
            // 
            this.progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 16);
            this.progress.Step = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEjecutarTodo,
            this.tsbLimpiarTablas,
            this.tsbBorrarDatos,
            this.tsbBorrarTodo,
            this.tsbDeschekear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1317, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEjecutarTodo
            // 
            this.tsbEjecutarTodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEjecutarTodo.Image = global::DataIncidence.UI.Properties.Resources.boton_ejecutar_servidor;
            this.tsbEjecutarTodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEjecutarTodo.Name = "tsbEjecutarTodo";
            this.tsbEjecutarTodo.Size = new System.Drawing.Size(23, 22);
            this.tsbEjecutarTodo.Text = "Ejecutar Todo";
            this.tsbEjecutarTodo.ToolTipText = "Ejecutar Todo";
            this.tsbEjecutarTodo.Click += new System.EventHandler(this.tsbEjecutarTodo_Click);
            // 
            // tsbLimpiarTablas
            // 
            this.tsbLimpiarTablas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLimpiarTablas.Image = global::DataIncidence.UI.Properties.Resources.barrer;
            this.tsbLimpiarTablas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpiarTablas.Name = "tsbLimpiarTablas";
            this.tsbLimpiarTablas.Size = new System.Drawing.Size(23, 22);
            this.tsbLimpiarTablas.Text = "Limpiar Tablas";
            this.tsbLimpiarTablas.Click += new System.EventHandler(this.tsbLimpiarTablas_Click);
            // 
            // tsbBorrarDatos
            // 
            this.tsbBorrarDatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBorrarDatos.Image = global::DataIncidence.UI.Properties.Resources.goma_de_borrar;
            this.tsbBorrarDatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrarDatos.Name = "tsbBorrarDatos";
            this.tsbBorrarDatos.Size = new System.Drawing.Size(23, 22);
            this.tsbBorrarDatos.Text = "Borrar Datos";
            this.tsbBorrarDatos.Click += new System.EventHandler(this.tsbBorrarDatos_Click);
            // 
            // tsbBorrarTodo
            // 
            this.tsbBorrarTodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBorrarTodo.Image = global::DataIncidence.UI.Properties.Resources.recogedor;
            this.tsbBorrarTodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrarTodo.Name = "tsbBorrarTodo";
            this.tsbBorrarTodo.Size = new System.Drawing.Size(23, 22);
            this.tsbBorrarTodo.Text = "Borrar y limpiar Todo";
            this.tsbBorrarTodo.Click += new System.EventHandler(this.tsbBorrarTodo_Click);
            // 
            // tsbDeschekear
            // 
            this.tsbDeschekear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeschekear.Image = global::DataIncidence.UI.Properties.Resources.cheked;
            this.tsbDeschekear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeschekear.Name = "tsbDeschekear";
            this.tsbDeschekear.Size = new System.Drawing.Size(23, 22);
            this.tsbDeschekear.Text = "Deschekear Todo";
            this.tsbDeschekear.Click += new System.EventHandler(this.tsbDeschekear_Click);
            // 
            // scGeneral
            // 
            this.scGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scGeneral.Location = new System.Drawing.Point(0, 25);
            this.scGeneral.Name = "scGeneral";
            this.scGeneral.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scGeneral.Panel1
            // 
            this.scGeneral.Panel1.Controls.Add(this.tabControles);
            // 
            // scGeneral.Panel2
            // 
            this.scGeneral.Panel2.Controls.Add(this.tabDatosTablas);
            this.scGeneral.Size = new System.Drawing.Size(1317, 617);
            this.scGeneral.SplitterDistance = 454;
            this.scGeneral.TabIndex = 1;
            // 
            // tabControles
            // 
            this.tabControles.Controls.Add(this.tabPage1);
            this.tabControles.Controls.Add(this.tabPage2);
            this.tabControles.Controls.Add(this.tabPage3);
            this.tabControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControles.Location = new System.Drawing.Point(0, 0);
            this.tabControles.Name = "tabControles";
            this.tabControles.SelectedIndex = 0;
            this.tabControles.Size = new System.Drawing.Size(1317, 454);
            this.tabControles.TabIndex = 8;
            this.tabControles.SelectedIndexChanged += new System.EventHandler(this.tabControles_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cTarget1);
            this.tabPage1.Controls.Add(this.cCampana1);
            this.tabPage1.Controls.Add(this.cCompania1);
            this.tabPage1.Controls.Add(this.cUsuario1);
            this.tabPage1.Controls.Add(this.cCliente1);
            this.tabPage1.Controls.Add(this.cCadenaAlias2);
            this.tabPage1.Controls.Add(this.cCadena1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1309, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cTarget1
            // 
            this.cTarget1.Location = new System.Drawing.Point(6, 335);
            this.cTarget1.MinimumSize = new System.Drawing.Size(816, 79);
            this.cTarget1.Name = "cTarget1";
            this.cTarget1.Size = new System.Drawing.Size(816, 79);
            this.cTarget1.TabIndex = 7;
            this.cTarget1.CargarDatosEvento += new DataIncidence.UI.View.cTarget.DatosEvento(this.C_CargarDatosEvento);
            // 
            // cCampana1
            // 
            this.cCampana1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cCampana1.Location = new System.Drawing.Point(3, 3);
            this.cCampana1.MinimumSize = new System.Drawing.Size(841, 84);
            this.cCampana1.Name = "cCampana1";
            this.cCampana1.Size = new System.Drawing.Size(1303, 84);
            this.cCampana1.TabIndex = 0;
            this.cCampana1.CargarDatosEvento += new DataIncidence.UI.View.cCampana.DatosEvento(this.C_CargarDatosEvento);
            // 
            // cCompania1
            // 
            this.cCompania1.Location = new System.Drawing.Point(614, 89);
            this.cCompania1.Name = "cCompania1";
            this.cCompania1.Size = new System.Drawing.Size(446, 82);
            this.cCompania1.TabIndex = 2;
            this.cCompania1.CargarDatosEvento += new DataIncidence.UI.View.cCompania.DatosEvento(this.C_CargarDatosEvento);
            // 
            // cUsuario1
            // 
            this.cUsuario1.Location = new System.Drawing.Point(3, 173);
            this.cUsuario1.MinimumSize = new System.Drawing.Size(585, 75);
            this.cUsuario1.Name = "cUsuario1";
            this.cUsuario1.Size = new System.Drawing.Size(585, 75);
            this.cUsuario1.TabIndex = 3;
            this.cUsuario1.CargarDatosEvento += new DataIncidence.UI.View.cUsuario.DatosEvento(this.C_CargarDatosEvento);
            // 
            // cCliente1
            // 
            this.cCliente1.Location = new System.Drawing.Point(6, 89);
            this.cCliente1.MinimumSize = new System.Drawing.Size(602, 78);
            this.cCliente1.Name = "cCliente1";
            this.cCliente1.Size = new System.Drawing.Size(602, 78);
            this.cCliente1.TabIndex = 1;
            this.cCliente1.CargarDatosEvento += new DataIncidence.UI.View.cCliente.DatosEvento(this.C_CargarDatosEvento);
            // 
            // cCadenaAlias2
            // 
            this.cCadenaAlias2.Location = new System.Drawing.Point(490, 254);
            this.cCadenaAlias2.MinimumSize = new System.Drawing.Size(600, 75);
            this.cCadenaAlias2.Name = "cCadenaAlias2";
            this.cCadenaAlias2.Size = new System.Drawing.Size(600, 75);
            this.cCadenaAlias2.TabIndex = 6;
            this.cCadenaAlias2.CargarDatosEvento += new DataIncidence.UI.View.cCadenaAlias.DatosEvento(this.C_CargarDatosEvento);
            // 
            // cCadena1
            // 
            this.cCadena1.Location = new System.Drawing.Point(8, 254);
            this.cCadena1.MinimumSize = new System.Drawing.Size(476, 78);
            this.cCadena1.Name = "cCadena1";
            this.cCadena1.Size = new System.Drawing.Size(476, 78);
            this.cCadena1.TabIndex = 4;
            this.cCadena1.CargarDatosEvento += new DataIncidence.UI.View.cCadena.DatosEvento(this.C_CargarDatosEvento);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cCambiosPendientes1);
            this.tabPage2.Controls.Add(this.cAnunciosEnviados1);
            this.tabPage2.Controls.Add(this.cPases1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1309, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busqueda Pases";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cCambiosPendientes1
            // 
            this.cCambiosPendientes1.Location = new System.Drawing.Point(6, 351);
            this.cCambiosPendientes1.Name = "cCambiosPendientes1";
            this.cCambiosPendientes1.Size = new System.Drawing.Size(667, 81);
            this.cCambiosPendientes1.TabIndex = 2;
            this.cCambiosPendientes1.CargarDatosEvento += new DataIncidence.UI.View.cCambiosPendientes.DatosEvento(this.C_CargarDatosEvento);
            // 
            // cAnunciosEnviados1
            // 
            this.cAnunciosEnviados1.Location = new System.Drawing.Point(8, 184);
            this.cAnunciosEnviados1.MinimumSize = new System.Drawing.Size(842, 161);
            this.cAnunciosEnviados1.Name = "cAnunciosEnviados1";
            this.cAnunciosEnviados1.Size = new System.Drawing.Size(842, 161);
            this.cAnunciosEnviados1.TabIndex = 1;
            this.cAnunciosEnviados1.CargarDatosEvento += new DataIncidence.UI.View.cAnunciosEnviados.DatosEvento(this.C_CargarDatosEvento);
            // 
            // cPases1
            // 
            this.cPases1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPases1.Location = new System.Drawing.Point(3, 3);
            this.cPases1.Name = "cPases1";
            this.cPases1.Size = new System.Drawing.Size(186, 68);
            this.cPases1.TabIndex = 0;
            this.cPases1.CargarDatosEvento += new DataIncidence.UI.View.cPases.DatosEvento(this.C_CargarDatosEvento);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridLeyenda);
            this.tabPage3.Controls.Add(this.cCargasDiarias1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1309, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cargas Diarias";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridLeyenda
            // 
            this.gridLeyenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLeyenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLeyenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoAudiencia,
            this.Servidor});
            this.gridLeyenda.Location = new System.Drawing.Point(1062, 124);
            this.gridLeyenda.Name = "gridLeyenda";
            this.gridLeyenda.Size = new System.Drawing.Size(244, 106);
            this.gridLeyenda.TabIndex = 1;
            this.gridLeyenda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridLeyenda_CellFormatting);
            // 
            // TipoAudiencia
            // 
            this.TipoAudiencia.HeaderText = "TipoAudiencia";
            this.TipoAudiencia.Name = "TipoAudiencia";
            // 
            // Servidor
            // 
            this.Servidor.HeaderText = "Servidor";
            this.Servidor.Name = "Servidor";
            // 
            // cCargasDiarias1
            // 
            this.cCargasDiarias1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cCargasDiarias1.Location = new System.Drawing.Point(0, 0);
            this.cCargasDiarias1.MinimumSize = new System.Drawing.Size(1007, 118);
            this.cCargasDiarias1.Name = "cCargasDiarias1";
            this.cCargasDiarias1.Size = new System.Drawing.Size(1309, 118);
            this.cCargasDiarias1.TabIndex = 0;
            this.cCargasDiarias1.CargarDatosEvento += new DataIncidence.UI.View.cCargasDiarias.DatosEvento(this.C_CargarDatosEvento);
            this.cCargasDiarias1.IniciarCarga += new DataIncidence.UI.View.cCargasDiarias.IniciarCargaEvento(this.cCargasDiarias1_IniciarCarga);
            this.cCargasDiarias1.FinCarga += new DataIncidence.UI.View.cCargasDiarias.FinCargaEvento(this.cCargasDiarias1_FinCarga);
            // 
            // tabDatosTablas
            // 
            this.tabDatosTablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDatosTablas.Location = new System.Drawing.Point(0, 0);
            this.tabDatosTablas.Name = "tabDatosTablas";
            this.tabDatosTablas.SelectedIndex = 0;
            this.tabDatosTablas.Size = new System.Drawing.Size(1317, 159);
            this.tabDatosTablas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 664);
            this.Controls.Add(this.scGeneral);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "View Datos Incidence";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.scGeneral.Panel1.ResumeLayout(false);
            this.scGeneral.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).EndInit();
            this.scGeneral.ResumeLayout(false);
            this.tabControles.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLeyenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblConexion;
        private System.Windows.Forms.ToolStripDropDownButton tsddbSelectorConexion;
        private System.Windows.Forms.ToolStripMenuItem tsPruebas;
        private System.Windows.Forms.ToolStripMenuItem tsProduccion;
        private System.Windows.Forms.ToolStripMenuItem tsDesarrollo;
        private System.Windows.Forms.SplitContainer scGeneral;
        private System.Windows.Forms.TabControl tabDatosTablas;
        private View.cCampana cCampana1;
        private View.cUsuario cUsuario1;
        private View.cCompania cCompania1;
        private View.cCliente cCliente1;
        private View.cCadenaAlias cCadenaAlias2;
        private View.cCadena cCadena1;
        private System.Windows.Forms.TabControl tabControles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private View.cTarget cTarget1;
        private System.Windows.Forms.TabPage tabPage3;
        private View.cPases cPases1;
        private View.cAnunciosEnviados cAnunciosEnviados1;
        private View.cCambiosPendientes cCambiosPendientes1;
        private View.cCargasDiarias cCargasDiarias1;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEjecutarTodo;
        private System.Windows.Forms.ToolStripButton tsbLimpiarTablas;
        private System.Windows.Forms.ToolStripButton tsbBorrarDatos;
        private System.Windows.Forms.ToolStripButton tsbBorrarTodo;
        private System.Windows.Forms.ToolStripButton tsbDeschekear;
        private System.Windows.Forms.DataGridView gridLeyenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAudiencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor;
    }
}


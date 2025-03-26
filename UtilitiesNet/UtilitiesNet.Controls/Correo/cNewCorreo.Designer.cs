namespace UtilitiesNet.Controls.Correo
{
    partial class cNewCorreo
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImagenes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoCorreo = new System.Windows.Forms.Label();
            this.btEnviar = new System.Windows.Forms.Button();
            this.lVcorreos = new System.Windows.Forms.ListView();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.lDestino = new System.Windows.Forms.Label();
            this.lMensaje = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lAsunto = new System.Windows.Forms.Label();
            this.MenuEliminar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkContenidoHTML = new System.Windows.Forms.CheckBox();
            this.btImgClipBoard = new System.Windows.Forms.Button();
            this.btEliminarImagenes = new System.Windows.Forms.Button();
            this.btInsertarImagen = new System.Windows.Forms.Button();
            this.btCCO = new System.Windows.Forms.Button();
            this.btCC = new System.Windows.Forms.Button();
            this.bAñadirCorreo = new System.Windows.Forms.Button();
            this.MenuEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Insertar Documentos/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "o Informacion";
            // 
            // txtImagenes
            // 
            this.txtImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagenes.Location = new System.Drawing.Point(365, 19);
            this.txtImagenes.Multiline = true;
            this.txtImagenes.Name = "txtImagenes";
            this.txtImagenes.ReadOnly = true;
            this.txtImagenes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtImagenes.Size = new System.Drawing.Size(204, 49);
            this.txtImagenes.TabIndex = 42;
            this.txtImagenes.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Imagenes de Error";
            // 
            // txtNuevoCorreo
            // 
            this.txtNuevoCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNuevoCorreo.AutoSize = true;
            this.txtNuevoCorreo.Location = new System.Drawing.Point(632, 22);
            this.txtNuevoCorreo.Name = "txtNuevoCorreo";
            this.txtNuevoCorreo.Size = new System.Drawing.Size(75, 13);
            this.txtNuevoCorreo.TabIndex = 39;
            this.txtNuevoCorreo.Text = "Nuevo  correo";
            // 
            // btEnviar
            // 
            this.btEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEnviar.Image = global::UtilitiesNet.Controls.Properties.Resources.avion_de_papel_3_;
            this.btEnviar.Location = new System.Drawing.Point(756, 3);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(114, 39);
            this.btEnviar.TabIndex = 23;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // lVcorreos
            // 
            this.lVcorreos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lVcorreos.ContextMenuStrip = this.MenuEliminar;
            this.lVcorreos.Location = new System.Drawing.Point(631, 129);
            this.lVcorreos.Name = "lVcorreos";
            this.lVcorreos.Size = new System.Drawing.Size(239, 138);
            this.lVcorreos.TabIndex = 35;
            this.lVcorreos.UseCompatibleStateImageBehavior = false;
            this.lVcorreos.View = System.Windows.Forms.View.Details;
            this.lVcorreos.SelectedIndexChanged += new System.EventHandler(this.lVcorreos_SelectedIndexChanged);
            // 
            // tbDestino
            // 
            this.tbDestino.AcceptsTab = true;
            this.tbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDestino.Location = new System.Drawing.Point(631, 45);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(239, 20);
            this.tbDestino.TabIndex = 34;
            this.tbDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDestino_KeyPress);
            // 
            // lDestino
            // 
            this.lDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lDestino.AutoSize = true;
            this.lDestino.Location = new System.Drawing.Point(632, 112);
            this.lDestino.Name = "lDestino";
            this.lDestino.Size = new System.Drawing.Size(82, 13);
            this.lDestino.TabIndex = 28;
            this.lDestino.Text = "Lista de correos";
            // 
            // lMensaje
            // 
            this.lMensaje.AutoSize = true;
            this.lMensaje.Location = new System.Drawing.Point(12, 113);
            this.lMensaje.Name = "lMensaje";
            this.lMensaje.Size = new System.Drawing.Size(47, 13);
            this.lMensaje.TabIndex = 33;
            this.lMensaje.Text = "Mensaje";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(150, 102);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescripcion.Size = new System.Drawing.Size(472, 165);
            this.txtDescripcion.TabIndex = 32;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsunto.Location = new System.Drawing.Point(150, 76);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(464, 20);
            this.txtAsunto.TabIndex = 26;
            // 
            // lAsunto
            // 
            this.lAsunto.AutoSize = true;
            this.lAsunto.Location = new System.Drawing.Point(12, 76);
            this.lAsunto.Name = "lAsunto";
            this.lAsunto.Size = new System.Drawing.Size(40, 13);
            this.lAsunto.TabIndex = 24;
            this.lAsunto.Text = "Asunto";
            // 
            // MenuEliminar
            // 
            this.MenuEliminar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.MenuEliminar.Name = "MenuEliminar";
            this.MenuEliminar.Size = new System.Drawing.Size(126, 48);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // chkContenidoHTML
            // 
            this.chkContenidoHTML.AutoSize = true;
            this.chkContenidoHTML.Location = new System.Drawing.Point(15, 146);
            this.chkContenidoHTML.Name = "chkContenidoHTML";
            this.chkContenidoHTML.Size = new System.Drawing.Size(107, 17);
            this.chkContenidoHTML.TabIndex = 47;
            this.chkContenidoHTML.Text = "Contenido HTML";
            this.chkContenidoHTML.UseVisualStyleBackColor = true;
            // 
            // btImgClipBoard
            // 
            this.btImgClipBoard.Image = global::UtilitiesNet.Controls.Properties.Resources.imagen_1_;
            this.btImgClipBoard.Location = new System.Drawing.Point(256, 19);
            this.btImgClipBoard.Name = "btImgClipBoard";
            this.btImgClipBoard.Size = new System.Drawing.Size(103, 49);
            this.btImgClipBoard.TabIndex = 44;
            this.btImgClipBoard.Text = "Insertar Imagenes del Portapapeles";
            this.btImgClipBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btImgClipBoard.UseVisualStyleBackColor = true;
            this.btImgClipBoard.Click += new System.EventHandler(this.btImgClipBoard_Click);
            // 
            // btEliminarImagenes
            // 
            this.btEliminarImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEliminarImagenes.Image = global::UtilitiesNet.Controls.Properties.Resources.delete2;
            this.btEliminarImagenes.Location = new System.Drawing.Point(575, 19);
            this.btEliminarImagenes.Name = "btEliminarImagenes";
            this.btEliminarImagenes.Size = new System.Drawing.Size(47, 49);
            this.btEliminarImagenes.TabIndex = 43;
            this.btEliminarImagenes.UseVisualStyleBackColor = true;
            this.btEliminarImagenes.Visible = false;
            this.btEliminarImagenes.Click += new System.EventHandler(this.btEliminarImagenes_Click);
            // 
            // btInsertarImagen
            // 
            this.btInsertarImagen.Image = global::UtilitiesNet.Controls.Properties.Resources.add_folder;
            this.btInsertarImagen.Location = new System.Drawing.Point(150, 19);
            this.btInsertarImagen.Name = "btInsertarImagen";
            this.btInsertarImagen.Size = new System.Drawing.Size(100, 49);
            this.btInsertarImagen.TabIndex = 40;
            this.btInsertarImagen.Text = "Insertar Documentos";
            this.btInsertarImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btInsertarImagen.UseVisualStyleBackColor = true;
            this.btInsertarImagen.Click += new System.EventHandler(this.btInsertarImagen_Click);
            // 
            // btCCO
            // 
            this.btCCO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCCO.Image = global::UtilitiesNet.Controls.Properties.Resources.binoculares_1_;
            this.btCCO.Location = new System.Drawing.Point(799, 69);
            this.btCCO.Name = "btCCO";
            this.btCCO.Size = new System.Drawing.Size(71, 40);
            this.btCCO.TabIndex = 38;
            this.btCCO.Text = "Añadir CCO";
            this.btCCO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btCCO.UseVisualStyleBackColor = true;
            this.btCCO.Click += new System.EventHandler(this.btCCO_Click);
            // 
            // btCC
            // 
            this.btCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCC.Image = global::UtilitiesNet.Controls.Properties.Resources.binoculares;
            this.btCC.Location = new System.Drawing.Point(720, 69);
            this.btCC.Name = "btCC";
            this.btCC.Size = new System.Drawing.Size(73, 40);
            this.btCC.TabIndex = 37;
            this.btCC.Text = "Añadir CC";
            this.btCC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btCC.UseVisualStyleBackColor = true;
            this.btCC.Click += new System.EventHandler(this.btCC_Click);
            // 
            // bAñadirCorreo
            // 
            this.bAñadirCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAñadirCorreo.Image = global::UtilitiesNet.Controls.Properties.Resources.email_1_;
            this.bAñadirCorreo.Location = new System.Drawing.Point(632, 69);
            this.bAñadirCorreo.Name = "bAñadirCorreo";
            this.bAñadirCorreo.Size = new System.Drawing.Size(82, 40);
            this.bAñadirCorreo.TabIndex = 36;
            this.bAñadirCorreo.Text = "Añadir correo";
            this.bAñadirCorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bAñadirCorreo.UseVisualStyleBackColor = true;
            this.bAñadirCorreo.Click += new System.EventHandler(this.bAñadirCorreo_Click);
            // 
            // cNewCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkContenidoHTML);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btImgClipBoard);
            this.Controls.Add(this.btEliminarImagenes);
            this.Controls.Add(this.txtImagenes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btInsertarImagen);
            this.Controls.Add(this.txtNuevoCorreo);
            this.Controls.Add(this.btCCO);
            this.Controls.Add(this.btCC);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.bAñadirCorreo);
            this.Controls.Add(this.lVcorreos);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.lDestino);
            this.Controls.Add(this.lMensaje);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.lAsunto);
            this.MinimumSize = new System.Drawing.Size(734, 271);
            this.Name = "cNewCorreo";
            this.Size = new System.Drawing.Size(873, 271);
            this.MenuEliminar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btImgClipBoard;
        private System.Windows.Forms.Button btEliminarImagenes;
        private System.Windows.Forms.TextBox txtImagenes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btInsertarImagen;
        private System.Windows.Forms.Label txtNuevoCorreo;
        private System.Windows.Forms.Button btCCO;
        private System.Windows.Forms.Button btCC;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Button bAñadirCorreo;
        private System.Windows.Forms.ListView lVcorreos;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.Label lDestino;
        private System.Windows.Forms.Label lMensaje;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lAsunto;
        private System.Windows.Forms.ContextMenuStrip MenuEliminar;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkContenidoHTML;
    }
}

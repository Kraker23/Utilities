namespace Utilities.Controls.HerramientaTextos
{
    partial class cEncriptarDesencriptarTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cEncriptarDesencriptarTexto));
            this.lbl = new System.Windows.Forms.Label();
            this.txtParaEncriptar = new System.Windows.Forms.TextBox();
            this.btEncriptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParaDesencriptar = new System.Windows.Forms.TextBox();
            this.txtResultadoEncriptar = new System.Windows.Forms.TextBox();
            this.txtResultadoDesencriptar = new System.Windows.Forms.TextBox();
            this.btCopiarEncriptado = new System.Windows.Forms.Button();
            this.btDesencriptar = new System.Windows.Forms.Button();
            this.btCopiarDesencriptado = new System.Windows.Forms.Button();
            this.chkDobleFuncion = new System.Windows.Forms.CheckBox();
            this.btLimpiarDesencriptar = new System.Windows.Forms.Button();
            this.btLimpiarEncriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(17, 41);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(76, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Encryptar AES";
            // 
            // txtParaEncriptar
            // 
            this.txtParaEncriptar.Location = new System.Drawing.Point(20, 67);
            this.txtParaEncriptar.Name = "txtParaEncriptar";
            this.txtParaEncriptar.Size = new System.Drawing.Size(258, 20);
            this.txtParaEncriptar.TabIndex = 4;
            // 
            // btEncriptar
            // 
            this.btEncriptar.Image = ((System.Drawing.Image)(resources.GetObject("btEncriptar.Image")));
            this.btEncriptar.Location = new System.Drawing.Point(284, 61);
            this.btEncriptar.Name = "btEncriptar";
            this.btEncriptar.Size = new System.Drawing.Size(141, 27);
            this.btEncriptar.TabIndex = 5;
            this.btEncriptar.Text = "Encriptar";
            this.btEncriptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEncriptar.UseVisualStyleBackColor = true;
            this.btEncriptar.Click += new System.EventHandler(this.btEncriptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desencriptar AES";
            // 
            // txtParaDesencriptar
            // 
            this.txtParaDesencriptar.Location = new System.Drawing.Point(20, 172);
            this.txtParaDesencriptar.Name = "txtParaDesencriptar";
            this.txtParaDesencriptar.Size = new System.Drawing.Size(258, 20);
            this.txtParaDesencriptar.TabIndex = 7;
            // 
            // txtResultadoEncriptar
            // 
            this.txtResultadoEncriptar.Enabled = false;
            this.txtResultadoEncriptar.Location = new System.Drawing.Point(20, 93);
            this.txtResultadoEncriptar.Name = "txtResultadoEncriptar";
            this.txtResultadoEncriptar.Size = new System.Drawing.Size(258, 20);
            this.txtResultadoEncriptar.TabIndex = 10;
            // 
            // txtResultadoDesencriptar
            // 
            this.txtResultadoDesencriptar.Enabled = false;
            this.txtResultadoDesencriptar.Location = new System.Drawing.Point(20, 198);
            this.txtResultadoDesencriptar.Name = "txtResultadoDesencriptar";
            this.txtResultadoDesencriptar.Size = new System.Drawing.Size(258, 20);
            this.txtResultadoDesencriptar.TabIndex = 11;
            // 
            // btCopiarEncriptado
            // 
            this.btCopiarEncriptado.Image = ((System.Drawing.Image)(resources.GetObject("btCopiarEncriptado.Image")));
            this.btCopiarEncriptado.Location = new System.Drawing.Point(284, 92);
            this.btCopiarEncriptado.Name = "btCopiarEncriptado";
            this.btCopiarEncriptado.Size = new System.Drawing.Size(141, 33);
            this.btCopiarEncriptado.TabIndex = 12;
            this.btCopiarEncriptado.Text = "Copiar Portapapeles";
            this.btCopiarEncriptado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCopiarEncriptado.UseVisualStyleBackColor = true;
            this.btCopiarEncriptado.Click += new System.EventHandler(this.btCopiarEncriptado_Click);
            // 
            // btDesencriptar
            // 
            this.btDesencriptar.Image = global::Utilities.Controls.Properties.Resources.form_green;
            this.btDesencriptar.Location = new System.Drawing.Point(284, 165);
            this.btDesencriptar.Name = "btDesencriptar";
            this.btDesencriptar.Size = new System.Drawing.Size(141, 28);
            this.btDesencriptar.TabIndex = 13;
            this.btDesencriptar.Text = "Desencriptar";
            this.btDesencriptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDesencriptar.UseVisualStyleBackColor = true;
            this.btDesencriptar.Click += new System.EventHandler(this.btDesencriptar_Click);
            // 
            // btCopiarDesencriptado
            // 
            this.btCopiarDesencriptado.Image = ((System.Drawing.Image)(resources.GetObject("btCopiarDesencriptado.Image")));
            this.btCopiarDesencriptado.Location = new System.Drawing.Point(284, 197);
            this.btCopiarDesencriptado.Name = "btCopiarDesencriptado";
            this.btCopiarDesencriptado.Size = new System.Drawing.Size(141, 35);
            this.btCopiarDesencriptado.TabIndex = 14;
            this.btCopiarDesencriptado.Text = "Copiar Portapapeles";
            this.btCopiarDesencriptado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCopiarDesencriptado.UseVisualStyleBackColor = true;
            this.btCopiarDesencriptado.Click += new System.EventHandler(this.btCopiarDesencriptado_Click);
            // 
            // chkDobleFuncion
            // 
            this.chkDobleFuncion.AutoSize = true;
            this.chkDobleFuncion.Checked = true;
            this.chkDobleFuncion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDobleFuncion.Location = new System.Drawing.Point(263, 3);
            this.chkDobleFuncion.Name = "chkDobleFuncion";
            this.chkDobleFuncion.Size = new System.Drawing.Size(171, 17);
            this.chkDobleFuncion.TabIndex = 15;
            this.chkDobleFuncion.Text = "Funcion + Copiar Portapapeles";
            this.chkDobleFuncion.UseVisualStyleBackColor = true;
            this.chkDobleFuncion.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btLimpiarDesencriptar
            // 
            this.btLimpiarDesencriptar.Image = global::Utilities.Controls.Properties.Resources.goma_de_borrar1;
            this.btLimpiarDesencriptar.Location = new System.Drawing.Point(114, 133);
            this.btLimpiarDesencriptar.Name = "btLimpiarDesencriptar";
            this.btLimpiarDesencriptar.Size = new System.Drawing.Size(141, 31);
            this.btLimpiarDesencriptar.TabIndex = 17;
            this.btLimpiarDesencriptar.Text = "Limpiar Desencriptar";
            this.btLimpiarDesencriptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpiarDesencriptar.UseVisualStyleBackColor = true;
            this.btLimpiarDesencriptar.Click += new System.EventHandler(this.btLimpiarDesencriptar_Click);
            // 
            // btLimpiarEncriptar
            // 
            this.btLimpiarEncriptar.Image = global::Utilities.Controls.Properties.Resources.goma_de_borrar1;
            this.btLimpiarEncriptar.Location = new System.Drawing.Point(116, 34);
            this.btLimpiarEncriptar.Name = "btLimpiarEncriptar";
            this.btLimpiarEncriptar.Size = new System.Drawing.Size(141, 27);
            this.btLimpiarEncriptar.TabIndex = 16;
            this.btLimpiarEncriptar.Text = "Limpiar Encriptar";
            this.btLimpiarEncriptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpiarEncriptar.UseVisualStyleBackColor = true;
            this.btLimpiarEncriptar.Click += new System.EventHandler(this.btLimpiarEncriptar_Click);
            // 
            // cEncriptarDesencriptarTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btLimpiarDesencriptar);
            this.Controls.Add(this.btLimpiarEncriptar);
            this.Controls.Add(this.chkDobleFuncion);
            this.Controls.Add(this.btCopiarDesencriptado);
            this.Controls.Add(this.btDesencriptar);
            this.Controls.Add(this.btCopiarEncriptado);
            this.Controls.Add(this.txtResultadoDesencriptar);
            this.Controls.Add(this.txtResultadoEncriptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParaDesencriptar);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtParaEncriptar);
            this.Controls.Add(this.btEncriptar);
            this.Name = "cEncriptarDesencriptarTexto";
            this.Size = new System.Drawing.Size(434, 241);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.TextBox txtParaEncriptar;
        private System.Windows.Forms.Button btEncriptar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtParaDesencriptar;
        public System.Windows.Forms.TextBox txtResultadoEncriptar;
        public System.Windows.Forms.TextBox txtResultadoDesencriptar;
        private System.Windows.Forms.Button btCopiarEncriptado;
        private System.Windows.Forms.Button btDesencriptar;
        private System.Windows.Forms.Button btCopiarDesencriptado;
        private System.Windows.Forms.CheckBox chkDobleFuncion;
        private System.Windows.Forms.Button btLimpiarEncriptar;
        private System.Windows.Forms.Button btLimpiarDesencriptar;
    }
}

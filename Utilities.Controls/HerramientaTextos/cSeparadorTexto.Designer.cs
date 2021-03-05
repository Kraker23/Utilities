namespace Utilities.Controls.HerramientaTextos
{
    partial class cSeparadorTexto
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
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtSeparador = new System.Windows.Forms.TextBox();
            this.btConcatenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCadenaSeparar = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCopiarClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(23, 29);
            this.txtCadena.MaxLength = 0;
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(168, 129);
            this.txtCadena.TabIndex = 0;
            this.txtCadena.TextChanged += new System.EventHandler(this.txtCadena_TextChanged);
            // 
            // txtSeparador
            // 
            this.txtSeparador.Location = new System.Drawing.Point(200, 29);
            this.txtSeparador.Name = "txtSeparador";
            this.txtSeparador.Size = new System.Drawing.Size(137, 20);
            this.txtSeparador.TabIndex = 1;
            // 
            // btConcatenar
            // 
            this.btConcatenar.Location = new System.Drawing.Point(380, 23);
            this.btConcatenar.Name = "btConcatenar";
            this.btConcatenar.Size = new System.Drawing.Size(75, 29);
            this.btConcatenar.TabIndex = 2;
            this.btConcatenar.Text = "Concatenar";
            this.btConcatenar.UseVisualStyleBackColor = true;
            this.btConcatenar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto a Separar/Concatenar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Separador(,)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caracter para separar(\\r\\n)";
            // 
            // txtCadenaSeparar
            // 
            this.txtCadenaSeparar.Location = new System.Drawing.Point(200, 75);
            this.txtCadenaSeparar.Name = "txtCadenaSeparar";
            this.txtCadenaSeparar.Size = new System.Drawing.Size(133, 20);
            this.txtCadenaSeparar.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(380, 58);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(197, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Image = global::Utilities.Controls.Properties.Resources.goma_de_borrar;
            this.btLimpiar.Location = new System.Drawing.Point(168, 3);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(25, 23);
            this.btLimpiar.TabIndex = 9;
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btCopiarClipboard
            // 
            this.btCopiarClipboard.Image = global::Utilities.Controls.Properties.Resources.copy1;
            this.btCopiarClipboard.Location = new System.Drawing.Point(461, 23);
            this.btCopiarClipboard.Name = "btCopiarClipboard";
            this.btCopiarClipboard.Size = new System.Drawing.Size(37, 31);
            this.btCopiarClipboard.TabIndex = 8;
            this.btCopiarClipboard.UseVisualStyleBackColor = true;
            this.btCopiarClipboard.Click += new System.EventHandler(this.btCopiarClipboard_Click);
            // 
            // SeparadorTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btCopiarClipboard);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtCadenaSeparar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConcatenar);
            this.Controls.Add(this.txtSeparador);
            this.Controls.Add(this.txtCadena);
            this.Name = "SeparadorTexto";
            this.Size = new System.Drawing.Size(589, 167);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.TextBox txtSeparador;
        private System.Windows.Forms.Button btConcatenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCadenaSeparar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btCopiarClipboard;
        private System.Windows.Forms.Button btLimpiar;
    }
}

namespace Utilities.Controls.HerramientaTextos
{
    partial class frmIntroducirTexto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(293, 54);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(86, 30);
            this.bt.TabIndex = 1;
            this.bt.Text = "Aceptar";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(26, 29);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(258, 20);
            this.txt.TabIndex = 0;
            this.txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(23, 13);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "label1";
            // 
            // btMostrar
            // 
            this.btMostrar.Image = global::Utilities.Controls.Properties.Resources.ocultar_2_;
            this.btMostrar.Location = new System.Drawing.Point(293, 28);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(32, 20);
            this.btMostrar.TabIndex = 3;
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // frmIntroducirTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 84);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmIntroducirTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmIntroducirTexto";
            this.Load += new System.EventHandler(this.frmIntroducirTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btMostrar;
    }
}
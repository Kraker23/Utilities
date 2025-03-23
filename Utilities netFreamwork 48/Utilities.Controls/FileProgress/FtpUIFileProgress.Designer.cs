namespace Utilities.Controls.FileProgress
{
    partial class FtpUIFileProgress
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.prgb = new System.Windows.Forms.ProgressBar();
            this.lblText = new System.Windows.Forms.Label();
            this.pktState = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pktState)).BeginInit();
            this.SuspendLayout();
            // 
            // prgb
            // 
            this.prgb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgb.Location = new System.Drawing.Point(2, 22);
            this.prgb.Name = "prgb";
            this.prgb.Size = new System.Drawing.Size(283, 19);
            this.prgb.Step = 1;
            this.prgb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgb.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Location = new System.Drawing.Point(27, 6);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "label1";
            // 
            // pktState
            // 
            this.pktState.Image = global::Utilities.Controls.Properties.Resources.ajax_loader;
            this.pktState.Location = new System.Drawing.Point(5, 4);
            this.pktState.Name = "pktState";
            this.pktState.Size = new System.Drawing.Size(16, 16);
            this.pktState.TabIndex = 2;
            this.pktState.TabStop = false;
            this.pktState.Visible = false;
            // 
            // FtpUIFileProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pktState);
            this.Controls.Add(this.prgb);
            this.Controls.Add(this.lblText);
            this.Name = "FtpUIFileProgress";
            this.Size = new System.Drawing.Size(288, 43);
            ((System.ComponentModel.ISupportInitialize)(this.pktState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgb;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pktState;
    }
}

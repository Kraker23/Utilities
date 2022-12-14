namespace Utilities.Test
{
    partial class frmQRCodigoBarras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btGenerarQR = new System.Windows.Forms.Button();
            this.btGenerarCodigoBarras = new System.Windows.Forms.Button();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblQR = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.pbCodigoBarras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // btGenerarQR
            // 
            this.btGenerarQR.Location = new System.Drawing.Point(342, 18);
            this.btGenerarQR.Name = "btGenerarQR";
            this.btGenerarQR.Size = new System.Drawing.Size(75, 51);
            this.btGenerarQR.TabIndex = 0;
            this.btGenerarQR.Text = "Generar QR";
            this.btGenerarQR.UseVisualStyleBackColor = true;
            this.btGenerarQR.Click += new System.EventHandler(this.btGenerarQR_Click);
            // 
            // btGenerarCodigoBarras
            // 
            this.btGenerarCodigoBarras.Location = new System.Drawing.Point(342, 245);
            this.btGenerarCodigoBarras.Name = "btGenerarCodigoBarras";
            this.btGenerarCodigoBarras.Size = new System.Drawing.Size(75, 48);
            this.btGenerarCodigoBarras.TabIndex = 1;
            this.btGenerarCodigoBarras.Text = "Generar Codigo Barras";
            this.btGenerarCodigoBarras.UseVisualStyleBackColor = true;
            this.btGenerarCodigoBarras.Click += new System.EventHandler(this.btGenerarCodigoBarras_Click);
            // 
            // txtQR
            // 
            this.txtQR.Location = new System.Drawing.Point(55, 34);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(267, 20);
            this.txtQR.TabIndex = 2;
            this.txtQR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQR_KeyPress);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(55, 260);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(267, 20);
            this.txtCodigoBarras.TabIndex = 3;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Location = new System.Drawing.Point(52, 18);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(88, 13);
            this.lblQR.TabIndex = 4;
            this.lblQR.Text = "Texto para el QR";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(52, 233);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(138, 13);
            this.lblCodigoBarras.TabIndex = 5;
            this.lblCodigoBarras.Text = "Texto para el Codigo Barras";
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(423, 12);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(200, 200);
            this.pbQR.TabIndex = 6;
            this.pbQR.TabStop = false;
            // 
            // pbCodigoBarras
            // 
            this.pbCodigoBarras.Location = new System.Drawing.Point(423, 233);
            this.pbCodigoBarras.Name = "pbCodigoBarras";
            this.pbCodigoBarras.Size = new System.Drawing.Size(346, 130);
            this.pbCodigoBarras.TabIndex = 7;
            this.pbCodigoBarras.TabStop = false;
            // 
            // frmQRCodigoBarras
            // 
            this.ClientSize = new System.Drawing.Size(781, 374);
            this.Controls.Add(this.pbCodigoBarras);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.lblCodigoBarras);
            this.Controls.Add(this.lblQR);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.btGenerarCodigoBarras);
            this.Controls.Add(this.btGenerarQR);
            this.MinimumSize = new System.Drawing.Size(797, 413);
            this.Name = "frmQRCodigoBarras";
            this.Text = "QR & CodigoBarras";
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoBarras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerarQR;
        private System.Windows.Forms.Button btGenerarCodigoBarras;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblQR;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.PictureBox pbCodigoBarras;
    }
}
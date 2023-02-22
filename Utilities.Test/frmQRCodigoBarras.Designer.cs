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
            this.pbQrImagen = new System.Windows.Forms.PictureBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblCodigoAnulacion = new System.Windows.Forms.Label();
            this.txtCodigoAnulacion = new System.Windows.Forms.TextBox();
            this.btGenerarQRImagen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nTamanyo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTamanyo)).BeginInit();
            this.SuspendLayout();
            // 
            // btGenerarQR
            // 
            this.btGenerarQR.Location = new System.Drawing.Point(19, 224);
            this.btGenerarQR.Name = "btGenerarQR";
            this.btGenerarQR.Size = new System.Drawing.Size(85, 75);
            this.btGenerarQR.TabIndex = 0;
            this.btGenerarQR.Text = "Generar QR";
            this.btGenerarQR.UseVisualStyleBackColor = true;
            this.btGenerarQR.Visible = false;
            this.btGenerarQR.Click += new System.EventHandler(this.btGenerarQR_Click);
            // 
            // btGenerarCodigoBarras
            // 
            this.btGenerarCodigoBarras.Location = new System.Drawing.Point(307, 370);
            this.btGenerarCodigoBarras.Name = "btGenerarCodigoBarras";
            this.btGenerarCodigoBarras.Size = new System.Drawing.Size(75, 48);
            this.btGenerarCodigoBarras.TabIndex = 1;
            this.btGenerarCodigoBarras.Text = "Generar Codigo Barras";
            this.btGenerarCodigoBarras.UseVisualStyleBackColor = true;
            this.btGenerarCodigoBarras.Click += new System.EventHandler(this.btGenerarCodigoBarras_Click);
            // 
            // txtQR
            // 
            this.txtQR.Enabled = false;
            this.txtQR.Location = new System.Drawing.Point(125, 227);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(267, 20);
            this.txtQR.TabIndex = 2;
            this.txtQR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQR_KeyPress);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(20, 385);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(267, 20);
            this.txtCodigoBarras.TabIndex = 3;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Location = new System.Drawing.Point(122, 211);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(88, 13);
            this.lblQR.TabIndex = 4;
            this.lblQR.Text = "Texto para el QR";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(17, 358);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(138, 13);
            this.lblCodigoBarras.TabIndex = 5;
            this.lblCodigoBarras.Text = "Texto para el Codigo Barras";
            // 
            // pbQR
            // 
            this.pbQR.Location = new System.Drawing.Point(285, 12);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(130, 113);
            this.pbQR.TabIndex = 6;
            this.pbQR.TabStop = false;
            // 
            // pbCodigoBarras
            // 
            this.pbCodigoBarras.Location = new System.Drawing.Point(398, 334);
            this.pbCodigoBarras.Name = "pbCodigoBarras";
            this.pbCodigoBarras.Size = new System.Drawing.Size(346, 130);
            this.pbCodigoBarras.TabIndex = 7;
            this.pbCodigoBarras.TabStop = false;
            // 
            // pbQrImagen
            // 
            this.pbQrImagen.Location = new System.Drawing.Point(451, 28);
            this.pbQrImagen.Name = "pbQrImagen";
            this.pbQrImagen.Size = new System.Drawing.Size(293, 263);
            this.pbQrImagen.TabIndex = 8;
            this.pbQrImagen.TabStop = false;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(16, 154);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 10;
            this.lblMatricula.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(19, 170);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(142, 20);
            this.txtMatricula.TabIndex = 9;
            // 
            // lblCodigoAnulacion
            // 
            this.lblCodigoAnulacion.AutoSize = true;
            this.lblCodigoAnulacion.Location = new System.Drawing.Point(177, 154);
            this.lblCodigoAnulacion.Name = "lblCodigoAnulacion";
            this.lblCodigoAnulacion.Size = new System.Drawing.Size(90, 13);
            this.lblCodigoAnulacion.TabIndex = 12;
            this.lblCodigoAnulacion.Text = "Codigo Anulacion";
            // 
            // txtCodigoAnulacion
            // 
            this.txtCodigoAnulacion.Location = new System.Drawing.Point(180, 170);
            this.txtCodigoAnulacion.Name = "txtCodigoAnulacion";
            this.txtCodigoAnulacion.Size = new System.Drawing.Size(142, 20);
            this.txtCodigoAnulacion.TabIndex = 11;
            // 
            // btGenerarQRImagen
            // 
            this.btGenerarQRImagen.Location = new System.Drawing.Point(180, 12);
            this.btGenerarQRImagen.Name = "btGenerarQRImagen";
            this.btGenerarQRImagen.Size = new System.Drawing.Size(75, 51);
            this.btGenerarQRImagen.TabIndex = 13;
            this.btGenerarQRImagen.Text = "Generar QR Imagen";
            this.btGenerarQRImagen.UseVisualStyleBackColor = true;
            this.btGenerarQRImagen.Click += new System.EventHandler(this.btGenerarQrImagen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Texto para el QR";
            // 
            // nTamanyo
            // 
            this.nTamanyo.Location = new System.Drawing.Point(20, 28);
            this.nTamanyo.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nTamanyo.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nTamanyo.Name = "nTamanyo";
            this.nTamanyo.Size = new System.Drawing.Size(120, 20);
            this.nTamanyo.TabIndex = 15;
            this.nTamanyo.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // frmQRCodigoBarras
            // 
            this.ClientSize = new System.Drawing.Size(781, 486);
            this.Controls.Add(this.nTamanyo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGenerarQRImagen);
            this.Controls.Add(this.lblCodigoAnulacion);
            this.Controls.Add(this.txtCodigoAnulacion);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.pbQrImagen);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbQrImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTamanyo)).EndInit();
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
        private System.Windows.Forms.PictureBox pbQrImagen;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblCodigoAnulacion;
        private System.Windows.Forms.TextBox txtCodigoAnulacion;
        private System.Windows.Forms.Button btGenerarQRImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nTamanyo;
    }
}
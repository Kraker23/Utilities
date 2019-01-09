namespace Utilities.Controls.EditarImagen
{
    partial class frmCaptura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaptura));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pck = new System.Windows.Forms.PictureBox();
            this.tsbRecortar = new System.Windows.Forms.ToolStripButton();
            this.btnColor = new System.Windows.Forms.ToolStripButton();
            this.tsbLine = new System.Windows.Forms.ToolStripButton();
            this.tsbRect = new System.Windows.Forms.ToolStripButton();
            this.tsbArrow = new System.Windows.Forms.ToolStripButton();
            this.tsbUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbReedo = new System.Windows.Forms.ToolStripButton();
            this.tsbddUndo = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pck)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnCancelar.Location = new System.Drawing.Point(544, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.Location = new System.Drawing.Point(650, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(117, 30);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Guardar Como";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRecortar,
            this.toolStripSeparator1,
            this.btnColor,
            this.tsbLine,
            this.tsbRect,
            this.tsbArrow,
            this.toolStripSeparator2,
            this.tsbUndo,
            this.tsbReedo,
            this.tsbddUndo});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 23);
            this.toolStrip1.TabIndex = 13;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            this.toolStripSeparator2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 44);
            this.panel2.TabIndex = 15;
            // 
            // pck
            // 
            this.pck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pck.Location = new System.Drawing.Point(0, 23);
            this.pck.Name = "pck";
            this.pck.Size = new System.Drawing.Size(784, 499);
            this.pck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pck.TabIndex = 12;
            this.pck.TabStop = false;
            this.pck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pck_MouseDown);
            this.pck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pck_MouseMove);
            this.pck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pck_MouseUp);
            this.pck.Resize += new System.EventHandler(this.pck_Resize);
            // 
            // tsbRecortar
            // 
            this.tsbRecortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecortar.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecortar.Image")));
            this.tsbRecortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecortar.Name = "tsbRecortar";
            this.tsbRecortar.Size = new System.Drawing.Size(23, 20);
            this.tsbRecortar.Text = "Recortar";
            this.tsbRecortar.Click += new System.EventHandler(this.tsbRecortar_Click);
            // 
            // btnColor
            // 
            this.btnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(23, 20);
            this.btnColor.Text = "Selecionar color";
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tsbLine
            // 
            this.tsbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
            this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLine.Name = "tsbLine";
            this.tsbLine.Size = new System.Drawing.Size(23, 20);
            this.tsbLine.Text = "Línea";
            this.tsbLine.Click += new System.EventHandler(this.tsbLine_Click);
            // 
            // tsbRect
            // 
            this.tsbRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRect.Image = ((System.Drawing.Image)(resources.GetObject("tsbRect.Image")));
            this.tsbRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRect.Name = "tsbRect";
            this.tsbRect.Size = new System.Drawing.Size(23, 20);
            this.tsbRect.Text = "Rectangulo";
            this.tsbRect.Click += new System.EventHandler(this.tsbRect_Click);
            // 
            // tsbArrow
            // 
            this.tsbArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbArrow.Image = ((System.Drawing.Image)(resources.GetObject("tsbArrow.Image")));
            this.tsbArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbArrow.Name = "tsbArrow";
            this.tsbArrow.Size = new System.Drawing.Size(23, 20);
            this.tsbArrow.Text = "Arrow";
            this.tsbArrow.Click += new System.EventHandler(this.tsbArrow_Click);
            // 
            // tsbUndo
            // 
            this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUndo.Image = global::Utilities.Controls.Properties.Resources.deshacer;
            this.tsbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndo.Name = "tsbUndo";
            this.tsbUndo.Size = new System.Drawing.Size(23, 20);
            this.tsbUndo.Text = "Deshacer";
            this.tsbUndo.Visible = false;
            this.tsbUndo.Click += new System.EventHandler(this.tsbUndo_Click);
            // 
            // tsbReedo
            // 
            this.tsbReedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReedo.Image = global::Utilities.Controls.Properties.Resources.deshacer_1_;
            this.tsbReedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReedo.Name = "tsbReedo";
            this.tsbReedo.Size = new System.Drawing.Size(23, 20);
            this.tsbReedo.Text = "Rehacer";
            this.tsbReedo.Visible = false;
            this.tsbReedo.Click += new System.EventHandler(this.tsbReedo_Click);
            // 
            // tsbddUndo
            // 
            this.tsbddUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbddUndo.Image = ((System.Drawing.Image)(resources.GetObject("tsbddUndo.Image")));
            this.tsbddUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbddUndo.Name = "tsbddUndo";
            this.tsbddUndo.Size = new System.Drawing.Size(29, 20);
            this.tsbddUndo.Text = "toolStripDropDownButton1";
            // 
            // frmCaptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.pck);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCaptura";
            this.ShowInTaskbar = false;
            this.Text = "Editar Captura de Pantalla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditarImg_FormClosing);
            this.Load += new System.EventHandler(this.frmEditarImg_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEditarImg_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRecortar;
        private System.Windows.Forms.ToolStripButton tsbLine;
        private System.Windows.Forms.ToolStripButton tsbRect;
        private System.Windows.Forms.ToolStripButton tsbArrow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnColor;
        private System.Windows.Forms.PictureBox pck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbUndo;
        private System.Windows.Forms.ToolStripButton tsbReedo;
        private System.Windows.Forms.ToolStripDropDownButton tsbddUndo;
    }
}
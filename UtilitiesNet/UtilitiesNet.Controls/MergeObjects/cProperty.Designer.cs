
namespace UtilitiesNet.Controls.MergeObjects
{
    partial class cProperty
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
            scX = new System.Windows.Forms.SplitContainer();
            chkX = new System.Windows.Forms.CheckBox();
            txtX = new System.Windows.Forms.TextBox();
            scBaseValor = new System.Windows.Forms.SplitContainer();
            scY = new System.Windows.Forms.SplitContainer();
            chkY = new System.Windows.Forms.CheckBox();
            txtY = new System.Windows.Forms.TextBox();
            scNombreValor = new System.Windows.Forms.SplitContainer();
            lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)scX).BeginInit();
            scX.Panel1.SuspendLayout();
            scX.Panel2.SuspendLayout();
            scX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scBaseValor).BeginInit();
            scBaseValor.Panel1.SuspendLayout();
            scBaseValor.Panel2.SuspendLayout();
            scBaseValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scY).BeginInit();
            scY.Panel1.SuspendLayout();
            scY.Panel2.SuspendLayout();
            scY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scNombreValor).BeginInit();
            scNombreValor.Panel1.SuspendLayout();
            scNombreValor.Panel2.SuspendLayout();
            scNombreValor.SuspendLayout();
            SuspendLayout();
            // 
            // scX
            // 
            scX.Dock = System.Windows.Forms.DockStyle.Fill;
            scX.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            scX.IsSplitterFixed = true;
            scX.Location = new System.Drawing.Point(0, 0);
            scX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            scX.Name = "scX";
            // 
            // scX.Panel1
            // 
            scX.Panel1.Controls.Add(chkX);
            scX.Panel1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            // 
            // scX.Panel2
            // 
            scX.Panel2.Controls.Add(txtX);
            scX.Panel2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            scX.Size = new System.Drawing.Size(326, 35);
            scX.SplitterDistance = 34;
            scX.SplitterWidth = 5;
            scX.TabIndex = 0;
            // 
            // chkX
            // 
            chkX.AutoSize = true;
            chkX.Dock = System.Windows.Forms.DockStyle.Fill;
            chkX.Location = new System.Drawing.Point(8, 8);
            chkX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkX.Name = "chkX";
            chkX.Size = new System.Drawing.Size(18, 19);
            chkX.TabIndex = 0;
            chkX.UseVisualStyleBackColor = true;
            chkX.CheckedChanged += chkX_CheckedChanged;
            // 
            // txtX
            // 
            txtX.Dock = System.Windows.Forms.DockStyle.Fill;
            txtX.Enabled = false;
            txtX.Location = new System.Drawing.Point(6, 6);
            txtX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtX.Name = "txtX";
            txtX.Size = new System.Drawing.Size(275, 23);
            txtX.TabIndex = 0;
            // 
            // scBaseValor
            // 
            scBaseValor.Dock = System.Windows.Forms.DockStyle.Fill;
            scBaseValor.Location = new System.Drawing.Point(0, 0);
            scBaseValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            scBaseValor.Name = "scBaseValor";
            // 
            // scBaseValor.Panel1
            // 
            scBaseValor.Panel1.Controls.Add(scX);
            // 
            // scBaseValor.Panel2
            // 
            scBaseValor.Panel2.Controls.Add(scY);
            scBaseValor.Size = new System.Drawing.Size(654, 35);
            scBaseValor.SplitterDistance = 326;
            scBaseValor.SplitterWidth = 5;
            scBaseValor.TabIndex = 1;
            // 
            // scY
            // 
            scY.Dock = System.Windows.Forms.DockStyle.Fill;
            scY.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            scY.IsSplitterFixed = true;
            scY.Location = new System.Drawing.Point(0, 0);
            scY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            scY.Name = "scY";
            // 
            // scY.Panel1
            // 
            scY.Panel1.Controls.Add(chkY);
            scY.Panel1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            // 
            // scY.Panel2
            // 
            scY.Panel2.Controls.Add(txtY);
            scY.Panel2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            scY.Size = new System.Drawing.Size(323, 35);
            scY.SplitterDistance = 33;
            scY.SplitterWidth = 5;
            scY.TabIndex = 1;
            // 
            // chkY
            // 
            chkY.AutoSize = true;
            chkY.Dock = System.Windows.Forms.DockStyle.Fill;
            chkY.Location = new System.Drawing.Point(8, 8);
            chkY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkY.Name = "chkY";
            chkY.Size = new System.Drawing.Size(17, 19);
            chkY.TabIndex = 0;
            chkY.UseVisualStyleBackColor = true;
            chkY.CheckedChanged += chkY_CheckedChanged;
            // 
            // txtY
            // 
            txtY.Dock = System.Windows.Forms.DockStyle.Fill;
            txtY.Enabled = false;
            txtY.Location = new System.Drawing.Point(6, 6);
            txtY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtY.Name = "txtY";
            txtY.Size = new System.Drawing.Size(273, 23);
            txtY.TabIndex = 1;
            // 
            // scNombreValor
            // 
            scNombreValor.Dock = System.Windows.Forms.DockStyle.Fill;
            scNombreValor.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            scNombreValor.Location = new System.Drawing.Point(0, 0);
            scNombreValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            scNombreValor.Name = "scNombreValor";
            // 
            // scNombreValor.Panel1
            // 
            scNombreValor.Panel1.Controls.Add(lblNombre);
            scNombreValor.Panel1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            // 
            // scNombreValor.Panel2
            // 
            scNombreValor.Panel2.Controls.Add(scBaseValor);
            scNombreValor.Size = new System.Drawing.Size(817, 35);
            scNombreValor.SplitterDistance = 158;
            scNombreValor.SplitterWidth = 5;
            scNombreValor.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            lblNombre.Location = new System.Drawing.Point(8, 8);
            lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(105, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NombrePropiedad";
            // 
            // cProperty
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            Controls.Add(scNombreValor);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "cProperty";
            Size = new System.Drawing.Size(817, 35);
            scX.Panel1.ResumeLayout(false);
            scX.Panel1.PerformLayout();
            scX.Panel2.ResumeLayout(false);
            scX.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scX).EndInit();
            scX.ResumeLayout(false);
            scBaseValor.Panel1.ResumeLayout(false);
            scBaseValor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scBaseValor).EndInit();
            scBaseValor.ResumeLayout(false);
            scY.Panel1.ResumeLayout(false);
            scY.Panel1.PerformLayout();
            scY.Panel2.ResumeLayout(false);
            scY.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scY).EndInit();
            scY.ResumeLayout(false);
            scNombreValor.Panel1.ResumeLayout(false);
            scNombreValor.Panel1.PerformLayout();
            scNombreValor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scNombreValor).EndInit();
            scNombreValor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer scX;
        private System.Windows.Forms.CheckBox chkX;
        private System.Windows.Forms.SplitContainer scBaseValor;
        private System.Windows.Forms.SplitContainer scY;
        private System.Windows.Forms.CheckBox chkY;
        private System.Windows.Forms.SplitContainer scNombreValor;
        public System.Windows.Forms.TextBox txtX;
        public System.Windows.Forms.TextBox txtY;
        public System.Windows.Forms.Label lblNombre;
    }
}


namespace Utilities.Controls.MergeObjects
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
            this.scX = new System.Windows.Forms.SplitContainer();
            this.chkX = new System.Windows.Forms.CheckBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.scBaseValor = new System.Windows.Forms.SplitContainer();
            this.scY = new System.Windows.Forms.SplitContainer();
            this.chkY = new System.Windows.Forms.CheckBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.scNombreValor = new System.Windows.Forms.SplitContainer();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scX)).BeginInit();
            this.scX.Panel1.SuspendLayout();
            this.scX.Panel2.SuspendLayout();
            this.scX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBaseValor)).BeginInit();
            this.scBaseValor.Panel1.SuspendLayout();
            this.scBaseValor.Panel2.SuspendLayout();
            this.scBaseValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scY)).BeginInit();
            this.scY.Panel1.SuspendLayout();
            this.scY.Panel2.SuspendLayout();
            this.scY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scNombreValor)).BeginInit();
            this.scNombreValor.Panel1.SuspendLayout();
            this.scNombreValor.Panel2.SuspendLayout();
            this.scNombreValor.SuspendLayout();
            this.SuspendLayout();
            // 
            // scX
            // 
            this.scX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scX.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scX.IsSplitterFixed = true;
            this.scX.Location = new System.Drawing.Point(0, 0);
            this.scX.Name = "scX";
            // 
            // scX.Panel1
            // 
            this.scX.Panel1.Controls.Add(this.chkX);
            this.scX.Panel1.Padding = new System.Windows.Forms.Padding(7);
            // 
            // scX.Panel2
            // 
            this.scX.Panel2.Controls.Add(this.txtX);
            this.scX.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.scX.Size = new System.Drawing.Size(280, 30);
            this.scX.SplitterDistance = 29;
            this.scX.TabIndex = 0;
            // 
            // chkX
            // 
            this.chkX.AutoSize = true;
            this.chkX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkX.Location = new System.Drawing.Point(7, 7);
            this.chkX.Name = "chkX";
            this.chkX.Size = new System.Drawing.Size(15, 16);
            this.chkX.TabIndex = 0;
            this.chkX.UseVisualStyleBackColor = true;
            this.chkX.CheckedChanged += new System.EventHandler(this.chkX_CheckedChanged);
            // 
            // txtX
            // 
            this.txtX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtX.Enabled = false;
            this.txtX.Location = new System.Drawing.Point(5, 5);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(237, 20);
            this.txtX.TabIndex = 0;
            // 
            // scBaseValor
            // 
            this.scBaseValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBaseValor.Location = new System.Drawing.Point(0, 0);
            this.scBaseValor.Name = "scBaseValor";
            // 
            // scBaseValor.Panel1
            // 
            this.scBaseValor.Panel1.Controls.Add(this.scX);
            // 
            // scBaseValor.Panel2
            // 
            this.scBaseValor.Panel2.Controls.Add(this.scY);
            this.scBaseValor.Size = new System.Drawing.Size(561, 30);
            this.scBaseValor.SplitterDistance = 280;
            this.scBaseValor.TabIndex = 1;
            // 
            // scY
            // 
            this.scY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scY.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scY.IsSplitterFixed = true;
            this.scY.Location = new System.Drawing.Point(0, 0);
            this.scY.Name = "scY";
            // 
            // scY.Panel1
            // 
            this.scY.Panel1.Controls.Add(this.chkY);
            this.scY.Panel1.Padding = new System.Windows.Forms.Padding(7);
            // 
            // scY.Panel2
            // 
            this.scY.Panel2.Controls.Add(this.txtY);
            this.scY.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.scY.Size = new System.Drawing.Size(277, 30);
            this.scY.SplitterDistance = 28;
            this.scY.TabIndex = 1;
            // 
            // chkY
            // 
            this.chkY.AutoSize = true;
            this.chkY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkY.Location = new System.Drawing.Point(7, 7);
            this.chkY.Name = "chkY";
            this.chkY.Size = new System.Drawing.Size(14, 16);
            this.chkY.TabIndex = 0;
            this.chkY.UseVisualStyleBackColor = true;
            this.chkY.CheckedChanged += new System.EventHandler(this.chkY_CheckedChanged);
            // 
            // txtY
            // 
            this.txtY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtY.Enabled = false;
            this.txtY.Location = new System.Drawing.Point(5, 5);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(235, 20);
            this.txtY.TabIndex = 1;
            // 
            // scNombreValor
            // 
            this.scNombreValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scNombreValor.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scNombreValor.Location = new System.Drawing.Point(0, 0);
            this.scNombreValor.Name = "scNombreValor";
            // 
            // scNombreValor.Panel1
            // 
            this.scNombreValor.Panel1.Controls.Add(this.lblNombre);
            this.scNombreValor.Panel1.Padding = new System.Windows.Forms.Padding(7);
            // 
            // scNombreValor.Panel2
            // 
            this.scNombreValor.Panel2.Controls.Add(this.scBaseValor);
            this.scNombreValor.Size = new System.Drawing.Size(700, 30);
            this.scNombreValor.SplitterDistance = 135;
            this.scNombreValor.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(7, 7);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NombrePropiedad";
            // 
            // cProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.scNombreValor);
            this.Name = "cProperty";
            this.Size = new System.Drawing.Size(700, 30);
            this.scX.Panel1.ResumeLayout(false);
            this.scX.Panel1.PerformLayout();
            this.scX.Panel2.ResumeLayout(false);
            this.scX.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scX)).EndInit();
            this.scX.ResumeLayout(false);
            this.scBaseValor.Panel1.ResumeLayout(false);
            this.scBaseValor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBaseValor)).EndInit();
            this.scBaseValor.ResumeLayout(false);
            this.scY.Panel1.ResumeLayout(false);
            this.scY.Panel1.PerformLayout();
            this.scY.Panel2.ResumeLayout(false);
            this.scY.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scY)).EndInit();
            this.scY.ResumeLayout(false);
            this.scNombreValor.Panel1.ResumeLayout(false);
            this.scNombreValor.Panel1.PerformLayout();
            this.scNombreValor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scNombreValor)).EndInit();
            this.scNombreValor.ResumeLayout(false);
            this.ResumeLayout(false);

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

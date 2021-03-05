namespace Utilities.Controls.HerramientaTextos
{
    partial class frmBuscarRemplazar
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
            this.btRemplazarTodo = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtRemplazar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblRemplazar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRemplazarTodo
            // 
            this.btRemplazarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemplazarTodo.Location = new System.Drawing.Point(273, 65);
            this.btRemplazarTodo.Name = "btRemplazarTodo";
            this.btRemplazarTodo.Size = new System.Drawing.Size(106, 23);
            this.btRemplazarTodo.TabIndex = 2;
            this.btRemplazarTodo.Text = "Reemplazar Todo";
            this.btRemplazarTodo.UseVisualStyleBackColor = true;
            this.btRemplazarTodo.Click += new System.EventHandler(this.btRemplazarTodo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(78, 6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(301, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // txtRemplazar
            // 
            this.txtRemplazar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemplazar.Location = new System.Drawing.Point(78, 39);
            this.txtRemplazar.Name = "txtRemplazar";
            this.txtRemplazar.Size = new System.Drawing.Size(301, 20);
            this.txtRemplazar.TabIndex = 5;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(9, 9);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblRemplazar
            // 
            this.lblRemplazar.AutoSize = true;
            this.lblRemplazar.Location = new System.Drawing.Point(9, 42);
            this.lblRemplazar.Name = "lblRemplazar";
            this.lblRemplazar.Size = new System.Drawing.Size(63, 13);
            this.lblRemplazar.TabIndex = 7;
            this.lblRemplazar.Text = "Reemplazar";
            // 
            // frmBuscarRemplazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 93);
            this.Controls.Add(this.lblRemplazar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtRemplazar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btRemplazarTodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1024, 127);
            this.MinimumSize = new System.Drawing.Size(16, 127);
            this.Name = "frmBuscarRemplazar";
            this.Text = "BuscarRemplazar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRemplazarTodo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtRemplazar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblRemplazar;
    }
}
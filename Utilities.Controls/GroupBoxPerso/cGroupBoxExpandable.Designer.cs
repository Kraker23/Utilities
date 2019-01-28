namespace Utilities.Controls.GroupBoxPerso
{
    partial class cGroupBoxExpandable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.group = new System.Windows.Forms.GroupBox();
            this.btExpandable = new System.Windows.Forms.Button();
            this.chk = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.group);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 241);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // group
            // 
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.checkBox2);
            this.group.Controls.Add(this.button2);
            this.group.Controls.Add(this.chk);
            this.group.Controls.Add(this.btExpandable);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(492, 241);
            this.group.TabIndex = 1;
            this.group.TabStop = false;
            // 
            // btExpandable
            // 
            this.btExpandable.BackColor = System.Drawing.Color.White;
            this.btExpandable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExpandable.Location = new System.Drawing.Point(0, 0);
            this.btExpandable.Name = "btExpandable";
            this.btExpandable.Size = new System.Drawing.Size(24, 20);
            this.btExpandable.TabIndex = 0;
            this.btExpandable.Tag = "btExpandable";
            this.btExpandable.Text = "-";
            this.btExpandable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExpandable.UseVisualStyleBackColor = false;
            this.btExpandable.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Checked = true;
            this.chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk.Location = new System.Drawing.Point(30, 3);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(59, 17);
            this.chk.TabIndex = 1;
            this.chk.Text = "Activar";
            this.chk.UseVisualStyleBackColor = true;
            this.chk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(344, 133);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // cGroupBoxExpandable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "cGroupBoxExpandable";
            this.Size = new System.Drawing.Size(492, 241);
            this.Load += new System.EventHandler(this.cGroupBoxExpandable_Load);
            this.panel1.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button btExpandable;
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
    }
}

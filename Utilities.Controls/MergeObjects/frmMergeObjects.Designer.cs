
namespace Utilities.Controls.MergeObjects
{
    partial class frmMergeObjects
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
            this.gbDiferents = new System.Windows.Forms.GroupBox();
            this.pDiferents = new System.Windows.Forms.Panel();
            this.scComparador = new System.Windows.Forms.SplitContainer();
            this.gbSame = new System.Windows.Forms.GroupBox();
            this.pSame = new System.Windows.Forms.Panel();
            this.scGeneral = new System.Windows.Forms.SplitContainer();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.cPropertyName = new Utilities.Controls.MergeObjects.cProperty();
            this.gbDiferents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scComparador)).BeginInit();
            this.scComparador.Panel1.SuspendLayout();
            this.scComparador.Panel2.SuspendLayout();
            this.scComparador.SuspendLayout();
            this.gbSame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).BeginInit();
            this.scGeneral.Panel1.SuspendLayout();
            this.scGeneral.Panel2.SuspendLayout();
            this.scGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDiferents
            // 
            this.gbDiferents.Controls.Add(this.pDiferents);
            this.gbDiferents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDiferents.Location = new System.Drawing.Point(0, 0);
            this.gbDiferents.Name = "gbDiferents";
            this.gbDiferents.Size = new System.Drawing.Size(545, 171);
            this.gbDiferents.TabIndex = 0;
            this.gbDiferents.TabStop = false;
            this.gbDiferents.Text = "Propiedades Diferentes";
            // 
            // pDiferents
            // 
            this.pDiferents.AutoScroll = true;
            this.pDiferents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDiferents.Location = new System.Drawing.Point(3, 16);
            this.pDiferents.Name = "pDiferents";
            this.pDiferents.Size = new System.Drawing.Size(539, 152);
            this.pDiferents.TabIndex = 0;
            // 
            // scComparador
            // 
            this.scComparador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scComparador.Location = new System.Drawing.Point(0, 30);
            this.scComparador.Name = "scComparador";
            this.scComparador.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scComparador.Panel1
            // 
            this.scComparador.Panel1.Controls.Add(this.gbDiferents);
            // 
            // scComparador.Panel2
            // 
            this.scComparador.Panel2.Controls.Add(this.gbSame);
            this.scComparador.Size = new System.Drawing.Size(545, 260);
            this.scComparador.SplitterDistance = 171;
            this.scComparador.TabIndex = 1;
            // 
            // gbSame
            // 
            this.gbSame.Controls.Add(this.pSame);
            this.gbSame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSame.Location = new System.Drawing.Point(0, 0);
            this.gbSame.Name = "gbSame";
            this.gbSame.Size = new System.Drawing.Size(545, 85);
            this.gbSame.TabIndex = 1;
            this.gbSame.TabStop = false;
            this.gbSame.Text = "Propiedades Iguales";
            // 
            // pSame
            // 
            this.pSame.AutoScroll = true;
            this.pSame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSame.Location = new System.Drawing.Point(3, 16);
            this.pSame.Name = "pSame";
            this.pSame.Size = new System.Drawing.Size(539, 66);
            this.pSame.TabIndex = 0;
            // 
            // scGeneral
            // 
            this.scGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scGeneral.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scGeneral.IsSplitterFixed = true;
            this.scGeneral.Location = new System.Drawing.Point(0, 0);
            this.scGeneral.Name = "scGeneral";
            this.scGeneral.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scGeneral.Panel1
            // 
            this.scGeneral.Panel1.Controls.Add(this.scComparador);
            this.scGeneral.Panel1.Controls.Add(this.cPropertyName);
            // 
            // scGeneral.Panel2
            // 
            this.scGeneral.Panel2.Controls.Add(this.btCancelar);
            this.scGeneral.Panel2.Controls.Add(this.btAceptar);
            this.scGeneral.Size = new System.Drawing.Size(545, 324);
            this.scGeneral.SplitterDistance = 290;
            this.scGeneral.TabIndex = 2;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(458, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.Location = new System.Drawing.Point(377, 4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // cPropertyName
            // 
            this.cPropertyName.BackColor = System.Drawing.SystemColors.Control;
            this.cPropertyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cPropertyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cPropertyName.Location = new System.Drawing.Point(0, 0);
            this.cPropertyName.Name = "cPropertyName";
            this.cPropertyName.propMerge = null;
            this.cPropertyName.Size = new System.Drawing.Size(545, 30);
            this.cPropertyName.TabIndex = 2;
            this.cPropertyName.CheckXEvento += new Utilities.Controls.MergeObjects.cProperty.CheckEvento(this.cPropertyName_CheckXEvento);
            this.cPropertyName.CheckYEvento += new Utilities.Controls.MergeObjects.cProperty.CheckEvento(this.cPropertyName_CheckYEvento);
            // 
            // frmMergeObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 324);
            this.Controls.Add(this.scGeneral);
            this.MinimumSize = new System.Drawing.Size(561, 363);
            this.Name = "frmMergeObjects";
            this.Text = "Merge Objects";
            this.gbDiferents.ResumeLayout(false);
            this.scComparador.Panel1.ResumeLayout(false);
            this.scComparador.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scComparador)).EndInit();
            this.scComparador.ResumeLayout(false);
            this.gbSame.ResumeLayout(false);
            this.scGeneral.Panel1.ResumeLayout(false);
            this.scGeneral.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scGeneral)).EndInit();
            this.scGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDiferents;
        private System.Windows.Forms.SplitContainer scComparador;
        private System.Windows.Forms.GroupBox gbSame;
        private System.Windows.Forms.SplitContainer scGeneral;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Panel pDiferents;
        private System.Windows.Forms.Panel pSame;
        private cProperty cPropertyName;
    }
}
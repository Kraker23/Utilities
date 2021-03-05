namespace Utilities.Controls.HerramientaTextos
{
    partial class frmTextReplace
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tsbDataService = new System.Windows.Forms.Button();
            this.btpPasteReplace = new System.Windows.Forms.Button();
            this.btnDuplicar = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.pReemplazos = new System.Windows.Forms.Panel();
            this.cReemplazarTexto = new cReemplazarTexto();
            this.btnEliminarFilasBlancas = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.lblReemplazos = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pReemplazos.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tsbDataService);
            this.splitContainer1.Panel1.Controls.Add(this.btpPasteReplace);
            this.splitContainer1.Panel1.Controls.Add(this.btnDuplicar);
            this.splitContainer1.Panel1.Controls.Add(this.btnDel);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.btnReemplazar);
            this.splitContainer1.Panel1.Controls.Add(this.pReemplazos);
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminarFilasBlancas);
            this.splitContainer1.Panel1.Controls.Add(this.btnTrim);
            this.splitContainer1.Panel1.Controls.Add(this.lblReemplazos);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTexto);
            this.splitContainer1.Size = new System.Drawing.Size(627, 440);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // tsbDataService
            // 
            this.tsbDataService.Image = global::Utilities.Controls.Properties.Resources.text_binary1;
            this.tsbDataService.Location = new System.Drawing.Point(51, 3);
            this.tsbDataService.Name = "tsbDataService";
            this.tsbDataService.Size = new System.Drawing.Size(25, 23);
            this.tsbDataService.TabIndex = 10;
            this.toolTip1.SetToolTip(this.tsbDataService, "Tratar texto cliente de DataService, para evitar\r\nlos estados de modificación sin" +
        " estar modificado.");
            this.tsbDataService.UseVisualStyleBackColor = true;
            this.tsbDataService.Click += new System.EventHandler(this.tsbDataService_Click);
            // 
            // btpPasteReplace
            // 
            this.btpPasteReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btpPasteReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpPasteReplace.Image = global::Utilities.Controls.Properties.Resources.bookmark_add;
            this.btpPasteReplace.Location = new System.Drawing.Point(139, 19);
            this.btpPasteReplace.Name = "btpPasteReplace";
            this.btpPasteReplace.Size = new System.Drawing.Size(25, 23);
            this.btpPasteReplace.TabIndex = 9;
            this.btpPasteReplace.UseVisualStyleBackColor = true;
            this.btpPasteReplace.Click += new System.EventHandler(this.btpPasteReplace_Click);
            // 
            // btnDuplicar
            // 
            this.btnDuplicar.Image = global::Utilities.Controls.Properties.Resources.documents_gear;
            this.btnDuplicar.Location = new System.Drawing.Point(110, 3);
            this.btnDuplicar.Name = "btnDuplicar";
            this.btnDuplicar.Size = new System.Drawing.Size(25, 23);
            this.btnDuplicar.TabIndex = 8;
            this.btnDuplicar.UseVisualStyleBackColor = true;
            this.btnDuplicar.Click += new System.EventHandler(this.btnDuplicar_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Image = global::Utilities.Controls.Properties.Resources.delete2;
            this.btnDel.Location = new System.Drawing.Point(187, 19);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(25, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Utilities.Controls.Properties.Resources.add2;
            this.btnAdd.Location = new System.Drawing.Point(163, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Image = global::Utilities.Controls.Properties.Resources.document_exchange;
            this.btnReemplazar.Location = new System.Drawing.Point(79, 3);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(25, 23);
            this.btnReemplazar.TabIndex = 5;
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // pReemplazos
            // 
            this.pReemplazos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pReemplazos.AutoScroll = true;
            this.pReemplazos.Controls.Add(this.cReemplazarTexto);
            this.pReemplazos.Location = new System.Drawing.Point(6, 45);
            this.pReemplazos.Name = "pReemplazos";
            this.pReemplazos.Size = new System.Drawing.Size(207, 392);
            this.pReemplazos.TabIndex = 4;
            // 
            // ctlReemplazo
            // 
            this.cReemplazarTexto.Buscar = "";
            this.cReemplazarTexto.Dock = System.Windows.Forms.DockStyle.Top;
            this.cReemplazarTexto.Location = new System.Drawing.Point(0, 0);
            this.cReemplazarTexto.Name = "ctlReemplazo";
            this.cReemplazarTexto.Orden = -1;
            this.cReemplazarTexto.Reemplazar = "";
            this.cReemplazarTexto.Size = new System.Drawing.Size(207, 55);
            this.cReemplazarTexto.TabIndex = 4;
            // 
            // btnEliminarFilasBlancas
            // 
            this.btnEliminarFilasBlancas.Image = global::Utilities.Controls.Properties.Resources.text_align_justified;
            this.btnEliminarFilasBlancas.Location = new System.Drawing.Point(3, 3);
            this.btnEliminarFilasBlancas.Name = "btnEliminarFilasBlancas";
            this.btnEliminarFilasBlancas.Size = new System.Drawing.Size(25, 23);
            this.btnEliminarFilasBlancas.TabIndex = 2;
            this.btnEliminarFilasBlancas.UseVisualStyleBackColor = true;
            this.btnEliminarFilasBlancas.Click += new System.EventHandler(this.btnEliminarFilasBlancas_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Image = global::Utilities.Controls.Properties.Resources.text_align_center;
            this.btnTrim.Location = new System.Drawing.Point(27, 3);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(25, 23);
            this.btnTrim.TabIndex = 1;
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // lblReemplazos
            // 
            this.lblReemplazos.AutoSize = true;
            this.lblReemplazos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReemplazos.Location = new System.Drawing.Point(3, 29);
            this.lblReemplazos.Name = "lblReemplazos";
            this.lblReemplazos.Size = new System.Drawing.Size(75, 13);
            this.lblReemplazos.TabIndex = 0;
            this.lblReemplazos.Text = "Reemplazos";
            // 
            // txtTexto
            // 
            this.txtTexto.AcceptsReturn = true;
            this.txtTexto.AcceptsTab = true;
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTexto.Location = new System.Drawing.Point(0, 0);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTexto.Size = new System.Drawing.Size(408, 440);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.WordWrap = false;
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            this.txtTexto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyUp);
            // 
            // frmTextReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 440);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTextReplace";
            this.Text = "frmTextReplace";
            this.Load += new System.EventHandler(this.frmTextReplace_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pReemplazos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Label lblReemplazos;
        private System.Windows.Forms.Button btnEliminarFilasBlancas;
        private System.Windows.Forms.Panel pReemplazos;
        private cReemplazarTexto cReemplazarTexto;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDuplicar;
        private System.Windows.Forms.Button btpPasteReplace;
        private System.Windows.Forms.Button tsbDataService;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
namespace UtilitiesNet.Controls.HerramientaTextos
{
    partial class frmStrEncrypt
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbbEncrypt = new System.Windows.Forms.ToolStripButton();
            this.tbbDecrypt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbEncryptAES = new System.Windows.Forms.ToolStripButton();
            this.tbbDecryptAES = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbEncryptURL = new System.Windows.Forms.ToolStripButton();
            this.tbbDecryptUrl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbToUrlEncoding = new System.Windows.Forms.ToolStripButton();
            this.tbbToUrlDecoding = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbEncrypt,
            this.tbbDecrypt,
            this.toolStripSeparator3,
            this.tbbEncryptAES,
            this.tbbDecryptAES,
            this.toolStripSeparator1,
            this.tbbEncryptURL,
            this.tbbDecryptUrl,
            this.toolStripSeparator2,
            this.tbbToUrlEncoding,
            this.tbbToUrlDecoding});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(419, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbbEncrypt
            // 
            this.tbbEncrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbEncrypt.Image = global::UtilitiesNet.Controls.Properties.Resources.text_marked;
            this.tbbEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbEncrypt.Name = "tbbEncrypt";
            this.tbbEncrypt.Size = new System.Drawing.Size(23, 22);
            this.tbbEncrypt.Text = "Encrypt text";
            this.tbbEncrypt.Click += new System.EventHandler(this.tbbEncrypt_Click);
            // 
            // tbbDecrypt
            // 
            this.tbbDecrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbDecrypt.Image = global::UtilitiesNet.Controls.Properties.Resources.text_binary1;
            this.tbbDecrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbDecrypt.Name = "tbbDecrypt";
            this.tbbDecrypt.Size = new System.Drawing.Size(23, 22);
            this.tbbDecrypt.Text = "Decrypt text";
            this.tbbDecrypt.Click += new System.EventHandler(this.tbbDecrypt_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbEncryptAES
            // 
            this.tbbEncryptAES.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbEncryptAES.Image = global::UtilitiesNet.Controls.Properties.Resources.scroll_run;
            this.tbbEncryptAES.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbEncryptAES.Name = "tbbEncryptAES";
            this.tbbEncryptAES.Size = new System.Drawing.Size(23, 22);
            this.tbbEncryptAES.Text = "toolStripButton2";
            this.tbbEncryptAES.Click += new System.EventHandler(this.tbbEncryptAES_Click);
            // 
            // tbbDecryptAES
            // 
            this.tbbDecryptAES.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbDecryptAES.Image = global::UtilitiesNet.Controls.Properties.Resources.scroll_replace;
            this.tbbDecryptAES.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbDecryptAES.Name = "tbbDecryptAES";
            this.tbbDecryptAES.Size = new System.Drawing.Size(23, 22);
            this.tbbDecryptAES.Text = "toolStripButton1";
            this.tbbDecryptAES.Click += new System.EventHandler(this.tbbDecryptAES_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbEncryptURL
            // 
            this.tbbEncryptURL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbEncryptURL.Image = global::UtilitiesNet.Controls.Properties.Resources.form_red;
            this.tbbEncryptURL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbEncryptURL.Name = "tbbEncryptURL";
            this.tbbEncryptURL.Size = new System.Drawing.Size(23, 22);
            this.tbbEncryptURL.Text = "Encrypt text for url";
            this.tbbEncryptURL.Click += new System.EventHandler(this.tbbEncryptURL_Click);
            // 
            // tbbDecryptUrl
            // 
            this.tbbDecryptUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbDecryptUrl.Image = global::UtilitiesNet.Controls.Properties.Resources.form_green;
            this.tbbDecryptUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbDecryptUrl.Name = "tbbDecryptUrl";
            this.tbbDecryptUrl.Size = new System.Drawing.Size(23, 22);
            this.tbbDecryptUrl.Text = "Decrypt text from url";
            this.tbbDecryptUrl.Click += new System.EventHandler(this.tbbDecryptUrl_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbToUrlEncoding
            // 
            this.tbbToUrlEncoding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbToUrlEncoding.Image = global::UtilitiesNet.Controls.Properties.Resources.earth_network;
            this.tbbToUrlEncoding.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbToUrlEncoding.Name = "tbbToUrlEncoding";
            this.tbbToUrlEncoding.Size = new System.Drawing.Size(23, 22);
            this.tbbToUrlEncoding.Text = "Encrypt to Url";
            this.tbbToUrlEncoding.Click += new System.EventHandler(this.tbbToUrlEncoding_Click);
            // 
            // tbbToUrlDecoding
            // 
            this.tbbToUrlDecoding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbToUrlDecoding.Image = global::UtilitiesNet.Controls.Properties.Resources.environment_network;
            this.tbbToUrlDecoding.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbToUrlDecoding.Name = "tbbToUrlDecoding";
            this.tbbToUrlDecoding.Size = new System.Drawing.Size(23, 22);
            this.tbbToUrlDecoding.Text = "Decrypt for Url";
            this.tbbToUrlDecoding.Click += new System.EventHandler(this.tbbToUrlDecoding_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtOrigin);
            this.splitContainer1.Panel1.Controls.Add(this.Result);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(419, 305);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtOrigin
            // 
            this.txtOrigin.AcceptsReturn = true;
            this.txtOrigin.AcceptsTab = true;
            this.txtOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrigin.Location = new System.Drawing.Point(0, 13);
            this.txtOrigin.MaxLength = 999999999;
            this.txtOrigin.Multiline = true;
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(204, 292);
            this.txtOrigin.TabIndex = 1;
            this.txtOrigin.WordWrap = false;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Dock = System.Windows.Forms.DockStyle.Top;
            this.Result.Location = new System.Drawing.Point(0, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(34, 13);
            this.Result.TabIndex = 0;
            this.Result.Text = "Origin";
            // 
            // txtResult
            // 
            this.txtResult.AcceptsReturn = true;
            this.txtResult.AcceptsTab = true;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 13);
            this.txtResult.MaxLength = 999999999;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(211, 292);
            this.txtResult.TabIndex = 2;
            this.txtResult.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // frmStrEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 330);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmStrEncrypt";
            this.Text = "Encrypt & Decrypt";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbbEncrypt;
        private System.Windows.Forms.ToolStripButton tbbDecrypt;
        private System.Windows.Forms.ToolStripButton tbbToUrlEncoding;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbbToUrlDecoding;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbbEncryptURL;
        private System.Windows.Forms.ToolStripButton tbbDecryptUrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbbEncryptAES;
        private System.Windows.Forms.ToolStripButton tbbDecryptAES;
    }
}
namespace doguAkdenizApp
{
    partial class browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(browser));
            this.toolStripBrowser = new System.Windows.Forms.ToolStrip();
            this.txtBrowserUrl = new System.Windows.Forms.ToolStripTextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnBrowserProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.btnBrowserBack = new System.Windows.Forms.ToolStripButton();
            this.btnBrowserForward = new System.Windows.Forms.ToolStripButton();
            this.btnBrowserRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnBrowserStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnBrowserGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripBrowser
            // 
            this.toolStripBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBrowserBack,
            this.btnBrowserForward,
            this.btnBrowserRefresh,
            this.btnBrowserStop,
            this.toolStripButton2,
            this.btnBrowserGo,
            this.txtBrowserUrl,
            this.btnBrowserProgress});
            this.toolStripBrowser.Location = new System.Drawing.Point(0, 0);
            this.toolStripBrowser.Name = "toolStripBrowser";
            this.toolStripBrowser.Size = new System.Drawing.Size(854, 25);
            this.toolStripBrowser.TabIndex = 0;
            this.toolStripBrowser.Text = "toolStrip1";
            // 
            // txtBrowserUrl
            // 
            this.txtBrowserUrl.Name = "txtBrowserUrl";
            this.txtBrowserUrl.Size = new System.Drawing.Size(300, 25);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 29);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(854, 425);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Url = new System.Uri("https://drive.google.com/drive/folders/0BwRFx2DAiJjUSWtmWU5DelRJaEU?usp=sharing", System.UriKind.Absolute);
            this.webBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser_ProgressChanged);
            // 
            // btnBrowserProgress
            // 
            this.btnBrowserProgress.Name = "btnBrowserProgress";
            this.btnBrowserProgress.Size = new System.Drawing.Size(50, 22);
            // 
            // btnBrowserBack
            // 
            this.btnBrowserBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBrowserBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowserBack.Image")));
            this.btnBrowserBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrowserBack.Name = "btnBrowserBack";
            this.btnBrowserBack.Size = new System.Drawing.Size(23, 22);
            this.btnBrowserBack.Text = "Geri";
            this.btnBrowserBack.Click += new System.EventHandler(this.btnBrowserBack_Click);
            // 
            // btnBrowserForward
            // 
            this.btnBrowserForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBrowserForward.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowserForward.Image")));
            this.btnBrowserForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrowserForward.Name = "btnBrowserForward";
            this.btnBrowserForward.Size = new System.Drawing.Size(23, 22);
            this.btnBrowserForward.Text = "İleri";
            this.btnBrowserForward.Click += new System.EventHandler(this.btnBrowserForward_Click);
            // 
            // btnBrowserRefresh
            // 
            this.btnBrowserRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBrowserRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowserRefresh.Image")));
            this.btnBrowserRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrowserRefresh.Name = "btnBrowserRefresh";
            this.btnBrowserRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnBrowserRefresh.Text = "Yenile";
            this.btnBrowserRefresh.Click += new System.EventHandler(this.btnBrowserRefresh_Click);
            // 
            // btnBrowserStop
            // 
            this.btnBrowserStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBrowserStop.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowserStop.Image")));
            this.btnBrowserStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrowserStop.Name = "btnBrowserStop";
            this.btnBrowserStop.Size = new System.Drawing.Size(23, 22);
            this.btnBrowserStop.Text = "Durdur";
            this.btnBrowserStop.Click += new System.EventHandler(this.btnBrowserStop_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Ana Sayfa";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnBrowserGo
            // 
            this.btnBrowserGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBrowserGo.Image = global::doguAkdenizApp.Properties.Resources.right_arrow__1_;
            this.btnBrowserGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrowserGo.Name = "btnBrowserGo";
            this.btnBrowserGo.Size = new System.Drawing.Size(23, 22);
            this.btnBrowserGo.Text = "Git";
            this.btnBrowserGo.Click += new System.EventHandler(this.btnBrowserGo_Click);
            // 
            // browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 536);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.toolStripBrowser);
            this.Name = "browser";
            this.Text = "Tarayıcı : Doğu Akdeniz Araştırma Derneği";
            this.toolStripBrowser.ResumeLayout(false);
            this.toolStripBrowser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripBrowser;
        private System.Windows.Forms.ToolStripButton btnBrowserBack;
        private System.Windows.Forms.ToolStripButton btnBrowserForward;
        private System.Windows.Forms.ToolStripButton btnBrowserRefresh;
        private System.Windows.Forms.ToolStripButton btnBrowserGo;
        private System.Windows.Forms.ToolStripTextBox txtBrowserUrl;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripButton btnBrowserStop;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripProgressBar btnBrowserProgress;
    }
}
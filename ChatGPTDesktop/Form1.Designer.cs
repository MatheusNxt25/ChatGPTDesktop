namespace ChatGPTDesktop
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStrip1 = new ToolStrip();
            btnRefresh = new ToolStripButton();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnShow = new ToolStripMenuItem();
            btnQuit = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(0, 28);
            webView.Name = "webView";
            webView.Size = new Size(639, 585);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnRefresh });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(639, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(23, 22);
            btnRefresh.Text = "toolStripButton1";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { btnShow, btnQuit });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 48);
            // 
            // btnShow
            // 
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(103, 22);
            btnShow.Text = "Show";
            // 
            // btnQuit
            // 
            btnQuit.Image = (Image)resources.GetObject("btnQuit.Image");
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(103, 22);
            btnQuit.Text = "Quit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 612);
            Controls.Add(toolStrip1);
            Controls.Add(webView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ChatGPT Desk";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private ToolStrip toolStrip1;
        private ToolStripButton btnRefresh;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem btnShow;
        private ToolStripMenuItem btnQuit;
    }
}
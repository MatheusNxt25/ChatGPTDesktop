namespace ChatGPTDesktop
{
    public partial class Form1 : Form
    {
        bool _allowedToclose;

        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_allowedToclose)
            {
                base.OnFormClosing(e);

            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPage();
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            btnShow.Click += btnShow_Click;
            btnQuit.Click += BtnQuit_Click;

        }

        private void btnShow_Click(object? sender, EventArgs e)
        {
            ShowForm();
        }

        private void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.Focus();
        }

        private void BtnQuit_Click(object? sender, EventArgs e)
        {
            _allowedToclose = true;
            Application.Exit();
        }

        private async void LoadPage()
        {
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.Navigate("https://chat.openai.com/");

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
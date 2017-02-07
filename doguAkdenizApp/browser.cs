using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doguAkdenizApp
{
    public partial class browser : Form
    {
        public browser()
        {
            InitializeComponent();
        }

        private void btnBrowserGo_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtBrowserUrl.Text);
        }

        private void btnBrowserBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnBrowserForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnBrowserRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void btnBrowserStop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                btnBrowserProgress.Value = Convert.ToInt32(e.CurrentProgress);
                btnBrowserProgress.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
            catch (Exception ex)
            {
            }
        }
    }
}

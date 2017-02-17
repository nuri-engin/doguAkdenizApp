using System;
using System.Windows.Forms;

namespace doguAkdenizApp
{
    public partial class pano : Form
    {
        public pano(string logInfo)
        {
            InitializeComponent();
            lblPanoLogInfo.Text = logInfo;
            timerPano.Start();
        }

        /*static bool close_alert_shown = false;*/

        private void btnPanoEkip_Click(object sender, EventArgs e)
        {
            this.Hide();
            ekip ekipEkrani = new ekip(lblPanoLogInfo.Text);
            ekipEkrani.ShowDialog();
        }

        private void btnPanoUye_Click(object sender, EventArgs e)
        {
            this.Hide();
            uye uyeEkrani = new uye(lblPanoLogInfo.Text);
            uyeEkrani.ShowDialog();
        }

        private void timerPano_Tick(object sender, EventArgs e)
        {
           DateTime tarihSaat = DateTime.Now;
           this.lblPanoTime.Text = tarihSaat.ToString();
            
        }

        private void pano_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            DialogResult dialog = MessageBox.Show("Uygulamadan çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.FormClosing -= pano_FormClosing;
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            /*
            if (close_alert_shown) return;
            close_alert_shown = true;
            DialogResult dialog = MessageBox.Show("Uygulamadan çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
                close_alert_shown = false;
            }*/
        }
    }
}

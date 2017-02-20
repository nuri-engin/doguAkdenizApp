using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;

namespace doguAkdenizApp
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void btnGirisLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                string myConnection= "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
    
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("select * from doguAkdenizApp.login where username='" + this.txtGirisKullanici.Text + "' and password= '" + this.txtGirisSifre.Text + "'; ", myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    //MessageBox.Show("Giriş başarılı!", "Giriş Başarılı", MessageBoxButtons.OK);
                    this.Hide();
                    pano pano = new pano(txtGirisKullanici.Text);
                    pano.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Veri çakışması yaşanıyor, girdiğiniz bilgileri kontrol ediniz!");
                }
                else
                    MessageBox.Show("Hatalı giriş yaptınız!");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

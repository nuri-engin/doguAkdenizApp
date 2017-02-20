using MySql.Data.MySqlClient;
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
    public partial class proje : Form
    {
        public proje(string LogInfo)
        {
            InitializeComponent();
            lblProjeLoginfo.Text = LogInfo;
            loadTable();
            dgvProje.Columns[0].Width = 50;
            dtpProjeKayitTarihi.Value = DateTime.Now;
        }
        DataTable dbdataset;
        MySqlConnection myConn;
        MySqlDataAdapter myAdapter;
        BindingSource myBinding;
        MySqlCommand myCommand;
        void clearAllText()
        {
            txtProjeBaslik.Text = "";
            txtProjeOzet.Text = "";
            txtProjeSorumlu.Text = "";
            txtProjeSorumluIletisim.Text = "";
            txtProjeFonOrg.Text = "";
            txtProjeFonTutar.Text = "";
            txtProjePartner.Text = "";
            txtProjeLokasyon.Text = "";
            dtpProjeKayitTarihi.Text = "";
        } 

        private void loadTable()
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            myConn = new MySqlConnection(myConnection);
            myCommand = new MySqlCommand("Select id as 'ID',title as 'Baslik', abstract as 'Ozet', location as 'Lokasyon', assign as 'Sorumlu', assigncontact as 'SorumluIletisimi', fundorganisation as 'FonOrganizasyonu', fundamount as 'FonTutari', partner as 'Partner', recorddate as 'KayitTarihi', username as 'Yetkili' from doguAkdenizApp.projects", myConn);
            try
            {
                myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                dbdataset = new DataTable();
                myAdapter.Fill(dbdataset);
                myBinding = new BindingSource();
                myBinding.DataSource = dbdataset;
                dgvProje.DataSource = myBinding;
                myAdapter.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProjePano_Click(object sender, EventArgs e)
        {
            this.Hide();
            pano panoEkrani = new pano(lblProjeLoginfo.Text);
            panoEkrani.ShowDialog();
        }

        private void btnProjeKaydet_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            string Query = "insert into doguAkdenizApp.projects (title,abstract,location,assign,assigncontact,fundorganisation,fundamount,partner,recorddate,username)values('" + this.txtProjeBaslik.Text + "','" + this.txtProjeOzet.Text + "','" + this.txtProjeLokasyon.Text + "','" + this.txtProjeSorumlu.Text + "','" + this.txtProjeSorumluIletisim.Text + "','" + this.txtProjeFonOrg.Text + "','" + this.txtProjeFonTutar.Text + "','" + this.txtProjePartner.Text + "','" + this.dtpProjeKayitTarihi.Text + "','" + this.lblProjeLoginfo.Text + "');";
            myConn = new MySqlConnection(myConnection);
            myCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Kayıt Başarılı!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnProjeGuncelle_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            string Query = "update doguAkdenizApp.projects set title='" + this.txtProjeBaslik.Text + "',abstract='" + this.txtProjeOzet.Text + "',location='" + this.txtProjeLokasyon.Text + "',assign='" + this.txtProjeSorumlu.Text + "',assigncontact='" + this.txtProjeSorumluIletisim.Text + "',fundorganisation='" + this.txtProjeFonOrg.Text + "',fundamount='" + this.txtProjeFonTutar.Text + "',partner='" + this.txtProjePartner.Text + "',recorddate='" + this.dtpProjeKayitTarihi.Text + "',username='" + lblProjeLoginfo.Text + "' where id='" + this.lblProjeID.Text + "'";
            myConn = new MySqlConnection(myConnection);
            myCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Güncelleme başarılı!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnProjeSil_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            string Query = "delete from doguAkdenizApp.projects where id='" + this.lblProjeID.Text + "'";
            myConn = new MySqlConnection(myConnection);
            myCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myreader;
            try
            {
                myConn.Open();
                myreader = myCommand.ExecuteReader();
                MessageBox.Show("Silme işlemi başarılı!");
                while (myreader.Read()) { }
                clearAllText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnProjeYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnProjeTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnProjeAra_Click(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Baslik LIKE '%{0}%' OR Ozet LIKE '%{0}%' OR Lokasyon LIKE '%{0}%' OR Sorumlu LIKE '%{0}%' OR FonOrganizasyonu LIKE '%{0}%' OR FonTutari LIKE '%{0}%' OR Partner LIKE '%{0}%'", txtProjeAra.Text);
            dgvProje.DataSource = DV;
        }

        private void btnProjeYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void dgvProje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProje.Rows[e.RowIndex];
                lblProjeID.Text = row.Cells["ID"].Value.ToString();
                txtProjeBaslik.Text = row.Cells["Baslik"].Value.ToString();
                txtProjeOzet.Text = row.Cells["Ozet"].Value.ToString();
                txtProjeLokasyon.Text = row.Cells["Lokasyon"].Value.ToString();
                txtProjeSorumlu.Text = row.Cells["Sorumlu"].Value.ToString();
                txtProjeSorumluIletisim.Text = row.Cells["SorumluIletisimi"].Value.ToString();
                txtProjeFonOrg.Text = row.Cells["FonOrganizasyonu"].Value.ToString();
                txtProjeFonTutar.Text = row.Cells["FonTutari"].Value.ToString();
                txtProjePartner.Text = row.Cells["Partner"].Value.ToString();
                dtpProjeKayitTarihi.Text = row.Cells["KayitTarihi"].Value.ToString();
            }
        }

        private void picProjeDrive_Click(object sender, EventArgs e)
        {
            browser tarayici = new browser();
            tarayici.ShowDialog();
        }

        private void cmsProjeItemYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void cmsProjeItemTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void cmsProjeItemYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}

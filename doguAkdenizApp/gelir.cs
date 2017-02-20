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
    public partial class gelir : Form
    {
        public gelir(string LogInfo)
        {
            InitializeComponent();
            lblGelirLoginfo.Text = LogInfo;
            loadTable();
            dtpGelirKayitTarihi.Value = DateTime.Now;
            dgvGelir.Columns[0].Width = 50;
            dgvGelir.Columns[4].Width = 150;
        }

        DataTable dbdataset;

        void clearAllText()
        {
            txtGelirIsim.Text = "";
            txtGelirSoyisim.Text = "";
            cbGelirTuru.Text = "";
            txtGelirOzet.Text = "";
        }

        private void loadTable()
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand("select id as 'ID', name as 'Isim', surname as 'Soyisim', type as 'Turu', summary as 'Ozet',recorddate as 'KayitTarihi',username as 'Yetkili' from doguAkdenizApp.income;", myConn);
            try
            {
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                dbdataset = new DataTable();
                myAdapter.Fill(dbdataset);
                BindingSource myBinding = new BindingSource();
                myBinding.DataSource = dbdataset;
                dgvGelir.DataSource = myBinding;
                myAdapter.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGelirPano_Click(object sender, EventArgs e)
        {
            this.Hide();
            pano panoEkrani = new pano(lblGelirLoginfo.Text);
            panoEkrani.ShowDialog();
        }

        private void btnGelirKaydet_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "insert into doguAkdenizApp.income(name,surname,type,summary,recorddate,username)values('" + this.txtGelirIsim.Text + "','" + this.txtGelirSoyisim.Text + "','" + this.cbGelirTuru.Text + "','" + this.txtGelirOzet.Text + "','" + this.dtpGelirKayitTarihi.Text + "','" + this.lblGelirLoginfo.Text + "')";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Kayit basarili!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnGelirGuncelle_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "update doguAkdenizApp.income set name='" + this.txtGelirIsim.Text + "',surname='" + this.txtGelirSoyisim.Text + "',type='" + this.cbGelirTuru.Text + "',summary='" + this.txtGelirOzet.Text + "',recorddate='" + this.dtpGelirKayitTarihi.Text + "',username='" + this.lblGelirLoginfo.Text + "' where id='" + this.lblGelirID.Text + "'";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Güncelleme basarili!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnGelirSil_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "delete from doguAkdenizApp.income where id='" + this.lblGelirID.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Silme islemi basarili!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnGelirYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnGelirYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnGelirTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnGelirAra_Click(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Isim LIKE '%{0}%' OR Soyisim LIKE '%{0}%' OR Turu LIKE '%{0}%' OR Ozet LIKE '%{0}%'", txtGelirAra.Text);
            dgvGelir.DataSource = DV;
        }

        private void dgvGelir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvGelir.Rows[e.RowIndex];
                lblGelirID.Text = row.Cells["ID"].Value.ToString();
                txtGelirIsim.Text = row.Cells["Isim"].Value.ToString();
                txtGelirSoyisim.Text = row.Cells["Soyisim"].Value.ToString();
                cbGelirTuru.Text = row.Cells["Turu"].Value.ToString();
                txtGelirOzet.Text = row.Cells["Ozet"].Value.ToString();
                dtpGelirKayitTarihi.Text = row.Cells["KayitTarihi"].Value.ToString();
            }
        }

        private void picGelirDrive_Click(object sender, EventArgs e)
        {
            browser tarayici = new browser();
            tarayici.ShowDialog();
        }

        private void cmsGelirItemYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void cmsGelirItemTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void cmsGelirItemYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}

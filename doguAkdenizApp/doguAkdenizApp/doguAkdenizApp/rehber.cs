using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doguAkdenizApp
{
    public partial class rehber : Form
    {
        public rehber(string LogInfo)
        {
            InitializeComponent();
            lblRehberLoginfo.Text = LogInfo;
            loadTable();
            dgvRehber.Columns[0].Width = 50;
            dtpRehberKayitTarihi.Value = DateTime.Now;
        }

        DataTable dbdataset;
        MySqlConnection myConn;
        MySqlDataAdapter myAdapter;
        BindingSource myBinding;
        MySqlCommand myCommand;

        void clearAllText()
        {
            txtRehberIsim.Text = "";
            txtRehberSoyisim.Text = "";
            txtRehberOrg.Text = "";
            cbRehberTur.Text = "";
            txtRehberTelefon.Text = "";
            txtRehberAdres.Text = "";
            txtRehberEposta.Text = "";
            cbRehberSehir.Text = "";
            dtpRehberKayitTarihi.Text = "";
        }

        private void loadTable()
        {
            string MyConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            myConn = new MySqlConnection(MyConnection);
            myCommand = new MySqlCommand("select id as 'ID', name as 'Isim', surname as 'Soyisim', email as 'ePosta', telephone as 'Telefon', organisation as 'Organizasyon', type as 'Turu', city as 'Sehir', adress as 'Adres', recorddate as 'KayitTarihi', username as 'Yetkili' from doguAkdenizApp.contact", myConn);
            try
            {
                myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                dbdataset = new DataTable();
                myAdapter.Fill(dbdataset);
                myBinding = new BindingSource();
                myBinding.DataSource = dbdataset;
                dgvRehber.DataSource = myBinding;
                myAdapter.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRehberKaydet_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            string Query = "insert into doguAkdenizApp.contact (name,surname,email,telephone,organisation,type,adress,city,recorddate,username)values('" + this.txtRehberIsim.Text + "','" + this.txtRehberSoyisim.Text + "','" + this.txtRehberEposta.Text + "','" + this.txtRehberTelefon.Text + "','" + this.txtRehberOrg.Text + "','" + this.cbRehberTur.Text + "','" + this.txtRehberAdres.Text + "','" + this.cbRehberSehir.Text + "','" + this.dtpRehberKayitTarihi.Text + "','" + this.lblRehberLoginfo.Text + "');";
            myConn = new MySqlConnection(myConnection);
            myCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Kayıt başarılı!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnRehberGuncelle_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            string Query = "update doguAkdenizApp.contact set name='" + this.txtRehberIsim.Text + "', surname='" + this.txtRehberSoyisim.Text + "',email='" + this.txtRehberEposta.Text + "',telephone='" + this.txtRehberTelefon.Text + "',organisation='" + this.txtRehberOrg.Text + "',type='" + this.cbRehberTur.Text + "',adress='" + this.txtRehberAdres.Text + "',city='" + this.cbRehberSehir.Text + "',recorddate='" + this.dtpRehberKayitTarihi.Text + "',username='" + this.lblRehberLoginfo.Text + "' where id='" + this.lblRehberID.Text + "'";
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

        private void btnRehberSil_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            string Query = "delete from doguAkdenizApp.contact where id='" + this.lblRehberID.Text + "'";
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

        private void btnRehberYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnRehberTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnRehberAra_Click(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Isim LIKE '%{0}%' OR Soyisim LIKE '%{0}%' OR Organizasyon LIKE '%{0}%' OR Turu LIKE '%{0}%' OR ePosta LIKE '%{0}%' OR Adres LIKE '%{0}%' OR Sehir LIKE '%{0}%'", txtRehberAra.Text);
            dgvRehber.DataSource = DV;
        }

        private void btnRehberYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void dgvRehber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvRehber.Rows[e.RowIndex];
                lblRehberID.Text = row.Cells["ID"].Value.ToString();
                txtRehberIsim.Text = row.Cells["Isim"].Value.ToString();
                txtRehberSoyisim.Text = row.Cells["Soyisim"].Value.ToString();
                txtRehberEposta.Text = row.Cells["ePosta"].Value.ToString();
                txtRehberTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtRehberOrg.Text = row.Cells["Organizasyon"].Value.ToString();
                cbRehberTur.Text = row.Cells["Turu"].Value.ToString();
                txtRehberAdres.Text = row.Cells["Adres"].Value.ToString();
                cbRehberSehir.Text = row.Cells["Sehir"].Value.ToString();
                dtpRehberKayitTarihi.Text = row.Cells["KayitTarihi"].Value.ToString();
               
            }
        }

        private void picRehberDrive_Click(object sender, EventArgs e)
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

        private void txtRehberEposta_Leave(object sender, EventArgs e)
        {
            Regex RX = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
            if (!RX.IsMatch(txtRehberEposta.Text))
            {
                MessageBox.Show("Hatalı bir ePosta adresi girdiniz!");
            }
        }

        private void btnRehberPano_Click(object sender, EventArgs e)
        {
            this.Hide();
            pano panoEkrani = new pano(lblRehberLoginfo.Text);
            panoEkrani.ShowDialog();
        }
    }
}

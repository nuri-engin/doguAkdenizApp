using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace doguAkdenizApp
{
    public partial class ekip : Form
    {
        public ekip(string logInfo)
        {
            InitializeComponent();
            lblEkipLoginfo.Text = logInfo;
            loadTable();
            dtpEkipKayitTarihi.Value = DateTime.Now;
            dgvEkip.Columns[0].Width = 50;
        }

        
        DataTable dbdataset;
        void clearAllTxt()
        {
            txtEkipIsim.Text = "";
            txtEkipSoyisim.Text = "";
            txtEkipTc.Text = "";
            dtpEkipDogum.Text = "";
            txtEkipTelefon.Text = "";
            txtEkipEposta.Text = "";
            cbEkipSehir.Text = "";
            txtEkipAdres.Text = "";
            lblEkipID.Text = "";
        }

        void loadTable()
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand("select id as 'ID',name as 'Isim',surname as 'Soyisim',idno as 'TCNo',birth as 'DoğumTarihi',telephone as 'Telefon',email as 'ePosta',city as 'Şehir',adress as 'Adres',title as 'Gorevi', recorddate as 'KayıtTarihi',username as 'Yetkili' from doguAkdenizApp.team;", myConn);
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                dataAdapter.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dgvEkip.DataSource = bSource;
                dataAdapter.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEkipPano_Click(object sender, EventArgs e)
        {
            this.Hide();
            pano panoEkrani = new pano(lblEkipLoginfo.Text);
            panoEkrani.ShowDialog();
        }

        private void btnEkipKaydet_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "insert into doguAkdenizApp.team (name,surname,idno,birth,telephone,email,city,adress,title,recorddate,username) values('" + this.txtEkipIsim.Text + "', '" + this.txtEkipSoyisim.Text + "', '" + this.txtEkipTc.Text + "', '" + this.dtpEkipDogum.Text + "', '" + this.txtEkipTelefon.Text + "', '" + this.txtEkipEposta.Text + "', '" + this.cbEkipSehir.Text + "', '" + this.txtEkipAdres.Text + "', '" + this.cbEkipGorev.Text + "', '" + this.dtpEkipKayitTarihi.Text+ "', '" + this.lblEkipLoginfo.Text + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Kayıt başarılı!");
                while (myReader.Read()) { }
                clearAllTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loadTable();

        }

        private void btnEkipGuncelle_Click(object sender, EventArgs e)
        {   
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "update doguAkdenizApp.team set name='" + this.txtEkipIsim.Text + "', surname='" + this.txtEkipSoyisim.Text + "', idno='" + this.txtEkipTc.Text + "', birth='" + this.dtpEkipDogum.Text + "', telephone='" + this.txtEkipTelefon.Text + "', email='" + this.txtEkipEposta.Text + "', city='" + this.cbEkipSehir.Text + "', adress='" + this.txtEkipAdres.Text + "', title='" + this.cbEkipGorev.Text + "', recorddate='" + this.dtpEkipKayitTarihi.Text + "', username='" + this.lblEkipLoginfo.Text + "' where id='" + this.lblEkipID.Text + "'";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Güncelleme başarılı!");
                while (myReader.Read()) { }
                clearAllTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
           
        }

        private void btnEkipSil_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "delete from doguAkdenizApp.team where id='" + this.lblEkipID.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Silme işlemi başarılı!");
                while (myReader.Read()) { }
                clearAllTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
            
        }

        private void btnEkipYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void dgvEkip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvEkip.Rows[e.RowIndex];
                lblEkipID.Text = row.Cells["ID"].Value.ToString();
                txtEkipIsim.Text = row.Cells["Isim"].Value.ToString();
                txtEkipSoyisim.Text = row.Cells["Soyisim"].Value.ToString();
                txtEkipTc.Text = row.Cells["TCNo"].Value.ToString();
                dtpEkipDogum.Text = row.Cells["DogumTarihi"].Value.ToString();
                txtEkipTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtEkipEposta.Text = row.Cells["ePosta"].Value.ToString();
                cbEkipSehir.Text = row.Cells["Sehir"].Value.ToString();
                txtEkipAdres.Text = row.Cells["Adres"].Value.ToString();
                cbEkipGorev.Text = row.Cells["Gorevi"].Value.ToString();
                dtpEkipKayitTarihi.Text = row.Cells["KayitTarihi"].Value.ToString();

            }      
        }

        private void btnEkipYeni_Click(object sender, EventArgs e)
        {
            clearAllTxt();
            loadTable();
        }

        private void btnEkipTemizle_Click(object sender, EventArgs e)
        {
            clearAllTxt();
            loadTable();
        }

        private void btnEkipAra_Click(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Isim LIKE '%{0}%' OR Soyisim LIKE '%{0}%' OR Telefon LIKE '%{0}%' OR ePosta LIKE '%{0}%' OR Sehir LIKE '%{0}%' OR Adres LIKE '%{0}%' OR Gorevi LIKE'%{0}%'", txtEkipAra.Text);
            dgvEkip.DataSource = DV;
        }

        private void btnEkipExcel_Click(object sender, EventArgs e)
        {   // Kod bloğu çalışmadı.
            /*
            string myConnection = "datasource=root;port=root;username=root;password=root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand("select id,name,surname,idno,birth,telephone,email,city,adress,recorddate from doguAkdenizApp.team;", myConn);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = cmdDataBase;
            dbdataset = new DataTable();
            dataAdapter.Fill(dbdataset);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbdataset;
            dgvEkip.DataSource = bSource;
            dataAdapter.Update(dbdataset);

            dbdataset.WriteXml("Ekip_Dataset.xls");
            MessageBox.Show("Dosya başarıyla oluşturulmuştur.");
            */

            //Bu kod bloğuda çalışmadı.
            /*
            string myConnection = "datasource=root;port=root;username=root;password=root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand("select id,name,surname,idno,birth,telephone,email,city,adress,recorddate from doguAkdenizApp.team;", myConn);
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                dataAdapter.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dgvEkip.DataSource = bSource;
                dataAdapter.Update(dbdataset);

                DataSet dataSet = new DataSet("ekipDataset");
                dataSet.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                dataAdapter.Fill(dbdataset);
                dataSet.Tables.Add(dbdataset);
                ExcelLibrary.DataSetHelper.CreateWorkbook("ekipDataset.xls", dataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void txtEkipTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen yalnızca rakamlardan oluşan 11 haneli TC Kimlik No bilgisini giriniz!");
            }
        }

        private void picEkipDrive_Click(object sender, EventArgs e)
        {
            browser tarayici = new browser();
            tarayici.ShowDialog();
        }

        private void txtEkipEposta_Leave(object sender, EventArgs e)
        {
            Regex RX = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
            if (!RX.IsMatch(txtEkipEposta.Text))
            {
                MessageBox.Show("Hatalı bir ePosta adresi girdiniz!");
            }
        }

        private void cmsEkipItemYeni_Click(object sender, EventArgs e)
        {
            clearAllTxt();
            loadTable();
        }

        private void cmsEkipItemTemizle_Click(object sender, EventArgs e)
        {
            clearAllTxt();
            loadTable();
        }

        private void cmsEkipItemYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}

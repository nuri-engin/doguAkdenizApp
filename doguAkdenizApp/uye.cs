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
    public partial class uye : Form
    {
        public uye(string LogInfo)
        {
            InitializeComponent();
            lblUyeLoginfo.Text=LogInfo;
            loadTable();
            dtpUyeKayitTarihi.Value = DateTime.Now;
            dgvUye.Columns[0].Width = 50;
        }

        DataTable dbdataset;
        string Gender;

        void clearAllText()
        {
            txtUyeIsim.Text = "";
            txtUyeSoyisim.Text = "";
            txtUyeTc.Text = "";
            dtpUyeDogum.Text = "";
            txtUyeBabaAdi.Text = "";
            txtUyeTelefon.Text = "";
            txtUyeEposta.Text = "";
            cbUyeSehir.Text = "";
            txtUyeAdres.Text = "";
            cbUyeKurulKarari.Text = "";
            cbUyeGirisUcreti.Text = "";
        }

        void loadTable()
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            MySqlConnection MyConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand("select id as 'ID',name as 'Isim',surname as 'Soyisim',idno as 'TCNo',birth as 'DogumTarihi',gender as 'Cinsiyet',father as 'BabaAdi',telephone as 'Telefon',email as 'ePosta',city as 'Sehir',adress as 'Adres',assize as 'KurulKarari',admisson as 'GirisUcreti',recorddate as 'KayıtTarihi',username as 'Yetkili' from doguAkdenizApp.member;", MyConn);
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                dataAdapter.Fill(dbdataset);
                BindingSource myBinding = new BindingSource();

                myBinding.DataSource = dbdataset;
                dgvUye.DataSource = myBinding;
                dataAdapter.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radUyeKadin_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Kadın";
        }

        private void radUyeErkek_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Erkek";
        }

        private void btnUyePano_Click(object sender, EventArgs e)
        {
            this.Hide();
            pano panoEkrani = new pano(lblUyeLoginfo.Text);
            panoEkrani.ShowDialog();
        }

        private void btnUyeKaydet_Click(object sender, EventArgs e)
        {
            string myConnection= "datasource=root;port=root;username=root;password=root";
            string Query = "insert into doguAkdenizApp.member(name,surname,idno,birth,gender,father,telephone,email,city,adress,assize,admisson,recorddate,username) values('" + this.txtUyeIsim.Text + "','" + this.txtUyeSoyisim.Text + "','" + this.txtUyeTc.Text + "','" + this.dtpUyeDogum.Text + "','" + this.Gender + "','" + this.txtUyeBabaAdi.Text + "','" + this.txtUyeTelefon.Text + "','" + this.txtUyeEposta.Text + "','" + this.cbUyeSehir.Text + "','" + this.txtUyeAdres.Text + "','" + this.cbUyeKurulKarari.Text + "','" + this.cbUyeGirisUcreti.Text + "','" + this.dtpUyeKayitTarihi.Text + "','" + this.lblUyeLoginfo.Text + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Kayıt Başarılı!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "update doguAkdenizApp.member set name='"+this.txtUyeIsim.Text+"', surname='" +this.txtUyeSoyisim.Text+"',idno='"+this.txtUyeTc.Text+"',birth='"+this.dtpUyeDogum.Text+"',gender='"+this.Gender+"',father='"+this.txtUyeBabaAdi.Text+"',telephone='"+this.txtUyeTelefon.Text+"',email='"+this.txtUyeEposta.Text+"',city='"+this.cbUyeSehir.Text+"',adress='"+this.txtUyeAdres.Text+"',assize='"+this.cbUyeKurulKarari.Text+"',admisson='"+this.cbUyeGirisUcreti.Text+"',username='"+this.lblUyeLoginfo.Text+"',recorddate='"+this.dtpUyeKayitTarihi.Text+"' where id='"+this.lblUyeID.Text+"'";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Güncelleme Başarılı!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "delete from doguAkdenizApp.member where id='" + this.lblUyeID.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Silme İşlemi Başarılı!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnUyeYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnUyeYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnUyeTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnUyeAra_Click(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Isim LIKE '%{0}%' OR Soyisim LIKE '%{0}%' OR Telefon LIKE '%{0}%' OR ePosta LIKE '%{0}%' OR Sehir LIKE '%{0}%' OR Adres LIKE '%{0}%'", txtUyeAra.Text);
            dgvUye.DataSource = DV;
        }

        private void dgvUye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUye.Rows[e.RowIndex];
                lblUyeID.Text = row.Cells["ID"].Value.ToString();
                txtUyeIsim.Text = row.Cells["Isim"].Value.ToString();
                txtUyeSoyisim.Text = row.Cells["Soyisim"].Value.ToString();
                txtUyeTc.Text = row.Cells["TCNo"].Value.ToString();
                dtpUyeDogum.Text = row.Cells["DogumTarihi"].Value.ToString();
                txtUyeBabaAdi.Text = row.Cells["BabaAdi"].Value.ToString();
                txtUyeTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtUyeEposta.Text = row.Cells["ePosta"].Value.ToString();
                cbUyeSehir.Text = row.Cells["Sehir"].Value.ToString();
                txtUyeAdres.Text = row.Cells["Adres"].Value.ToString();
                cbUyeKurulKarari.Text = row.Cells["KurulKarari"].Value.ToString();
                cbUyeGirisUcreti.Text = row.Cells["GirisUcreti"].Value.ToString();
                dtpUyeKayitTarihi.Text = row.Cells["KayitTarihi"].Value.ToString();
            }
        }

        private void picUyeDrive_Click(object sender, EventArgs e)
        {
            browser tarayici = new browser();
            tarayici.ShowDialog();
        }

        private void txtUyeTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch)&&ch !=8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen yalnizca rakamlardan olusan 11 haneli TC Kimlik No bilgisini giriniz!");
            }
        }

        private void txtUyeEposta_Leave(object sender, EventArgs e)
        {
            Regex RX = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
            if (!RX.IsMatch(txtUyeEposta.Text))
            {
                MessageBox.Show("Hatali bir ePosta adresi girdiniz!");
            }
        }

        private void cmsUyeItemYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void cmsUyeItemTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void cmsUyeItemYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}

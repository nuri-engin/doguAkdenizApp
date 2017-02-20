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
    public partial class aidat : Form
    {
        public aidat(string LogInfo)
        {
            InitializeComponent();
            lblAidatLoginfo.Text = LogInfo;
            loadTable();
            dtpAidatKayitTarihi.Value = DateTime.Now;
            dgvAidat.Columns[0].Width = 50;
        }

        DataTable dbdataset;

        void clearAllText()
        {
            txtAidatIsim.Text = "";
            txtAidatSoyisim.Text = "";
            txtAidatTutar.Text = "";
            cbAidatCins.Text = "";
        }

        private void loadTable()
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand("select id as 'ID',name as 'Isim', surname as 'Soyisim', amount as 'Tutar', currency as 'ParaBirimi', recorddate as 'KayitTarihi', username as 'Yetkili' from doguAkdenizApp.dues;", myConn);
            try
            {
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                dbdataset = new DataTable();
                myAdapter.Fill(dbdataset);
                BindingSource myBinding = new BindingSource();

                myBinding.DataSource = dbdataset;
                dgvAidat.DataSource = myBinding;
                myAdapter.Update(dbdataset);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAidatPano_Click(object sender, EventArgs e)
        {
            this.Hide();
            pano panoEkrani = new pano(lblAidatLoginfo.Text);
            panoEkrani.ShowDialog();
        }

        private void btnAidatKaydet_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            string myQuery = "insert into doguAkdenizApp.dues(name,surname,amount,currency,recorddate,username) values('" + this.txtAidatIsim.Text + "','" + this.txtAidatSoyisim.Text + "','" + this.txtAidatTutar.Text + "','" + this.cbAidatCins.Text + "','"+dtpAidatKayitTarihi.Text+"','"+lblAidatLoginfo.Text+"');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand(myQuery, myConn);
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

        private void btnAidatGuncelle_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            string myQuery = "update doguAkdenizApp.dues set name='" + this.txtAidatIsim.Text + "',surname='" + this.txtAidatSoyisim.Text + "',amount='" + this.txtAidatTutar.Text + "',currency='" + this.cbAidatCins.Text + "',recorddate='" + this.dtpAidatKayitTarihi.Text + "',username='" + this.lblAidatLoginfo.Text + "' where id='" + this.lblAidatID.Text + "'";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Güncelleme başarılı!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnAidatSil_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=160.153.129.19;port=3306;username=nuridesengin;password=uiVypENP65";
            string myQuery = "delete from doguAkdenizApp.dues where id='" + lblAidatID.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand(myQuery, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Silme işlemi başarılı!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnAidatYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnAidatYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnAidatTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnAidatAra_Click(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Isim LIKE '%{0}%' OR Soyisim LIKE '%{0}%' OR Tutar LIKE '%{0}%' OR ParaBirimi LIKE '%{0}%'", txtAidatAra.Text);
            dgvAidat.DataSource=DV;
        }

        private void dgvAidat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAidat.Rows[e.RowIndex];
                lblAidatID.Text = row.Cells["ID"].Value.ToString();
                txtAidatIsim.Text = row.Cells["Isim"].Value.ToString();
                txtAidatSoyisim.Text = row.Cells["Soyisim"].Value.ToString();
                txtAidatTutar.Text = row.Cells["Tutar"].Value.ToString();
                cbAidatCins.Text = row.Cells["ParaBirimi"].Value.ToString();
                dtpAidatKayitTarihi.Text = row.Cells["KayitTarihi"].Value.ToString();
            }
        }

        private void picAidatDrive_Click(object sender, EventArgs e)
        {
            browser tariyici = new browser();
            tariyici.ShowDialog();
        }
    }
}

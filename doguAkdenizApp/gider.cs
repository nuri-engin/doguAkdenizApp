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
    public partial class gider : Form
    {
        public gider(string LogInfo)
        {
            InitializeComponent();
            lblGiderLoginfo.Text = LogInfo;
            loadTable();
            dtpGiderKayitTarihi.Value = DateTime.Now;
            dgvGider.Columns[0].Width = 50;
        }

        DataTable dbdataset;

        void clearAllText()
        {
            txtGiderKisi.Text = "";
            txtGiderAmac.Text = "";
            cbGiderTuru.Text = "";
            txtGiderTutar.Text = "";
        }

        private void loadTable()
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand("select id as 'ID', person as 'Kisi', purpose as 'Amac', type as 'Turu', amount as 'Tutar',recorddate as 'KayitTarihi',username as 'Yetkili' from doguAkdenizApp.outgoing;", myConn);
            try
            {
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = myCommand;
                dbdataset = new DataTable();
                myAdapter.Fill(dbdataset);
                BindingSource myBinding = new BindingSource();
                myBinding.DataSource = dbdataset;
                dgvGider.DataSource = myBinding;
                myAdapter.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGiderPano_Click(object sender, EventArgs e)
        {
            this.Hide();
            pano panoEkrani = new pano(lblGiderLoginfo.Text);
            panoEkrani.ShowDialog();
        }

        private void btnGiderKaydet_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "insert into doguAkdenizApp.outgoing(person,purpose,type,amount,recorddate,username)values('" + this.txtGiderKisi.Text + "','" + this.txtGiderAmac.Text + "','" + this.cbGiderTuru.Text + "','" + this.txtGiderTutar.Text + "','" + this.dtpGiderKayitTarihi.Text + "','" + this.lblGiderLoginfo.Text + "')";
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

        private void btnGiderGuncelle_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "update doguAkdenizApp.outgoing set person='" + this.txtGiderKisi.Text + "',purpose='" + this.txtGiderAmac.Text + "',type='" + this.cbGiderTuru.Text + "',amount='" + this.txtGiderTutar.Text + "',recorddate='" + this.dtpGiderKayitTarihi.Text + "',username='" + this.lblGiderLoginfo.Text + "' where id='" + this.lblGiderID.Text + "'";
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

        private void btnGiderSil_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "delete from doguAkdenizApp.outgoing where id='" + this.lblGiderID.Text + "';";
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

        private void btnGiderYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnGiderYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnGiderTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnGiderAra_Click(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Kisi LIKE '%{0}%' OR Amac LIKE '%{0}%' OR Turu LIKE '%{0}%' OR Tutar LIKE '%{0}%'", txtGiderAra.Text);
            dgvGider.DataSource = DV;
        }

        private void dgvGider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvGider.Rows[e.RowIndex];
                lblGiderID.Text = row.Cells["ID"].Value.ToString();
                txtGiderKisi.Text = row.Cells["Kisi"].Value.ToString();
                txtGiderAmac.Text = row.Cells["Amac"].Value.ToString();
                cbGiderTuru.Text = row.Cells["Turu"].Value.ToString();
                txtGiderTutar.Text = row.Cells["Tutar"].Value.ToString();
                dtpGiderKayitTarihi.Text = row.Cells["KayitTarihi"].Value.ToString();
            }
        }

        private void picGiderDrive_Click(object sender, EventArgs e)
        {
            browser tarayici = new browser();
            tarayici.ShowDialog();
        }

        private void cmsGiderItemYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void cmsGiderItemTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void cmsGiderItemYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}

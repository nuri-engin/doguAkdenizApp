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
    public partial class bagis : Form
    {
        public bagis(string LogInfo)
        {
            InitializeComponent();
            lblBagisLoginfo.Text = LogInfo;
            loadTable();
            dtpBagisKayitTarihi.Value = DateTime.Now;
            dgvBagis.Columns[0].Width = 50;
            dgvBagis.Columns[4].Width = 150;
        }

        DataTable dbdataset;

        void clearAllText()
        {
            txtBagisIsim.Text = "";
            txtBagisSoyisim.Text = "";
            cbBagisTuru.Text = "";
            txtBagisOzet.Text = "";
        }

        private void loadTable()
        {
            string myConnection="datasource=root;port=root;username=root;password=root";
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
                dgvBagis.DataSource = myBinding;
                myAdapter.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBagisPano_Click(object sender, EventArgs e)
        {
            this.Hide();
            pano panoEkrani = new pano(lblBagisLoginfo.Text);
            panoEkrani.ShowDialog();
        }

        private void btnBagisKaydet_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "insert into doguAkdenizApp.income(name,surname,type,summary,recorddate,username)values('" + this.txtBagisIsim.Text + "','" + this.txtBagisSoyisim.Text + "','" + this.cbBagisTuru.Text + "','" + this.txtBagisOzet.Text + "','" + this.dtpBagisKayitTarihi.Text + "','" + this.lblBagisLoginfo.Text + "')";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Kayıt başarılı!");
                while (myReader.Read()) { }
                clearAllText();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadTable();
        }

        private void btnBagisGuncelle_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "update doguAkdenizApp.income set name='" + this.txtBagisIsim.Text + "',surname='" + this.txtBagisSoyisim.Text + "',type='" + this.cbBagisTuru.Text + "',summary='" + this.txtBagisOzet.Text + "',recorddate='" + this.dtpBagisKayitTarihi.Text + "',username='" + this.lblBagisLoginfo.Text + "' where id='" + this.lblBagisID.Text + "'";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand(Query, myConn);
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

        private void btnBagisSil_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=root;port=root;username=root;password=root";
            string Query = "delete from doguAkdenizApp.income where id='" + this.lblBagisID.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand myCommand = new MySqlCommand(Query, myConn);
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

        private void btnBagisYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnBagisYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnBagisTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void btnBagisAra_Click(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Isim LIKE '%{0}%' OR Soyisim LIKE '%{0}%' OR Turu LIKE '%{0}%' OR Ozet LIKE '%{0}%'",txtBagisAra.Text);
            dgvBagis.DataSource = DV;
        }

        private void dgvBagis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBagis.Rows[e.RowIndex];
                lblBagisID.Text = row.Cells["ID"].Value.ToString();
                txtBagisIsim.Text = row.Cells["Isim"].Value.ToString();
                txtBagisSoyisim.Text = row.Cells["Soyisim"].Value.ToString();
                cbBagisTuru.Text = row.Cells["Turu"].Value.ToString();
                txtBagisOzet.Text = row.Cells["Ozet"].Value.ToString();
                dtpBagisKayitTarihi.Text = row.Cells["KayitTarihi"].Value.ToString();
            }
        }

        private void picBagisDrive_Click(object sender, EventArgs e)
        {
            browser tarayici = new browser();
            tarayici.ShowDialog();
        }

        private void cmsBagisItemYeni_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void cmsBagisItemTemizle_Click(object sender, EventArgs e)
        {
            clearAllText();
            loadTable();
        }

        private void cmsBagisItemYenile_Click(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}

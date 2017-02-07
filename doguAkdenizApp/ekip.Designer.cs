namespace doguAkdenizApp
{
    partial class ekip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvEkip = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkipGuncelle = new System.Windows.Forms.Button();
            this.txtEkipAra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEkipAra = new System.Windows.Forms.Button();
            this.btnEkipYeni = new System.Windows.Forms.Button();
            this.btnEkipKaydet = new System.Windows.Forms.Button();
            this.btnEkipSil = new System.Windows.Forms.Button();
            this.btnEkipTemizle = new System.Windows.Forms.Button();
            this.lblEkipIsim = new System.Windows.Forms.Label();
            this.lblEkipSoyisim = new System.Windows.Forms.Label();
            this.lblEkipDogum = new System.Windows.Forms.Label();
            this.lblEkipTc = new System.Windows.Forms.Label();
            this.lblEkipTelefon = new System.Windows.Forms.Label();
            this.lblEkipEposta = new System.Windows.Forms.Label();
            this.lblEkipAdres = new System.Windows.Forms.Label();
            this.lblEkipSehir = new System.Windows.Forms.Label();
            this.txtEkipIsim = new System.Windows.Forms.TextBox();
            this.txtEkipTc = new System.Windows.Forms.TextBox();
            this.txtEkipTelefon = new System.Windows.Forms.TextBox();
            this.txtEkipEposta = new System.Windows.Forms.TextBox();
            this.txtEkipAdres = new System.Windows.Forms.TextBox();
            this.txtEkipSoyisim = new System.Windows.Forms.TextBox();
            this.btnEkipExcel = new System.Windows.Forms.Button();
            this.btnEkipEposta = new System.Windows.Forms.Button();
            this.btnEkipPano = new System.Windows.Forms.Button();
            this.lblEkipKayitTarihi = new System.Windows.Forms.Label();
            this.dtpEkipKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpEkipDogum = new System.Windows.Forms.DateTimePicker();
            this.cbEkipSehir = new System.Windows.Forms.ComboBox();
            this.lblEkipLoginfo = new System.Windows.Forms.Label();
            this.picEkipDrive = new System.Windows.Forms.PictureBox();
            this.btnEkipYenile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmsEkip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEkipItemYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEkipItemTemizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEkipItemYenile = new System.Windows.Forms.ToolStripMenuItem();
            this.tipEkipYeni = new System.Windows.Forms.ToolTip(this.components);
            this.tipEkipTemizle = new System.Windows.Forms.ToolTip(this.components);
            this.tipEkipSil = new System.Windows.Forms.ToolTip(this.components);
            this.tipEkipDuzenle = new System.Windows.Forms.ToolTip(this.components);
            this.tipEkipKaydet = new System.Windows.Forms.ToolTip(this.components);
            this.tipEkipAra = new System.Windows.Forms.ToolTip(this.components);
            this.tipEkipYenile = new System.Windows.Forms.ToolTip(this.components);
            this.tipEkipDrive = new System.Windows.Forms.ToolTip(this.components);
            this.lblEkipID = new System.Windows.Forms.Label();
            this.lblEkipKayitNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEkipKullanici = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEkip)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEkipDrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cmsEkip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEkip
            // 
            this.dgvEkip.AllowUserToAddRows = false;
            this.dgvEkip.AllowUserToDeleteRows = false;
            this.dgvEkip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEkip.Location = new System.Drawing.Point(40, 336);
            this.dgvEkip.Name = "dgvEkip";
            this.dgvEkip.ReadOnly = true;
            this.dgvEkip.Size = new System.Drawing.Size(605, 239);
            this.dgvEkip.TabIndex = 20;
            this.dgvEkip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEkip_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkipGuncelle);
            this.groupBox1.Controls.Add(this.txtEkipAra);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnEkipAra);
            this.groupBox1.Controls.Add(this.btnEkipYeni);
            this.groupBox1.Controls.Add(this.btnEkipKaydet);
            this.groupBox1.Controls.Add(this.btnEkipSil);
            this.groupBox1.Controls.Add(this.btnEkipTemizle);
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(40, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekip Kaydı Olustur";
            // 
            // btnEkipGuncelle
            // 
            this.btnEkipGuncelle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEkipGuncelle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkipGuncelle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEkipGuncelle.Image = global::doguAkdenizApp.Properties.Resources.Update20;
            this.btnEkipGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkipGuncelle.Location = new System.Drawing.Point(153, 57);
            this.btnEkipGuncelle.Name = "btnEkipGuncelle";
            this.btnEkipGuncelle.Size = new System.Drawing.Size(86, 32);
            this.btnEkipGuncelle.TabIndex = 12;
            this.btnEkipGuncelle.Text = "Düzenle";
            this.btnEkipGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipEkipDuzenle.SetToolTip(this.btnEkipGuncelle, "Seçili kaydı veritabanında gunceller");
            this.btnEkipGuncelle.UseVisualStyleBackColor = false;
            this.btnEkipGuncelle.Click += new System.EventHandler(this.btnEkipGuncelle_Click);
            // 
            // txtEkipAra
            // 
            this.txtEkipAra.Location = new System.Drawing.Point(399, 27);
            this.txtEkipAra.Name = "txtEkipAra";
            this.txtEkipAra.Size = new System.Drawing.Size(195, 20);
            this.txtEkipAra.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::doguAkdenizApp.Properties.Resources._5;
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEkipAra
            // 
            this.btnEkipAra.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEkipAra.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkipAra.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEkipAra.Image = global::doguAkdenizApp.Properties.Resources.glass_24;
            this.btnEkipAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkipAra.Location = new System.Drawing.Point(514, 57);
            this.btnEkipAra.Name = "btnEkipAra";
            this.btnEkipAra.Size = new System.Drawing.Size(80, 32);
            this.btnEkipAra.TabIndex = 15;
            this.btnEkipAra.Text = "Ara";
            this.btnEkipAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipEkipAra.SetToolTip(this.btnEkipAra, "Veritabanında yalnızca \'İsme\' göre arama yapar");
            this.btnEkipAra.UseVisualStyleBackColor = false;
            this.btnEkipAra.Click += new System.EventHandler(this.btnEkipAra_Click);
            // 
            // btnEkipYeni
            // 
            this.btnEkipYeni.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEkipYeni.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkipYeni.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEkipYeni.Image = global::doguAkdenizApp.Properties.Resources._00001;
            this.btnEkipYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkipYeni.Location = new System.Drawing.Point(85, 19);
            this.btnEkipYeni.Name = "btnEkipYeni";
            this.btnEkipYeni.Size = new System.Drawing.Size(62, 32);
            this.btnEkipYeni.TabIndex = 8;
            this.btnEkipYeni.Text = "Yeni";
            this.btnEkipYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipEkipYeni.SetToolTip(this.btnEkipYeni, "Yeni bir form açar");
            this.btnEkipYeni.UseVisualStyleBackColor = false;
            this.btnEkipYeni.Click += new System.EventHandler(this.btnEkipYeni_Click);
            // 
            // btnEkipKaydet
            // 
            this.btnEkipKaydet.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEkipKaydet.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkipKaydet.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEkipKaydet.Image = global::doguAkdenizApp.Properties.Resources.floppy;
            this.btnEkipKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkipKaydet.Location = new System.Drawing.Point(245, 57);
            this.btnEkipKaydet.Name = "btnEkipKaydet";
            this.btnEkipKaydet.Size = new System.Drawing.Size(85, 32);
            this.btnEkipKaydet.TabIndex = 13;
            this.btnEkipKaydet.Text = "Kaydet";
            this.btnEkipKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipEkipKaydet.SetToolTip(this.btnEkipKaydet, "Formda yer alan bilgileri veritabanına kaydeder");
            this.btnEkipKaydet.UseVisualStyleBackColor = false;
            this.btnEkipKaydet.Click += new System.EventHandler(this.btnEkipKaydet_Click);
            // 
            // btnEkipSil
            // 
            this.btnEkipSil.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEkipSil.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkipSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEkipSil.Image = global::doguAkdenizApp.Properties.Resources._0001;
            this.btnEkipSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkipSil.Location = new System.Drawing.Point(85, 57);
            this.btnEkipSil.Name = "btnEkipSil";
            this.btnEkipSil.Size = new System.Drawing.Size(62, 32);
            this.btnEkipSil.TabIndex = 11;
            this.btnEkipSil.Text = "Sil";
            this.btnEkipSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipEkipSil.SetToolTip(this.btnEkipSil, "Seçili kaydı veritabanından siler");
            this.btnEkipSil.UseVisualStyleBackColor = false;
            this.btnEkipSil.Click += new System.EventHandler(this.btnEkipSil_Click);
            // 
            // btnEkipTemizle
            // 
            this.btnEkipTemizle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEkipTemizle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkipTemizle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEkipTemizle.Image = global::doguAkdenizApp.Properties.Resources.clear;
            this.btnEkipTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkipTemizle.Location = new System.Drawing.Point(153, 20);
            this.btnEkipTemizle.Name = "btnEkipTemizle";
            this.btnEkipTemizle.Size = new System.Drawing.Size(86, 31);
            this.btnEkipTemizle.TabIndex = 9;
            this.btnEkipTemizle.Text = "Temizle";
            this.btnEkipTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipEkipTemizle.SetToolTip(this.btnEkipTemizle, "Formu temizler");
            this.btnEkipTemizle.UseVisualStyleBackColor = false;
            this.btnEkipTemizle.Click += new System.EventHandler(this.btnEkipTemizle_Click);
            // 
            // lblEkipIsim
            // 
            this.lblEkipIsim.AutoSize = true;
            this.lblEkipIsim.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipIsim.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipIsim.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipIsim.Location = new System.Drawing.Point(5, 19);
            this.lblEkipIsim.Name = "lblEkipIsim";
            this.lblEkipIsim.Size = new System.Drawing.Size(40, 22);
            this.lblEkipIsim.TabIndex = 2;
            this.lblEkipIsim.Text = "İsim: ";
            // 
            // lblEkipSoyisim
            // 
            this.lblEkipSoyisim.AutoSize = true;
            this.lblEkipSoyisim.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipSoyisim.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipSoyisim.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipSoyisim.Location = new System.Drawing.Point(299, 19);
            this.lblEkipSoyisim.Name = "lblEkipSoyisim";
            this.lblEkipSoyisim.Size = new System.Drawing.Size(61, 22);
            this.lblEkipSoyisim.TabIndex = 3;
            this.lblEkipSoyisim.Text = "Soyisim: ";
            // 
            // lblEkipDogum
            // 
            this.lblEkipDogum.AutoSize = true;
            this.lblEkipDogum.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipDogum.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipDogum.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipDogum.Location = new System.Drawing.Point(299, 43);
            this.lblEkipDogum.Name = "lblEkipDogum";
            this.lblEkipDogum.Size = new System.Drawing.Size(92, 22);
            this.lblEkipDogum.TabIndex = 4;
            this.lblEkipDogum.Text = "Dogum Tarihi: ";
            // 
            // lblEkipTc
            // 
            this.lblEkipTc.AutoSize = true;
            this.lblEkipTc.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipTc.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipTc.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipTc.Location = new System.Drawing.Point(5, 43);
            this.lblEkipTc.Name = "lblEkipTc";
            this.lblEkipTc.Size = new System.Drawing.Size(48, 22);
            this.lblEkipTc.TabIndex = 5;
            this.lblEkipTc.Text = "TC No: ";
            // 
            // lblEkipTelefon
            // 
            this.lblEkipTelefon.AutoSize = true;
            this.lblEkipTelefon.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipTelefon.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipTelefon.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipTelefon.Location = new System.Drawing.Point(5, 65);
            this.lblEkipTelefon.Name = "lblEkipTelefon";
            this.lblEkipTelefon.Size = new System.Drawing.Size(59, 22);
            this.lblEkipTelefon.TabIndex = 6;
            this.lblEkipTelefon.Text = "Telefon: ";
            // 
            // lblEkipEposta
            // 
            this.lblEkipEposta.AutoSize = true;
            this.lblEkipEposta.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipEposta.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipEposta.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipEposta.Location = new System.Drawing.Point(299, 65);
            this.lblEkipEposta.Name = "lblEkipEposta";
            this.lblEkipEposta.Size = new System.Drawing.Size(55, 22);
            this.lblEkipEposta.TabIndex = 7;
            this.lblEkipEposta.Text = "ePosta: ";
            // 
            // lblEkipAdres
            // 
            this.lblEkipAdres.AutoSize = true;
            this.lblEkipAdres.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipAdres.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipAdres.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipAdres.Location = new System.Drawing.Point(299, 88);
            this.lblEkipAdres.Name = "lblEkipAdres";
            this.lblEkipAdres.Size = new System.Drawing.Size(50, 22);
            this.lblEkipAdres.TabIndex = 8;
            this.lblEkipAdres.Text = "Adres: ";
            // 
            // lblEkipSehir
            // 
            this.lblEkipSehir.AutoSize = true;
            this.lblEkipSehir.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipSehir.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipSehir.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipSehir.Location = new System.Drawing.Point(5, 90);
            this.lblEkipSehir.Name = "lblEkipSehir";
            this.lblEkipSehir.Size = new System.Drawing.Size(46, 22);
            this.lblEkipSehir.TabIndex = 9;
            this.lblEkipSehir.Text = "Şehir: ";
            // 
            // txtEkipIsim
            // 
            this.txtEkipIsim.Location = new System.Drawing.Point(68, 21);
            this.txtEkipIsim.Name = "txtEkipIsim";
            this.txtEkipIsim.Size = new System.Drawing.Size(201, 20);
            this.txtEkipIsim.TabIndex = 0;
            // 
            // txtEkipTc
            // 
            this.txtEkipTc.Location = new System.Drawing.Point(68, 46);
            this.txtEkipTc.Name = "txtEkipTc";
            this.txtEkipTc.Size = new System.Drawing.Size(201, 20);
            this.txtEkipTc.TabIndex = 2;
            this.txtEkipTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEkipTc_KeyPress);
            // 
            // txtEkipTelefon
            // 
            this.txtEkipTelefon.Location = new System.Drawing.Point(68, 68);
            this.txtEkipTelefon.Name = "txtEkipTelefon";
            this.txtEkipTelefon.Size = new System.Drawing.Size(201, 20);
            this.txtEkipTelefon.TabIndex = 4;
            // 
            // txtEkipEposta
            // 
            this.txtEkipEposta.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com",
            "@live.com",
            "@yahoo.com"});
            this.txtEkipEposta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEkipEposta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEkipEposta.Location = new System.Drawing.Point(393, 65);
            this.txtEkipEposta.Name = "txtEkipEposta";
            this.txtEkipEposta.Size = new System.Drawing.Size(201, 20);
            this.txtEkipEposta.TabIndex = 5;
            this.txtEkipEposta.Leave += new System.EventHandler(this.txtEkipEposta_Leave);
            // 
            // txtEkipAdres
            // 
            this.txtEkipAdres.Location = new System.Drawing.Point(393, 90);
            this.txtEkipAdres.Name = "txtEkipAdres";
            this.txtEkipAdres.Size = new System.Drawing.Size(201, 20);
            this.txtEkipAdres.TabIndex = 7;
            // 
            // txtEkipSoyisim
            // 
            this.txtEkipSoyisim.Location = new System.Drawing.Point(393, 19);
            this.txtEkipSoyisim.Name = "txtEkipSoyisim";
            this.txtEkipSoyisim.Size = new System.Drawing.Size(201, 20);
            this.txtEkipSoyisim.TabIndex = 1;
            // 
            // btnEkipExcel
            // 
            this.btnEkipExcel.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEkipExcel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkipExcel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEkipExcel.Location = new System.Drawing.Point(464, 581);
            this.btnEkipExcel.Name = "btnEkipExcel";
            this.btnEkipExcel.Size = new System.Drawing.Size(96, 32);
            this.btnEkipExcel.TabIndex = 25;
            this.btnEkipExcel.Text = "Excel\'e Çıkar";
            this.btnEkipExcel.UseVisualStyleBackColor = false;
            this.btnEkipExcel.Click += new System.EventHandler(this.btnEkipExcel_Click);
            // 
            // btnEkipEposta
            // 
            this.btnEkipEposta.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEkipEposta.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkipEposta.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEkipEposta.Location = new System.Drawing.Point(362, 581);
            this.btnEkipEposta.Name = "btnEkipEposta";
            this.btnEkipEposta.Size = new System.Drawing.Size(96, 32);
            this.btnEkipEposta.TabIndex = 26;
            this.btnEkipEposta.Text = "ePosta Gönder";
            this.btnEkipEposta.UseVisualStyleBackColor = false;
            // 
            // btnEkipPano
            // 
            this.btnEkipPano.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEkipPano.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkipPano.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEkipPano.Location = new System.Drawing.Point(74, 581);
            this.btnEkipPano.Name = "btnEkipPano";
            this.btnEkipPano.Size = new System.Drawing.Size(102, 32);
            this.btnEkipPano.TabIndex = 29;
            this.btnEkipPano.Text = "Panoya Geri dön!";
            this.btnEkipPano.UseVisualStyleBackColor = false;
            this.btnEkipPano.Click += new System.EventHandler(this.btnEkipPano_Click);
            // 
            // lblEkipKayitTarihi
            // 
            this.lblEkipKayitTarihi.AutoSize = true;
            this.lblEkipKayitTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipKayitTarihi.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipKayitTarihi.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipKayitTarihi.Location = new System.Drawing.Point(299, 20);
            this.lblEkipKayitTarihi.Name = "lblEkipKayitTarihi";
            this.lblEkipKayitTarihi.Size = new System.Drawing.Size(80, 22);
            this.lblEkipKayitTarihi.TabIndex = 30;
            this.lblEkipKayitTarihi.Text = "Kayıt Tarihi:";
            // 
            // dtpEkipKayitTarihi
            // 
            this.dtpEkipKayitTarihi.CustomFormat = "yyyy-MM-dd";
            this.dtpEkipKayitTarihi.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEkipKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEkipKayitTarihi.Location = new System.Drawing.Point(393, 20);
            this.dtpEkipKayitTarihi.MinDate = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            this.dtpEkipKayitTarihi.Name = "dtpEkipKayitTarihi";
            this.dtpEkipKayitTarihi.Size = new System.Drawing.Size(201, 21);
            this.dtpEkipKayitTarihi.TabIndex = 31;
            // 
            // dtpEkipDogum
            // 
            this.dtpEkipDogum.CustomFormat = "yyyy-MM-dd";
            this.dtpEkipDogum.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEkipDogum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEkipDogum.Location = new System.Drawing.Point(393, 45);
            this.dtpEkipDogum.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpEkipDogum.Name = "dtpEkipDogum";
            this.dtpEkipDogum.Size = new System.Drawing.Size(201, 21);
            this.dtpEkipDogum.TabIndex = 32;
            this.dtpEkipDogum.Value = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            // 
            // cbEkipSehir
            // 
            this.cbEkipSehir.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEkipSehir.FormattingEnabled = true;
            this.cbEkipSehir.Items.AddRange(new object[] {
            "01 Adana",
            "02 Adıyaman",
            "03 Afyon ",
            "04 Agrı ",
            "05 Amasya",
            "06 Ankara",
            "07 Antalya",
            "08 Artvin",
            "09 Aydın",
            "10 Balıkesir",
            "11 Bilecik",
            "12 Bingöl",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazıg",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir",
            "27 Gaziantep",
            "28 Giresun",
            "29 Gümüşhane",
            "30 Hakkari",
            "31 Hatay",
            "32 Isparta",
            "33 Içel (Mersin)",
            "34 Istanbul",
            "35 Izmir",
            "36 Kars",
            "37 Kastamonu",
            "38 Kayseri",
            "39 Kırklareli",
            "40 Kırşehir",
            "41 Kocaeli",
            "42 Konya",
            "43 Kütahya",
            "44 Malatya",
            "45 Manisa",
            "46 K.maraş",
            "47 Mardin",
            "48 Mugla",
            "49 Muş",
            "50 Nevşehir",
            "51 Nigde",
            "52 Ordu",
            "53 Rize",
            "54 Sakarya",
            "55 Samsun",
            "56 Siirt",
            "57 Sinop",
            "58 Sivas",
            "59 Tekirdag",
            "60 Tokat",
            "61 Trabzon",
            "62 Tunceli",
            "63 Şanlıurfa",
            "64 Uşak",
            "65 Van",
            "66 Yozgat",
            "67 Zonguldak",
            "68 Aksaray",
            "69 Bayburt",
            "70 Karaman",
            "71 Kırıkkale",
            "72 Batman",
            "73 Şırnak",
            "74 Bartın",
            "75 Ardahan",
            "76 Igdır",
            "77 Yalova",
            "78 Karabük",
            "79 Kilis",
            "80 Osmaniye",
            "81 Düzce"});
            this.cbEkipSehir.Location = new System.Drawing.Point(68, 90);
            this.cbEkipSehir.Name = "cbEkipSehir";
            this.cbEkipSehir.Size = new System.Drawing.Size(201, 23);
            this.cbEkipSehir.TabIndex = 33;
            this.cbEkipSehir.Text = "Lütfen listeden şehir seçimi yapınız.";
            // 
            // lblEkipLoginfo
            // 
            this.lblEkipLoginfo.AutoSize = true;
            this.lblEkipLoginfo.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipLoginfo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipLoginfo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipLoginfo.Location = new System.Drawing.Point(64, 19);
            this.lblEkipLoginfo.Name = "lblEkipLoginfo";
            this.lblEkipLoginfo.Size = new System.Drawing.Size(68, 22);
            this.lblEkipLoginfo.TabIndex = 34;
            this.lblEkipLoginfo.Text = "{ logInfo }";
            this.lblEkipLoginfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picEkipDrive
            // 
            this.picEkipDrive.Image = global::doguAkdenizApp.Properties.Resources.drive;
            this.picEkipDrive.Location = new System.Drawing.Point(326, 586);
            this.picEkipDrive.Name = "picEkipDrive";
            this.picEkipDrive.Size = new System.Drawing.Size(30, 32);
            this.picEkipDrive.TabIndex = 35;
            this.picEkipDrive.TabStop = false;
            this.tipEkipDrive.SetToolTip(this.picEkipDrive, "Google Drive\'a bağlanır");
            this.picEkipDrive.Click += new System.EventHandler(this.picEkipDrive_Click);
            // 
            // btnEkipYenile
            // 
            this.btnEkipYenile.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEkipYenile.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkipYenile.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEkipYenile.Image = global::doguAkdenizApp.Properties.Resources.radial_arrows_20;
            this.btnEkipYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkipYenile.Location = new System.Drawing.Point(566, 581);
            this.btnEkipYenile.Name = "btnEkipYenile";
            this.btnEkipYenile.Size = new System.Drawing.Size(79, 32);
            this.btnEkipYenile.TabIndex = 10;
            this.btnEkipYenile.Text = "Yenile";
            this.btnEkipYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipEkipYenile.SetToolTip(this.btnEkipYenile, "Veritabanını yeniler");
            this.btnEkipYenile.UseVisualStyleBackColor = false;
            this.btnEkipYenile.Click += new System.EventHandler(this.btnEkipYenile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::doguAkdenizApp.Properties.Resources.list;
            this.pictureBox2.Location = new System.Drawing.Point(40, 581);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 44);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // cmsEkip
            // 
            this.cmsEkip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEkipItemYeni,
            this.cmsEkipItemTemizle,
            this.cmsEkipItemYenile});
            this.cmsEkip.Name = "cmsEkip";
            this.cmsEkip.Size = new System.Drawing.Size(115, 70);
            // 
            // cmsEkipItemYeni
            // 
            this.cmsEkipItemYeni.Name = "cmsEkipItemYeni";
            this.cmsEkipItemYeni.Size = new System.Drawing.Size(114, 22);
            this.cmsEkipItemYeni.Text = "Yeni";
            this.cmsEkipItemYeni.Click += new System.EventHandler(this.cmsEkipItemYeni_Click);
            // 
            // cmsEkipItemTemizle
            // 
            this.cmsEkipItemTemizle.Name = "cmsEkipItemTemizle";
            this.cmsEkipItemTemizle.Size = new System.Drawing.Size(114, 22);
            this.cmsEkipItemTemizle.Text = "Temizle";
            this.cmsEkipItemTemizle.Click += new System.EventHandler(this.cmsEkipItemTemizle_Click);
            // 
            // cmsEkipItemYenile
            // 
            this.cmsEkipItemYenile.Name = "cmsEkipItemYenile";
            this.cmsEkipItemYenile.Size = new System.Drawing.Size(114, 22);
            this.cmsEkipItemYenile.Text = "Yenile";
            this.cmsEkipItemYenile.Click += new System.EventHandler(this.cmsEkipItemYenile_Click);
            // 
            // lblEkipID
            // 
            this.lblEkipID.AutoSize = true;
            this.lblEkipID.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipID.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipID.Location = new System.Drawing.Point(207, 19);
            this.lblEkipID.Name = "lblEkipID";
            this.lblEkipID.Size = new System.Drawing.Size(73, 22);
            this.lblEkipID.TabIndex = 36;
            this.lblEkipID.Text = "{ KayitNo }";
            // 
            // lblEkipKayitNo
            // 
            this.lblEkipKayitNo.AutoSize = true;
            this.lblEkipKayitNo.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipKayitNo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipKayitNo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipKayitNo.Location = new System.Drawing.Point(149, 19);
            this.lblEkipKayitNo.Name = "lblEkipKayitNo";
            this.lblEkipKayitNo.Size = new System.Drawing.Size(62, 22);
            this.lblEkipKayitNo.TabIndex = 37;
            this.lblEkipKayitNo.Text = "Kayıt No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEkipIsim);
            this.groupBox2.Controls.Add(this.lblEkipSoyisim);
            this.groupBox2.Controls.Add(this.lblEkipDogum);
            this.groupBox2.Controls.Add(this.lblEkipTc);
            this.groupBox2.Controls.Add(this.lblEkipTelefon);
            this.groupBox2.Controls.Add(this.lblEkipEposta);
            this.groupBox2.Controls.Add(this.lblEkipAdres);
            this.groupBox2.Controls.Add(this.cbEkipSehir);
            this.groupBox2.Controls.Add(this.lblEkipSehir);
            this.groupBox2.Controls.Add(this.dtpEkipDogum);
            this.groupBox2.Controls.Add(this.txtEkipIsim);
            this.groupBox2.Controls.Add(this.txtEkipTc);
            this.groupBox2.Controls.Add(this.txtEkipTelefon);
            this.groupBox2.Controls.Add(this.txtEkipEposta);
            this.groupBox2.Controls.Add(this.txtEkipAdres);
            this.groupBox2.Controls.Add(this.txtEkipSoyisim);
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(40, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 125);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEkipKullanici);
            this.groupBox3.Controls.Add(this.lblEkipKayitNo);
            this.groupBox3.Controls.Add(this.lblEkipID);
            this.groupBox3.Controls.Add(this.lblEkipKayitTarihi);
            this.groupBox3.Controls.Add(this.dtpEkipKayitTarihi);
            this.groupBox3.Controls.Add(this.lblEkipLoginfo);
            this.groupBox3.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox3.Location = new System.Drawing.Point(40, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 54);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıt Bilgileri";
            // 
            // lblEkipKullanici
            // 
            this.lblEkipKullanici.AutoSize = true;
            this.lblEkipKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblEkipKullanici.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEkipKullanici.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkipKullanici.Location = new System.Drawing.Point(5, 19);
            this.lblEkipKullanici.Name = "lblEkipKullanici";
            this.lblEkipKullanici.Size = new System.Drawing.Size(64, 22);
            this.lblEkipKullanici.TabIndex = 38;
            this.lblEkipKullanici.Text = "Kullanıcı:";
            this.lblEkipKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ekip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(665, 625);
            this.ContextMenuStrip = this.cmsEkip;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picEkipDrive);
            this.Controls.Add(this.btnEkipYenile);
            this.Controls.Add(this.btnEkipPano);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEkipEposta);
            this.Controls.Add(this.btnEkipExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEkip);
            this.MaximizeBox = false;
            this.Name = "ekip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekip : Doğu Akdeniz Araştırma Derneği";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEkip)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEkipDrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cmsEkip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEkip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEkipIsim;
        private System.Windows.Forms.Label lblEkipSoyisim;
        private System.Windows.Forms.Label lblEkipDogum;
        private System.Windows.Forms.Label lblEkipTc;
        private System.Windows.Forms.Label lblEkipTelefon;
        private System.Windows.Forms.Label lblEkipEposta;
        private System.Windows.Forms.Label lblEkipAdres;
        private System.Windows.Forms.Label lblEkipSehir;
        private System.Windows.Forms.TextBox txtEkipAra;
        private System.Windows.Forms.Button btnEkipAra;
        private System.Windows.Forms.Button btnEkipYeni;
        private System.Windows.Forms.Button btnEkipKaydet;
        private System.Windows.Forms.Button btnEkipSil;
        private System.Windows.Forms.Button btnEkipTemizle;
        private System.Windows.Forms.TextBox txtEkipIsim;
        private System.Windows.Forms.TextBox txtEkipTc;
        private System.Windows.Forms.TextBox txtEkipTelefon;
        private System.Windows.Forms.TextBox txtEkipEposta;
        private System.Windows.Forms.TextBox txtEkipAdres;
        private System.Windows.Forms.TextBox txtEkipSoyisim;
        private System.Windows.Forms.Button btnEkipExcel;
        private System.Windows.Forms.Button btnEkipEposta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEkipPano;
        private System.Windows.Forms.Button btnEkipGuncelle;
        private System.Windows.Forms.Button btnEkipYenile;
        private System.Windows.Forms.Label lblEkipKayitTarihi;
        private System.Windows.Forms.DateTimePicker dtpEkipKayitTarihi;
        private System.Windows.Forms.DateTimePicker dtpEkipDogum;
        private System.Windows.Forms.ComboBox cbEkipSehir;
        private System.Windows.Forms.Label lblEkipLoginfo;
        private System.Windows.Forms.PictureBox picEkipDrive;
        private System.Windows.Forms.ContextMenuStrip cmsEkip;
        private System.Windows.Forms.ToolStripMenuItem cmsEkipItemYeni;
        private System.Windows.Forms.ToolStripMenuItem cmsEkipItemTemizle;
        private System.Windows.Forms.ToolStripMenuItem cmsEkipItemYenile;
        private System.Windows.Forms.ToolTip tipEkipYeni;
        private System.Windows.Forms.ToolTip tipEkipAra;
        private System.Windows.Forms.ToolTip tipEkipSil;
        private System.Windows.Forms.ToolTip tipEkipDuzenle;
        private System.Windows.Forms.ToolTip tipEkipTemizle;
        private System.Windows.Forms.ToolTip tipEkipKaydet;
        private System.Windows.Forms.ToolTip tipEkipDrive;
        private System.Windows.Forms.ToolTip tipEkipYenile;
        private System.Windows.Forms.Label lblEkipID;
        private System.Windows.Forms.Label lblEkipKayitNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEkipKullanici;
    }
}
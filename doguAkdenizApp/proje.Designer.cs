namespace doguAkdenizApp
{
    partial class proje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProjeGuncelle = new System.Windows.Forms.Button();
            this.txtProjeAra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProjeAra = new System.Windows.Forms.Button();
            this.btnProjeYeni = new System.Windows.Forms.Button();
            this.btnProjeKaydet = new System.Windows.Forms.Button();
            this.btnProjeSil = new System.Windows.Forms.Button();
            this.btnProjeTemizle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblProjeKullanici = new System.Windows.Forms.Label();
            this.lblProjeKayitNo = new System.Windows.Forms.Label();
            this.lblProjeID = new System.Windows.Forms.Label();
            this.lblProjeKayitTarihi = new System.Windows.Forms.Label();
            this.dtpProjeKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblProjeLoginfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProjeOzet = new System.Windows.Forms.TextBox();
            this.txtProjePartner = new System.Windows.Forms.TextBox();
            this.lblProjePartner = new System.Windows.Forms.Label();
            this.txtProjeFonTutar = new System.Windows.Forms.TextBox();
            this.lblProjeFonTutar = new System.Windows.Forms.Label();
            this.txtProjeFonOrg = new System.Windows.Forms.TextBox();
            this.lblProjeBaslik = new System.Windows.Forms.Label();
            this.lblProjeLokasyon = new System.Windows.Forms.Label();
            this.lblProjeOzet = new System.Windows.Forms.Label();
            this.lblProjeSorumlu = new System.Windows.Forms.Label();
            this.lblProjeSorumluIletisim = new System.Windows.Forms.Label();
            this.lblProjeFonOr = new System.Windows.Forms.Label();
            this.txtProjeBaslik = new System.Windows.Forms.TextBox();
            this.txtProjeSorumlu = new System.Windows.Forms.TextBox();
            this.txtProjeSorumluIletisim = new System.Windows.Forms.TextBox();
            this.txtProjeLokasyon = new System.Windows.Forms.TextBox();
            this.cmsProje = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsProjeItemYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsProjeItemTemizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsProjeItemYenile = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvProje = new System.Windows.Forms.DataGridView();
            this.picProjeDrive = new System.Windows.Forms.PictureBox();
            this.btnProjeYenile = new System.Windows.Forms.Button();
            this.btnProjePano = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnProjeEposta = new System.Windows.Forms.Button();
            this.btnProjeExcel = new System.Windows.Forms.Button();
            this.tipProjeYeni = new System.Windows.Forms.ToolTip(this.components);
            this.tipProjeTemizle = new System.Windows.Forms.ToolTip(this.components);
            this.tipProjeSil = new System.Windows.Forms.ToolTip(this.components);
            this.tipProjeDuzenle = new System.Windows.Forms.ToolTip(this.components);
            this.tipProjeKaydet = new System.Windows.Forms.ToolTip(this.components);
            this.tipProjeAra = new System.Windows.Forms.ToolTip(this.components);
            this.tipProjeDrive = new System.Windows.Forms.ToolTip(this.components);
            this.tipProjeYenile = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cmsProje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjeDrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProjeGuncelle);
            this.groupBox1.Controls.Add(this.txtProjeAra);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnProjeAra);
            this.groupBox1.Controls.Add(this.btnProjeYeni);
            this.groupBox1.Controls.Add(this.btnProjeKaydet);
            this.groupBox1.Controls.Add(this.btnProjeSil);
            this.groupBox1.Controls.Add(this.btnProjeTemizle);
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proje Kaydı Olustur";
            // 
            // btnProjeGuncelle
            // 
            this.btnProjeGuncelle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProjeGuncelle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjeGuncelle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeGuncelle.Image = global::doguAkdenizApp.Properties.Resources.Update20;
            this.btnProjeGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjeGuncelle.Location = new System.Drawing.Point(153, 57);
            this.btnProjeGuncelle.Name = "btnProjeGuncelle";
            this.btnProjeGuncelle.Size = new System.Drawing.Size(86, 32);
            this.btnProjeGuncelle.TabIndex = 3;
            this.btnProjeGuncelle.Text = "Düzenle";
            this.btnProjeGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipProjeDuzenle.SetToolTip(this.btnProjeGuncelle, "Seçili kaydı veritabanında gunceller");
            this.btnProjeGuncelle.UseVisualStyleBackColor = false;
            this.btnProjeGuncelle.Click += new System.EventHandler(this.btnProjeGuncelle_Click);
            // 
            // txtProjeAra
            // 
            this.txtProjeAra.Location = new System.Drawing.Point(471, 27);
            this.txtProjeAra.Name = "txtProjeAra";
            this.txtProjeAra.Size = new System.Drawing.Size(195, 20);
            this.txtProjeAra.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::doguAkdenizApp.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnProjeAra
            // 
            this.btnProjeAra.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProjeAra.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjeAra.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeAra.Image = global::doguAkdenizApp.Properties.Resources.glass_24;
            this.btnProjeAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjeAra.Location = new System.Drawing.Point(586, 57);
            this.btnProjeAra.Name = "btnProjeAra";
            this.btnProjeAra.Size = new System.Drawing.Size(80, 32);
            this.btnProjeAra.TabIndex = 6;
            this.btnProjeAra.Text = "Ara";
            this.btnProjeAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipProjeAra.SetToolTip(this.btnProjeAra, "Veritabanında arama yapar");
            this.btnProjeAra.UseVisualStyleBackColor = false;
            this.btnProjeAra.Click += new System.EventHandler(this.btnProjeAra_Click);
            // 
            // btnProjeYeni
            // 
            this.btnProjeYeni.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProjeYeni.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjeYeni.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeYeni.Image = global::doguAkdenizApp.Properties.Resources._00001;
            this.btnProjeYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjeYeni.Location = new System.Drawing.Point(85, 19);
            this.btnProjeYeni.Name = "btnProjeYeni";
            this.btnProjeYeni.Size = new System.Drawing.Size(62, 32);
            this.btnProjeYeni.TabIndex = 0;
            this.btnProjeYeni.Text = "Yeni";
            this.btnProjeYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipProjeYeni.SetToolTip(this.btnProjeYeni, "Yeni bir form açar");
            this.btnProjeYeni.UseVisualStyleBackColor = false;
            this.btnProjeYeni.Click += new System.EventHandler(this.btnProjeYeni_Click);
            // 
            // btnProjeKaydet
            // 
            this.btnProjeKaydet.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProjeKaydet.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjeKaydet.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeKaydet.Image = global::doguAkdenizApp.Properties.Resources.floppy;
            this.btnProjeKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjeKaydet.Location = new System.Drawing.Point(245, 57);
            this.btnProjeKaydet.Name = "btnProjeKaydet";
            this.btnProjeKaydet.Size = new System.Drawing.Size(85, 32);
            this.btnProjeKaydet.TabIndex = 4;
            this.btnProjeKaydet.Text = "Kaydet";
            this.btnProjeKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipProjeKaydet.SetToolTip(this.btnProjeKaydet, "Formda yer alan bilgileri veritabanına kaydeder");
            this.btnProjeKaydet.UseVisualStyleBackColor = false;
            this.btnProjeKaydet.Click += new System.EventHandler(this.btnProjeKaydet_Click);
            // 
            // btnProjeSil
            // 
            this.btnProjeSil.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProjeSil.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjeSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeSil.Image = global::doguAkdenizApp.Properties.Resources._0001;
            this.btnProjeSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjeSil.Location = new System.Drawing.Point(85, 57);
            this.btnProjeSil.Name = "btnProjeSil";
            this.btnProjeSil.Size = new System.Drawing.Size(62, 32);
            this.btnProjeSil.TabIndex = 2;
            this.btnProjeSil.Text = "Sil";
            this.btnProjeSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipProjeSil.SetToolTip(this.btnProjeSil, "Seçili kaydı veritabanından siler");
            this.btnProjeSil.UseVisualStyleBackColor = false;
            this.btnProjeSil.Click += new System.EventHandler(this.btnProjeSil_Click);
            // 
            // btnProjeTemizle
            // 
            this.btnProjeTemizle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProjeTemizle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjeTemizle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeTemizle.Image = global::doguAkdenizApp.Properties.Resources.clear;
            this.btnProjeTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjeTemizle.Location = new System.Drawing.Point(153, 20);
            this.btnProjeTemizle.Name = "btnProjeTemizle";
            this.btnProjeTemizle.Size = new System.Drawing.Size(86, 32);
            this.btnProjeTemizle.TabIndex = 1;
            this.btnProjeTemizle.Text = "Temizle";
            this.btnProjeTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipProjeTemizle.SetToolTip(this.btnProjeTemizle, "Formu temizler");
            this.btnProjeTemizle.UseVisualStyleBackColor = false;
            this.btnProjeTemizle.Click += new System.EventHandler(this.btnProjeTemizle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblProjeKullanici);
            this.groupBox3.Controls.Add(this.lblProjeKayitNo);
            this.groupBox3.Controls.Add(this.lblProjeID);
            this.groupBox3.Controls.Add(this.lblProjeKayitTarihi);
            this.groupBox3.Controls.Add(this.dtpProjeKayitTarihi);
            this.groupBox3.Controls.Add(this.lblProjeLoginfo);
            this.groupBox3.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox3.Location = new System.Drawing.Point(12, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıt Bilgileri";
            // 
            // lblProjeKullanici
            // 
            this.lblProjeKullanici.AutoSize = true;
            this.lblProjeKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeKullanici.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeKullanici.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeKullanici.Location = new System.Drawing.Point(5, 19);
            this.lblProjeKullanici.Name = "lblProjeKullanici";
            this.lblProjeKullanici.Size = new System.Drawing.Size(64, 22);
            this.lblProjeKullanici.TabIndex = 1;
            this.lblProjeKullanici.Text = "Kullanıcı:";
            this.lblProjeKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjeKayitNo
            // 
            this.lblProjeKayitNo.AutoSize = true;
            this.lblProjeKayitNo.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeKayitNo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeKayitNo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeKayitNo.Location = new System.Drawing.Point(149, 19);
            this.lblProjeKayitNo.Name = "lblProjeKayitNo";
            this.lblProjeKayitNo.Size = new System.Drawing.Size(62, 22);
            this.lblProjeKayitNo.TabIndex = 3;
            this.lblProjeKayitNo.Text = "Kayıt No:";
            // 
            // lblProjeID
            // 
            this.lblProjeID.AutoSize = true;
            this.lblProjeID.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeID.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeID.Location = new System.Drawing.Point(207, 19);
            this.lblProjeID.Name = "lblProjeID";
            this.lblProjeID.Size = new System.Drawing.Size(73, 22);
            this.lblProjeID.TabIndex = 4;
            this.lblProjeID.Text = "{ KayitNo }";
            // 
            // lblProjeKayitTarihi
            // 
            this.lblProjeKayitTarihi.AutoSize = true;
            this.lblProjeKayitTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeKayitTarihi.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeKayitTarihi.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeKayitTarihi.Location = new System.Drawing.Point(359, 19);
            this.lblProjeKayitTarihi.Name = "lblProjeKayitTarihi";
            this.lblProjeKayitTarihi.Size = new System.Drawing.Size(80, 22);
            this.lblProjeKayitTarihi.TabIndex = 5;
            this.lblProjeKayitTarihi.Text = "Kayıt Tarihi:";
            // 
            // dtpProjeKayitTarihi
            // 
            this.dtpProjeKayitTarihi.CustomFormat = "yyyy-MM-dd";
            this.dtpProjeKayitTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProjeKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProjeKayitTarihi.Location = new System.Drawing.Point(465, 21);
            this.dtpProjeKayitTarihi.MinDate = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            this.dtpProjeKayitTarihi.Name = "dtpProjeKayitTarihi";
            this.dtpProjeKayitTarihi.Size = new System.Drawing.Size(201, 20);
            this.dtpProjeKayitTarihi.TabIndex = 0;
            // 
            // lblProjeLoginfo
            // 
            this.lblProjeLoginfo.AutoSize = true;
            this.lblProjeLoginfo.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeLoginfo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeLoginfo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeLoginfo.Location = new System.Drawing.Point(64, 19);
            this.lblProjeLoginfo.Name = "lblProjeLoginfo";
            this.lblProjeLoginfo.Size = new System.Drawing.Size(68, 22);
            this.lblProjeLoginfo.TabIndex = 2;
            this.lblProjeLoginfo.Text = "{ logInfo }";
            this.lblProjeLoginfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProjeOzet);
            this.groupBox2.Controls.Add(this.txtProjePartner);
            this.groupBox2.Controls.Add(this.lblProjePartner);
            this.groupBox2.Controls.Add(this.txtProjeFonTutar);
            this.groupBox2.Controls.Add(this.lblProjeFonTutar);
            this.groupBox2.Controls.Add(this.txtProjeFonOrg);
            this.groupBox2.Controls.Add(this.lblProjeBaslik);
            this.groupBox2.Controls.Add(this.lblProjeLokasyon);
            this.groupBox2.Controls.Add(this.lblProjeOzet);
            this.groupBox2.Controls.Add(this.lblProjeSorumlu);
            this.groupBox2.Controls.Add(this.lblProjeSorumluIletisim);
            this.groupBox2.Controls.Add(this.lblProjeFonOr);
            this.groupBox2.Controls.Add(this.txtProjeBaslik);
            this.groupBox2.Controls.Add(this.txtProjeSorumlu);
            this.groupBox2.Controls.Add(this.txtProjeSorumluIletisim);
            this.groupBox2.Controls.Add(this.txtProjeLokasyon);
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proje Bilgileri";
            // 
            // txtProjeOzet
            // 
            this.txtProjeOzet.Location = new System.Drawing.Point(68, 50);
            this.txtProjeOzet.Multiline = true;
            this.txtProjeOzet.Name = "txtProjeOzet";
            this.txtProjeOzet.Size = new System.Drawing.Size(598, 41);
            this.txtProjeOzet.TabIndex = 1;
            // 
            // txtProjePartner
            // 
            this.txtProjePartner.Location = new System.Drawing.Point(67, 149);
            this.txtProjePartner.Name = "txtProjePartner";
            this.txtProjePartner.Size = new System.Drawing.Size(201, 20);
            this.txtProjePartner.TabIndex = 6;
            // 
            // lblProjePartner
            // 
            this.lblProjePartner.AutoSize = true;
            this.lblProjePartner.BackColor = System.Drawing.Color.Transparent;
            this.lblProjePartner.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjePartner.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjePartner.Location = new System.Drawing.Point(5, 146);
            this.lblProjePartner.Name = "lblProjePartner";
            this.lblProjePartner.Size = new System.Drawing.Size(56, 22);
            this.lblProjePartner.TabIndex = 12;
            this.lblProjePartner.Text = "Partner:";
            // 
            // txtProjeFonTutar
            // 
            this.txtProjeFonTutar.Location = new System.Drawing.Point(465, 123);
            this.txtProjeFonTutar.Name = "txtProjeFonTutar";
            this.txtProjeFonTutar.Size = new System.Drawing.Size(201, 20);
            this.txtProjeFonTutar.TabIndex = 5;
            // 
            // lblProjeFonTutar
            // 
            this.lblProjeFonTutar.AutoSize = true;
            this.lblProjeFonTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeFonTutar.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeFonTutar.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeFonTutar.Location = new System.Drawing.Point(334, 120);
            this.lblProjeFonTutar.Name = "lblProjeFonTutar";
            this.lblProjeFonTutar.Size = new System.Drawing.Size(70, 22);
            this.lblProjeFonTutar.TabIndex = 14;
            this.lblProjeFonTutar.Text = "Fon Tutarı:";
            // 
            // txtProjeFonOrg
            // 
            this.txtProjeFonOrg.Location = new System.Drawing.Point(68, 123);
            this.txtProjeFonOrg.Name = "txtProjeFonOrg";
            this.txtProjeFonOrg.Size = new System.Drawing.Size(200, 20);
            this.txtProjeFonOrg.TabIndex = 4;
            // 
            // lblProjeBaslik
            // 
            this.lblProjeBaslik.AutoSize = true;
            this.lblProjeBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeBaslik.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeBaslik.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeBaslik.Location = new System.Drawing.Point(5, 19);
            this.lblProjeBaslik.Name = "lblProjeBaslik";
            this.lblProjeBaslik.Size = new System.Drawing.Size(49, 22);
            this.lblProjeBaslik.TabIndex = 8;
            this.lblProjeBaslik.Text = "Başlık:";
            // 
            // lblProjeLokasyon
            // 
            this.lblProjeLokasyon.AutoSize = true;
            this.lblProjeLokasyon.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeLokasyon.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeLokasyon.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeLokasyon.Location = new System.Drawing.Point(334, 146);
            this.lblProjeLokasyon.Name = "lblProjeLokasyon";
            this.lblProjeLokasyon.Size = new System.Drawing.Size(68, 22);
            this.lblProjeLokasyon.TabIndex = 15;
            this.lblProjeLokasyon.Text = "Lokasyon:";
            // 
            // lblProjeOzet
            // 
            this.lblProjeOzet.AutoSize = true;
            this.lblProjeOzet.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeOzet.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeOzet.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeOzet.Location = new System.Drawing.Point(5, 47);
            this.lblProjeOzet.Name = "lblProjeOzet";
            this.lblProjeOzet.Size = new System.Drawing.Size(40, 22);
            this.lblProjeOzet.TabIndex = 9;
            this.lblProjeOzet.Text = "Özet:";
            // 
            // lblProjeSorumlu
            // 
            this.lblProjeSorumlu.AutoSize = true;
            this.lblProjeSorumlu.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeSorumlu.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeSorumlu.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeSorumlu.Location = new System.Drawing.Point(5, 94);
            this.lblProjeSorumlu.Name = "lblProjeSorumlu";
            this.lblProjeSorumlu.Size = new System.Drawing.Size(60, 22);
            this.lblProjeSorumlu.TabIndex = 10;
            this.lblProjeSorumlu.Text = "Sorumlu:";
            // 
            // lblProjeSorumluIletisim
            // 
            this.lblProjeSorumluIletisim.AutoSize = true;
            this.lblProjeSorumluIletisim.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeSorumluIletisim.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeSorumluIletisim.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeSorumluIletisim.Location = new System.Drawing.Point(334, 94);
            this.lblProjeSorumluIletisim.Name = "lblProjeSorumluIletisim";
            this.lblProjeSorumluIletisim.Size = new System.Drawing.Size(105, 22);
            this.lblProjeSorumluIletisim.TabIndex = 13;
            this.lblProjeSorumluIletisim.Text = "Sorumlu İletişim:";
            // 
            // lblProjeFonOr
            // 
            this.lblProjeFonOr.AutoSize = true;
            this.lblProjeFonOr.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeFonOr.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeFonOr.ForeColor = System.Drawing.Color.Firebrick;
            this.lblProjeFonOr.Location = new System.Drawing.Point(5, 120);
            this.lblProjeFonOr.Name = "lblProjeFonOr";
            this.lblProjeFonOr.Size = new System.Drawing.Size(62, 22);
            this.lblProjeFonOr.TabIndex = 11;
            this.lblProjeFonOr.Text = "Fon Org.:";
            // 
            // txtProjeBaslik
            // 
            this.txtProjeBaslik.Location = new System.Drawing.Point(68, 22);
            this.txtProjeBaslik.Name = "txtProjeBaslik";
            this.txtProjeBaslik.Size = new System.Drawing.Size(201, 20);
            this.txtProjeBaslik.TabIndex = 0;
            // 
            // txtProjeSorumlu
            // 
            this.txtProjeSorumlu.Location = new System.Drawing.Point(68, 97);
            this.txtProjeSorumlu.Name = "txtProjeSorumlu";
            this.txtProjeSorumlu.Size = new System.Drawing.Size(201, 20);
            this.txtProjeSorumlu.TabIndex = 2;
            // 
            // txtProjeSorumluIletisim
            // 
            this.txtProjeSorumluIletisim.Location = new System.Drawing.Point(465, 97);
            this.txtProjeSorumluIletisim.Name = "txtProjeSorumluIletisim";
            this.txtProjeSorumluIletisim.Size = new System.Drawing.Size(201, 20);
            this.txtProjeSorumluIletisim.TabIndex = 3;
            // 
            // txtProjeLokasyon
            // 
            this.txtProjeLokasyon.Location = new System.Drawing.Point(465, 149);
            this.txtProjeLokasyon.Name = "txtProjeLokasyon";
            this.txtProjeLokasyon.Size = new System.Drawing.Size(201, 20);
            this.txtProjeLokasyon.TabIndex = 7;
            // 
            // cmsProje
            // 
            this.cmsProje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsProjeItemYeni,
            this.cmsProjeItemTemizle,
            this.cmsProjeItemYenile});
            this.cmsProje.Name = "contextMenuStrip1";
            this.cmsProje.Size = new System.Drawing.Size(115, 70);
            // 
            // cmsProjeItemYeni
            // 
            this.cmsProjeItemYeni.Name = "cmsProjeItemYeni";
            this.cmsProjeItemYeni.Size = new System.Drawing.Size(114, 22);
            this.cmsProjeItemYeni.Text = "Yeni";
            this.cmsProjeItemYeni.Click += new System.EventHandler(this.cmsProjeItemYeni_Click);
            // 
            // cmsProjeItemTemizle
            // 
            this.cmsProjeItemTemizle.Name = "cmsProjeItemTemizle";
            this.cmsProjeItemTemizle.Size = new System.Drawing.Size(114, 22);
            this.cmsProjeItemTemizle.Text = "Temizle";
            this.cmsProjeItemTemizle.Click += new System.EventHandler(this.cmsProjeItemTemizle_Click);
            // 
            // cmsProjeItemYenile
            // 
            this.cmsProjeItemYenile.Name = "cmsProjeItemYenile";
            this.cmsProjeItemYenile.Size = new System.Drawing.Size(114, 22);
            this.cmsProjeItemYenile.Text = "Yenile";
            this.cmsProjeItemYenile.Click += new System.EventHandler(this.cmsProjeItemYenile_Click);
            // 
            // dgvProje
            // 
            this.dgvProje.AllowUserToAddRows = false;
            this.dgvProje.AllowUserToDeleteRows = false;
            this.dgvProje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProje.Location = new System.Drawing.Point(12, 371);
            this.dgvProje.Name = "dgvProje";
            this.dgvProje.ReadOnly = true;
            this.dgvProje.Size = new System.Drawing.Size(672, 239);
            this.dgvProje.TabIndex = 7;
            this.dgvProje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProje_CellContentClick);
            // 
            // picProjeDrive
            // 
            this.picProjeDrive.Image = global::doguAkdenizApp.Properties.Resources.drive;
            this.picProjeDrive.Location = new System.Drawing.Point(365, 621);
            this.picProjeDrive.Name = "picProjeDrive";
            this.picProjeDrive.Size = new System.Drawing.Size(30, 32);
            this.picProjeDrive.TabIndex = 50;
            this.picProjeDrive.TabStop = false;
            this.picProjeDrive.Click += new System.EventHandler(this.picProjeDrive_Click);
            // 
            // btnProjeYenile
            // 
            this.btnProjeYenile.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProjeYenile.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjeYenile.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeYenile.Image = global::doguAkdenizApp.Properties.Resources.radial_arrows_20;
            this.btnProjeYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjeYenile.Location = new System.Drawing.Point(605, 616);
            this.btnProjeYenile.Name = "btnProjeYenile";
            this.btnProjeYenile.Size = new System.Drawing.Size(79, 32);
            this.btnProjeYenile.TabIndex = 3;
            this.btnProjeYenile.Text = "Yenile";
            this.btnProjeYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipProjeYenile.SetToolTip(this.btnProjeYenile, "Veritabanını yeniler");
            this.btnProjeYenile.UseVisualStyleBackColor = false;
            this.btnProjeYenile.Click += new System.EventHandler(this.btnProjeYenile_Click);
            // 
            // btnProjePano
            // 
            this.btnProjePano.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProjePano.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjePano.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjePano.Location = new System.Drawing.Point(46, 616);
            this.btnProjePano.Name = "btnProjePano";
            this.btnProjePano.Size = new System.Drawing.Size(102, 32);
            this.btnProjePano.TabIndex = 6;
            this.btnProjePano.Text = "Panoya Geri dön!";
            this.btnProjePano.UseVisualStyleBackColor = false;
            this.btnProjePano.Click += new System.EventHandler(this.btnProjePano_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::doguAkdenizApp.Properties.Resources.list;
            this.pictureBox2.Location = new System.Drawing.Point(12, 616);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 44);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // btnProjeEposta
            // 
            this.btnProjeEposta.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProjeEposta.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjeEposta.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeEposta.Location = new System.Drawing.Point(401, 616);
            this.btnProjeEposta.Name = "btnProjeEposta";
            this.btnProjeEposta.Size = new System.Drawing.Size(96, 32);
            this.btnProjeEposta.TabIndex = 5;
            this.btnProjeEposta.Text = "ePosta Gönder";
            this.btnProjeEposta.UseVisualStyleBackColor = false;
            // 
            // btnProjeExcel
            // 
            this.btnProjeExcel.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProjeExcel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjeExcel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeExcel.Location = new System.Drawing.Point(503, 616);
            this.btnProjeExcel.Name = "btnProjeExcel";
            this.btnProjeExcel.Size = new System.Drawing.Size(96, 32);
            this.btnProjeExcel.TabIndex = 4;
            this.btnProjeExcel.Text = "Excel\'e Çıkar";
            this.btnProjeExcel.UseVisualStyleBackColor = false;
            // 
            // proje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(696, 664);
            this.ContextMenuStrip = this.cmsProje;
            this.Controls.Add(this.picProjeDrive);
            this.Controls.Add(this.btnProjeYenile);
            this.Controls.Add(this.btnProjePano);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnProjeEposta);
            this.Controls.Add(this.btnProjeExcel);
            this.Controls.Add(this.dgvProje);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "proje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje : Doğu Akdeniz Araştırma Derneği";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cmsProje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjeDrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProjeGuncelle;
        private System.Windows.Forms.TextBox txtProjeAra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProjeAra;
        private System.Windows.Forms.Button btnProjeYeni;
        private System.Windows.Forms.Button btnProjeKaydet;
        private System.Windows.Forms.Button btnProjeSil;
        private System.Windows.Forms.Button btnProjeTemizle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblProjeKullanici;
        private System.Windows.Forms.Label lblProjeKayitNo;
        private System.Windows.Forms.Label lblProjeID;
        private System.Windows.Forms.Label lblProjeKayitTarihi;
        private System.Windows.Forms.DateTimePicker dtpProjeKayitTarihi;
        private System.Windows.Forms.Label lblProjeLoginfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblProjeBaslik;
        private System.Windows.Forms.Label lblProjeLokasyon;
        private System.Windows.Forms.Label lblProjeOzet;
        private System.Windows.Forms.Label lblProjeSorumlu;
        private System.Windows.Forms.Label lblProjeSorumluIletisim;
        private System.Windows.Forms.Label lblProjeFonOr;
        private System.Windows.Forms.TextBox txtProjeBaslik;
        private System.Windows.Forms.TextBox txtProjeSorumlu;
        private System.Windows.Forms.TextBox txtProjeSorumluIletisim;
        private System.Windows.Forms.TextBox txtProjeLokasyon;
        private System.Windows.Forms.ContextMenuStrip cmsProje;
        private System.Windows.Forms.TextBox txtProjePartner;
        private System.Windows.Forms.Label lblProjePartner;
        private System.Windows.Forms.TextBox txtProjeFonTutar;
        private System.Windows.Forms.Label lblProjeFonTutar;
        private System.Windows.Forms.TextBox txtProjeFonOrg;
        private System.Windows.Forms.DataGridView dgvProje;
        private System.Windows.Forms.PictureBox picProjeDrive;
        private System.Windows.Forms.Button btnProjeYenile;
        private System.Windows.Forms.Button btnProjePano;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnProjeEposta;
        private System.Windows.Forms.Button btnProjeExcel;
        private System.Windows.Forms.ToolStripMenuItem cmsProjeItemYeni;
        private System.Windows.Forms.ToolStripMenuItem cmsProjeItemTemizle;
        private System.Windows.Forms.ToolStripMenuItem cmsProjeItemYenile;
        private System.Windows.Forms.ToolTip tipProjeYeni;
        private System.Windows.Forms.ToolTip tipProjeTemizle;
        private System.Windows.Forms.ToolTip tipProjeSil;
        private System.Windows.Forms.ToolTip tipProjeDuzenle;
        private System.Windows.Forms.ToolTip tipProjeKaydet;
        private System.Windows.Forms.ToolTip tipProjeAra;
        private System.Windows.Forms.ToolTip tipProjeDrive;
        private System.Windows.Forms.ToolTip tipProjeYenile;
        private System.Windows.Forms.TextBox txtProjeOzet;
    }
}
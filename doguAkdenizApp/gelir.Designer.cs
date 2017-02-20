namespace doguAkdenizApp
{
    partial class gelir
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
            this.picGelirDrive = new System.Windows.Forms.PictureBox();
            this.btnGelirPano = new System.Windows.Forms.Button();
            this.cbGelirTuru = new System.Windows.Forms.ComboBox();
            this.lblGelirTuru = new System.Windows.Forms.Label();
            this.lblGelirIsim = new System.Windows.Forms.Label();
            this.lblGelirSoyisim = new System.Windows.Forms.Label();
            this.lblGelirOzet = new System.Windows.Forms.Label();
            this.txtGelirIsim = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGelirEposta = new System.Windows.Forms.Button();
            this.btnGelirExcel = new System.Windows.Forms.Button();
            this.tipGelirAra = new System.Windows.Forms.ToolTip(this.components);
            this.btnGelirAra = new System.Windows.Forms.Button();
            this.tipGelirYenile = new System.Windows.Forms.ToolTip(this.components);
            this.btnGelirYenile = new System.Windows.Forms.Button();
            this.tipGelirDrive = new System.Windows.Forms.ToolTip(this.components);
            this.tipGelirYeni = new System.Windows.Forms.ToolTip(this.components);
            this.btnGelirYeni = new System.Windows.Forms.Button();
            this.tipGelirTemizle = new System.Windows.Forms.ToolTip(this.components);
            this.btnGelirTemizle = new System.Windows.Forms.Button();
            this.tipGelirSil = new System.Windows.Forms.ToolTip(this.components);
            this.btnGelirSil = new System.Windows.Forms.Button();
            this.tipGelirDuzenle = new System.Windows.Forms.ToolTip(this.components);
            this.btnGelirGuncelle = new System.Windows.Forms.Button();
            this.tipGelirKaydet = new System.Windows.Forms.ToolTip(this.components);
            this.btnGelirKaydet = new System.Windows.Forms.Button();
            this.cmsGelir = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsBagisItemYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBagisItemTemizle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBagisItemYenile = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGelirOzet = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblGelirKullanici = new System.Windows.Forms.Label();
            this.lblGelirKayitNo = new System.Windows.Forms.Label();
            this.lblGelirID = new System.Windows.Forms.Label();
            this.lblGelirKayitTarihi = new System.Windows.Forms.Label();
            this.dtpGelirKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblGelirLoginfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGelirSoyisim = new System.Windows.Forms.TextBox();
            this.txtGelirAra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvGelir = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGelirDrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cmsGelir.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGelir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picGelirDrive
            // 
            this.picGelirDrive.Image = global::doguAkdenizApp.Properties.Resources.drive;
            this.picGelirDrive.Location = new System.Drawing.Point(365, 513);
            this.picGelirDrive.Name = "picGelirDrive";
            this.picGelirDrive.Size = new System.Drawing.Size(30, 32);
            this.picGelirDrive.TabIndex = 58;
            this.picGelirDrive.TabStop = false;
            this.tipGelirDrive.SetToolTip(this.picGelirDrive, "Google Drive\'a bağlanır");
            // 
            // btnGelirPano
            // 
            this.btnGelirPano.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGelirPano.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirPano.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelirPano.Location = new System.Drawing.Point(46, 508);
            this.btnGelirPano.Name = "btnGelirPano";
            this.btnGelirPano.Size = new System.Drawing.Size(102, 32);
            this.btnGelirPano.TabIndex = 6;
            this.btnGelirPano.Text = "Panoya Geri dön!";
            this.btnGelirPano.UseVisualStyleBackColor = false;
            // 
            // cbGelirTuru
            // 
            this.cbGelirTuru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbGelirTuru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGelirTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGelirTuru.FormattingEnabled = true;
            this.cbGelirTuru.Items.AddRange(new object[] {
            "Materyal Geliri",
            "Nakit Gelir"});
            this.cbGelirTuru.Location = new System.Drawing.Point(68, 45);
            this.cbGelirTuru.Name = "cbGelirTuru";
            this.cbGelirTuru.Size = new System.Drawing.Size(201, 20);
            this.cbGelirTuru.TabIndex = 2;
            this.cbGelirTuru.Text = "Lütfen listeden gelir türü seçimi yapınız.";
            // 
            // lblGelirTuru
            // 
            this.lblGelirTuru.AutoSize = true;
            this.lblGelirTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblGelirTuru.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelirTuru.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGelirTuru.Location = new System.Drawing.Point(3, 45);
            this.lblGelirTuru.Name = "lblGelirTuru";
            this.lblGelirTuru.Size = new System.Drawing.Size(39, 22);
            this.lblGelirTuru.TabIndex = 6;
            this.lblGelirTuru.Text = "Türü:";
            // 
            // lblGelirIsim
            // 
            this.lblGelirIsim.AutoSize = true;
            this.lblGelirIsim.BackColor = System.Drawing.Color.Transparent;
            this.lblGelirIsim.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelirIsim.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGelirIsim.Location = new System.Drawing.Point(5, 19);
            this.lblGelirIsim.Name = "lblGelirIsim";
            this.lblGelirIsim.Size = new System.Drawing.Size(40, 22);
            this.lblGelirIsim.TabIndex = 4;
            this.lblGelirIsim.Text = "İsim: ";
            // 
            // lblGelirSoyisim
            // 
            this.lblGelirSoyisim.AutoSize = true;
            this.lblGelirSoyisim.BackColor = System.Drawing.Color.Transparent;
            this.lblGelirSoyisim.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelirSoyisim.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGelirSoyisim.Location = new System.Drawing.Point(371, 21);
            this.lblGelirSoyisim.Name = "lblGelirSoyisim";
            this.lblGelirSoyisim.Size = new System.Drawing.Size(61, 22);
            this.lblGelirSoyisim.TabIndex = 5;
            this.lblGelirSoyisim.Text = "Soyisim: ";
            // 
            // lblGelirOzet
            // 
            this.lblGelirOzet.AutoSize = true;
            this.lblGelirOzet.BackColor = System.Drawing.Color.Transparent;
            this.lblGelirOzet.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelirOzet.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGelirOzet.Location = new System.Drawing.Point(371, 45);
            this.lblGelirOzet.Name = "lblGelirOzet";
            this.lblGelirOzet.Size = new System.Drawing.Size(40, 22);
            this.lblGelirOzet.TabIndex = 7;
            this.lblGelirOzet.Text = "Özet:";
            // 
            // txtGelirIsim
            // 
            this.txtGelirIsim.Location = new System.Drawing.Point(68, 21);
            this.txtGelirIsim.Name = "txtGelirIsim";
            this.txtGelirIsim.Size = new System.Drawing.Size(201, 20);
            this.txtGelirIsim.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::doguAkdenizApp.Properties.Resources.list;
            this.pictureBox2.Location = new System.Drawing.Point(12, 508);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 44);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // btnGelirEposta
            // 
            this.btnGelirEposta.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGelirEposta.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirEposta.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelirEposta.Location = new System.Drawing.Point(401, 508);
            this.btnGelirEposta.Name = "btnGelirEposta";
            this.btnGelirEposta.Size = new System.Drawing.Size(96, 32);
            this.btnGelirEposta.TabIndex = 5;
            this.btnGelirEposta.Text = "ePosta Gönder";
            this.btnGelirEposta.UseVisualStyleBackColor = false;
            // 
            // btnGelirExcel
            // 
            this.btnGelirExcel.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGelirExcel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirExcel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelirExcel.Location = new System.Drawing.Point(503, 508);
            this.btnGelirExcel.Name = "btnGelirExcel";
            this.btnGelirExcel.Size = new System.Drawing.Size(96, 32);
            this.btnGelirExcel.TabIndex = 4;
            this.btnGelirExcel.Text = "Excel\'e Çıkar";
            this.btnGelirExcel.UseVisualStyleBackColor = false;
            // 
            // btnGelirAra
            // 
            this.btnGelirAra.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGelirAra.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirAra.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelirAra.Image = global::doguAkdenizApp.Properties.Resources.glass_24;
            this.btnGelirAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelirAra.Location = new System.Drawing.Point(586, 57);
            this.btnGelirAra.Name = "btnGelirAra";
            this.btnGelirAra.Size = new System.Drawing.Size(80, 32);
            this.btnGelirAra.TabIndex = 6;
            this.btnGelirAra.Text = "Ara";
            this.btnGelirAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipGelirAra.SetToolTip(this.btnGelirAra, "Veritabanında arama yapar");
            this.btnGelirAra.UseVisualStyleBackColor = false;
            // 
            // btnGelirYenile
            // 
            this.btnGelirYenile.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGelirYenile.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirYenile.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelirYenile.Image = global::doguAkdenizApp.Properties.Resources.radial_arrows_20;
            this.btnGelirYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelirYenile.Location = new System.Drawing.Point(605, 508);
            this.btnGelirYenile.Name = "btnGelirYenile";
            this.btnGelirYenile.Size = new System.Drawing.Size(79, 32);
            this.btnGelirYenile.TabIndex = 3;
            this.btnGelirYenile.Text = "Yenile";
            this.btnGelirYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipGelirYenile.SetToolTip(this.btnGelirYenile, "Veritabanını yeniler");
            this.btnGelirYenile.UseVisualStyleBackColor = false;
            // 
            // btnGelirYeni
            // 
            this.btnGelirYeni.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGelirYeni.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirYeni.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelirYeni.Image = global::doguAkdenizApp.Properties.Resources._00001;
            this.btnGelirYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelirYeni.Location = new System.Drawing.Point(85, 19);
            this.btnGelirYeni.Name = "btnGelirYeni";
            this.btnGelirYeni.Size = new System.Drawing.Size(62, 32);
            this.btnGelirYeni.TabIndex = 0;
            this.btnGelirYeni.Text = "Yeni";
            this.btnGelirYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipGelirYeni.SetToolTip(this.btnGelirYeni, "Yeni bir form açar");
            this.btnGelirYeni.UseVisualStyleBackColor = false;
            // 
            // btnGelirTemizle
            // 
            this.btnGelirTemizle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGelirTemizle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirTemizle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelirTemizle.Image = global::doguAkdenizApp.Properties.Resources.clear;
            this.btnGelirTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelirTemizle.Location = new System.Drawing.Point(153, 20);
            this.btnGelirTemizle.Name = "btnGelirTemizle";
            this.btnGelirTemizle.Size = new System.Drawing.Size(86, 32);
            this.btnGelirTemizle.TabIndex = 1;
            this.btnGelirTemizle.Text = "Temizle";
            this.btnGelirTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipGelirTemizle.SetToolTip(this.btnGelirTemizle, "Formu temizler");
            this.btnGelirTemizle.UseVisualStyleBackColor = false;
            // 
            // btnGelirSil
            // 
            this.btnGelirSil.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGelirSil.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelirSil.Image = global::doguAkdenizApp.Properties.Resources._0001;
            this.btnGelirSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelirSil.Location = new System.Drawing.Point(85, 57);
            this.btnGelirSil.Name = "btnGelirSil";
            this.btnGelirSil.Size = new System.Drawing.Size(62, 32);
            this.btnGelirSil.TabIndex = 2;
            this.btnGelirSil.Text = "Sil";
            this.btnGelirSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipGelirSil.SetToolTip(this.btnGelirSil, "Seçili kaydı veritabanından siler");
            this.btnGelirSil.UseVisualStyleBackColor = false;
            // 
            // btnGelirGuncelle
            // 
            this.btnGelirGuncelle.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGelirGuncelle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirGuncelle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelirGuncelle.Image = global::doguAkdenizApp.Properties.Resources.Update20;
            this.btnGelirGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelirGuncelle.Location = new System.Drawing.Point(153, 57);
            this.btnGelirGuncelle.Name = "btnGelirGuncelle";
            this.btnGelirGuncelle.Size = new System.Drawing.Size(86, 32);
            this.btnGelirGuncelle.TabIndex = 3;
            this.btnGelirGuncelle.Text = "Düzenle";
            this.btnGelirGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipGelirDuzenle.SetToolTip(this.btnGelirGuncelle, "Seçili kaydı veritabanında gunceller");
            this.btnGelirGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnGelirKaydet
            // 
            this.btnGelirKaydet.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGelirKaydet.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirKaydet.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelirKaydet.Image = global::doguAkdenizApp.Properties.Resources.floppy;
            this.btnGelirKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelirKaydet.Location = new System.Drawing.Point(245, 57);
            this.btnGelirKaydet.Name = "btnGelirKaydet";
            this.btnGelirKaydet.Size = new System.Drawing.Size(85, 32);
            this.btnGelirKaydet.TabIndex = 4;
            this.btnGelirKaydet.Text = "Kaydet";
            this.btnGelirKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tipGelirKaydet.SetToolTip(this.btnGelirKaydet, "Formda yer alan bilgileri veritabanına kaydeder");
            this.btnGelirKaydet.UseVisualStyleBackColor = false;
            // 
            // cmsGelir
            // 
            this.cmsGelir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsBagisItemYeni,
            this.cmsBagisItemTemizle,
            this.cmsBagisItemYenile});
            this.cmsGelir.Name = "cmsBagis";
            this.cmsGelir.Size = new System.Drawing.Size(115, 70);
            // 
            // cmsBagisItemYeni
            // 
            this.cmsBagisItemYeni.Name = "cmsBagisItemYeni";
            this.cmsBagisItemYeni.Size = new System.Drawing.Size(114, 22);
            this.cmsBagisItemYeni.Text = "Yeni";
            // 
            // cmsBagisItemTemizle
            // 
            this.cmsBagisItemTemizle.Name = "cmsBagisItemTemizle";
            this.cmsBagisItemTemizle.Size = new System.Drawing.Size(114, 22);
            this.cmsBagisItemTemizle.Text = "Temizle";
            // 
            // cmsBagisItemYenile
            // 
            this.cmsBagisItemYenile.Name = "cmsBagisItemYenile";
            this.cmsBagisItemYenile.Size = new System.Drawing.Size(114, 22);
            this.cmsBagisItemYenile.Text = "Yenile";
            // 
            // txtGelirOzet
            // 
            this.txtGelirOzet.Location = new System.Drawing.Point(465, 45);
            this.txtGelirOzet.Name = "txtGelirOzet";
            this.txtGelirOzet.Size = new System.Drawing.Size(201, 20);
            this.txtGelirOzet.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblGelirKullanici);
            this.groupBox3.Controls.Add(this.lblGelirKayitNo);
            this.groupBox3.Controls.Add(this.lblGelirID);
            this.groupBox3.Controls.Add(this.lblGelirKayitTarihi);
            this.groupBox3.Controls.Add(this.dtpGelirKayitTarihi);
            this.groupBox3.Controls.Add(this.lblGelirLoginfo);
            this.groupBox3.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıt Bilgileri";
            // 
            // lblGelirKullanici
            // 
            this.lblGelirKullanici.AutoSize = true;
            this.lblGelirKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblGelirKullanici.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelirKullanici.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGelirKullanici.Location = new System.Drawing.Point(5, 19);
            this.lblGelirKullanici.Name = "lblGelirKullanici";
            this.lblGelirKullanici.Size = new System.Drawing.Size(64, 22);
            this.lblGelirKullanici.TabIndex = 1;
            this.lblGelirKullanici.Text = "Kullanıcı:";
            this.lblGelirKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGelirKayitNo
            // 
            this.lblGelirKayitNo.AutoSize = true;
            this.lblGelirKayitNo.BackColor = System.Drawing.Color.Transparent;
            this.lblGelirKayitNo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelirKayitNo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGelirKayitNo.Location = new System.Drawing.Point(149, 19);
            this.lblGelirKayitNo.Name = "lblGelirKayitNo";
            this.lblGelirKayitNo.Size = new System.Drawing.Size(62, 22);
            this.lblGelirKayitNo.TabIndex = 3;
            this.lblGelirKayitNo.Text = "Kayıt No:";
            // 
            // lblGelirID
            // 
            this.lblGelirID.AutoSize = true;
            this.lblGelirID.BackColor = System.Drawing.Color.Transparent;
            this.lblGelirID.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelirID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGelirID.Location = new System.Drawing.Point(207, 19);
            this.lblGelirID.Name = "lblGelirID";
            this.lblGelirID.Size = new System.Drawing.Size(73, 22);
            this.lblGelirID.TabIndex = 4;
            this.lblGelirID.Text = "{ KayitNo }";
            // 
            // lblGelirKayitTarihi
            // 
            this.lblGelirKayitTarihi.AutoSize = true;
            this.lblGelirKayitTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblGelirKayitTarihi.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelirKayitTarihi.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGelirKayitTarihi.Location = new System.Drawing.Point(371, 19);
            this.lblGelirKayitTarihi.Name = "lblGelirKayitTarihi";
            this.lblGelirKayitTarihi.Size = new System.Drawing.Size(80, 22);
            this.lblGelirKayitTarihi.TabIndex = 5;
            this.lblGelirKayitTarihi.Text = "Kayıt Tarihi:";
            // 
            // dtpGelirKayitTarihi
            // 
            this.dtpGelirKayitTarihi.CustomFormat = "yyyy-MM-dd";
            this.dtpGelirKayitTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGelirKayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGelirKayitTarihi.Location = new System.Drawing.Point(465, 21);
            this.dtpGelirKayitTarihi.MinDate = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            this.dtpGelirKayitTarihi.Name = "dtpGelirKayitTarihi";
            this.dtpGelirKayitTarihi.Size = new System.Drawing.Size(201, 20);
            this.dtpGelirKayitTarihi.TabIndex = 0;
            // 
            // lblGelirLoginfo
            // 
            this.lblGelirLoginfo.AutoSize = true;
            this.lblGelirLoginfo.BackColor = System.Drawing.Color.Transparent;
            this.lblGelirLoginfo.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelirLoginfo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGelirLoginfo.Location = new System.Drawing.Point(64, 19);
            this.lblGelirLoginfo.Name = "lblGelirLoginfo";
            this.lblGelirLoginfo.Size = new System.Drawing.Size(68, 22);
            this.lblGelirLoginfo.TabIndex = 2;
            this.lblGelirLoginfo.Text = "{ logInfo }";
            this.lblGelirLoginfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGelirTuru);
            this.groupBox2.Controls.Add(this.lblGelirTuru);
            this.groupBox2.Controls.Add(this.lblGelirIsim);
            this.groupBox2.Controls.Add(this.lblGelirSoyisim);
            this.groupBox2.Controls.Add(this.lblGelirOzet);
            this.groupBox2.Controls.Add(this.txtGelirIsim);
            this.groupBox2.Controls.Add(this.txtGelirOzet);
            this.groupBox2.Controls.Add(this.txtGelirSoyisim);
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelir Bilgileri";
            // 
            // txtGelirSoyisim
            // 
            this.txtGelirSoyisim.Location = new System.Drawing.Point(465, 19);
            this.txtGelirSoyisim.Name = "txtGelirSoyisim";
            this.txtGelirSoyisim.Size = new System.Drawing.Size(201, 20);
            this.txtGelirSoyisim.TabIndex = 1;
            // 
            // txtGelirAra
            // 
            this.txtGelirAra.Location = new System.Drawing.Point(471, 27);
            this.txtGelirAra.Name = "txtGelirAra";
            this.txtGelirAra.Size = new System.Drawing.Size(195, 20);
            this.txtGelirAra.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::doguAkdenizApp.Properties.Resources._12;
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvGelir
            // 
            this.dgvGelir.AllowUserToAddRows = false;
            this.dgvGelir.AllowUserToDeleteRows = false;
            this.dgvGelir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGelir.Location = new System.Drawing.Point(12, 263);
            this.dgvGelir.Name = "dgvGelir";
            this.dgvGelir.ReadOnly = true;
            this.dgvGelir.Size = new System.Drawing.Size(672, 239);
            this.dgvGelir.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGelirGuncelle);
            this.groupBox1.Controls.Add(this.txtGelirAra);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnGelirAra);
            this.groupBox1.Controls.Add(this.btnGelirYeni);
            this.groupBox1.Controls.Add(this.btnGelirKaydet);
            this.groupBox1.Controls.Add(this.btnGelirSil);
            this.groupBox1.Controls.Add(this.btnGelirTemizle);
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelir Kaydı Olustur";
            // 
            // gelir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(696, 559);
            this.ContextMenuStrip = this.cmsGelir;
            this.Controls.Add(this.picGelirDrive);
            this.Controls.Add(this.btnGelirPano);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGelirEposta);
            this.Controls.Add(this.btnGelirExcel);
            this.Controls.Add(this.btnGelirYenile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvGelir);
            this.Controls.Add(this.groupBox1);
            this.Name = "gelir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir : Doğu Akdeniz Araştırma Derneği";
            ((System.ComponentModel.ISupportInitialize)(this.picGelirDrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cmsGelir.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGelir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGelirDrive;
        private System.Windows.Forms.ToolTip tipGelirDrive;
        private System.Windows.Forms.Button btnGelirPano;
        private System.Windows.Forms.ComboBox cbGelirTuru;
        private System.Windows.Forms.Label lblGelirTuru;
        private System.Windows.Forms.Label lblGelirIsim;
        private System.Windows.Forms.Label lblGelirSoyisim;
        private System.Windows.Forms.Label lblGelirOzet;
        private System.Windows.Forms.TextBox txtGelirIsim;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGelirEposta;
        private System.Windows.Forms.Button btnGelirExcel;
        private System.Windows.Forms.ToolTip tipGelirAra;
        private System.Windows.Forms.ToolTip tipGelirYenile;
        private System.Windows.Forms.Button btnGelirYenile;
        private System.Windows.Forms.ToolTip tipGelirYeni;
        private System.Windows.Forms.Button btnGelirYeni;
        private System.Windows.Forms.ToolTip tipGelirTemizle;
        private System.Windows.Forms.Button btnGelirTemizle;
        private System.Windows.Forms.ToolTip tipGelirSil;
        private System.Windows.Forms.Button btnGelirSil;
        private System.Windows.Forms.ToolTip tipGelirDuzenle;
        private System.Windows.Forms.Button btnGelirGuncelle;
        private System.Windows.Forms.ToolTip tipGelirKaydet;
        private System.Windows.Forms.Button btnGelirKaydet;
        private System.Windows.Forms.Button btnGelirAra;
        private System.Windows.Forms.ContextMenuStrip cmsGelir;
        private System.Windows.Forms.ToolStripMenuItem cmsBagisItemYeni;
        private System.Windows.Forms.ToolStripMenuItem cmsBagisItemTemizle;
        private System.Windows.Forms.ToolStripMenuItem cmsBagisItemYenile;
        private System.Windows.Forms.TextBox txtGelirOzet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblGelirKullanici;
        private System.Windows.Forms.Label lblGelirKayitNo;
        private System.Windows.Forms.Label lblGelirID;
        private System.Windows.Forms.Label lblGelirKayitTarihi;
        private System.Windows.Forms.DateTimePicker dtpGelirKayitTarihi;
        private System.Windows.Forms.Label lblGelirLoginfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGelirSoyisim;
        private System.Windows.Forms.TextBox txtGelirAra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvGelir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
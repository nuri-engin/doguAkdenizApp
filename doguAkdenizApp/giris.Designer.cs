namespace doguAkdenizApp
{
    partial class giris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGirisLogin = new System.Windows.Forms.Button();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.txtGirisKullanici = new System.Windows.Forms.TextBox();
            this.lblGirisSifre = new System.Windows.Forms.Label();
            this.lblGirisKullanici = new System.Windows.Forms.Label();
            this.lblGirisWww = new System.Windows.Forms.Label();
            this.lblGirisAt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGirisLogin);
            this.groupBox1.Controls.Add(this.txtGirisSifre);
            this.groupBox1.Controls.Add(this.txtGirisKullanici);
            this.groupBox1.Controls.Add(this.lblGirisSifre);
            this.groupBox1.Controls.Add(this.lblGirisKullanici);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // btnGirisLogin
            // 
            this.btnGirisLogin.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnGirisLogin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisLogin.ForeColor = System.Drawing.Color.Firebrick;
            this.btnGirisLogin.Image = global::doguAkdenizApp.Properties.Resources.login;
            this.btnGirisLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGirisLogin.Location = new System.Drawing.Point(232, 122);
            this.btnGirisLogin.Name = "btnGirisLogin";
            this.btnGirisLogin.Size = new System.Drawing.Size(125, 35);
            this.btnGirisLogin.TabIndex = 4;
            this.btnGirisLogin.Text = "Giriş Yap";
            this.btnGirisLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGirisLogin.UseVisualStyleBackColor = false;
            this.btnGirisLogin.Enter += new System.EventHandler(this.btnGirisLogin_Click);
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGirisSifre.Location = new System.Drawing.Point(232, 77);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.PasswordChar = '*';
            this.txtGirisSifre.Size = new System.Drawing.Size(125, 24);
            this.txtGirisSifre.TabIndex = 3;
            // 
            // txtGirisKullanici
            // 
            this.txtGirisKullanici.Location = new System.Drawing.Point(232, 51);
            this.txtGirisKullanici.Name = "txtGirisKullanici";
            this.txtGirisKullanici.Size = new System.Drawing.Size(125, 24);
            this.txtGirisKullanici.TabIndex = 2;
            // 
            // lblGirisSifre
            // 
            this.lblGirisSifre.AutoSize = true;
            this.lblGirisSifre.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisSifre.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGirisSifre.Location = new System.Drawing.Point(91, 77);
            this.lblGirisSifre.Name = "lblGirisSifre";
            this.lblGirisSifre.Size = new System.Drawing.Size(48, 24);
            this.lblGirisSifre.TabIndex = 1;
            this.lblGirisSifre.Text = "Şifre: ";
            // 
            // lblGirisKullanici
            // 
            this.lblGirisKullanici.AutoSize = true;
            this.lblGirisKullanici.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisKullanici.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGirisKullanici.Location = new System.Drawing.Point(91, 51);
            this.lblGirisKullanici.Name = "lblGirisKullanici";
            this.lblGirisKullanici.Size = new System.Drawing.Size(98, 24);
            this.lblGirisKullanici.TabIndex = 0;
            this.lblGirisKullanici.Text = "Kullanıcı Adı: ";
            // 
            // lblGirisWww
            // 
            this.lblGirisWww.AutoSize = true;
            this.lblGirisWww.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisWww.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGirisWww.Location = new System.Drawing.Point(12, 214);
            this.lblGirisWww.Name = "lblGirisWww";
            this.lblGirisWww.Size = new System.Drawing.Size(117, 19);
            this.lblGirisWww.TabIndex = 5;
            this.lblGirisWww.Text = "www.doguakdeniz.org";
            // 
            // lblGirisAt
            // 
            this.lblGirisAt.AutoSize = true;
            this.lblGirisAt.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisAt.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGirisAt.Location = new System.Drawing.Point(253, 214);
            this.lblGirisAt.Name = "lblGirisAt";
            this.lblGirisAt.Size = new System.Drawing.Size(183, 19);
            this.lblGirisAt.TabIndex = 6;
            this.lblGirisAt.Text = "doguakdenizarastirma@gmail.com";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(448, 239);
            this.Controls.Add(this.lblGirisWww);
            this.Controls.Add(this.lblGirisAt);
            this.Controls.Add(this.groupBox1);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş : Doğu Akdeniz Araştırma Derneği";
            this.Enter += new System.EventHandler(this.btnGirisLogin_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGirisLogin;
        private System.Windows.Forms.TextBox txtGirisSifre;
        private System.Windows.Forms.TextBox txtGirisKullanici;
        private System.Windows.Forms.Label lblGirisSifre;
        private System.Windows.Forms.Label lblGirisKullanici;
        private System.Windows.Forms.Label lblGirisAt;
        private System.Windows.Forms.Label lblGirisWww;
    }
}


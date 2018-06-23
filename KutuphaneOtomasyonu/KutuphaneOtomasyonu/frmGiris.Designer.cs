namespace KutuphaneOtomasyonu
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.linkSifremiunuttum = new System.Windows.Forms.LinkLabel();
            this.btnyenile = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKod = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkSifreDegistir = new System.Windows.Forms.LinkLabel();
            this.cmdCikis = new System.Windows.Forms.Button();
            this.cmdTamam = new System.Windows.Forms.Button();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.txtKullaniciParola = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.labelKParola = new System.Windows.Forms.Label();
            this.labelKAd = new System.Windows.Forms.Label();
            this.panelSifremiUnuttum = new System.Windows.Forms.Panel();
            this.cmdSifremiunuttumCikis = new System.Windows.Forms.Button();
            this.cmdSifremiUnuttumTamam = new System.Windows.Forms.Button();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.labelCevap = new System.Windows.Forms.Label();
            this.labelSoru = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifreDegistirSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifreDegistirSifreTekrar = new System.Windows.Forms.TextBox();
            this.cmdSifreDegistirTamam = new System.Windows.Forms.Button();
            this.cmdSifreDegistirCikis = new System.Windows.Forms.Button();
            this.panelSifreDegistir = new System.Windows.Forms.Panel();
            this.txtSifreDegistirCevap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSifreDegistirSoru = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifreDegistirKullaniciAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnyenile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSifremiUnuttum.SuspendLayout();
            this.panelSifreDegistir.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkSifremiunuttum
            // 
            this.linkSifremiunuttum.AutoSize = true;
            this.linkSifremiunuttum.Location = new System.Drawing.Point(153, 169);
            this.linkSifremiunuttum.Name = "linkSifremiunuttum";
            this.linkSifremiunuttum.Size = new System.Drawing.Size(99, 17);
            this.linkSifremiunuttum.TabIndex = 6;
            this.linkSifremiunuttum.TabStop = true;
            this.linkSifremiunuttum.Text = "Şifremi unuttum";
            this.linkSifremiunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifremiunuttum_LinkClicked);
            // 
            // btnyenile
            // 
            this.btnyenile.Controls.Add(this.button1);
            this.btnyenile.Controls.Add(this.panel1);
            this.btnyenile.Controls.Add(this.label8);
            this.btnyenile.Controls.Add(this.linkSifreDegistir);
            this.btnyenile.Controls.Add(this.cmdCikis);
            this.btnyenile.Controls.Add(this.cmdTamam);
            this.btnyenile.Controls.Add(this.linkSifremiunuttum);
            this.btnyenile.Controls.Add(this.txtKod);
            this.btnyenile.Controls.Add(this.txtKullaniciParola);
            this.btnyenile.Controls.Add(this.txtKullaniciAd);
            this.btnyenile.Controls.Add(this.labelKParola);
            this.btnyenile.Controls.Add(this.labelKAd);
            this.btnyenile.Location = new System.Drawing.Point(0, 1);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(263, 190);
            this.btnyenile.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.Button_Refresh_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(222, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 26);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.Adsız;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelKod);
            this.panel1.Font = new System.Drawing.Font("Bradley Hand ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(116, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 38);
            this.panel1.TabIndex = 15;
            // 
            // labelKod
            // 
            this.labelKod.AutoSize = true;
            this.labelKod.Font = new System.Drawing.Font("Pristina", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKod.Image = global::KutuphaneOtomasyonu.Properties.Resources.Adsız;
            this.labelKod.Location = new System.Drawing.Point(6, -8);
            this.labelKod.Name = "labelKod";
            this.labelKod.Size = new System.Drawing.Size(86, 49);
            this.labelKod.TabIndex = 8;
            this.labelKod.Text = "0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "Güvenlik Kodunu\r\nGiriniz\r\n";
            // 
            // linkSifreDegistir
            // 
            this.linkSifreDegistir.AutoSize = true;
            this.linkSifreDegistir.Location = new System.Drawing.Point(12, 169);
            this.linkSifreDegistir.Name = "linkSifreDegistir";
            this.linkSifreDegistir.Size = new System.Drawing.Size(111, 17);
            this.linkSifreDegistir.TabIndex = 13;
            this.linkSifreDegistir.TabStop = true;
            this.linkSifreDegistir.Text = "Şifre/Bilgi değiştir";
            this.linkSifreDegistir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifreDegistir_LinkClicked);
            // 
            // cmdCikis
            // 
            this.cmdCikis.Location = new System.Drawing.Point(147, 133);
            this.cmdCikis.Name = "cmdCikis";
            this.cmdCikis.Size = new System.Drawing.Size(115, 29);
            this.cmdCikis.TabIndex = 12;
            this.cmdCikis.Text = "&Çıkış";
            this.cmdCikis.UseVisualStyleBackColor = true;
            this.cmdCikis.Click += new System.EventHandler(this.cmdCikis_Click);
            // 
            // cmdTamam
            // 
            this.cmdTamam.Location = new System.Drawing.Point(8, 133);
            this.cmdTamam.Name = "cmdTamam";
            this.cmdTamam.Size = new System.Drawing.Size(118, 29);
            this.cmdTamam.TabIndex = 11;
            this.cmdTamam.Text = "&Tamam";
            this.cmdTamam.UseVisualStyleBackColor = true;
            this.cmdTamam.Click += new System.EventHandler(this.cmdTamam_Click);
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(116, 103);
            this.txtKod.MaxLength = 4;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(145, 25);
            this.txtKod.TabIndex = 9;
            this.txtKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKod_KeyPress);
            // 
            // txtKullaniciParola
            // 
            this.txtKullaniciParola.Location = new System.Drawing.Point(116, 36);
            this.txtKullaniciParola.Name = "txtKullaniciParola";
            this.txtKullaniciParola.Size = new System.Drawing.Size(144, 25);
            this.txtKullaniciParola.TabIndex = 7;
            this.txtKullaniciParola.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(116, 7);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(145, 25);
            this.txtKullaniciAd.TabIndex = 6;
            // 
            // labelKParola
            // 
            this.labelKParola.AutoSize = true;
            this.labelKParola.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKParola.Location = new System.Drawing.Point(6, 39);
            this.labelKParola.Name = "labelKParola";
            this.labelKParola.Size = new System.Drawing.Size(104, 17);
            this.labelKParola.TabIndex = 5;
            this.labelKParola.Text = "Kullanıcı Parola";
            // 
            // labelKAd
            // 
            this.labelKAd.AutoSize = true;
            this.labelKAd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKAd.Location = new System.Drawing.Point(6, 10);
            this.labelKAd.Name = "labelKAd";
            this.labelKAd.Size = new System.Drawing.Size(82, 17);
            this.labelKAd.TabIndex = 4;
            this.labelKAd.Text = "Kullanıcı Ad";
            // 
            // panelSifremiUnuttum
            // 
            this.panelSifremiUnuttum.Controls.Add(this.cmdSifremiunuttumCikis);
            this.panelSifremiUnuttum.Controls.Add(this.cmdSifremiUnuttumTamam);
            this.panelSifremiUnuttum.Controls.Add(this.txtSifreTekrar);
            this.panelSifremiUnuttum.Controls.Add(this.label2);
            this.panelSifremiUnuttum.Controls.Add(this.txtSifre);
            this.panelSifremiUnuttum.Controls.Add(this.label1);
            this.panelSifremiUnuttum.Controls.Add(this.txtCevap);
            this.panelSifremiUnuttum.Controls.Add(this.labelCevap);
            this.panelSifremiUnuttum.Controls.Add(this.labelSoru);
            this.panelSifremiUnuttum.Location = new System.Drawing.Point(293, 1);
            this.panelSifremiUnuttum.Name = "panelSifremiUnuttum";
            this.panelSifremiUnuttum.Size = new System.Drawing.Size(263, 160);
            this.panelSifremiUnuttum.TabIndex = 8;
            // 
            // cmdSifremiunuttumCikis
            // 
            this.cmdSifremiunuttumCikis.Location = new System.Drawing.Point(142, 126);
            this.cmdSifremiunuttumCikis.Name = "cmdSifremiunuttumCikis";
            this.cmdSifremiunuttumCikis.Size = new System.Drawing.Size(114, 29);
            this.cmdSifremiunuttumCikis.TabIndex = 14;
            this.cmdSifremiunuttumCikis.Text = "&Çıkış";
            this.cmdSifremiunuttumCikis.UseVisualStyleBackColor = true;
            this.cmdSifremiunuttumCikis.Click += new System.EventHandler(this.cmdSifremiunuttumCikis_Click);
            // 
            // cmdSifremiUnuttumTamam
            // 
            this.cmdSifremiUnuttumTamam.Location = new System.Drawing.Point(3, 126);
            this.cmdSifremiUnuttumTamam.Name = "cmdSifremiUnuttumTamam";
            this.cmdSifremiUnuttumTamam.Size = new System.Drawing.Size(120, 29);
            this.cmdSifremiUnuttumTamam.TabIndex = 13;
            this.cmdSifremiUnuttumTamam.Text = "&Tamam";
            this.cmdSifremiUnuttumTamam.UseVisualStyleBackColor = true;
            this.cmdSifremiUnuttumTamam.Click += new System.EventHandler(this.cmdSifremiUnuttumTamam_Click);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(91, 95);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(162, 25);
            this.txtSifreTekrar.TabIndex = 12;
            this.txtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre(Tekrar):";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(91, 64);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(162, 25);
            this.txtSifre.TabIndex = 10;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yeni Şifre:";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(91, 33);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(162, 25);
            this.txtCevap.TabIndex = 8;
            // 
            // labelCevap
            // 
            this.labelCevap.AutoSize = true;
            this.labelCevap.Location = new System.Drawing.Point(6, 36);
            this.labelCevap.Name = "labelCevap";
            this.labelCevap.Size = new System.Drawing.Size(47, 17);
            this.labelCevap.TabIndex = 1;
            this.labelCevap.Text = "Cevap:";
            // 
            // labelSoru
            // 
            this.labelSoru.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSoru.Location = new System.Drawing.Point(0, 0);
            this.labelSoru.Name = "labelSoru";
            this.labelSoru.Size = new System.Drawing.Size(263, 27);
            this.labelSoru.TabIndex = 0;
            this.labelSoru.Text = "Soru ?";
            this.labelSoru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şifre:";
            // 
            // txtSifreDegistirSifre
            // 
            this.txtSifreDegistirSifre.Location = new System.Drawing.Point(94, 45);
            this.txtSifreDegistirSifre.Name = "txtSifreDegistirSifre";
            this.txtSifreDegistirSifre.Size = new System.Drawing.Size(162, 25);
            this.txtSifreDegistirSifre.TabIndex = 10;
            this.txtSifreDegistirSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Şifre(Tekrar):";
            // 
            // txtSifreDegistirSifreTekrar
            // 
            this.txtSifreDegistirSifreTekrar.Location = new System.Drawing.Point(94, 76);
            this.txtSifreDegistirSifreTekrar.Name = "txtSifreDegistirSifreTekrar";
            this.txtSifreDegistirSifreTekrar.Size = new System.Drawing.Size(162, 25);
            this.txtSifreDegistirSifreTekrar.TabIndex = 12;
            this.txtSifreDegistirSifreTekrar.UseSystemPasswordChar = true;
            // 
            // cmdSifreDegistirTamam
            // 
            this.cmdSifreDegistirTamam.Location = new System.Drawing.Point(3, 168);
            this.cmdSifreDegistirTamam.Name = "cmdSifreDegistirTamam";
            this.cmdSifreDegistirTamam.Size = new System.Drawing.Size(120, 29);
            this.cmdSifreDegistirTamam.TabIndex = 13;
            this.cmdSifreDegistirTamam.Text = "&Tamam";
            this.cmdSifreDegistirTamam.UseVisualStyleBackColor = true;
            this.cmdSifreDegistirTamam.Click += new System.EventHandler(this.cmdSifreDegistirTamam_Click);
            // 
            // cmdSifreDegistirCikis
            // 
            this.cmdSifreDegistirCikis.Location = new System.Drawing.Point(142, 168);
            this.cmdSifreDegistirCikis.Name = "cmdSifreDegistirCikis";
            this.cmdSifreDegistirCikis.Size = new System.Drawing.Size(114, 29);
            this.cmdSifreDegistirCikis.TabIndex = 14;
            this.cmdSifreDegistirCikis.Text = "&Çıkış";
            this.cmdSifreDegistirCikis.UseVisualStyleBackColor = true;
            this.cmdSifreDegistirCikis.Click += new System.EventHandler(this.cmdSifreDegistirCikis_Click);
            // 
            // panelSifreDegistir
            // 
            this.panelSifreDegistir.Controls.Add(this.txtSifreDegistirCevap);
            this.panelSifreDegistir.Controls.Add(this.label7);
            this.panelSifreDegistir.Controls.Add(this.txtSifreDegistirSoru);
            this.panelSifreDegistir.Controls.Add(this.label6);
            this.panelSifreDegistir.Controls.Add(this.txtSifreDegistirKullaniciAd);
            this.panelSifreDegistir.Controls.Add(this.label5);
            this.panelSifreDegistir.Controls.Add(this.cmdSifreDegistirCikis);
            this.panelSifreDegistir.Controls.Add(this.cmdSifreDegistirTamam);
            this.panelSifreDegistir.Controls.Add(this.txtSifreDegistirSifreTekrar);
            this.panelSifreDegistir.Controls.Add(this.label3);
            this.panelSifreDegistir.Controls.Add(this.txtSifreDegistirSifre);
            this.panelSifreDegistir.Controls.Add(this.label4);
            this.panelSifreDegistir.Location = new System.Drawing.Point(293, 170);
            this.panelSifreDegistir.Name = "panelSifreDegistir";
            this.panelSifreDegistir.Size = new System.Drawing.Size(263, 204);
            this.panelSifreDegistir.TabIndex = 9;
            // 
            // txtSifreDegistirCevap
            // 
            this.txtSifreDegistirCevap.Location = new System.Drawing.Point(94, 137);
            this.txtSifreDegistirCevap.Name = "txtSifreDegistirCevap";
            this.txtSifreDegistirCevap.Size = new System.Drawing.Size(162, 25);
            this.txtSifreDegistirCevap.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cevap:";
            // 
            // txtSifreDegistirSoru
            // 
            this.txtSifreDegistirSoru.Location = new System.Drawing.Point(94, 106);
            this.txtSifreDegistirSoru.Name = "txtSifreDegistirSoru";
            this.txtSifreDegistirSoru.Size = new System.Drawing.Size(162, 25);
            this.txtSifreDegistirSoru.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Soru:";
            // 
            // txtSifreDegistirKullaniciAd
            // 
            this.txtSifreDegistirKullaniciAd.Location = new System.Drawing.Point(94, 14);
            this.txtSifreDegistirKullaniciAd.Name = "txtSifreDegistirKullaniciAd";
            this.txtSifreDegistirKullaniciAd.Size = new System.Drawing.Size(162, 25);
            this.txtSifreDegistirKullaniciAd.TabIndex = 16;
            this.txtSifreDegistirKullaniciAd.Text = "Mustafa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kullanıcı Ad:";
            // 
            // frmGiris
            // 
            this.AcceptButton = this.cmdTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(263, 191);
            this.Controls.Add(this.panelSifreDegistir);
            this.Controls.Add(this.panelSifremiUnuttum);
            this.Controls.Add(this.btnyenile);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGiris";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş İşlem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.btnyenile.ResumeLayout(false);
            this.btnyenile.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSifremiUnuttum.ResumeLayout(false);
            this.panelSifremiUnuttum.PerformLayout();
            this.panelSifreDegistir.ResumeLayout(false);
            this.panelSifreDegistir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkSifremiunuttum;
        private System.Windows.Forms.Panel btnyenile;
        private System.Windows.Forms.TextBox txtKullaniciParola;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label labelKParola;
        private System.Windows.Forms.Label labelKAd;
        private System.Windows.Forms.Panel panelSifremiUnuttum;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label labelCevap;
        private System.Windows.Forms.Label labelSoru;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label labelKod;
        private System.Windows.Forms.Button cmdSifremiunuttumCikis;
        private System.Windows.Forms.Button cmdSifremiUnuttumTamam;
        private System.Windows.Forms.Button cmdCikis;
        private System.Windows.Forms.Button cmdTamam;
        private System.Windows.Forms.LinkLabel linkSifreDegistir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifreDegistirSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifreDegistirSifreTekrar;
        private System.Windows.Forms.Button cmdSifreDegistirTamam;
        private System.Windows.Forms.Button cmdSifreDegistirCikis;
        private System.Windows.Forms.Panel panelSifreDegistir;
        private System.Windows.Forms.TextBox txtSifreDegistirSoru;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifreDegistirKullaniciAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifreDegistirCevap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
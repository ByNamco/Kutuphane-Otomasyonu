namespace KutuphaneOtomasyonu
{
    partial class frmKullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdTamam = new System.Windows.Forms.Button();
            this.Çıkış = new System.Windows.Forms.Button();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtKullaniciParola = new System.Windows.Forms.TextBox();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbtur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cevap";
            // 
            // cmdTamam
            // 
            this.cmdTamam.Location = new System.Drawing.Point(4, 187);
            this.cmdTamam.Name = "cmdTamam";
            this.cmdTamam.Size = new System.Drawing.Size(141, 44);
            this.cmdTamam.TabIndex = 4;
            this.cmdTamam.Text = "&Tamam";
            this.cmdTamam.UseVisualStyleBackColor = true;
            this.cmdTamam.Click += new System.EventHandler(this.cmdTamam_Click);
            // 
            // Çıkış
            // 
            this.Çıkış.Location = new System.Drawing.Point(151, 187);
            this.Çıkış.Name = "Çıkış";
            this.Çıkış.Size = new System.Drawing.Size(141, 44);
            this.Çıkış.TabIndex = 5;
            this.Çıkış.Text = "&Çıkış";
            this.Çıkış.UseVisualStyleBackColor = true;
            this.Çıkış.Click += new System.EventHandler(this.Çıkış_Click);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(134, 6);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(151, 25);
            this.txtKullaniciAd.TabIndex = 6;
            // 
            // txtKullaniciParola
            // 
            this.txtKullaniciParola.Location = new System.Drawing.Point(134, 40);
            this.txtKullaniciParola.Name = "txtKullaniciParola";
            this.txtKullaniciParola.Size = new System.Drawing.Size(151, 25);
            this.txtKullaniciParola.TabIndex = 7;
            this.txtKullaniciParola.UseSystemPasswordChar = true;
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(134, 108);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(151, 25);
            this.txtSoru.TabIndex = 8;
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(134, 142);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(151, 25);
            this.txtCevap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tür";
            // 
            // cmbtur
            // 
            this.cmbtur.FormattingEnabled = true;
            this.cmbtur.Items.AddRange(new object[] {
            "ADMİN",
            "USER"});
            this.cmbtur.Location = new System.Drawing.Point(134, 74);
            this.cmbtur.Name = "cmbtur";
            this.cmbtur.Size = new System.Drawing.Size(151, 25);
            this.cmbtur.TabIndex = 11;
            this.cmbtur.Text = "Kullanıcı Türü Seçiniz";
            // 
            // frmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(299, 247);
            this.Controls.Add(this.cmbtur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.txtKullaniciParola);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.Çıkış);
            this.Controls.Add(this.cmdTamam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmKullaniciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdTamam;
        private System.Windows.Forms.Button Çıkış;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtKullaniciParola;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbtur;
    }
}
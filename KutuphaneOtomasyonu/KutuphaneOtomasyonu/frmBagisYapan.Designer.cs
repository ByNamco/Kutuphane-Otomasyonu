namespace KutuphaneOtomasyonu
{
    partial class frmBagisYapan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBagisYapan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtisbnkod = new System.Windows.Forms.TextBox();
            this.dtpbasimtarih = new System.Windows.Forms.DateTimePicker();
            this.btnyeni = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.lbybaslik = new System.Windows.Forms.Label();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.txtadres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(8, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 218);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağış Yapan Bilgileri";
            // 
            // txtsoyad
            // 
            this.txtsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoyad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.ForeColor = System.Drawing.Color.Navy;
            this.txtsoyad.Location = new System.Drawing.Point(115, 96);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(187, 22);
            this.txtsoyad.TabIndex = 161;
            // 
            // txttel
            // 
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttel.ForeColor = System.Drawing.Color.Navy;
            this.txttel.Location = new System.Drawing.Point(115, 130);
            this.txttel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttel.MaxLength = 11;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(187, 22);
            this.txttel.TabIndex = 162;
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress);
            // 
            // txtadres
            // 
            this.txtadres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadres.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadres.ForeColor = System.Drawing.Color.Navy;
            this.txtadres.Location = new System.Drawing.Point(61, 164);
            this.txtadres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(241, 47);
            this.txtadres.TabIndex = 163;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 138;
            this.label5.Text = "Tc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 137;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 136;
            this.label3.Text = "Tel";
            // 
            // txtad
            // 
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.ForeColor = System.Drawing.Color.Navy;
            this.txtad.Location = new System.Drawing.Point(115, 64);
            this.txtad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(187, 22);
            this.txtad.TabIndex = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 135;
            this.label2.Text = "Soyad";
            // 
            // txttc
            // 
            this.txttc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttc.ForeColor = System.Drawing.Color.Navy;
            this.txttc.Location = new System.Drawing.Point(115, 31);
            this.txttc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttc.MaxLength = 11;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(187, 22);
            this.txttc.TabIndex = 159;
            this.txttc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 134;
            this.label1.Text = "Ad";
            // 
            // txtisbnkod
            // 
            this.txtisbnkod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtisbnkod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisbnkod.ForeColor = System.Drawing.Color.Navy;
            this.txtisbnkod.Location = new System.Drawing.Point(123, 11);
            this.txtisbnkod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtisbnkod.Name = "txtisbnkod";
            this.txtisbnkod.Size = new System.Drawing.Size(187, 22);
            this.txtisbnkod.TabIndex = 160;
            // 
            // dtpbasimtarih
            // 
            this.dtpbasimtarih.CustomFormat = "dd.MM.yyyy";
            this.dtpbasimtarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpbasimtarih.Location = new System.Drawing.Point(123, 38);
            this.dtpbasimtarih.Name = "dtpbasimtarih";
            this.dtpbasimtarih.Size = new System.Drawing.Size(187, 20);
            this.dtpbasimtarih.TabIndex = 168;
            // 
            // btnyeni
            // 
            this.btnyeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnyeni.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyeni.ForeColor = System.Drawing.Color.Blue;
            this.btnyeni.Image = global::KutuphaneOtomasyonu.Properties.Resources.Actions_document_new_icon;
            this.btnyeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyeni.Location = new System.Drawing.Point(330, 4);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(137, 52);
            this.btnyeni.TabIndex = 161;
            this.btnyeni.Text = "Yeni";
            this.btnyeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnyeni.UseVisualStyleBackColor = true;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnkaydet.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.ForeColor = System.Drawing.Color.Blue;
            this.btnkaydet.Image = global::KutuphaneOtomasyonu.Properties.Resources.Actions_document_save_as_icon;
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.Location = new System.Drawing.Point(330, 63);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(137, 52);
            this.btnkaydet.TabIndex = 162;
            this.btnkaydet.Text = "      Kaydet";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // lbybaslik
            // 
            this.lbybaslik.AutoSize = true;
            this.lbybaslik.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbybaslik.ForeColor = System.Drawing.Color.Blue;
            this.lbybaslik.Location = new System.Drawing.Point(5, 12);
            this.lbybaslik.Name = "lbybaslik";
            this.lbybaslik.Size = new System.Drawing.Size(112, 17);
            this.lbybaslik.TabIndex = 159;
            this.lbybaslik.Text = "Kitap ISBN Kod";
            // 
            // btncikis
            // 
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncikis.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.ForeColor = System.Drawing.Color.Blue;
            this.btncikis.Image = global::KutuphaneOtomasyonu.Properties.Resources.exit;
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.Location = new System.Drawing.Point(330, 237);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(137, 52);
            this.btncikis.TabIndex = 165;
            this.btncikis.Text = "Çıkış";
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnguncelle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.ForeColor = System.Drawing.Color.Blue;
            this.btnguncelle.Image = global::KutuphaneOtomasyonu.Properties.Resources.softwareUpdate_256;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.Location = new System.Drawing.Point(330, 121);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(137, 52);
            this.btnguncelle.TabIndex = 163;
            this.btnguncelle.Text = "       Güncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsil.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.ForeColor = System.Drawing.Color.Blue;
            this.btnsil.Image = global::KutuphaneOtomasyonu.Properties.Resources.Actions_edit_clear_icon;
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.Location = new System.Drawing.Point(330, 179);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(137, 52);
            this.btnsil.TabIndex = 164;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(5, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 167;
            this.label8.Text = "Bağış Tarih";
            // 
            // frmBagisYapan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtisbnkod);
            this.Controls.Add(this.dtpbasimtarih);
            this.Controls.Add(this.btnyeni);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.lbybaslik);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBagisYapan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bagış Yapan İşlem";
            this.Load += new System.EventHandler(this.frmBagisYapan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadres;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtad;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttc;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtisbnkod;
        private System.Windows.Forms.DateTimePicker dtpbasimtarih;
        internal System.Windows.Forms.Button btnyeni;
        internal System.Windows.Forms.Button btnkaydet;
        internal System.Windows.Forms.Label lbybaslik;
        internal System.Windows.Forms.Button btncikis;
        internal System.Windows.Forms.Button btnguncelle;
        internal System.Windows.Forms.Button btnsil;
        internal System.Windows.Forms.Label label8;
    }
}
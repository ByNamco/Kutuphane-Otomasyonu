namespace KutuphaneOtomasyonu
{
    partial class frmYazarIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYazarIslem));
            this.btncikis = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtyazarno = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtotobiyografi = new System.Windows.Forms.TextBox();
            this.dgwyazar = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtsoyadsuzme = new System.Windows.Forms.TextBox();
            this.txtadsuzme = new System.Windows.Forms.TextBox();
            this.txtyazarnosuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnbul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwyazar)).BeginInit();
            this.SuspendLayout();
            // 
            // btncikis
            // 
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncikis.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.ForeColor = System.Drawing.Color.Blue;
            this.btncikis.Image = global::KutuphaneOtomasyonu.Properties.Resources.exit;
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.Location = new System.Drawing.Point(720, 3);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(170, 52);
            this.btncikis.TabIndex = 29;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsil.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.ForeColor = System.Drawing.Color.Blue;
            this.btnsil.Image = global::KutuphaneOtomasyonu.Properties.Resources.Actions_edit_clear_icon;
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.Location = new System.Drawing.Point(542, 3);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(170, 52);
            this.btnsil.TabIndex = 28;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnguncelle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.ForeColor = System.Drawing.Color.Blue;
            this.btnguncelle.Image = global::KutuphaneOtomasyonu.Properties.Resources.softwareUpdate_256;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.Location = new System.Drawing.Point(364, 3);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(170, 52);
            this.btnguncelle.TabIndex = 27;
            this.btnguncelle.Text = "       Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnkaydet.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.ForeColor = System.Drawing.Color.Blue;
            this.btnkaydet.Image = global::KutuphaneOtomasyonu.Properties.Resources.Actions_document_save_as_icon;
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.Location = new System.Drawing.Point(186, 3);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(170, 52);
            this.btnkaydet.TabIndex = 26;
            this.btnkaydet.Text = "      Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnyeni
            // 
            this.btnyeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnyeni.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyeni.ForeColor = System.Drawing.Color.Blue;
            this.btnyeni.Image = global::KutuphaneOtomasyonu.Properties.Resources.Actions_document_new_icon;
            this.btnyeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyeni.Location = new System.Drawing.Point(8, 3);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(170, 52);
            this.btnyeni.TabIndex = 25;
            this.btnyeni.Text = "Yeni";
            this.btnyeni.UseVisualStyleBackColor = true;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 166;
            this.label4.Text = "Yazar No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(9, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 167;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 168;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(9, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 169;
            this.label3.Text = "Otobiyografi";
            // 
            // txtyazarno
            // 
            this.txtyazarno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyazarno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyazarno.ForeColor = System.Drawing.Color.Navy;
            this.txtyazarno.Location = new System.Drawing.Point(126, 68);
            this.txtyazarno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtyazarno.Name = "txtyazarno";
            this.txtyazarno.Size = new System.Drawing.Size(243, 22);
            this.txtyazarno.TabIndex = 175;
            this.txtyazarno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyazarno_KeyPress);
            // 
            // txtad
            // 
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.ForeColor = System.Drawing.Color.Navy;
            this.txtad.Location = new System.Drawing.Point(126, 114);
            this.txtad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(297, 22);
            this.txtad.TabIndex = 176;
            // 
            // txtsoyad
            // 
            this.txtsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoyad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.ForeColor = System.Drawing.Color.Navy;
            this.txtsoyad.Location = new System.Drawing.Point(126, 158);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(297, 22);
            this.txtsoyad.TabIndex = 177;
            // 
            // txtotobiyografi
            // 
            this.txtotobiyografi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtotobiyografi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtotobiyografi.ForeColor = System.Drawing.Color.Navy;
            this.txtotobiyografi.Location = new System.Drawing.Point(111, 203);
            this.txtotobiyografi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtotobiyografi.Multiline = true;
            this.txtotobiyografi.Name = "txtotobiyografi";
            this.txtotobiyografi.Size = new System.Drawing.Size(312, 419);
            this.txtotobiyografi.TabIndex = 178;
            // 
            // dgwyazar
            // 
            this.dgwyazar.AllowUserToAddRows = false;
            this.dgwyazar.AllowUserToDeleteRows = false;
            this.dgwyazar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwyazar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwyazar.BackgroundColor = System.Drawing.Color.White;
            this.dgwyazar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwyazar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwyazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwyazar.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwyazar.Location = new System.Drawing.Point(429, 100);
            this.dgwyazar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwyazar.Name = "dgwyazar";
            this.dgwyazar.ReadOnly = true;
            this.dgwyazar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwyazar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwyazar.Size = new System.Drawing.Size(461, 522);
            this.dgwyazar.TabIndex = 188;
            this.dgwyazar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwyazar_MouseClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(802, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 202;
            this.label15.Text = "Soyad";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(674, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 17);
            this.label16.TabIndex = 201;
            this.label16.Text = "Ad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(521, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 200;
            this.label17.Text = "Yazar No";
            // 
            // txtsoyadsuzme
            // 
            this.txtsoyadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoyadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtsoyadsuzme.Location = new System.Drawing.Point(765, 75);
            this.txtsoyadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoyadsuzme.Name = "txtsoyadsuzme";
            this.txtsoyadsuzme.Size = new System.Drawing.Size(125, 22);
            this.txtsoyadsuzme.TabIndex = 199;
            this.txtsoyadsuzme.TextChanged += new System.EventHandler(this.txtsoyadsuzme_TextChanged);
            // 
            // txtadsuzme
            // 
            this.txtadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtadsuzme.Location = new System.Drawing.Point(629, 75);
            this.txtadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadsuzme.Name = "txtadsuzme";
            this.txtadsuzme.Size = new System.Drawing.Size(125, 22);
            this.txtadsuzme.TabIndex = 198;
            this.txtadsuzme.TextChanged += new System.EventHandler(this.txtadsuzme_TextChanged);
            // 
            // txtyazarnosuzme
            // 
            this.txtyazarnosuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyazarnosuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyazarnosuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtyazarnosuzme.Location = new System.Drawing.Point(491, 75);
            this.txtyazarnosuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtyazarnosuzme.Name = "txtyazarnosuzme";
            this.txtyazarnosuzme.Size = new System.Drawing.Size(125, 22);
            this.txtyazarnosuzme.TabIndex = 197;
            this.txtyazarnosuzme.TextChanged += new System.EventHandler(this.txtyazarnosuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(430, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 196;
            this.label13.Text = "Süzme :";
            // 
            // btnbul
            // 
            this.btnbul.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.Search_2_icon;
            this.btnbul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnbul.Location = new System.Drawing.Point(375, 64);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(48, 33);
            this.btnbul.TabIndex = 203;
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // frmYazarIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 635);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtsoyadsuzme);
            this.Controls.Add(this.txtadsuzme);
            this.Controls.Add(this.txtyazarnosuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwyazar);
            this.Controls.Add(this.txtotobiyografi);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtyazarno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYazarIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazar İşlem";
            this.Load += new System.EventHandler(this.frmYazarIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwyazar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btncikis;
        internal System.Windows.Forms.Button btnsil;
        internal System.Windows.Forms.Button btnguncelle;
        internal System.Windows.Forms.Button btnkaydet;
        internal System.Windows.Forms.Button btnyeni;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtyazarno;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtotobiyografi;
        private System.Windows.Forms.DataGridView dgwyazar;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtsoyadsuzme;
        private System.Windows.Forms.TextBox txtadsuzme;
        private System.Windows.Forms.TextBox txtyazarnosuzme;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnbul;
    }
}
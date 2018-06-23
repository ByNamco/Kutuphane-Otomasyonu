namespace KutuphaneOtomasyonu
{
    partial class frmParametreKitapYeri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametreKitapYeri));
            this.txttanim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwKitapYer = new System.Windows.Forms.DataGridView();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitapYer)).BeginInit();
            this.SuspendLayout();
            // 
            // txttanim
            // 
            this.txttanim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttanim.ForeColor = System.Drawing.Color.Indigo;
            this.txttanim.Location = new System.Drawing.Point(53, 32);
            this.txttanim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttanim.Name = "txttanim";
            this.txttanim.Size = new System.Drawing.Size(210, 22);
            this.txttanim.TabIndex = 227;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 226;
            this.label1.Text = "Tanim";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.ForeColor = System.Drawing.Color.Indigo;
            this.txtid.Location = new System.Drawing.Point(53, 2);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(210, 22);
            this.txtid.TabIndex = 225;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 224;
            this.label2.Text = "İd";
            // 
            // dgwKitapYer
            // 
            this.dgwKitapYer.AllowUserToAddRows = false;
            this.dgwKitapYer.AllowUserToDeleteRows = false;
            this.dgwKitapYer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKitapYer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwKitapYer.BackgroundColor = System.Drawing.Color.White;
            this.dgwKitapYer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwKitapYer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitapYer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwKitapYer.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwKitapYer.Location = new System.Drawing.Point(0, 59);
            this.dgwKitapYer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwKitapYer.Name = "dgwKitapYer";
            this.dgwKitapYer.ReadOnly = true;
            this.dgwKitapYer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwKitapYer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKitapYer.Size = new System.Drawing.Size(266, 226);
            this.dgwKitapYer.TabIndex = 223;
            // 
            // btncikis
            // 
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncikis.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.ForeColor = System.Drawing.Color.Blue;
            this.btncikis.Image = global::KutuphaneOtomasyonu.Properties.Resources.exit;
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.Location = new System.Drawing.Point(265, 234);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(150, 52);
            this.btncikis.TabIndex = 222;
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
            this.btnsil.Location = new System.Drawing.Point(265, 175);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 52);
            this.btnsil.TabIndex = 221;
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
            this.btnguncelle.Location = new System.Drawing.Point(265, 116);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(150, 52);
            this.btnguncelle.TabIndex = 220;
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
            this.btnkaydet.Location = new System.Drawing.Point(265, 58);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(150, 52);
            this.btnkaydet.TabIndex = 219;
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
            this.btnyeni.Location = new System.Drawing.Point(265, 0);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(150, 52);
            this.btnyeni.TabIndex = 218;
            this.btnyeni.Text = "Yeni";
            this.btnyeni.UseVisualStyleBackColor = true;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // frmParametreKitapYeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 286);
            this.Controls.Add(this.txttanim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwKitapYer);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParametreKitapYeri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametre Kitap Yeri";
            this.Load += new System.EventHandler(this.frmParametreKitapYeri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitapYer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttanim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwKitapYer;
        internal System.Windows.Forms.Button btncikis;
        internal System.Windows.Forms.Button btnsil;
        internal System.Windows.Forms.Button btnguncelle;
        internal System.Windows.Forms.Button btnkaydet;
        internal System.Windows.Forms.Button btnyeni;
    }
}
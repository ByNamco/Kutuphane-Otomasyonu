namespace KutuphaneOtomasyonu
{
    partial class frmParametreKitapTur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametreKitapTur));
            this.btncikis = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            this.dgwKitapTur = new System.Windows.Forms.DataGridView();
            this.txttanim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitapTur)).BeginInit();
            this.SuspendLayout();
            // 
            // btncikis
            // 
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncikis.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.ForeColor = System.Drawing.Color.Blue;
            this.btncikis.Image = global::KutuphaneOtomasyonu.Properties.Resources.exit;
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.Location = new System.Drawing.Point(265, 235);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(150, 52);
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
            this.btnsil.Location = new System.Drawing.Point(265, 176);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 52);
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
            this.btnguncelle.Location = new System.Drawing.Point(265, 117);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(150, 52);
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
            this.btnkaydet.Location = new System.Drawing.Point(265, 59);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(150, 52);
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
            this.btnyeni.Location = new System.Drawing.Point(265, 1);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(150, 52);
            this.btnyeni.TabIndex = 25;
            this.btnyeni.Text = "Yeni";
            this.btnyeni.UseVisualStyleBackColor = true;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // dgwKitapTur
            // 
            this.dgwKitapTur.AllowUserToAddRows = false;
            this.dgwKitapTur.AllowUserToDeleteRows = false;
            this.dgwKitapTur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKitapTur.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwKitapTur.BackgroundColor = System.Drawing.Color.White;
            this.dgwKitapTur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwKitapTur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitapTur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwKitapTur.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwKitapTur.Location = new System.Drawing.Point(0, 60);
            this.dgwKitapTur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwKitapTur.Name = "dgwKitapTur";
            this.dgwKitapTur.ReadOnly = true;
            this.dgwKitapTur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwKitapTur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKitapTur.Size = new System.Drawing.Size(266, 226);
            this.dgwKitapTur.TabIndex = 160;
            // 
            // txttanim
            // 
            this.txttanim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttanim.ForeColor = System.Drawing.Color.Indigo;
            this.txttanim.Location = new System.Drawing.Point(53, 33);
            this.txttanim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttanim.Name = "txttanim";
            this.txttanim.Size = new System.Drawing.Size(210, 22);
            this.txttanim.TabIndex = 217;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 216;
            this.label1.Text = "Tanim";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.ForeColor = System.Drawing.Color.Indigo;
            this.txtid.Location = new System.Drawing.Point(53, 3);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(210, 22);
            this.txtid.TabIndex = 215;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 214;
            this.label2.Text = "İd";
            // 
            // frmParametreKitapTur
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
            this.Controls.Add(this.dgwKitapTur);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParametreKitapTur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametre Kitap Tür";
            this.Load += new System.EventHandler(this.frmParametreKitapTur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitapTur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btncikis;
        internal System.Windows.Forms.Button btnsil;
        internal System.Windows.Forms.Button btnguncelle;
        internal System.Windows.Forms.Button btnkaydet;
        internal System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.DataGridView dgwKitapTur;
        private System.Windows.Forms.TextBox txttanim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
    }
}
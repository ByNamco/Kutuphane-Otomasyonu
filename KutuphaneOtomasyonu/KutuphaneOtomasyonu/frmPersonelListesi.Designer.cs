namespace KutuphaneOtomasyonu
{
    partial class frmPersonelListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListesi));
            this.cmbcalismadurumsuz = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtsoyadsuzme = new System.Windows.Forms.TextBox();
            this.txtadsuzme = new System.Windows.Forms.TextBox();
            this.txttcsuzme = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dgwpersonel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwpersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbcalismadurumsuz
            // 
            this.cmbcalismadurumsuz.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbcalismadurumsuz.ForeColor = System.Drawing.Color.Navy;
            this.cmbcalismadurumsuz.FormattingEnabled = true;
            this.cmbcalismadurumsuz.Items.AddRange(new object[] {
            "AKTİF",
            "PASİF",
            "EMEKLİ"});
            this.cmbcalismadurumsuz.Location = new System.Drawing.Point(701, 17);
            this.cmbcalismadurumsuz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbcalismadurumsuz.Name = "cmbcalismadurumsuz";
            this.cmbcalismadurumsuz.Size = new System.Drawing.Size(195, 24);
            this.cmbcalismadurumsuz.TabIndex = 217;
            this.cmbcalismadurumsuz.Text = "AKTİF";
            this.cmbcalismadurumsuz.SelectedIndexChanged += new System.EventHandler(this.cmbcalismadurumsuz_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(729, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 17);
            this.label18.TabIndex = 216;
            this.label18.Text = "Çalışma Durum";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(554, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 17);
            this.label19.TabIndex = 215;
            this.label19.Text = "Soyad";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(357, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 17);
            this.label20.TabIndex = 214;
            this.label20.Text = "Ad";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(148, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 17);
            this.label21.TabIndex = 213;
            this.label21.Text = "Tc";
            // 
            // txtsoyadsuzme
            // 
            this.txtsoyadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoyadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtsoyadsuzme.Location = new System.Drawing.Point(491, 19);
            this.txtsoyadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoyadsuzme.Name = "txtsoyadsuzme";
            this.txtsoyadsuzme.Size = new System.Drawing.Size(195, 22);
            this.txtsoyadsuzme.TabIndex = 212;
            this.txtsoyadsuzme.TextChanged += new System.EventHandler(this.txtsoyadsuzme_TextChanged);
            // 
            // txtadsuzme
            // 
            this.txtadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtadsuzme.Location = new System.Drawing.Point(282, 19);
            this.txtadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadsuzme.Name = "txtadsuzme";
            this.txtadsuzme.Size = new System.Drawing.Size(195, 22);
            this.txtadsuzme.TabIndex = 211;
            this.txtadsuzme.TextChanged += new System.EventHandler(this.txtadsuzme_TextChanged);
            // 
            // txttcsuzme
            // 
            this.txttcsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttcsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttcsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txttcsuzme.Location = new System.Drawing.Point(69, 19);
            this.txttcsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttcsuzme.Name = "txttcsuzme";
            this.txttcsuzme.Size = new System.Drawing.Size(195, 22);
            this.txttcsuzme.TabIndex = 210;
            this.txttcsuzme.TextChanged += new System.EventHandler(this.txttcsuzme_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(3, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 17);
            this.label22.TabIndex = 209;
            this.label22.Text = "Süzme :";
            // 
            // dgwpersonel
            // 
            this.dgwpersonel.AllowUserToAddRows = false;
            this.dgwpersonel.AllowUserToDeleteRows = false;
            this.dgwpersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwpersonel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwpersonel.BackgroundColor = System.Drawing.Color.White;
            this.dgwpersonel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwpersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwpersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwpersonel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwpersonel.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwpersonel.Location = new System.Drawing.Point(0, 49);
            this.dgwpersonel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwpersonel.Name = "dgwpersonel";
            this.dgwpersonel.ReadOnly = true;
            this.dgwpersonel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwpersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwpersonel.Size = new System.Drawing.Size(899, 586);
            this.dgwpersonel.TabIndex = 208;
            // 
            // frmPersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 635);
            this.Controls.Add(this.cmbcalismadurumsuz);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtsoyadsuzme);
            this.Controls.Add(this.txtadsuzme);
            this.Controls.Add(this.txttcsuzme);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dgwpersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonelListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.frmPersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwpersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcalismadurumsuz;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtsoyadsuzme;
        private System.Windows.Forms.TextBox txtadsuzme;
        private System.Windows.Forms.TextBox txttcsuzme;
        internal System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dgwpersonel;
    }
}
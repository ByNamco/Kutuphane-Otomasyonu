namespace KutuphaneOtomasyonu
{
    partial class frmKutuphaneIstatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKutuphaneIstatistik));
            this.dgwkutuphaneistatistik = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.txttursuzme = new System.Windows.Forms.TextBox();
            this.txtadsuzme = new System.Windows.Forms.TextBox();
            this.txtknosuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbyil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkutuphaneistatistik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwkutuphaneistatistik
            // 
            this.dgwkutuphaneistatistik.AllowUserToAddRows = false;
            this.dgwkutuphaneistatistik.AllowUserToDeleteRows = false;
            this.dgwkutuphaneistatistik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwkutuphaneistatistik.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwkutuphaneistatistik.BackgroundColor = System.Drawing.Color.White;
            this.dgwkutuphaneistatistik.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwkutuphaneistatistik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwkutuphaneistatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwkutuphaneistatistik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwkutuphaneistatistik.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwkutuphaneistatistik.Location = new System.Drawing.Point(0, 53);
            this.dgwkutuphaneistatistik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwkutuphaneistatistik.Name = "dgwkutuphaneistatistik";
            this.dgwkutuphaneistatistik.ReadOnly = true;
            this.dgwkutuphaneistatistik.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwkutuphaneistatistik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwkutuphaneistatistik.Size = new System.Drawing.Size(1140, 576);
            this.dgwkutuphaneistatistik.TabIndex = 159;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(769, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 17);
            this.label15.TabIndex = 211;
            this.label15.Text = "Kütüphane Tür";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(480, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 17);
            this.label16.TabIndex = 210;
            this.label16.Text = "Kütüphane Ad";
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labell.ForeColor = System.Drawing.Color.Blue;
            this.labell.Location = new System.Drawing.Point(156, 3);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(106, 17);
            this.labell.TabIndex = 209;
            this.labell.Text = "Kütüphane No";
            // 
            // txttursuzme
            // 
            this.txttursuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttursuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttursuzme.ForeColor = System.Drawing.Color.Navy;
            this.txttursuzme.Location = new System.Drawing.Point(685, 23);
            this.txttursuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttursuzme.Name = "txttursuzme";
            this.txttursuzme.Size = new System.Drawing.Size(279, 22);
            this.txttursuzme.TabIndex = 208;
            this.txttursuzme.TextChanged += new System.EventHandler(this.txttursuzme_TextChanged);
            // 
            // txtadsuzme
            // 
            this.txtadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtadsuzme.Location = new System.Drawing.Point(378, 24);
            this.txtadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadsuzme.Name = "txtadsuzme";
            this.txtadsuzme.Size = new System.Drawing.Size(293, 22);
            this.txtadsuzme.TabIndex = 207;
            this.txtadsuzme.TextChanged += new System.EventHandler(this.txtadsuzme_TextChanged);
            // 
            // txtknosuzme
            // 
            this.txtknosuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtknosuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtknosuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtknosuzme.Location = new System.Drawing.Point(69, 24);
            this.txtknosuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtknosuzme.Name = "txtknosuzme";
            this.txtknosuzme.Size = new System.Drawing.Size(293, 22);
            this.txtknosuzme.TabIndex = 206;
            this.txtknosuzme.TextChanged += new System.EventHandler(this.txtknosuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(3, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 205;
            this.label13.Text = "Süzme :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(992, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 223;
            this.label1.Text = "Sorgulanacak Yıl";
            // 
            // cmbyil
            // 
            this.cmbyil.FormattingEnabled = true;
            this.cmbyil.Location = new System.Drawing.Point(976, 23);
            this.cmbyil.Name = "cmbyil";
            this.cmbyil.Size = new System.Drawing.Size(164, 21);
            this.cmbyil.TabIndex = 222;
            this.cmbyil.Text = "Yıl Seçiniz";
            this.cmbyil.SelectedIndexChanged += new System.EventHandler(this.cmbyil_SelectedIndexChanged);
            // 
            // frmKutuphaneIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbyil);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labell);
            this.Controls.Add(this.txttursuzme);
            this.Controls.Add(this.txtadsuzme);
            this.Controls.Add(this.txtknosuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwkutuphaneistatistik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKutuphaneIstatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Kitap Verme İstatistik";
            this.Load += new System.EventHandler(this.frmKutuphaneIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwkutuphaneistatistik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwkutuphaneistatistik;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label labell;
        private System.Windows.Forms.TextBox txttursuzme;
        private System.Windows.Forms.TextBox txtadsuzme;
        private System.Windows.Forms.TextBox txtknosuzme;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbyil;
    }
}
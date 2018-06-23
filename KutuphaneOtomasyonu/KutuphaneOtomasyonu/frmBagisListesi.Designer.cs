namespace KutuphaneOtomasyonu
{
    partial class frmBagisListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBagisListesi));
            this.dgwbagis = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txttcsuzme = new System.Windows.Forms.TextBox();
            this.txtisbnsuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwbagis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwbagis
            // 
            this.dgwbagis.AllowUserToAddRows = false;
            this.dgwbagis.AllowUserToDeleteRows = false;
            this.dgwbagis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwbagis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwbagis.BackgroundColor = System.Drawing.Color.White;
            this.dgwbagis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwbagis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwbagis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwbagis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwbagis.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwbagis.Location = new System.Drawing.Point(0, 46);
            this.dgwbagis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwbagis.Name = "dgwbagis";
            this.dgwbagis.ReadOnly = true;
            this.dgwbagis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwbagis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwbagis.Size = new System.Drawing.Size(899, 589);
            this.dgwbagis.TabIndex = 204;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(211, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 217;
            this.label10.Text = "Kitap İsbn Kod";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(631, -1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 17);
            this.label16.TabIndex = 216;
            this.label16.Text = "Bağış Yapan TC";
            // 
            // txttcsuzme
            // 
            this.txttcsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttcsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttcsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txttcsuzme.Location = new System.Drawing.Point(491, 20);
            this.txttcsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttcsuzme.Name = "txttcsuzme";
            this.txttcsuzme.Size = new System.Drawing.Size(408, 22);
            this.txttcsuzme.TabIndex = 215;
            this.txttcsuzme.TextChanged += new System.EventHandler(this.txttcsuzme_TextChanged);
            // 
            // txtisbnsuzme
            // 
            this.txtisbnsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtisbnsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisbnsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtisbnsuzme.Location = new System.Drawing.Point(77, 20);
            this.txtisbnsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtisbnsuzme.Name = "txtisbnsuzme";
            this.txtisbnsuzme.Size = new System.Drawing.Size(408, 22);
            this.txtisbnsuzme.TabIndex = 214;
            this.txtisbnsuzme.TextChanged += new System.EventHandler(this.txtisbnsuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(11, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 213;
            this.label13.Text = "Süzme :";
            // 
            // frmBagisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 635);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txttcsuzme);
            this.Controls.Add(this.txtisbnsuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwbagis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBagisListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Bagış Listesi";
            this.Load += new System.EventHandler(this.frmBagisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwbagis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwbagis;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txttcsuzme;
        private System.Windows.Forms.TextBox txtisbnsuzme;
        internal System.Windows.Forms.Label label13;
    }
}
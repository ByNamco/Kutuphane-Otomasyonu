namespace KutuphaneOtomasyonu
{
    partial class frmKitapListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapListesi));
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txttursuzme = new System.Windows.Forms.TextBox();
            this.txtyazarsuzme = new System.Windows.Forms.TextBox();
            this.txtadsuzme = new System.Windows.Forms.TextBox();
            this.txtisbnsuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgwkitap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkitap)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(778, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 186;
            this.label14.Text = "Tür";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(564, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 17);
            this.label15.TabIndex = 185;
            this.label15.Text = "Yazar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(373, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 17);
            this.label16.TabIndex = 184;
            this.label16.Text = "Ad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(131, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 17);
            this.label17.TabIndex = 183;
            this.label17.Text = "ISBN Kod";
            // 
            // txttursuzme
            // 
            this.txttursuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttursuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttursuzme.ForeColor = System.Drawing.Color.Navy;
            this.txttursuzme.Location = new System.Drawing.Point(697, 23);
            this.txttursuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttursuzme.Name = "txttursuzme";
            this.txttursuzme.Size = new System.Drawing.Size(202, 22);
            this.txttursuzme.TabIndex = 182;
            this.txttursuzme.TextChanged += new System.EventHandler(this.txttursuzme_TextChanged);
            // 
            // txtyazarsuzme
            // 
            this.txtyazarsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyazarsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyazarsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtyazarsuzme.Location = new System.Drawing.Point(489, 23);
            this.txtyazarsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtyazarsuzme.Name = "txtyazarsuzme";
            this.txtyazarsuzme.Size = new System.Drawing.Size(202, 22);
            this.txtyazarsuzme.TabIndex = 181;
            this.txtyazarsuzme.TextChanged += new System.EventHandler(this.txtyazarsuzme_TextChanged);
            // 
            // txtadsuzme
            // 
            this.txtadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtadsuzme.Location = new System.Drawing.Point(281, 23);
            this.txtadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadsuzme.Name = "txtadsuzme";
            this.txtadsuzme.Size = new System.Drawing.Size(202, 22);
            this.txtadsuzme.TabIndex = 180;
            this.txtadsuzme.TextChanged += new System.EventHandler(this.txtadsuzme_TextChanged);
            // 
            // txtisbnsuzme
            // 
            this.txtisbnsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtisbnsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisbnsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtisbnsuzme.Location = new System.Drawing.Point(74, 23);
            this.txtisbnsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtisbnsuzme.Name = "txtisbnsuzme";
            this.txtisbnsuzme.Size = new System.Drawing.Size(202, 22);
            this.txtisbnsuzme.TabIndex = 179;
            this.txtisbnsuzme.TextChanged += new System.EventHandler(this.txtisbnsuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(13, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 178;
            this.label13.Text = "Süzme :";
            // 
            // dgwkitap
            // 
            this.dgwkitap.AllowUserToAddRows = false;
            this.dgwkitap.AllowUserToDeleteRows = false;
            this.dgwkitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwkitap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwkitap.BackgroundColor = System.Drawing.Color.White;
            this.dgwkitap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwkitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwkitap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwkitap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwkitap.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwkitap.Location = new System.Drawing.Point(0, 53);
            this.dgwkitap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwkitap.Name = "dgwkitap";
            this.dgwkitap.ReadOnly = true;
            this.dgwkitap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwkitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwkitap.Size = new System.Drawing.Size(899, 582);
            this.dgwkitap.TabIndex = 177;
            // 
            // frmKitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 635);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txttursuzme);
            this.Controls.Add(this.txtyazarsuzme);
            this.Controls.Add(this.txtadsuzme);
            this.Controls.Add(this.txtisbnsuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwkitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitapListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.frmKitapListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwkitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txttursuzme;
        private System.Windows.Forms.TextBox txtyazarsuzme;
        private System.Windows.Forms.TextBox txtadsuzme;
        private System.Windows.Forms.TextBox txtisbnsuzme;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgwkitap;
    }
}
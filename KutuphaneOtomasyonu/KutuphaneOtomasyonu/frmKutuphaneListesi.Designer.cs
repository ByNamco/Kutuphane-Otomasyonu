namespace KutuphaneOtomasyonu
{
    partial class frmKutuphaneListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKutuphaneListesi));
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.txtilsuzme = new System.Windows.Forms.TextBox();
            this.txttursuzme = new System.Windows.Forms.TextBox();
            this.txtadsuzme = new System.Windows.Forms.TextBox();
            this.txtknosuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgwkutuphane = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkutuphane)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(790, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 17);
            this.label14.TabIndex = 215;
            this.label14.Text = "İl";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(578, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 214;
            this.label15.Text = "Tür";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(374, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 17);
            this.label16.TabIndex = 213;
            this.label16.Text = "Ad";
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labell.ForeColor = System.Drawing.Color.Blue;
            this.labell.Location = new System.Drawing.Point(132, 3);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(106, 17);
            this.labell.TabIndex = 212;
            this.labell.Text = "Kütüphane No";
            // 
            // txtilsuzme
            // 
            this.txtilsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtilsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtilsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtilsuzme.Location = new System.Drawing.Point(700, 22);
            this.txtilsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtilsuzme.Name = "txtilsuzme";
            this.txtilsuzme.Size = new System.Drawing.Size(199, 22);
            this.txtilsuzme.TabIndex = 211;
            this.txtilsuzme.TextChanged += new System.EventHandler(this.txtilsuzme_TextChanged);
            // 
            // txttursuzme
            // 
            this.txttursuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttursuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttursuzme.ForeColor = System.Drawing.Color.Navy;
            this.txttursuzme.Location = new System.Drawing.Point(495, 22);
            this.txttursuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttursuzme.Name = "txttursuzme";
            this.txttursuzme.Size = new System.Drawing.Size(199, 22);
            this.txttursuzme.TabIndex = 210;
            this.txttursuzme.TextChanged += new System.EventHandler(this.txttursuzme_TextChanged);
            // 
            // txtadsuzme
            // 
            this.txtadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtadsuzme.Location = new System.Drawing.Point(290, 22);
            this.txtadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadsuzme.Name = "txtadsuzme";
            this.txtadsuzme.Size = new System.Drawing.Size(199, 22);
            this.txtadsuzme.TabIndex = 209;
            this.txtadsuzme.TextChanged += new System.EventHandler(this.txtadsuzme_TextChanged);
            // 
            // txtknosuzme
            // 
            this.txtknosuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtknosuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtknosuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtknosuzme.Location = new System.Drawing.Point(85, 22);
            this.txtknosuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtknosuzme.Name = "txtknosuzme";
            this.txtknosuzme.Size = new System.Drawing.Size(199, 22);
            this.txtknosuzme.TabIndex = 208;
            this.txtknosuzme.TextChanged += new System.EventHandler(this.txtknosuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(5, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 207;
            this.label13.Text = "Süzme :";
            // 
            // dgwkutuphane
            // 
            this.dgwkutuphane.AllowUserToAddRows = false;
            this.dgwkutuphane.AllowUserToDeleteRows = false;
            this.dgwkutuphane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwkutuphane.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwkutuphane.BackgroundColor = System.Drawing.Color.White;
            this.dgwkutuphane.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwkutuphane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwkutuphane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwkutuphane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwkutuphane.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwkutuphane.Location = new System.Drawing.Point(0, 52);
            this.dgwkutuphane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwkutuphane.Name = "dgwkutuphane";
            this.dgwkutuphane.ReadOnly = true;
            this.dgwkutuphane.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwkutuphane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwkutuphane.Size = new System.Drawing.Size(899, 583);
            this.dgwkutuphane.TabIndex = 206;
            // 
            // frmKutuphaneListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 635);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labell);
            this.Controls.Add(this.txtilsuzme);
            this.Controls.Add(this.txttursuzme);
            this.Controls.Add(this.txtadsuzme);
            this.Controls.Add(this.txtknosuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwkutuphane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKutuphaneListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Listesi";
            this.Load += new System.EventHandler(this.frmKutuphaneListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwkutuphane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label labell;
        private System.Windows.Forms.TextBox txtilsuzme;
        private System.Windows.Forms.TextBox txttursuzme;
        private System.Windows.Forms.TextBox txtadsuzme;
        private System.Windows.Forms.TextBox txtknosuzme;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgwkutuphane;
    }
}
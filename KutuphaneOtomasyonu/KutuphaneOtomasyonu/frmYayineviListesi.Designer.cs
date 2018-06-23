namespace KutuphaneOtomasyonu
{
    partial class frmYayineviListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYayineviListesi));
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtadsuzme = new System.Windows.Forms.TextBox();
            this.txtkodsuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgwyayinevi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwyayinevi)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(213, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 212;
            this.label10.Text = "Yayınevi Kod";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(700, -1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 17);
            this.label16.TabIndex = 211;
            this.label16.Text = "Ad";
            // 
            // txtadsuzme
            // 
            this.txtadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtadsuzme.Location = new System.Drawing.Point(493, 20);
            this.txtadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadsuzme.Name = "txtadsuzme";
            this.txtadsuzme.Size = new System.Drawing.Size(408, 22);
            this.txtadsuzme.TabIndex = 209;
            this.txtadsuzme.TextChanged += new System.EventHandler(this.txtadsuzme_TextChanged);
            // 
            // txtkodsuzme
            // 
            this.txtkodsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkodsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkodsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtkodsuzme.Location = new System.Drawing.Point(79, 20);
            this.txtkodsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtkodsuzme.Name = "txtkodsuzme";
            this.txtkodsuzme.Size = new System.Drawing.Size(408, 22);
            this.txtkodsuzme.TabIndex = 208;
            this.txtkodsuzme.TextChanged += new System.EventHandler(this.txtkodsuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(13, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 207;
            this.label13.Text = "Süzme :";
            // 
            // dgwyayinevi
            // 
            this.dgwyayinevi.AllowUserToAddRows = false;
            this.dgwyayinevi.AllowUserToDeleteRows = false;
            this.dgwyayinevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwyayinevi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwyayinevi.BackgroundColor = System.Drawing.Color.White;
            this.dgwyayinevi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwyayinevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwyayinevi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwyayinevi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwyayinevi.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwyayinevi.Location = new System.Drawing.Point(0, 50);
            this.dgwyayinevi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwyayinevi.Name = "dgwyayinevi";
            this.dgwyayinevi.ReadOnly = true;
            this.dgwyayinevi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwyayinevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwyayinevi.Size = new System.Drawing.Size(899, 585);
            this.dgwyayinevi.TabIndex = 206;
            // 
            // frmYayineviListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 635);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtadsuzme);
            this.Controls.Add(this.txtkodsuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwyayinevi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYayineviListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yayınevi Listesi";
            this.Load += new System.EventHandler(this.frmYayineviListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwyayinevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtadsuzme;
        private System.Windows.Forms.TextBox txtkodsuzme;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgwyayinevi;
    }
}
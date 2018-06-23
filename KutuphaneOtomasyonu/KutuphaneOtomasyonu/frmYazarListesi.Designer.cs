namespace KutuphaneOtomasyonu
{
    partial class frmYazarListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYazarListesi));
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtsoyadsuzme = new System.Windows.Forms.TextBox();
            this.txtadsuzme = new System.Windows.Forms.TextBox();
            this.txtyazarnosuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgwyazar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwyazar)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(739, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 210;
            this.label15.Text = "Soyad";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(467, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 17);
            this.label16.TabIndex = 209;
            this.label16.Text = "Ad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(171, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 208;
            this.label17.Text = "Yazar No";
            // 
            // txtsoyadsuzme
            // 
            this.txtsoyadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoyadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtsoyadsuzme.Location = new System.Drawing.Point(633, 20);
            this.txtsoyadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoyadsuzme.Name = "txtsoyadsuzme";
            this.txtsoyadsuzme.Size = new System.Drawing.Size(270, 22);
            this.txtsoyadsuzme.TabIndex = 207;
            this.txtsoyadsuzme.TextChanged += new System.EventHandler(this.txtsoyadsuzme_TextChanged);
            // 
            // txtadsuzme
            // 
            this.txtadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtadsuzme.Location = new System.Drawing.Point(357, 20);
            this.txtadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadsuzme.Name = "txtadsuzme";
            this.txtadsuzme.Size = new System.Drawing.Size(270, 22);
            this.txtadsuzme.TabIndex = 206;
            this.txtadsuzme.TextChanged += new System.EventHandler(this.txtadsuzme_TextChanged);
            // 
            // txtyazarnosuzme
            // 
            this.txtyazarnosuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyazarnosuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyazarnosuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtyazarnosuzme.Location = new System.Drawing.Point(81, 20);
            this.txtyazarnosuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtyazarnosuzme.Name = "txtyazarnosuzme";
            this.txtyazarnosuzme.Size = new System.Drawing.Size(270, 22);
            this.txtyazarnosuzme.TabIndex = 205;
            this.txtyazarnosuzme.TextChanged += new System.EventHandler(this.txtyazarnosuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(3, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 204;
            this.label13.Text = "Süzme :";
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
            this.dgwyazar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwyazar.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwyazar.Location = new System.Drawing.Point(0, 50);
            this.dgwyazar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwyazar.Name = "dgwyazar";
            this.dgwyazar.ReadOnly = true;
            this.dgwyazar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwyazar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwyazar.Size = new System.Drawing.Size(903, 589);
            this.dgwyazar.TabIndex = 203;
            // 
            // frmYazarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 639);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtsoyadsuzme);
            this.Controls.Add(this.txtadsuzme);
            this.Controls.Add(this.txtyazarnosuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwyazar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYazarListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazar Listesi";
            this.Load += new System.EventHandler(this.frmYazarListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwyazar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtsoyadsuzme;
        private System.Windows.Forms.TextBox txtadsuzme;
        private System.Windows.Forms.TextBox txtyazarnosuzme;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgwyazar;
    }
}
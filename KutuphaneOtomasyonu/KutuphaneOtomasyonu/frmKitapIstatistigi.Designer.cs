namespace KutuphaneOtomasyonu
{
    partial class frmKitapIstatistigi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapIstatistigi));
            this.dgwkitapistatistik = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txttursuzme = new System.Windows.Forms.TextBox();
            this.txtyazarsuzme = new System.Windows.Forms.TextBox();
            this.txtadsuzme = new System.Windows.Forms.TextBox();
            this.txtisbnsuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbyil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkitapistatistik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwkitapistatistik
            // 
            this.dgwkitapistatistik.AllowUserToAddRows = false;
            this.dgwkitapistatistik.AllowUserToDeleteRows = false;
            this.dgwkitapistatistik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwkitapistatistik.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwkitapistatistik.BackgroundColor = System.Drawing.Color.White;
            this.dgwkitapistatistik.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwkitapistatistik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwkitapistatistik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwkitapistatistik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwkitapistatistik.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwkitapistatistik.Location = new System.Drawing.Point(0, 53);
            this.dgwkitapistatistik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwkitapistatistik.Name = "dgwkitapistatistik";
            this.dgwkitapistatistik.ReadOnly = true;
            this.dgwkitapistatistik.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwkitapistatistik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwkitapistatistik.Size = new System.Drawing.Size(1140, 576);
            this.dgwkitapistatistik.TabIndex = 158;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(810, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 219;
            this.label14.Text = "Kitabın Türü";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(585, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 17);
            this.label15.TabIndex = 218;
            this.label15.Text = "Kitabın Yazarı";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(379, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 17);
            this.label16.TabIndex = 217;
            this.label16.Text = "Kitap Adı";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(120, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 17);
            this.label17.TabIndex = 216;
            this.label17.Text = "Kitap ISBN Kod";
            // 
            // txttursuzme
            // 
            this.txttursuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttursuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttursuzme.ForeColor = System.Drawing.Color.Navy;
            this.txttursuzme.Location = new System.Drawing.Point(753, 24);
            this.txttursuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttursuzme.Name = "txttursuzme";
            this.txttursuzme.Size = new System.Drawing.Size(217, 22);
            this.txttursuzme.TabIndex = 215;
            this.txttursuzme.TextChanged += new System.EventHandler(this.txttursuzme_TextChanged);
            // 
            // txtyazarsuzme
            // 
            this.txtyazarsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyazarsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyazarsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtyazarsuzme.Location = new System.Drawing.Point(525, 24);
            this.txtyazarsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtyazarsuzme.Name = "txtyazarsuzme";
            this.txtyazarsuzme.Size = new System.Drawing.Size(222, 22);
            this.txtyazarsuzme.TabIndex = 214;
            this.txtyazarsuzme.TextChanged += new System.EventHandler(this.txtyazarsuzme_TextChanged);
            // 
            // txtadsuzme
            // 
            this.txtadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtadsuzme.Location = new System.Drawing.Point(297, 24);
            this.txtadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadsuzme.Name = "txtadsuzme";
            this.txtadsuzme.Size = new System.Drawing.Size(222, 22);
            this.txtadsuzme.TabIndex = 213;
            this.txtadsuzme.TextChanged += new System.EventHandler(this.txtadsuzme_TextChanged);
            // 
            // txtisbnsuzme
            // 
            this.txtisbnsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtisbnsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisbnsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtisbnsuzme.Location = new System.Drawing.Point(69, 24);
            this.txtisbnsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtisbnsuzme.Name = "txtisbnsuzme";
            this.txtisbnsuzme.Size = new System.Drawing.Size(222, 22);
            this.txtisbnsuzme.TabIndex = 212;
            this.txtisbnsuzme.TextChanged += new System.EventHandler(this.txtisbnsuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(3, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 211;
            this.label13.Text = "Süzme :";
            // 
            // cmbyil
            // 
            this.cmbyil.FormattingEnabled = true;
            this.cmbyil.Location = new System.Drawing.Point(976, 24);
            this.cmbyil.Name = "cmbyil";
            this.cmbyil.Size = new System.Drawing.Size(164, 21);
            this.cmbyil.TabIndex = 220;
            this.cmbyil.Text = "Yıl Seçiniz";
            this.cmbyil.SelectedIndexChanged += new System.EventHandler(this.cmbyil_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(992, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 221;
            this.label1.Text = "Sorgulanacak Yıl";
            // 
            // frmKitapIstatistigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbyil);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txttursuzme);
            this.Controls.Add(this.txtyazarsuzme);
            this.Controls.Add(this.txtadsuzme);
            this.Controls.Add(this.txtisbnsuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwkitapistatistik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitapIstatistigi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Okunma İstatistiği";
            this.Load += new System.EventHandler(this.frmKitapIstatistigi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwkitapistatistik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwkitapistatistik;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txttursuzme;
        private System.Windows.Forms.TextBox txtyazarsuzme;
        private System.Windows.Forms.TextBox txtadsuzme;
        private System.Windows.Forms.TextBox txtisbnsuzme;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbyil;
        internal System.Windows.Forms.Label label1;
    }
}
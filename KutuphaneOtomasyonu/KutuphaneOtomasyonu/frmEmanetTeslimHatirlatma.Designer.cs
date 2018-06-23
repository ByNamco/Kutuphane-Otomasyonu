namespace KutuphaneOtomasyonu
{
    partial class frmEmanetTeslimHatirlatma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmanetTeslimHatirlatma));
            this.dgwteslimhatirlatma = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.txttcsuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtisbnsuzme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwteslimhatirlatma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwteslimhatirlatma
            // 
            this.dgwteslimhatirlatma.AllowUserToAddRows = false;
            this.dgwteslimhatirlatma.AllowUserToDeleteRows = false;
            this.dgwteslimhatirlatma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwteslimhatirlatma.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwteslimhatirlatma.BackgroundColor = System.Drawing.Color.White;
            this.dgwteslimhatirlatma.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwteslimhatirlatma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwteslimhatirlatma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwteslimhatirlatma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwteslimhatirlatma.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwteslimhatirlatma.Location = new System.Drawing.Point(0, 57);
            this.dgwteslimhatirlatma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwteslimhatirlatma.Name = "dgwteslimhatirlatma";
            this.dgwteslimhatirlatma.ReadOnly = true;
            this.dgwteslimhatirlatma.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwteslimhatirlatma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwteslimhatirlatma.Size = new System.Drawing.Size(1000, 328);
            this.dgwteslimhatirlatma.TabIndex = 210;
            this.dgwteslimhatirlatma.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwteslimhatirlatma_ColumnHeaderMouseClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(701, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 17);
            this.label17.TabIndex = 213;
            this.label17.Text = "Kitap ISBN Kod";
            // 
            // txttcsuzme
            // 
            this.txttcsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttcsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttcsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txttcsuzme.Location = new System.Drawing.Point(60, 30);
            this.txttcsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttcsuzme.Name = "txttcsuzme";
            this.txttcsuzme.Size = new System.Drawing.Size(459, 22);
            this.txttcsuzme.TabIndex = 212;
            this.txttcsuzme.TextChanged += new System.EventHandler(this.txtisbnsuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(-3, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 211;
            this.label13.Text = "Süzme :";
            // 
            // txtisbnsuzme
            // 
            this.txtisbnsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtisbnsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisbnsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtisbnsuzme.Location = new System.Drawing.Point(529, 30);
            this.txtisbnsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtisbnsuzme.Name = "txtisbnsuzme";
            this.txtisbnsuzme.Size = new System.Drawing.Size(459, 22);
            this.txtisbnsuzme.TabIndex = 214;
            this.txtisbnsuzme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 215;
            this.label1.Text = "Üye Tc";
            // 
            // frmEmanetTeslimHatirlatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtisbnsuzme);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txttcsuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwteslimhatirlatma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmanetTeslimHatirlatma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teslim  Hatırlatma";
            this.Load += new System.EventHandler(this.frmTeslimHatirlatma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwteslimhatirlatma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwteslimhatirlatma;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txttcsuzme;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtisbnsuzme;
        internal System.Windows.Forms.Label label1;
    }
}
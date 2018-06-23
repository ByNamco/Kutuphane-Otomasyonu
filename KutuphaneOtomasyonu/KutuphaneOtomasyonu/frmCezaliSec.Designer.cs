namespace KutuphaneOtomasyonu
{
    partial class frmCezaliSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCezaliSec));
            this.dgwcezalisec = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtidsuzme = new System.Windows.Forms.TextBox();
            this.txttcsuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwcezalisec)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwcezalisec
            // 
            this.dgwcezalisec.AllowUserToAddRows = false;
            this.dgwcezalisec.AllowUserToDeleteRows = false;
            this.dgwcezalisec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwcezalisec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwcezalisec.BackgroundColor = System.Drawing.Color.White;
            this.dgwcezalisec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwcezalisec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwcezalisec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwcezalisec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwcezalisec.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwcezalisec.Location = new System.Drawing.Point(0, 50);
            this.dgwcezalisec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwcezalisec.Name = "dgwcezalisec";
            this.dgwcezalisec.ReadOnly = true;
            this.dgwcezalisec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwcezalisec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwcezalisec.Size = new System.Drawing.Size(676, 317);
            this.dgwcezalisec.TabIndex = 202;
            this.dgwcezalisec.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgwcezalisec_MouseDoubleClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(455, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 17);
            this.label16.TabIndex = 214;
            this.label16.Text = "Ceza İd";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(180, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 17);
            this.label17.TabIndex = 213;
            this.label17.Text = "Üye Tc";
            // 
            // txtidsuzme
            // 
            this.txtidsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtidsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtidsuzme.Location = new System.Drawing.Point(375, 22);
            this.txtidsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtidsuzme.Name = "txtidsuzme";
            this.txtidsuzme.Size = new System.Drawing.Size(301, 22);
            this.txtidsuzme.TabIndex = 212;
            this.txtidsuzme.TextChanged += new System.EventHandler(this.txtidsuzme_TextChanged);
            // 
            // txttcsuzme
            // 
            this.txttcsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttcsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttcsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txttcsuzme.Location = new System.Drawing.Point(71, 22);
            this.txttcsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttcsuzme.Name = "txttcsuzme";
            this.txttcsuzme.Size = new System.Drawing.Size(301, 22);
            this.txttcsuzme.TabIndex = 211;
            this.txttcsuzme.TextChanged += new System.EventHandler(this.txttcsuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(5, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 210;
            this.label13.Text = "Süzme :";
            // 
            // frmCezaliSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 367);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtidsuzme);
            this.Controls.Add(this.txttcsuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwcezalisec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCezaliSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cezalı Seç";
            this.Load += new System.EventHandler(this.frmCezaliSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwcezalisec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwcezalisec;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtidsuzme;
        private System.Windows.Forms.TextBox txttcsuzme;
        internal System.Windows.Forms.Label label13;
    }
}
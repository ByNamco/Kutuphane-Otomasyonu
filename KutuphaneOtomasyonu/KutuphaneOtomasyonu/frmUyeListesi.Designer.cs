﻿namespace KutuphaneOtomasyonu
{
    partial class frmUyeListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeListesi));
            this.dgwuye = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtmesleksuzme = new System.Windows.Forms.TextBox();
            this.txtsoyadsuzme = new System.Windows.Forms.TextBox();
            this.txtadsuzme = new System.Windows.Forms.TextBox();
            this.txttcsuzme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwuye)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwuye
            // 
            this.dgwuye.AllowUserToAddRows = false;
            this.dgwuye.AllowUserToDeleteRows = false;
            this.dgwuye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwuye.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwuye.BackgroundColor = System.Drawing.Color.White;
            this.dgwuye.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgwuye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwuye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwuye.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwuye.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgwuye.Location = new System.Drawing.Point(0, 48);
            this.dgwuye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwuye.Name = "dgwuye";
            this.dgwuye.ReadOnly = true;
            this.dgwuye.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwuye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwuye.Size = new System.Drawing.Size(899, 587);
            this.dgwuye.TabIndex = 188;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(774, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 205;
            this.label14.Text = "Meslek";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(572, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 17);
            this.label15.TabIndex = 204;
            this.label15.Text = "Soyad";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(370, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 17);
            this.label16.TabIndex = 203;
            this.label16.Text = "Ad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(169, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 17);
            this.label17.TabIndex = 202;
            this.label17.Text = "Tc";
            // 
            // txtmesleksuzme
            // 
            this.txtmesleksuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmesleksuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmesleksuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtmesleksuzme.Location = new System.Drawing.Point(699, 18);
            this.txtmesleksuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmesleksuzme.Name = "txtmesleksuzme";
            this.txtmesleksuzme.Size = new System.Drawing.Size(200, 22);
            this.txtmesleksuzme.TabIndex = 201;
            this.txtmesleksuzme.TextChanged += new System.EventHandler(this.txtmesleksuzme_TextChanged);
            // 
            // txtsoyadsuzme
            // 
            this.txtsoyadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoyadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtsoyadsuzme.Location = new System.Drawing.Point(493, 18);
            this.txtsoyadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoyadsuzme.Name = "txtsoyadsuzme";
            this.txtsoyadsuzme.Size = new System.Drawing.Size(200, 22);
            this.txtsoyadsuzme.TabIndex = 200;
            this.txtsoyadsuzme.TextChanged += new System.EventHandler(this.txtsoyadsuzme_TextChanged);
            // 
            // txtadsuzme
            // 
            this.txtadsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txtadsuzme.Location = new System.Drawing.Point(287, 18);
            this.txtadsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtadsuzme.Name = "txtadsuzme";
            this.txtadsuzme.Size = new System.Drawing.Size(200, 22);
            this.txtadsuzme.TabIndex = 199;
            this.txtadsuzme.TextChanged += new System.EventHandler(this.txtadsuzme_TextChanged);
            // 
            // txttcsuzme
            // 
            this.txttcsuzme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttcsuzme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttcsuzme.ForeColor = System.Drawing.Color.Navy;
            this.txttcsuzme.Location = new System.Drawing.Point(81, 18);
            this.txttcsuzme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttcsuzme.Name = "txttcsuzme";
            this.txttcsuzme.Size = new System.Drawing.Size(200, 22);
            this.txttcsuzme.TabIndex = 198;
            this.txttcsuzme.TextChanged += new System.EventHandler(this.txttcsuzme_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(12, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 197;
            this.label13.Text = "Süzme :";
            // 
            // frmUyeListesi
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
            this.Controls.Add(this.txtmesleksuzme);
            this.Controls.Add(this.txtsoyadsuzme);
            this.Controls.Add(this.txtadsuzme);
            this.Controls.Add(this.txttcsuzme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwuye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUyeListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Listesi";
            this.Load += new System.EventHandler(this.frmUyeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwuye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwuye;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtmesleksuzme;
        private System.Windows.Forms.TextBox txtsoyadsuzme;
        private System.Windows.Forms.TextBox txtadsuzme;
        private System.Windows.Forms.TextBox txttcsuzme;
        internal System.Windows.Forms.Label label13;
    }
}
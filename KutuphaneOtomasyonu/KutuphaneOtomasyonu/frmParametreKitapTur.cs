﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmParametreKitapTur : Form
    {
        public frmParametreKitapTur()
        {
            InitializeComponent();
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txttanim.Text = "";
            id();
        }
        private void id()
        {
            clsParametreKitapTur a = new clsParametreKitapTur();
            a.hazirid();
            txtid.Text = a.zDgr;

        }
        public void datagrdDoldur()
        { 
            clsParametreKitapTur a = new clsParametreKitapTur();
            dgwKitapTur.DataSource = a.datagrdDoldur();
        }

        private void frmParametreKitapTur_Load(object sender, EventArgs e)
        {
            datagrdDoldur();
            id();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 0 & txttanim.Text.Length > 0)
            {
                clsParametreKitapTur a = new clsParametreKitapTur();
                a.zId = txtid.Text;
                a.zTanim = txttanim.Text;
                a.kaydet();
                datagrdDoldur();
                MessageBox.Show(a.zDgr);
                btnyeni_Click(sender, e);
                id();

            }
            else
            {
                MessageBox.Show("Gerekli Bilgileri Giriniz");
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 0 & txttanim.Text.Length > 0)
            {
                clsParametreKitapTur a = new clsParametreKitapTur();
                a.zId = txtid.Text;
                a.zTanim = txttanim.Text;
                a.guncelle();
                datagrdDoldur();
                MessageBox.Show(a.zDgr);
                btnyeni_Click(sender, e);
                id();

            }
            else
            {
                MessageBox.Show("Gerekli Bilgileri Giriniz");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 0)
            {
                clsParametreKitapTur a = new clsParametreKitapTur();
                a.zId = txtid.Text;
                a.sil();
                datagrdDoldur();
                MessageBox.Show(a.zDgr);
                btnyeni_Click(sender, e);
                id();

            }
            else
            {
                MessageBox.Show("İd Giriniz");
            }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmParametreKitapYeri : Form
    {
        public frmParametreKitapYeri()
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
            clsParametreKitapYeri a = new clsParametreKitapYeri();
            a.hazirid();
            txtid.Text = a.zDgr;

        }
        public void datagrdDoldur()
        { 
            clsParametreKitapYeri a = new clsParametreKitapYeri();
            dgwKitapYer.DataSource = a.datagrdDoldur();
        }

        private void frmParametreKitapYeri_Load(object sender, EventArgs e)
        {
            datagrdDoldur();
            id();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 0 & txttanim.Text.Length > 0)
            {
                clsParametreKitapYeri a = new clsParametreKitapYeri();
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
                clsParametreKitapYeri a = new clsParametreKitapYeri();
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
                clsParametreKitapYeri a = new clsParametreKitapYeri();
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

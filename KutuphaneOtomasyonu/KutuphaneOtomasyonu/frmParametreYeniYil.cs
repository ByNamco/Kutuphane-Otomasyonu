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
    public partial class frmParametreYeniYil : Form
    {
        public frmParametreYeniYil()
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
            clsParametreYeniYil a = new clsParametreYeniYil();
            a.hazirid();
            txtid.Text = a.zDgr;

        }
        public void datagrdDoldur()
        {
            clsParametreYeniYil a = new clsParametreYeniYil();
            dgwyyil.DataSource = a.datagrdDoldur();
        }

        private void frmParametreYeniYil_Load(object sender, EventArgs e)
        {
            datagrdDoldur();
            id();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 0)
            {
                clsParametreYeniYil a = new clsParametreYeniYil();
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
                MessageBox.Show("İd Giriniz");
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 0)
            {
                clsParametreYeniYil a = new clsParametreYeniYil();
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
                MessageBox.Show("İd Giriniz");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 0)
            {
                clsParametreYeniYil a = new clsParametreYeniYil();
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

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
    public partial class frmYazarIslem : Form
    {
        public frmYazarIslem()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
        public void datagrdDoldur()
        {
            clsYazarIslem y = new clsYazarIslem();
            dgwyazar.DataSource = y.datagrdDoldur();
        }
        private void id()
        {
            clsYazarIslem a = new clsYazarIslem();
            a.hazirid();
            txtyazarno.Text = a.zDgr;

        }
        private void frmYazarIslem_Load(object sender, EventArgs e)
        {
            datagrdDoldur();
            id();
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtadsuzme.Clear();
            txtotobiyografi.Clear();
            txtsoyad.Clear();
            txtsoyadsuzme.Clear();
            txtyazarno.Clear();
            txtyazarnosuzme.Clear();
            id();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtyazarno.Text.Length > 0 & txtad.Text.Length > 0)
            {
                clsYazarIslem y = new clsYazarIslem();
                y.zAd = txtad.Text;
                y.zNo = txtyazarno.Text;
                y.zOtobiyografi = txtotobiyografi.Text;
                y.zSoyad = txtsoyad.Text;
                y.kaydet();
                MessageBox.Show(y.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Gerekli Bilgileri Giriniz"); }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtyazarno.Text.Length > 0 & txtad.Text.Length > 0)
            {
                clsYazarIslem y = new clsYazarIslem();
                y.zAd = txtad.Text;
                y.zNo = txtyazarno.Text;
                y.zOtobiyografi = txtotobiyografi.Text;
                y.zSoyad = txtsoyad.Text;
                y.guncelle();
                MessageBox.Show(y.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Yazar Nosunu Kontrol Edip Tekrar Deneyin"); }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtyazarno.Text.Length > 0)
            {
                clsYazarIslem y = new clsYazarIslem();
                y.zNo = txtyazarno.Text;
                y.sil();
                MessageBox.Show(y.zDgr);
                btnyeni_Click(sender, e);
                datagrdDoldur();

            }
            else { MessageBox.Show("Yazar Nosunu Giriniz"); }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            if (txtyazarno.Text.Length > 0)
            {
                clsYazarIslem y = new clsYazarIslem();
                y.zNo = txtyazarno.Text;
                y.bul();
                txtad.Text = y.zAd;
                txtotobiyografi.Text  = y.zOtobiyografi;
                txtsoyad.Text  = y.zSoyad;
                txtyazarno.Text = y.zNo;
                MessageBox.Show(y.zDgr);
            }
            else { MessageBox.Show("Yazar Nosunu Giriniz"); }
        }

        private void dgwyazar_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgwyazar.RowCount != 0)
            {
                txtyazarno.Text = dgwyazar.CurrentRow.Cells[0].Value.ToString();
                txtad.Text = dgwyazar.CurrentRow.Cells[1].Value.ToString();
                txtsoyad.Text = dgwyazar.CurrentRow.Cells[2].Value.ToString();
                txtotobiyografi.Text = dgwyazar.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void suzme()
        {
            clsYazarIslem y = new clsYazarIslem();
            y.zAd = txtadsuzme.Text;
            y.zSoyad = txtsoyadsuzme.Text;
            y.zNo = txtyazarnosuzme.Text;
            dgwyazar.DataSource = y.suzme();
        }
        private void txtyazarnosuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtsoyadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtyazarno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

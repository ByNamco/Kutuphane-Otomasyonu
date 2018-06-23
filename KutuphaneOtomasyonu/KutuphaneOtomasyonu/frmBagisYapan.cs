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
    public partial class frmBagisYapan : Form
    {
        public frmBagisYapan()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void frmBagisYapan_Load(object sender, EventArgs e)
        {
            txtisbnkod.Text = clsKitapIslem.zBagisisbn;
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtadres.Clear();
            txtisbnkod.Clear();
            txtsoyad.Clear();
            txttc.Clear();
            txttel.Clear();
            dtpbasimtarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtisbnkod.Text.Length > 0 & txttc.Text.Length == 11)
            {
                clsBagisYapan b = new clsBagisYapan();
                b.zAd = txtad.Text;
                b.zAdres = txtadres.Text;
                b.zBagistarih = dtpbasimtarih.Text;
                b.zIsbn = txtisbnkod.Text;
                b.zSoyad = txtsoyad.Text;
                b.zTc = txttc.Text;
                b.zTel = txttel.Text;
                b.kaydet();
                MessageBox.Show(b.zDgr);
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Gerekli Bilgileri Giriniz"); }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtisbnkod.Text.Length > 0 & txttc.Text.Length == 11)
            {
                clsBagisYapan b = new clsBagisYapan();
                b.zAd = txtad.Text;
                b.zAdres = txtadres.Text;
                b.zBagistarih = dtpbasimtarih.Text;
                b.zIsbn = txtisbnkod.Text;
                b.zSoyad = txtsoyad.Text;
                b.zTc = txttc.Text;
                b.zTel = txttel.Text;
                b.guncelle();
                MessageBox.Show(b.zDgr);
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("ISBN Kodunu Giriniz"); }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtisbnkod.Text.Length > 0)
            {
                clsBagisYapan b = new clsBagisYapan();
                b.zIsbn = txtisbnkod.Text;
                b.sil();
                MessageBox.Show(b.zDgr);
                btnyeni_Click(sender, e);

            }
            else { MessageBox.Show("ISBN Kodunu Giriniz"); }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

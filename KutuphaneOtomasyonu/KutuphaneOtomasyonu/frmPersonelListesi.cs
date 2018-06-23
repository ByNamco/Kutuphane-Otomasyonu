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
    public partial class frmPersonelListesi : Form
    {
        public frmPersonelListesi()
        {
            InitializeComponent();
        }

        private void frmPersonelListesi_Load(object sender, EventArgs e)
        {
            clsPersonelListesi u = new clsPersonelListesi();
            dgwpersonel.DataSource = u.datagrdDoldur();
        }
        private void suzme()
        {
            clsPersonelListesi u = new clsPersonelListesi();
            u.zAd = txtadsuzme.Text;
            u.zCalismadurum = cmbcalismadurumsuz.Text;
            u.zSoyad = txtsoyadsuzme.Text;
            u.zTc = txttcsuzme.Text;
            dgwpersonel.DataSource = u.suzme();
        }

        private void txttcsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        

        private void txtsoyadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void cmbcalismadurumsuz_SelectedIndexChanged(object sender, EventArgs e)
        { { suzme(); } }
    }
}

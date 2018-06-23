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
    public partial class frmYazarListesi : Form
    {
        public frmYazarListesi()
        {
            InitializeComponent();
        }

        private void frmYazarListesi_Load(object sender, EventArgs e)
        {
            clsYazarListesi y = new clsYazarListesi();
            dgwyazar.DataSource = y.datagrdDoldur();
        }
        private void suzme()
        {
            clsYazarListesi y = new clsYazarListesi();
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
    }
}

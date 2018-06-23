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
    public partial class frmKutuphaneListesi : Form
    {
        public frmKutuphaneListesi()
        {
            InitializeComponent();
        }

        private void frmKutuphaneListesi_Load(object sender, EventArgs e)
        {
            clsKutuphaneListesi k = new clsKutuphaneListesi();
            dgwkutuphane.DataSource = k.datagrdDoldur();
        }
        private void suzme()
        {
            clsKutuphaneListesi k = new clsKutuphaneListesi();
            k.zAd = txtadsuzme.Text;
            k.zIl = txtilsuzme.Text;
            k.zKutuphaneno = txtknosuzme.Text;
            k.zTur = txttursuzme.Text;
            dgwkutuphane.DataSource = k.suzme();
        }

        private void txtknosuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txttursuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtilsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
    }
}

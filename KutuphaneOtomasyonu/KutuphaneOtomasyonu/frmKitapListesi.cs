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
    public partial class frmKitapListesi : Form
    {
        public frmKitapListesi()
        {
            InitializeComponent();
        }

        private void frmKitapListesi_Load(object sender, EventArgs e)
        {
            clsKitapListesi k = new clsKitapListesi();
            dgwkitap.DataSource = k.datagrdDoldur();
        }
        private void suzme()
        {
            clsKitapListesi k = new clsKitapListesi();
            k.zIsbn = txtisbnsuzme.Text;
            k.zAd = txtadsuzme.Text;
            k.zTur = txttursuzme.Text;
            k.zYazar = txtyazarsuzme.Text;
            dgwkitap.DataSource = k.suzme();
        }

        private void txtisbnsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtyazarsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txttursuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
    }
}

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
    public partial class frmUyeListesi : Form
    {
        public frmUyeListesi()
        {
            InitializeComponent();
        }

        private void frmUyeListesi_Load(object sender, EventArgs e)
        {
            clsUyeListesi u = new clsUyeListesi();
            dgwuye.DataSource = u.datagrdDoldur();
        }
        private void suzme()
        {
            clsUyeListesi u = new clsUyeListesi();
            u.zAd = txtadsuzme.Text;
            u.zMeslek = txtmesleksuzme.Text;
            u.zSoyad = txtsoyadsuzme.Text;
            u.zTc = txttcsuzme.Text;
            dgwuye.DataSource = u.suzme();
        }

        private void txttcsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtsoyadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtmesleksuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
    }
}

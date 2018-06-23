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
    public partial class frmYayineviListesi : Form
    {
        public frmYayineviListesi()
        {
            InitializeComponent();
        }

        private void frmYayineviListesi_Load(object sender, EventArgs e)
        {
            clsYayineviListesi k = new clsYayineviListesi();
            dgwyayinevi.DataSource = k.datagrdDoldur();
        }
        private void suzme()
        {
            clsYayineviListesi k = new clsYayineviListesi();
            k.zNo = txtkodsuzme.Text;
            k.zAd = txtadsuzme.Text;
            dgwyayinevi.DataSource = k.suzme();
        }

        private void txtkodsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
    }
}

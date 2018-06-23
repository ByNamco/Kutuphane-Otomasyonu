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
    public partial class frmBagisListesi : Form
    {
        public frmBagisListesi()
        {
            InitializeComponent();
        }

        private void frmBagisListesi_Load(object sender, EventArgs e)
        {
            clsBagisListesi b = new clsBagisListesi();
            dgwbagis.DataSource = b.datagrdDoldur();
        }
        private void suzme()
        {
            clsBagisListesi b = new clsBagisListesi();
            b.zBytc = txttcsuzme.Text; ;
            b.zIsbn  = txtisbnsuzme .Text ;
            dgwbagis.DataSource = b.suzme();
        }

        private void txttcsuzme_TextChanged(object sender, EventArgs e)
        {suzme();}

        private void txtisbnsuzme_TextChanged(object sender, EventArgs e)
        { suzme(); }
    }
}

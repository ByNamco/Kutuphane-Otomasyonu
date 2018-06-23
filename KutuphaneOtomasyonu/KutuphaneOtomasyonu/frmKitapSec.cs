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
    public partial class frmKitapSec : Form
    {
        public frmKitapSec()
        {
            InitializeComponent();
        }

        private void frmKitapSec_Load(object sender, EventArgs e)
        {
            clsKitapSec k = new clsKitapSec();
            dgwkitapsec.DataSource = k.datagrdDoldur();
        }
        private void suzme()
        {
            clsKitapSec k = new clsKitapSec();
            k.zIsbn = txtisbnsuzme.Text;
            k.zAd = txtadsuzme.Text;
            k.zTur = txttursuzme.Text;
            k.zYazar = txtyazarsuzme.Text;
            dgwkitapsec.DataSource = k.suzme();
        }

        private void txtisbnsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtyazarsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txttursuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void dgwkitapsec_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgwkitapsec.RowCount != 0)
            {
                clsStatik.zIsbn = dgwkitapsec.CurrentRow.Cells[0].Value.ToString();
                clsStatik.zKad = dgwkitapsec.CurrentRow.Cells[1].Value.ToString();
                clsStatik.zYazar = dgwkitapsec.CurrentRow.Cells[2].Value.ToString();
                clsStatik.zTur = dgwkitapsec.CurrentRow.Cells[3].Value.ToString();
                this.Close();
            }
        }

    }
}

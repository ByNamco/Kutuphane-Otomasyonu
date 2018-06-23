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
    public partial class frmUyeSec : Form
    {
        public frmUyeSec()
        {
            InitializeComponent();
        }

        private void frmUyeSec_Load(object sender, EventArgs e)
        {
            clsUyeSec u = new clsUyeSec();
            dgwuyesec.DataSource = u.datagrdDoldur();
        }
        private void suzme()
        {
            clsUyeSec u = new clsUyeSec();
            u.zAd = txtadsuzme.Text;
            u.zMeslek = txtmesleksuzme.Text;
            u.zSoyad = txtsoyadsuzme.Text;
            u.zTc = txttcsuzme.Text;
            dgwuyesec.DataSource = u.suzme();
        }

        private void txttcsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }


        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }


        private void txtsoyadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }


        private void txtmesleksuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void dgwuyesec_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgwuyesec.RowCount != 0)
            {
                clsStatik.zTc = dgwuyesec.CurrentRow.Cells[0].Value.ToString();
                clsStatik.zAd = dgwuyesec.CurrentRow.Cells[1].Value.ToString();
                clsStatik.zSoyad = dgwuyesec.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
        }

    }
}

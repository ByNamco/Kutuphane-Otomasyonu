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
    public partial class frmCezaliSec : Form
    {
        public frmCezaliSec()
        {
            InitializeComponent();
        }
        private void suzme()
        {
            clsCezaliSec c = new clsCezaliSec();
            c.zId = txtidsuzme.Text;
            c.zTc = txttcsuzme.Text;
            dgwcezalisec.DataSource = c.suzme();
        }
        private void frmCezaliSec_Load(object sender, EventArgs e)
        {
            clsCezaliSec c = new clsCezaliSec();
            dgwcezalisec.DataSource = c.datagrdDoldur();

        }

        private void txtidsuzme_TextChanged(object sender, EventArgs e)
        {suzme();}

        private void txttcsuzme_TextChanged(object sender, EventArgs e)
        { suzme();}

        private void dgwcezalisec_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgwcezalisec.RowCount != 0)
            {
                clsStatik.zSebep = dgwcezalisec.CurrentRow.Cells[3].Value.ToString();
                clsStatik.zSonuc = dgwcezalisec.CurrentRow.Cells[6].Value.ToString();
                clsStatik.zId = dgwcezalisec.CurrentRow.Cells[0].Value.ToString();
                clsStatik.zBaslangic = dgwcezalisec.CurrentRow.Cells[4].Value.ToString();
                clsStatik.zBitis = dgwcezalisec.CurrentRow.Cells[5].Value.ToString();
                this.Close();
            }
        }
    }
}

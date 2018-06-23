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
    public partial class frmUyeIstatistik : Form
    {
        public frmUyeIstatistik()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void suzme()
        {
           
                clsUyeIstatistik u = new clsUyeIstatistik();
                u.zAd = txtadsuzme.Text;
                u.zMeslek = txtmesleksuzme.Text;
                u.zSoyad = txtsoyadsuzme.Text;
                u.zYil = cmbyil.Text;
                u.zTc = txttcsuzme.Text;
                dgwuyeistatistik.DataSource = u.suzme();
           
        }
        private void frmUyeIstatistik_Load(object sender, EventArgs e)
        {
            clsUyeIstatistik u = new clsUyeIstatistik();
            dgwuyeistatistik.DataSource = u.datagrdDoldur();
            cmbyil.DisplayMember = "tanim";
            cmbyil.ValueMember = "id";
            cmbyil.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_tarih order by tanim desc");
            cmbyil.Text = DateTime.Now.Year.ToString();
        }

        private void txttcsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtsoyadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtmesleksuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void cmbyil_SelectedIndexChanged(object sender, EventArgs e)
        { { suzme(); } }

    }
}

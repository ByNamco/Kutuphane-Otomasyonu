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
    public partial class frmKutuphaneIstatistik : Form
    {
        public frmKutuphaneIstatistik()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void suzme()
        {
            
                clsKutuphaneIstatistik k = new clsKutuphaneIstatistik();
                k.zAd = txtadsuzme.Text;
                k.zYil = cmbyil.Text;
                k.zTur = txttursuzme.Text;
                k.zKutuphaneno = txtknosuzme.Text;
                dgwkutuphaneistatistik.DataSource = k.suzme();
           
        }
        private void frmKutuphaneIstatistik_Load(object sender, EventArgs e)
        {
            clsKutuphaneIstatistik k = new clsKutuphaneIstatistik();
            dgwkutuphaneistatistik.DataSource = k.datagrdDoldur();
            cmbyil.DisplayMember = "tanim";
            cmbyil.ValueMember = "id";
            cmbyil.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_tarih order by tanim desc");
            cmbyil.Text = DateTime.Now.Year.ToString ();
        }

        private void txtknosuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txttursuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void cmbyil_SelectedIndexChanged(object sender, EventArgs e)
        { { suzme(); } }
    }
}

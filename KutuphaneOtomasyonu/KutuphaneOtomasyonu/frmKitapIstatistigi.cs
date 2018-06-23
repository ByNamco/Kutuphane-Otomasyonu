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
    public partial class frmKitapIstatistigi : Form
    {
        public frmKitapIstatistigi()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void frmKitapIstatistigi_Load(object sender, EventArgs e)
        {
            clsKitapIstatistik k = new clsKitapIstatistik();
            dgwkitapistatistik.DataSource = k.datagrdDoldur();
            cmbyil.DisplayMember = "tanim";
            cmbyil.ValueMember = "id";
            cmbyil.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_tarih order by tanim desc");
            cmbyil.Text = DateTime.Now.Year.ToString();
            cmbyil_SelectedIndexChanged(sender, e);
        }
        private void suzme()
        {
           
                clsKitapIstatistik k = new clsKitapIstatistik();
                k.zIsbn = txtisbnsuzme.Text;
                k.zAd = txtadsuzme.Text;
                k.zTur = txttursuzme.Text;
                k.zYazar = txtyazarsuzme.Text;
                k.zYil = cmbyil.Text;
                dgwkitapistatistik.DataSource = k.suzme();
            
        }

        private void txtisbnsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtyazarsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txttursuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void cmbyil_SelectedIndexChanged(object sender, EventArgs e)
        { { suzme(); } }
    }
}

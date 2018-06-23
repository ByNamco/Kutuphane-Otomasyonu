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
    public partial class frmKutuphaneIslem : Form
    {
        public frmKutuphaneIslem()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void ComboDoldur()
        {
            cmbil.DisplayMember = "il";
            cmbil.ValueMember = "id";
            cmbil.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_il order by il");
            cmbil.Text = "İl Seçiniz";

            cmbtur.DisplayMember = "tanim";
            cmbtur.ValueMember = "id";
            cmbtur.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_kutuphane_tur order by tanim");
            cmbtur.Text = "Tür Seçiniz";


        }
        public void ilcedoldur()
        {
            string sql = "Select * from tbl_ilce where il_id = #il_id order by ilce ";
            sql = sql.Replace("#il_id", cmbil.SelectedValue.ToString());
            cmbilce.DisplayMember = "ilce";
            cmbilce.ValueMember = "id";

            cmbilce.DataSource = da.ExecuteDataTable(sql);
        }
        public void semtdoldur()
        {
            string sql = "Select * from tbl_semt where ilce_id = #ilce_id order by semt ";
            sql = sql.Replace("#ilce_id", cmbilce.SelectedValue.ToString());
            cmbsemt.DisplayMember = "semt";
            cmbsemt.ValueMember = "id";

            cmbsemt.DataSource = da.ExecuteDataTable(sql);
        }
        public void datagrdDoldur()
        {
            clsKutuphaneIslem k = new clsKutuphaneIslem();
            dgwkutuphane.DataSource = k.datagrdDoldur();
        }
        private void id()
        {
            clsKutuphaneIslem a = new clsKutuphaneIslem();
            a.hazirid();
            txtkutuphaneno.Text = a.zDgr;

        }
        private void frmKutuphaneIslem_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            datagrdDoldur();
            id();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilcedoldur();
            cmbilce.Text = "İlçe Seçiniz";
        }

        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            semtdoldur();
            cmbsemt.Text = "Semt Seçiniz";
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtadres.Clear();
            txtadsuzme.Clear();
            txtemail.Clear();
            txtfax.Clear();
            txtilsuzme.Clear();
            txtknosuzme.Clear();
            txtkutuphaneno.Clear();
            txttel.Clear();
            txttursuzme.Clear();
            cmbil.Text = "İl Seçiniz";
            cmbilce.Text = "İlçe Seçiniz";
            cmbsemt.Text = "Semt Seçiniz";
            cmbtur.Text = "Tür Seçiniz";
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtkutuphaneno.Text.Length > 0 & txtad.Text.Length > 0 & cmbtur.Text!= "Tür Seçiniz" & cmbil.Text!= "İl Seçiniz" & cmbilce.Text!= "İlçe Seçiniz" & cmbsemt.Text!= "Semt Seçiniz")
            {
                clsKutuphaneIslem k = new clsKutuphaneIslem();
                k.zAd = txtad.Text;
                k.zAdres = txtadres.Text;
                k.zEmail = txtemail.Text;
                k.zFax = txtfax.Text;
                k.zIl = cmbil.Text;
                k.zIlce = cmbilce.Text;
                k.zKutuphaneno = txtkutuphaneno.Text;
                k.zSemt = cmbsemt.Text;
                k.zTel = txttel.Text;
                k.zTur = cmbtur.Text;
                k.kaydet();
                MessageBox.Show(k.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
                id();
            }
            else { MessageBox.Show("Gerekli Bilgileri Giriniz"); }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtkutuphaneno.Text.Length > 0 & txtad.Text.Length > 0 & cmbtur.Text != "Tür Seçiniz" & cmbil.Text != "İl Seçiniz" & cmbilce.Text != "İlçe Seçiniz" & cmbsemt.Text != "Semt Seçiniz")
            {
                clsKutuphaneIslem k = new clsKutuphaneIslem();
                k.zAd = txtad.Text;
                k.zAdres = txtadres.Text;
                k.zEmail = txtemail.Text;
                k.zFax = txtfax.Text;
                k.zIl = cmbil.Text;
                k.zIlce = cmbilce.Text;
                k.zKutuphaneno = txtkutuphaneno.Text;
                k.zSemt = cmbsemt.Text;
                k.zTel = txttel.Text;
                k.zTur = cmbtur.Text;
                k.guncelle();
                MessageBox.Show(k.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Kütüphane Nosunu Kontrol Edip Tekrar Deneyin"); }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtkutuphaneno.Text.Length > 0)
            {
                clsKutuphaneIslem k = new clsKutuphaneIslem();
                k.zKutuphaneno = txtkutuphaneno.Text;
                k.sil();
                MessageBox.Show(k.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Kütüphane Nosunu Kontrol Edip Tekrar Deneyin"); }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            if (txtkutuphaneno.Text.Length > 0)
            {
                clsKutuphaneIslem k = new clsKutuphaneIslem();
                k.zKutuphaneno = txtkutuphaneno.Text;
                k.bul();
                txtad.Text=k.zAd;
                txtadres.Text=k.zAdres;
                txtemail.Text=k.zEmail;
                txtfax.Text=k.zFax;
                cmbil.Text=k.zIl;
                cmbilce.Text= k.zIlce;
                cmbsemt.Text=k.zSemt;
                txttel.Text=k.zTel;
                cmbtur.Text=k.zTur;
                MessageBox.Show(k.zDgr);
            }
            else { MessageBox.Show("Kütüphane Nosunu Kontrol Edip Tekrar Deneyin"); }
        }

        private void dgwkutuphane_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgwkutuphane.RowCount != 0)
            {
                txtad.Text = dgwkutuphane.CurrentRow.Cells[1].Value.ToString();
                txtadres.Text = dgwkutuphane.CurrentRow.Cells[3].Value.ToString();
                txtemail.Text = dgwkutuphane.CurrentRow.Cells[9].Value.ToString();
                txtfax.Text = dgwkutuphane.CurrentRow.Cells[8].Value.ToString();
                txtkutuphaneno.Text = dgwkutuphane.CurrentRow.Cells[0].Value.ToString();
                txttel.Text = dgwkutuphane.CurrentRow.Cells[7].Value.ToString();
                cmbil.Text = dgwkutuphane.CurrentRow.Cells[4].Value.ToString();
                cmbilce.Text = dgwkutuphane.CurrentRow.Cells[5].Value.ToString();
                cmbsemt.Text = dgwkutuphane.CurrentRow.Cells[6].Value.ToString();
                cmbtur.Text = dgwkutuphane.CurrentRow.Cells[2].Value.ToString();
            }
        }
        private void suzme()
        {
            clsKutuphaneIslem k = new clsKutuphaneIslem();
            k.zAd = txtadsuzme.Text;
            k.zIl = txtilsuzme.Text;
            k.zKutuphaneno = txtknosuzme.Text;
            k.zTur = txttursuzme.Text;
            dgwkutuphane.DataSource = k.suzme();
        }

        private void txtknosuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txttursuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtilsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtkutuphaneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtfax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

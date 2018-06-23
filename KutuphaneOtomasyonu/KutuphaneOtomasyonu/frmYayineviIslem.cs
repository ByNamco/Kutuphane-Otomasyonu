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
    public partial class frmYayineviIslem : Form
    {
        public frmYayineviIslem()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
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
            clsYayineviIslem k = new clsYayineviIslem();
            dgwyayinevi.DataSource = k.datagrdDoldur();
        }
        private void id()
        {
            clsYayineviIslem a = new clsYayineviIslem();
            a.hazirid();
            txtyayinevino.Text = a.zDgr;

        }
        private void frmYayineviIslem_Load(object sender, EventArgs e)
        {
            cmbil.DisplayMember = "il";
            cmbil.ValueMember = "id";
            cmbil.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_il order by il");
            cmbil.Text = "İl Seçiniz";
            datagrdDoldur();
            id();
        }

        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            semtdoldur();
            cmbsemt.Text = "Semt Seçiniz";
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilcedoldur();
            cmbilce.Text = "İlçe Seçiniz";
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
            txtkodsuzme.Clear();
            txtyayinevino.Clear();
            txttel.Clear();
            cmbil.Text = "İl Seçiniz";
            cmbilce.Text = "İlçe Seçiniz";
            cmbsemt.Text = "Semt Seçiniz";
            id();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtyayinevino.Text.Length > 0 & txtad.Text.Length > 0 & cmbil.Text != "İl Seçiniz" & cmbilce.Text != "İlçe Seçiniz" & cmbsemt.Text != "Semt Seçiniz")
            {
                clsYayineviIslem k = new clsYayineviIslem();
                k.zAd = txtad.Text;
                k.zAdres = txtadres.Text;
                k.zEmail = txtemail.Text;
                k.zFax = txtfax.Text;
                k.zIl = cmbil.Text;
                k.zIlce = cmbilce.Text;
                k.zNo = txtyayinevino.Text;
                k.zSemt = cmbsemt.Text;
                k.zTel = txttel.Text;
                k.kaydet();
                MessageBox.Show(k.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Gerekli Bilgileri Giriniz"); }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtyayinevino.Text.Length > 0 & txtad.Text.Length > 0 & cmbil.Text != "İl Seçiniz" & cmbilce.Text != "İlçe Seçiniz" & cmbsemt.Text != "Semt Seçiniz")
            {
                clsYayineviIslem k = new clsYayineviIslem();
                k.zAd = txtad.Text;
                k.zAdres = txtadres.Text;
                k.zEmail = txtemail.Text;
                k.zFax = txtfax.Text;
                k.zIl = cmbil.Text;
                k.zIlce = cmbilce.Text;
                k.zNo = txtyayinevino.Text;
                k.zSemt = cmbsemt.Text;
                k.zTel = txttel.Text;
                k.guncelle();
                MessageBox.Show(k.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Yayınevi Nosunu Kontrol Edip Tekrar Deneyin"); }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtyayinevino.Text.Length > 0)
            {
                clsYayineviIslem k = new clsYayineviIslem();
                k.zNo = txtyayinevino.Text;
                k.sil();
                MessageBox.Show(k.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Yayınevi Nosunu Kontrol Edip Tekrar Deneyin"); }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            if (txtyayinevino.Text.Length > 0)
            {
                clsYayineviIslem k = new clsYayineviIslem();
                k.zNo = txtyayinevino.Text;
                k.bul();
                txtad.Text = k.zAd;
                txtadres.Text = k.zAdres;
                txtemail.Text = k.zEmail;
                txtfax.Text = k.zFax;
                cmbil.Text = k.zIl;
                cmbilce.Text = k.zIlce;
                cmbsemt.Text = k.zSemt;
                txttel.Text = k.zTel;
                MessageBox.Show(k.zDgr);
            }
            else { MessageBox.Show("Yayınevi Nosunu Kontrol Edip Tekrar Deneyin"); }
        }

        private void dgwyayinevi_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgwyayinevi.RowCount != 0)
            {
                txtad.Text = dgwyayinevi.CurrentRow.Cells[1].Value.ToString();
                txtadres.Text = dgwyayinevi.CurrentRow.Cells[2].Value.ToString();
                txtemail.Text = dgwyayinevi.CurrentRow.Cells[8].Value.ToString();
                txtfax.Text = dgwyayinevi.CurrentRow.Cells[7].Value.ToString();
                txtyayinevino.Text = dgwyayinevi.CurrentRow.Cells[0].Value.ToString();
                txttel.Text = dgwyayinevi.CurrentRow.Cells[6].Value.ToString();
                cmbil.Text = dgwyayinevi.CurrentRow.Cells[3].Value.ToString();
                cmbilce.Text = dgwyayinevi.CurrentRow.Cells[4].Value.ToString();
                cmbsemt.Text = dgwyayinevi.CurrentRow.Cells[5].Value.ToString();
            }
        }
        private void suzme()
        {
            clsYayineviIslem k = new clsYayineviIslem();
            k.zNo = txtkodsuzme.Text;
            k.zAd = txtadsuzme.Text;
            dgwyayinevi.DataSource = k.suzme();
        }

        private void txtkodsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtyayinevino_KeyPress(object sender, KeyPressEventArgs e)
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

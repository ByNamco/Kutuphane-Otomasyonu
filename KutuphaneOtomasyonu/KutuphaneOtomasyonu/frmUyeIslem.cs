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
    public partial class frmUyeIslem : Form
    {
        public frmUyeIslem()
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

            cmbmeslek.DisplayMember = "tanim";
            cmbmeslek.ValueMember = "id";
            cmbmeslek.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_meslek order by tanim");
            cmbmeslek.Text = "Meslek Seçiniz";


        }
        public void datagrdDoldur()
        {
            clsUyeIslem u = new clsUyeIslem();
            dgwuye.DataSource = u.datagrdDoldur();
        }
        private void frmUyeIslem_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            datagrdDoldur();
        }
        public void ilcedoldur()
        {
            string sql = "Select * from tbl_ilce where il_id = #il_id order by ilce ";
            sql = sql.Replace("#il_id", cmbil.SelectedValue.ToString());
            cmbilce.DisplayMember = "ilce";
            cmbilce.ValueMember = "id";
            cmbilce.DataSource = da.ExecuteDataTable(sql);
        }
        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilcedoldur();
            cmbilce.Text = "İlçe Seçiniz";
        }
        public void semtdoldur()
        {
            string sql = "Select * from tbl_semt where ilce_id = #ilce_id order by semt ";
            sql = sql.Replace("#ilce_id", cmbilce.SelectedValue.ToString());
            cmbsemt.DisplayMember = "semt";
            cmbsemt.ValueMember = "id";

            cmbsemt.DataSource = da.ExecuteDataTable(sql);
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
            txtceptel.Clear();
            txtemail.Clear();
            txtmesleksuzme.Clear();
            txtsoyad.Clear();
            txtsoyadsuzme.Clear();
            txttc.Clear();
            txttcsuzme.Clear();
            txttel.Clear();
            cmbil.Text = "İl Seçiniz";
            cmbilce.Text = "İlçe Seçiniz";
            cmbsemt.Text = "Semt Seçiniz";
            cmbmeslek.Text = "Meslek Seçiniz";
            cmbcinsiyet.Text = "Cinsiyet Seçiniz";
            dtpdogumtarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txttc.Text.Length == 11 & txtad.Text.Length > 0 & txtsoyad.Text.Length > 0 & cmbil.Text != "İl Seçiniz" & cmbilce.Text != "İlçe Seçiniz" & cmbsemt.Text != "Semt Seçiniz" & cmbmeslek.Text!= "Meslek Seçiniz" & cmbcinsiyet.Text!= "Cinsiyet Seçiniz")
            {
               clsUyeIslem u = new clsUyeIslem ();
                u.zAd = txtad .Text ;
                u.zAdres =txtadres .Text ;
                u.zCeptel =txtceptel .Text ;
                u.zCinsiyet = cmbcinsiyet .Text ;
                u.zDogumtarih =dtpdogumtarih .Text ;
                u.zEmail =txtemail .Text ;
                u.zIl =cmbil .Text ;
                u.zIlce =cmbilce .Text ;
                u.zMeslek =cmbmeslek .Text ;
                u.zSemt =cmbsemt .Text ;
                u.zSoyad =txtsoyad .Text ;
                u.zTc =txttc .Text ;
                u.zTel =txttel .Text ;
                u.kaydet();
                MessageBox.Show(u.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Gerekli Bilgileri Giriniz"); }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txttc.Text.Length == 11 & txtad.Text.Length > 0 & txtsoyad.Text.Length > 0 & cmbil.Text != "İl Seçiniz" & cmbilce.Text != "İlçe Seçiniz" & cmbsemt.Text != "Semt Seçiniz" & cmbmeslek.Text != "Meslek Seçiniz" & cmbcinsiyet.Text != "Cinsiyet Seçiniz")
            {
                clsUyeIslem u = new clsUyeIslem();
                u.zAd = txtad.Text;
                u.zAdres = txtadres.Text;
                u.zCeptel = txtceptel.Text;
                u.zCinsiyet = cmbcinsiyet.Text;
                u.zDogumtarih = dtpdogumtarih.Text;
                u.zEmail = txtemail.Text;
                u.zIl = cmbil.Text;
                u.zIlce = cmbilce.Text;
                u.zMeslek = cmbmeslek.Text;
                u.zSemt = cmbsemt.Text;
                u.zSoyad = txtsoyad.Text;
                u.zTc = txttc.Text;
                u.zTel = txttel.Text;
                u.guncelle();
                MessageBox.Show(u.zDgr);
                datagrdDoldur();
               
            }
            else { MessageBox.Show("Tc Numarasını Kontrol Edip Tekrar Deneyin"); }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txttc.Text.Length == 11)
            {
                clsUyeIslem u = new clsUyeIslem();
                u.zTc = txttc.Text;
                u.sil();
                MessageBox.Show(u.zDgr);
                btnyeni_Click(sender, e);
                datagrdDoldur();

            }
            else { MessageBox.Show("Tc Numarasını Kontrol Edip Tekrar Deneyin"); }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            if (txttc.Text.Length == 11)
            {
                clsUyeIslem u = new clsUyeIslem();
                u.zTc = txttc.Text;
                u.bul();
                txtad.Text=u.zAd ;
                txtadres.Text=u.zAdres;
                txtceptel.Text=u.zCeptel;
                cmbcinsiyet.Text=u.zCinsiyet;
                dtpdogumtarih.Text= u.zDogumtarih;
                txtemail.Text=u.zEmail;
                cmbil.Text=u.zIl;
                cmbilce.Text=u.zIlce;
                cmbmeslek.Text=u.zMeslek;
                cmbsemt.Text=u.zSemt;
                txtsoyad.Text=u.zSoyad;
                txttel.Text = u.zTel;
                MessageBox.Show(u.zDgr);
            }
            else { MessageBox.Show("Tc Numarasını Kontrol Edip Tekrar Deneyin"); }
        }

        private void dgwuye_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgwuye.RowCount != 0)
            {
                txtad.Text = dgwuye.CurrentRow.Cells[1].Value.ToString();
                txtadres.Text = dgwuye.CurrentRow.Cells[6].Value.ToString();
                txtceptel.Text = dgwuye.CurrentRow.Cells[11].Value.ToString();
                txtemail.Text = dgwuye.CurrentRow.Cells[12].Value.ToString();
                txtsoyad.Text = dgwuye.CurrentRow.Cells[2].Value.ToString();
                txttc.Text = dgwuye.CurrentRow.Cells[0].Value.ToString();
                txttel.Text = dgwuye.CurrentRow.Cells[10].Value.ToString();
                cmbil.Text = dgwuye.CurrentRow.Cells[7].Value.ToString();
                cmbilce.Text = dgwuye.CurrentRow.Cells[8].Value.ToString();
                cmbsemt.Text = dgwuye.CurrentRow.Cells[9].Value.ToString();
                cmbmeslek.Text = dgwuye.CurrentRow.Cells[4].Value.ToString();
                cmbcinsiyet.Text = dgwuye.CurrentRow.Cells[5].Value.ToString();
                dtpdogumtarih.Text = dgwuye.CurrentRow.Cells[3].Value.ToString();
            }
           
        }
        private void suzme()
        {
            clsUyeIslem u = new clsUyeIslem();
            u.zAd = txtadsuzme.Text;
            u.zMeslek = txtmesleksuzme.Text;
            u.zSoyad = txtsoyadsuzme.Text;
            u.zTc = txttcsuzme.Text;
            dgwuye.DataSource = u.suzme();
        }
        private void txttcsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtsoyadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtmesleksuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtceptel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

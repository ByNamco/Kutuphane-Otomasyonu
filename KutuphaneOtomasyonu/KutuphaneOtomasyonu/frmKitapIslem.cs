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
    public partial class frmKitapIslem : Form
    {
        public frmKitapIslem()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void btncikis_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
        private void ComboDoldur()
        {
            cmbdil.DisplayMember = "tanim";
            cmbdil.ValueMember = "id";
            cmbdil.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_dil order by tanim");
            cmbdil.Text = "Dil Seçiniz";

            cmbkonum.DisplayMember = "tanim";
            cmbkonum.ValueMember = "id";
            cmbkonum.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_kitap_yer order by tanim");
            cmbkonum.Text = "Kitabın Koyulacağı Yeri Seçiniz";

            cmbkutuphane.DisplayMember = "ad";
            cmbkutuphane.ValueMember = "kutuphane_no";
            cmbkutuphane.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_kutuphane order by ad");
            cmbkutuphane.Text = "Kütüphane Seçiniz";

            cmbteminsekli.DisplayMember = "tanim";
            cmbteminsekli.ValueMember = "id";
            cmbteminsekli.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_temin order by tanim");
            cmbteminsekli.Text = "Temin Şekli Seçiniz";

            cmbtur.DisplayMember = "tanim";
            cmbtur.ValueMember = "id";
            cmbtur.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_kitap_tur order by tanim");
            cmbtur.Text = "Kitap Tür Seçiniz";

            cmbyayinevi.DisplayMember = "ad";
            cmbyayinevi.ValueMember = "yayinevi_no";
            cmbyayinevi.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_yayinevi order by ad");
            cmbyayinevi.Text = "Yayınevi Seçiniz";

            cmbyazar.DisplayMember = "adsoyad";
            cmbyazar.ValueMember = "yazar_kod";
            cmbyazar.DataSource = da.ExecuteDataTable("SELECT ad+' '+soyad as adsoyad FROM tbl_yazar order by ad");
            cmbyazar.Text = "Yazar Seçiniz";
           
        }
        public void datagrdDoldur()
        {
            clsKitapIslem k = new clsKitapIslem();
            dgwkitap.DataSource = k.datagrdDoldur();
        }
        private void frmKitapEkle_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            datagrdDoldur();
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtbaskisayisi.Clear();
            txtisbnkod.Clear();
            txtkitapicerik.Clear();
            txtsayfasayisi.Clear();
            dtpbasimtarih.Text = DateTime.Now.ToShortDateString();
            cmbdil.Text = "Dil Seçiniz";
            cmbkonum.Text = "Kitabın Koyulacağı Yeri Seçiniz";
            cmbkutuphane.Text = "Kütüphane Seçiniz";
            cmbteminsekli.Text = "Temin Şekli Seçiniz";
            cmbtur.Text = "Kitap Tür Seçiniz";
            cmbyayinevi.Text = "Yayınevi Seçiniz";
            cmbyazar.Text = "Yazar Seçiniz";
            txtisbnsuzme.Clear();
            txtadsuzme.Clear();
            txtyazarsuzme.Clear();
            txttursuzme.Clear();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtisbnkod.Text.Length > 0 & txtad.Text.Length > 0 & cmbyazar.Text != "Yazar Seçiniz" & cmbtur.Text!= "Kitap Tür Seçiniz" & cmbdil.Text != "Dil Seçiniz" & cmbkutuphane.Text != "Kütüphane Seçiniz" & cmbyayinevi.Text != "Yayınevi Seçiniz" & cmbkonum.Text != "Kitabın Koyulacağı Yeri Seçiniz" & cmbteminsekli.Text!= "Temin Şekli Seçiniz")
            {
                clsKitapIslem k = new clsKitapIslem();
                k.zAd = txtad.Text;
                k.zBasimtarih = dtpbasimtarih.Text;
                k.zBaskisayisi = txtbaskisayisi.Text;
                k.zDil = cmbdil.Text;
                k.zIsbn = txtisbnkod.Text;
                k.zKitapicerik = txtkitapicerik.Text;
                k.zKitapyeri = cmbkonum.Text;
                k.zKutuphane = cmbkutuphane.Text;
                k.zSayfasayisi = txtsayfasayisi.Text;
                k.zTeminsekli = cmbteminsekli.Text;
                k.zTur = cmbtur.Text;
                k.zYayinevi = cmbyayinevi.Text;
                k.zYazar = cmbyazar.Text;
                k.kaydet();
                MessageBox.Show(k.zDgr);
                datagrdDoldur();
                isbngonder();
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Gerekli Bilgileri Giriniz"); }
            }
        private void isbngonder()
        {
            if (cmbteminsekli.Text == "Bağış")
            {
                frmBagisYapan frm = new frmBagisYapan();
                clsKitapIslem.zBagisisbn = txtisbnkod.Text;
                frm.ShowDialog();
            }
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtisbnkod.Text.Length > 0 & txtad.Text.Length > 0 & cmbyazar.Text != "Yazar Seçiniz" & cmbtur.Text != "Kitap Tür Seçiniz" & cmbdil.Text != "Dil Seçiniz" & cmbkutuphane.Text != "Kütüphane Seçiniz" & cmbyayinevi.Text != "Yayınevi Seçiniz" & cmbkonum.Text != "Kitabın Koyulacağı Yeri Seçiniz" & cmbteminsekli.Text != "Temin Şekli Seçiniz")
            {
                clsKitapIslem k = new clsKitapIslem();
                k.zAd = txtad.Text;
                k.zBasimtarih = dtpbasimtarih.Text;
                k.zBaskisayisi = txtbaskisayisi.Text;
                k.zDil = cmbdil.Text;
                k.zIsbn = txtisbnkod.Text;
                k.zKitapicerik = txtkitapicerik.Text;
                k.zKitapyeri = cmbkonum.Text;
                k.zKutuphane = cmbkutuphane.Text;
                k.zSayfasayisi = txtsayfasayisi.Text;
                k.zTeminsekli = cmbteminsekli.Text;
                k.zTur = cmbtur.Text;
                k.zYayinevi = cmbyayinevi.Text;
                k.zYazar = cmbyazar.Text;
                k.guncelle();
                MessageBox.Show(k.zDgr);
                isbngonder();
                btnyeni_Click(sender, e);
                datagrdDoldur();
                
            }
            else { MessageBox.Show("ISBN Kodunu Giriniz"); }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtisbnkod.Text.Length > 0)
            {
                clsKitapIslem k = new clsKitapIslem();
                k.zIsbn = txtisbnkod.Text;
                k.sil();
                MessageBox.Show(k.zDgr);
                btnyeni_Click(sender, e);
                datagrdDoldur();

            }
            else { MessageBox.Show("ISBN Kodunu Giriniz"); }
        }

        private void dgwkitap_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgwkitap.RowCount != 0)
            {
                txtisbnkod.Text = dgwkitap.CurrentRow.Cells[0].Value.ToString();
                txtad.Text = dgwkitap.CurrentRow.Cells[1].Value.ToString();
                cmbyazar.Text = dgwkitap.CurrentRow.Cells[2].Value.ToString();
                cmbyayinevi.Text = dgwkitap.CurrentRow.Cells[3].Value.ToString();
                txtsayfasayisi.Text = dgwkitap.CurrentRow.Cells[4].Value.ToString();
                cmbtur.Text = dgwkitap.CurrentRow.Cells[5].Value.ToString();
                cmbkutuphane.Text = dgwkitap.CurrentRow.Cells[6].Value.ToString();
                cmbkonum.Text = dgwkitap.CurrentRow.Cells[7].Value.ToString();
                dtpbasimtarih.Text = dgwkitap.CurrentRow.Cells[8].Value.ToString();
                txtbaskisayisi.Text = dgwkitap.CurrentRow.Cells[9].Value.ToString();
                cmbdil.Text = dgwkitap.CurrentRow.Cells[10].Value.ToString();
                cmbteminsekli.Text = dgwkitap.CurrentRow.Cells[12].Value.ToString();
                txtkitapicerik.Text = dgwkitap.CurrentRow.Cells[13].Value.ToString();
            }
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            if (txtisbnkod.Text.Length > 0)
            {
                clsKitapIslem k = new clsKitapIslem();
                k.zIsbn = txtisbnkod.Text;
                k.bul();
                txtad.Text = k.zAd;
                txtbaskisayisi.Text = k.zBaskisayisi;
                txtkitapicerik.Text = k.zKitapicerik;
                txtsayfasayisi.Text = k.zSayfasayisi;
                cmbdil.Text = k.zDil;
                cmbkonum.Text = k.zKitapyeri;
                cmbkutuphane.Text = k.zKutuphane;
                cmbteminsekli.Text = k.zTeminsekli;
                cmbtur.Text = k.zTur;
                cmbyayinevi.Text = k.zYayinevi;
                cmbyazar.Text = k.zYazar;
                MessageBox.Show(k.zDgr);
            }
            else { MessageBox.Show("ISBN Kodunu Giriniz"); }
        }
        private void suzme()
        {
            clsKitapIslem k = new clsKitapIslem();
            k.zIsbn = txtisbnsuzme.Text;
            k.zAd = txtadsuzme.Text;
            k.zTur = txttursuzme.Text;
            k.zYazar = txtyazarsuzme.Text;
            dgwkitap.DataSource = k.suzme();
        }

        private void txtisbnsuzme_TextChanged(object sender, EventArgs e)
        {{ suzme(); }}

        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        {{ suzme(); }}

        private void txtyazarsuzme_TextChanged(object sender, EventArgs e)
        {{ suzme(); }}

        private void txttursuzme_TextChanged(object sender, EventArgs e)
        {{ suzme(); }}

        private void txtisbnkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsayfasayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

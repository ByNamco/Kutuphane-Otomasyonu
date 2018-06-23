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
    public partial class frmPersonelIslem : Form
    {
        public frmPersonelIslem()
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
            cmbil.DisplayMember = "il";
            cmbil.ValueMember = "id";
            cmbil.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_il order by il");
            cmbil.Text = "İl Seçiniz";

            cmbdogumyer.DisplayMember = "il";
            cmbdogumyer.ValueMember = "id";
            cmbdogumyer.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_il order by il");
            cmbdogumyer.Text = "Doğum Yer Seçiniz";

            cmbogrenimdurum.DisplayMember = "tanim";
            cmbogrenimdurum.ValueMember = "id";
            cmbogrenimdurum.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_ogrenim order by tanim");
            cmbogrenimdurum.Text = "Öğrenim Durum Seçiniz";

            cmbgorev.DisplayMember = "tanim";
            cmbgorev.ValueMember = "id";
            cmbgorev.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_gorev order by tanim");
            cmbgorev.Text = "Görev Seçiniz";

            cmbkutuphane.DisplayMember = "ad";
            cmbkutuphane.ValueMember = "kutuphane_no";
            cmbkutuphane.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_kutuphane order by ad");
            cmbkutuphane.Text = "Kütüphane Seçiniz";

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
            clsPersonelIslem u = new clsPersonelIslem();
            dgwpersonel.DataSource = u.datagrdDoldur();
        }
        private void frmPersonelIslem_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            datagrdDoldur();
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

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtadres.Clear();
            txtadsuzme.Clear();
            txtceptel.Clear();
            txtemail.Clear();
            txtsoyad.Clear();
            txtsoyadsuzme.Clear();
            txttc.Clear();
            txttcsuzme.Clear();
            txttel.Clear();
            cmbcalismadurum.Text = "";
            cmbcalismadurumsuz.Text = "AKTİF";
            cmbcinsiyet.Text = "Cinsiyet Seçiniz";
            cmbdogumyer.Text = "Doğum Yer Seçiniz";
            cmbgorev.Text = "Görev Seçiniz";
            cmbil.Text = "İl Seçiniz";
            cmbilce.Text = "İlçe Seçiniz";
            cmbkutuphane.Text = "Kütüphane Seçiniz";
            cmbogrenimdurum.Text = "Öğrenim Durum Seçiniz";
            cmbsemt.Text = "Semt Seçiniz";
            dtpdogumtarih.Text = DateTime.Now.ToShortDateString();
            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txttc.Text.Length == 11 & txtad.Text.Length > 0 & txtsoyad.Text.Length > 0 & cmbgorev.Text != "Görev Seçiniz" & cmbkutuphane.Text != "Kütüphane Seçiniz" & cmbil.Text != "İl Seçiniz" & cmbilce.Text != "İlçe Seçiniz" & cmbsemt.Text != "Semt Seçiniz" & cmbogrenimdurum.Text != "Öğrenim Durum Seçiniz" & cmbcinsiyet.Text != "Cinsiyet Seçiniz" & cmbdogumyer.Text != "Doğum Yeri Seçiniz" & cmbcalismadurum.Text != "Çalışma Durum Seçiniz")
            {
                clsPersonelIslem u = new clsPersonelIslem();
                u.zAd = txtad.Text;
                u.zAdres = txtadres.Text;
                u.zCeptel = txtceptel.Text;
                u.zCinsiyet = cmbcinsiyet.Text;
                u.zDogumtarih = dtpdogumtarih.Text;
                u.zEmail = txtemail.Text;
                u.zIl = cmbil.Text;
                u.zIlce = cmbilce.Text;
                u.zSemt = cmbsemt.Text;
                u.zSoyad = txtsoyad.Text;
                u.zTc = txttc.Text;
                u.zTel = txttel.Text;
                u.zDogumyer = cmbdogumyer.Text;
                u.zOgrenimdurum = cmbogrenimdurum.Text;
                u.zCalismadurum = cmbcalismadurum.Text;
                u.zGorev = cmbgorev.Text;
                u.zKutuphane = cmbkutuphane.Text;
                u.kaydet();
                MessageBox.Show(u.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Gerekli Bilgileri Giriniz"); }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txttc.Text.Length == 11 & txtad.Text.Length > 0 & txtsoyad.Text.Length > 0 & cmbgorev.Text != "Görev Seçiniz" & cmbkutuphane.Text != "Kütüphane Seçiniz" & cmbil.Text != "İl Seçiniz" & cmbilce.Text != "İlçe Seçiniz" & cmbsemt.Text != "Semt Seçiniz" & cmbogrenimdurum.Text != "Öğrenim Durum Seçiniz" & cmbcinsiyet.Text != "Cinsiyet Seçiniz" & cmbdogumyer.Text != "Doğum Yeri Seçiniz" & cmbcalismadurum.Text != "Çalışma Durum Seçiniz")
            {
                clsPersonelIslem u = new clsPersonelIslem();
                u.zAd = txtad.Text;
                u.zAdres = txtadres.Text;
                u.zCeptel = txtceptel.Text;
                u.zCinsiyet = cmbcinsiyet.Text;
                u.zDogumtarih = dtpdogumtarih.Text;
                u.zEmail = txtemail.Text;
                u.zIl = cmbil.Text;
                u.zIlce = cmbilce.Text;
                u.zSemt = cmbsemt.Text;
                u.zSoyad = txtsoyad.Text;
                u.zTc = txttc.Text;
                u.zTel = txttel.Text;
                u.zDogumyer = cmbdogumyer.Text;
                u.zOgrenimdurum = cmbogrenimdurum.Text;
                u.zCalismadurum = cmbcalismadurum.Text;
                u.zGorev = cmbgorev.Text;
                u.zKutuphane = cmbkutuphane.Text;
                u.guncelle();
                MessageBox.Show(u.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);

            }
            else { MessageBox.Show("Tc Numarasını Kontrol Edip Tekrar Deneyin"); }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txttc.Text.Length == 11)
            {
                clsPersonelIslem u = new clsPersonelIslem();
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
                clsPersonelIslem u = new clsPersonelIslem();
                u.zTc = txttc.Text;
                u.bul();
                txtad.Text = u.zAd;
                txtadres.Text = u.zAdres;
                txtceptel.Text = u.zCeptel;
                cmbcinsiyet.Text = u.zCinsiyet;
                dtpdogumtarih.Text = u.zDogumtarih;
                txtemail.Text = u.zEmail;
                cmbil.Text = u.zIl;
                cmbilce.Text = u.zIlce;
                cmbsemt.Text = u.zSemt;
                txtsoyad.Text = u.zSoyad;
                txttel.Text = u.zTel;
                cmbdogumyer.Text=u.zDogumyer;
                cmbogrenimdurum.Text=u.zOgrenimdurum;
                cmbcalismadurum.Text=u.zCalismadurum;
                cmbgorev.Text=u.zGorev ;
                cmbkutuphane.Text=u.zKutuphane;
                MessageBox.Show(u.zDgr);
            }
            else { MessageBox.Show("Tc Numarasını Kontrol Edip Tekrar Deneyin"); }
        }

        private void dgwpersonel_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgwpersonel.RowCount != 0)
            {
                txtad.Text = dgwpersonel.CurrentRow.Cells[1].Value.ToString();
                txtadres.Text = dgwpersonel.CurrentRow.Cells[6].Value.ToString();
                txtceptel.Text = dgwpersonel.CurrentRow.Cells[11].Value.ToString();
                txtemail.Text = dgwpersonel.CurrentRow.Cells[16].Value.ToString();
                txtsoyad.Text = dgwpersonel.CurrentRow.Cells[2].Value.ToString();
                txttc.Text = dgwpersonel.CurrentRow.Cells[0].Value.ToString();
                txttel.Text = dgwpersonel.CurrentRow.Cells[10].Value.ToString();
                cmbil.Text = dgwpersonel.CurrentRow.Cells[7].Value.ToString();
                cmbilce.Text = dgwpersonel.CurrentRow.Cells[8].Value.ToString();
                cmbsemt.Text = dgwpersonel.CurrentRow.Cells[9].Value.ToString();
                cmbcinsiyet.Text = dgwpersonel.CurrentRow.Cells[5].Value.ToString();
                dtpdogumtarih.Text = dgwpersonel.CurrentRow.Cells[4].Value.ToString();
                cmbdogumyer.Text = dgwpersonel.CurrentRow.Cells[3].Value.ToString();
                cmbogrenimdurum.Text = dgwpersonel.CurrentRow.Cells[12].Value.ToString();
                cmbcalismadurum.Text = dgwpersonel.CurrentRow.Cells[13].Value.ToString();
                cmbgorev.Text = dgwpersonel.CurrentRow.Cells[14].Value.ToString();
                cmbkutuphane.Text = dgwpersonel.CurrentRow.Cells[15].Value.ToString();
            }
        }
        private void suzme()
        {
            clsPersonelIslem u = new clsPersonelIslem();
            u.zAd = txtadsuzme.Text;
            u.zCalismadurum = cmbcalismadurumsuz.Text;
            u.zSoyad = txtsoyadsuzme.Text;
            u.zTc = txttcsuzme.Text;
            dgwpersonel.DataSource = u.suzme();
        }

        private void txttcsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txtadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txtsoyadsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void cmbcalismadurumsuz_SelectedIndexChanged(object sender, EventArgs e)
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

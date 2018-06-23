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
    public partial class frmKitapVermeIslem : Form
    {
        public frmKitapVermeIslem()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void btnkitapsec_Click(object sender, EventArgs e)
        {
          
            frmKitapSec frm = new frmKitapSec();
            frm.ShowDialog();

            txtisbnkod.Text = clsStatik.zIsbn;
            txtkad.Text = clsStatik.zKad;
            txttur.Text = clsStatik.zTur;
            txtyazar.Text = clsStatik.zYazar;


            if (txtisbnkod.Text.Length > 0)
            {
                txtisbnkod.Enabled = true;
                txtkad.Enabled = true;
                txttur.Enabled = true;
                txtyazar.Enabled = true;
            
            }
        }

        private void btnuyesec_Click(object sender, EventArgs e)
        {
            frmUyeSec frm = new frmUyeSec();
            frm.ShowDialog();

            txttc.Text  = clsStatik.zTc;
            txtad.Text = clsStatik.zAd;
            txtsoyad.Text = clsStatik.zSoyad;


            if (txttc.Text.Length > 0)
            {
                txttc.Enabled = true;
                txtad.Enabled = true;
                txtsoyad.Enabled = true;
            }
        }
        private void id()
        {
            clsKitapVermeIslem k = new clsKitapVermeIslem();
            k.hazirid();
            txtemanetno.Text  = k.zDgr;
        }
        public void datagrdDoldur()
        {
            clsKitapVermeIslem k = new clsKitapVermeIslem();
            dgwkitapverme.DataSource = k.datagrdDoldur();
        }
        private void frmKitapVermeIslem_Load(object sender, EventArgs e)
        {
            datagrdDoldur();
            cmbkutuphane.DisplayMember = "ad";
            cmbkutuphane.ValueMember = "kutuphane_no";
            cmbkutuphane.DataSource = da.ExecuteDataTable("SELECT * FROM tbl_kutuphane order by ad");
            cmbkutuphane.Text = "Kütüphane Seçiniz";
            id();
            rbiedilmeyen.Checked = false;
            rbiedilen.Checked = false;
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtemanetno.Clear();
            txtisbnkod.Clear();
            txtisbnsuzme.Clear();
            txtkad.Clear();
            txtnosuzme.Clear();
            txtsoyad.Clear();
            txttc.Clear();
            txttcsuzme.Clear();
            txttur.Clear();
            txtyazar.Clear();
            cmbkutuphane.Text = "Kütüphane Seçiniz";
            cmbpersonel.Text = "Personel Seçiniz";
            dtpalinacak.Text = DateTime.Now.ToShortDateString();
            dtpverilis  .Text =DateTime.Now.ToShortDateString();
            txtisbnkod.Enabled = false;
            txtkad.Enabled = false;
            txttur.Enabled = false;
            txtyazar.Enabled = false;
            txttc.Enabled = false;
            txtad.Enabled = false;
            txtsoyad.Enabled = false;
            id();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtemanetno.Text.Length > 0 && txttc .Text .Length > 0 && txtisbnkod .Text .Length > 0 && cmbkutuphane.Text != "Kütüphane Seçiniz" && cmbpersonel.Text != "Personel Seçiniz")
            {
                if (Convert.ToDateTime(dtpalinacak.Text) >= DateTime.Now)
                {

                    clsKitapVermeIslem k = new clsKitapVermeIslem();
                    k.zAlinacak = dtpalinacak.Text;
                    k.zIsbn = txtisbnkod.Text;
                    k.zKutuphane = cmbkutuphane.Text;
                    k.zNo = txtemanetno.Text;
                    k.zPersonel = cmbpersonel.Text;
                    k.zTc = txttc.Text;
                    k.zVerilis = dtpverilis.Text;
                    k.emanetver();
                    MessageBox.Show(k.zDgr);
                    datagrdDoldur();
                    btnyeni_Click(sender, e);
                }
                else { MessageBox.Show("Kitabın Alınacağı Tarih Geçmiş Zaman Olamaz.."); }
            }
            else { MessageBox.Show("Gerekli Bilgileri Giriniz"); }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtemanetno.Text.Length > 0 && txttc.Text.Length > 0 && txtisbnkod.Text.Length > 0 && cmbkutuphane.Text != "Kütüphane Seçiniz" && cmbpersonel.Text != "Personel Seçiniz")
            {
                if (Convert.ToDateTime(dtpalinacak.Text) >= DateTime.Now)
                {
                    clsKitapVermeIslem k = new clsKitapVermeIslem();
                k.zAlinacak = dtpalinacak.Text;
                k.zIsbn = txtisbnkod.Text;
                k.zKutuphane = cmbkutuphane.Text;
                k.zNo = txtemanetno.Text;
                k.zPersonel = cmbpersonel.Text;
                k.zTc = txttc.Text;
                k.zVerilis = dtpverilis.Text;
                k.guncelle();
                MessageBox.Show(k.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);
                }
                else { MessageBox.Show("Kitabın Alınacağı Tarih Geçmiş Zaman Olamaz.."); }
            }
            else { MessageBox.Show("Gerekli Bilgileri Giriniz"); }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
           
            if (txtemanetno.Text.Length > 0)
            {
                clsKitapVermeIslem k = new clsKitapVermeIslem();
                k.zNo = txtemanetno.Text;
                k.sil();
                MessageBox.Show(k.zDgr);
                btnyeni_Click(sender, e);
                datagrdDoldur();

            }
            else { MessageBox.Show("Emanet Nosunu Giriniz"); }
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            

            this.Close();

           
        }

        private void dgwkitapverme_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgwkitapverme.RowCount != 0)
            {
                txtemanetno.Text = dgwkitapverme.CurrentRow.Cells[0].Value.ToString();
                txttc.Text = dgwkitapverme.CurrentRow.Cells[1].Value.ToString();
                string sql = @"select ad,soyad from tbl_uye where tc=#tc";
                sql = sql.Replace("#tc", txttc.Text);
                DataTable dt = new DataTable();
                dt = da.ExecuteDataTable(sql);
                txtad.Text = dt.Rows[0][0].ToString();
                txtsoyad.Text = dt.Rows[0][1].ToString();
                dtpverilis.Text = dgwkitapverme.CurrentRow.Cells[2].Value.ToString();
                dtpalinacak.Text = dgwkitapverme.CurrentRow.Cells[3].Value.ToString();
                txtisbnkod.Text = dgwkitapverme.CurrentRow.Cells[5].Value.ToString();
                sql = @"select ad,yazar,tur from tbl_kitap where ISBN_kod=#isbn";
                sql = sql.Replace("#isbn", "'" + txtisbnkod.Text + "'");
                dt = da.ExecuteDataTable(sql);
                txtkad.Text = dt.Rows[0][0].ToString();
                txtyazar.Text = dt.Rows[0][1].ToString();
                txttur.Text = dt.Rows[0][2].ToString();
                cmbkutuphane.Text = dgwkitapverme.CurrentRow.Cells[6].Value.ToString();
                cmbpersonel.Text = dgwkitapverme.CurrentRow.Cells[7].Value.ToString();
                txtisbnkod.Enabled = true;
                txtkad.Enabled = true;
                txttur.Enabled = true;
                txtyazar.Enabled = true;
                txttc.Enabled = true;
                txtad.Enabled = true;
                txtsoyad.Enabled = true;
            }
        }

        private void suzme()
        {
            clsKitapVermeIslem k = new clsKitapVermeIslem();
            k.zNo = txtnosuzme.Text;
            k.zIsbn = txtisbnsuzme.Text;
            k.zTc = txttcsuzme.Text;
            if (rbiedilen.Checked == true)
            {
                dgwkitapverme.DataSource = k.iedilensuzme();
            }
            else if (rbiedilmeyen.Checked == true)
            {
                dgwkitapverme.DataSource = k.iedilmeyensuzme();
            }
            else

            {
                dgwkitapverme.DataSource = k.suzme();
            }
        
        }

        private void txtnosuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void txtisbnsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txttcsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void rbiedilen_CheckedChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void rbiedilmeyen_CheckedChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void cmbkutuphane_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT     tbl_personel.tc, tbl_personel.ad+' '+ tbl_personel.soyad as AdSoyad FROM         tbl_kutuphane INNER JOIN tbl_personel ON tbl_kutuphane.ad = tbl_personel.kutuphane WHERE     (tbl_personel.kutuphane ='#kutuphane')";
            sql = sql.Replace("#kutuphane", cmbkutuphane .Text );
            cmbpersonel.DisplayMember = "AdSoyad";
            cmbpersonel.ValueMember = "tc";
            cmbpersonel.DataSource = da.ExecuteDataTable(sql);
            cmbpersonel.Text = "Personel Seçiniz";
        }

        private void txtemanetno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

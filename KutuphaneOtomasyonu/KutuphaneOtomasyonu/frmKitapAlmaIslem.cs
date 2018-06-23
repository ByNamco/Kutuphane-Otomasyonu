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
    public partial class frmKitapAlmaIslem : Form
    {
        public frmKitapAlmaIslem()
        {
            InitializeComponent();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void btnyeni_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtemanetno.Text = "";
            txtisbnkod.Text = "";
            txtisbnsuzme.Text = "";
            txtkad.Text = "";
            txtnosuzme.Text = "";
            txtsoyad.Text = "";
            txttc.Text = "";
            txttcsuzme.Text = "";
            txttur.Text = "";
            txtyazar.Text = "";
            cmbkutuphane.Text = "";
            cmbpersonel.Text = "";
            dtpalinacak.Text = "";
            dtpverilis.Text = "";
            txtid.Text = "";
            txtsonuc.Text = "";
            txtsebep.Text = "";
            dtpbitis.Text = DateTime.Now.ToShortDateString();
            dtpbaslangic.Text = DateTime.Now.ToShortDateString();
            dtpiade.Text = DateTime.Now.ToShortDateString();
        }
        public void datagrdDoldur()
        {
            clsKitapAlmaIslem k = new clsKitapAlmaIslem();
            dgwkitapalma.DataSource = k.datagrdDoldur();
        }
        private void frmKitapAlmaIslem_Load(object sender, EventArgs e)
        {
            datagrdDoldur();
        }

        private void dgwkitapalma_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgwkitapalma.RowCount != 0)
            {

                txtemanetno.Text = dgwkitapalma.CurrentRow.Cells[0].Value.ToString();
                txttc.Text = dgwkitapalma.CurrentRow.Cells[1].Value.ToString();
                string sql = @"select ad,soyad from tbl_uye where tc=#tc";
                sql = sql.Replace("#tc", txttc.Text);
                DataTable dt = new DataTable();
                dt = da.ExecuteDataTable(sql);
                txtad.Text = dt.Rows[0][0].ToString();
                txtsoyad.Text = dt.Rows[0][1].ToString();
                dtpverilis.Text = dgwkitapalma.CurrentRow.Cells[2].Value.ToString();
                dtpalinacak.Text = dgwkitapalma.CurrentRow.Cells[3].Value.ToString();
                txtisbnkod.Text = dgwkitapalma.CurrentRow.Cells[5].Value.ToString();
                sql = @"select ad,yazar,tur from tbl_kitap where ISBN_kod=#isbn";
                sql = sql.Replace("#isbn", "'" + txtisbnkod.Text + "'");
                dt = da.ExecuteDataTable(sql);
                txtkad.Text = dt.Rows[0][0].ToString();
                txtyazar.Text = dt.Rows[0][1].ToString();
                txttur.Text = dt.Rows[0][2].ToString();
                cmbkutuphane.Text = dgwkitapalma.CurrentRow.Cells[6].Value.ToString();
                cmbpersonel.Text = dgwkitapalma.CurrentRow.Cells[7].Value.ToString();
            }
        }
        private void suzme()
        {
            clsKitapAlmaIslem k = new clsKitapAlmaIslem();
            k.zNo = txtnosuzme.Text;
            k.zIsbn = txtisbnsuzme.Text;
            k.zTc = txttcsuzme.Text;
            dgwkitapalma.DataSource = k.suzme();

        }

        private void txtnosuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txtisbnsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }
        private void txttcsuzme_TextChanged(object sender, EventArgs e)
        { { suzme(); } }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtemanetno.Text.Length  > 0)
            {
                clsKitapAlmaIslem k = new clsKitapAlmaIslem();
                if (txtsebep.Text.Length > 0)
                {
                    k.zCezaid = txtid.Text;
                    k.zKutuphane = cmbkutuphane.Text;
                    k.zCezasebep = txtsebep.Text;
                    k.zCezasonuc = txtsonuc.Text;
                    k.zTc = txttc.Text;
                    k.zCezabaslangic = dtpbaslangic.Text;
                    k.zCezabitis = dtpbitis.Text;
                    k.cezakayit();
                }
                k.zNo = txtemanetno.Text;
                k.zTc = txttc.Text;
                k.zIsbn = txtisbnkod.Text;
                k.zIade = dtpiade.Text;
                k.emanetal();
                MessageBox.Show(k.zDgr);
                datagrdDoldur();
                btnyeni_Click(sender, e);

            }
            else { MessageBox.Show("Bilgileri Kontrol Ediniz"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpalinacak.Text.Length > 0)
            {
                int iadegun = int.Parse(dtpiade.Text.Substring(0, 2));
                int alinacakay = int.Parse(dtpalinacak.Text.Substring(3, 2));
                int iadeay = int.Parse(dtpiade.Text.Substring(3, 2));
                int alinacakgun = int.Parse(dtpalinacak.Text.Substring(0, 2));
                if (iadeay > alinacakay)
                {
                    int gecay = iadeay - alinacakay;
                    txtsebep.Text = gecay + " ay Geç İade";
                    txtsebep.ForeColor = Color.Red;
                }
                else if (iadegun > alinacakgun)
                {
                    int gecgun = iadegun - alinacakgun;
                    txtsebep.Text = gecgun + " Gün Geç İade";
                    txtsebep.ForeColor = Color.Red;
                }
            }
            else { MessageBox.Show("Bilgileri Kontrol Ediniz"); }
        }

        private void txtemanetno_TextChanged(object sender, EventArgs e)
        {
            txtid.Text = txtemanetno.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 0)
            {
                clsKitapAlmaIslem k = new clsKitapAlmaIslem();
                k.zCezaid = txtid.Text;
                k.cezabitir();
                MessageBox.Show(k.zDgr);
                btnyeni_Click(sender, e);
            }
            else { MessageBox.Show("Gerekli Bilgileri Giriniz"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCezaliSec frm = new frmCezaliSec();
            frm.ShowDialog();
            txtsebep.Text = clsStatik.zSebep;
            txtsonuc.Text = clsStatik.zSonuc;
            txtid.Text = clsStatik.zId;
            dtpbaslangic.Text = clsStatik.zBaslangic;
            dtpbitis.Text = clsStatik.zBitis;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Length > 0)
            {
                clsKitapAlmaIslem k = new clsKitapAlmaIslem();
                k.zCezaid = txtid.Text;
                k.zCezasebep = txtsebep.Text;
                k.zCezasonuc = txtsonuc.Text;
                k.zCezabaslangic = dtpbaslangic.Text;
                k.zCezabitis = dtpbitis.Text;
                k.cezaguncelle();
                MessageBox.Show(k.zDgr);
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemanetno_TextChanged_1(object sender, EventArgs e)
        {
            txtid.Text = txtemanetno.Text;
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            if (txtemanetno.Text.Length > 0)
            {
               clsKitapAlmaIslem k = new clsKitapAlmaIslem();
               k.zNo = txtemanetno.Text;
               k.bul();
               txttc .Text = k.zTc;
               txtad.Text = k.zUad;
               txtsoyad.Text = k.zUsoyad;
               dtpverilis.Text = k.zVerilis;
               dtpalinacak.Text = k.zAlinacak;
               txtisbnkod.Text = k.zIsbn;
               txtkad.Text = k.zKad;
               txtyazar.Text = k.zYazarr;
               txttur.Text = k.zTurr;
               cmbkutuphane.Text = k.zKutuphane;
               cmbpersonel.Text = k.zPersonel;
               MessageBox.Show(k.zDgr);
            }
            else { MessageBox.Show("Emanet Nosunu Giriniz"); }
        }

        private void txtemanetno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

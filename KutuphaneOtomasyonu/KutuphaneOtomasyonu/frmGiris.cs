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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }       
        private string cevap = "[]";
        private void linkSifremiunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DataTable dt = da.ExecuteDataTable("Select soru,soru_cevap from tbl_giris where kullanici_ad='" + txtKullaniciAd.Text + "'");
            if (dt == null)
            {
                MessageBox.Show("Kullanıcı yanlış.");
                return;
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı yanlış.");
                return;
            }
            else
            {
                if (btnyenile.Visible)
                {
                    panelSifremiUnuttum.Location = new Point(0, 0);
                    panelSifremiUnuttum.Visible = true;
                    btnyenile.Visible = false;
                    Size = new Size(275, 200);
                }
                labelSoru.Text = dt.Rows[0][0].ToString();
                cevap = dt.Rows[0][1].ToString();
            }
        }

        private void KodDegistir()
        {
            Random rd = new Random();
            labelKod.Text = rd.Next(0, 9).ToString() + rd.Next(0, 9).ToString() + rd.Next(0, 9).ToString() + rd.Next(0, 9).ToString();
            labelKod.ForeColor  = System.Drawing.Color.FromArgb(((int)(((byte)(rd.Next (0, 255))))), ((int)(((byte)(rd.Next(0, 255))))), ((int)(((byte)(rd.Next(0, 255))))));
          
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            KodDegistir();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void cmdTamam_Click(object sender, EventArgs e)
        {
            if (txtKod.Text== "" || labelKod.Text == "")
            {
                MessageBox.Show("Kod Yanlış...");
                KodDegistir();
                txtKod.Text = "";
                return;
            }
            if (int.Parse(txtKod.Text) != int.Parse(labelKod.Text))
            {
                MessageBox.Show("Kod Yanlış...");
                KodDegistir();
                txtKod.Text = "";
                return;
            }
            DataTable dt = da.ExecuteDataTable("Select kullanici_ad,kullanici_parola,tur from tbl_giris where kullanici_ad='" + txtKullaniciAd.Text + "' and kullanici_parola='" + txtKullaniciParola.Text + "'");
            if (dt == null)
            {
                MessageBox.Show("Kullanıcı Ad Veya Parola Yanlış...");
                KodDegistir();
                txtKod.Text = "";            
                return;
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı Ad Veya Parola Yanlış...");
                KodDegistir();
                txtKod.Text = "";      
                return;
            }
            else
            {
                this.Hide();
                frmAnasayfa anasayfa = new frmAnasayfa();
                anasayfa.Tag = txtKullaniciAd.Text + "|" + dt.Rows[0][2].ToString();
                anasayfa.ShowDialog();
                this.Show();
                txtKullaniciAd.Clear();
                txtKullaniciParola.Clear();
                txtKod .Clear ();
            }
            KodDegistir();
        }

        private void cmdSifremiunuttumCikis_Click(object sender, EventArgs e)
        {
            Size = new Size(275, 225);
            btnyenile.Visible = true;
            panelSifremiUnuttum.Visible = false;
            txtCevap.Clear();
            txtSifre.Clear();
            txtSifreTekrar.Clear();
        }

        private void cmdSifremiUnuttumTamam_Click(object sender, EventArgs e)
        {
            if (cevap == txtCevap.Text)
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler uyuşmuyor.");
                    return;
                }
                da.Execute("Update tbl_giris SET kullanici_parola='" + txtSifre.Text + "' where kullanici_ad='" + txtKullaniciAd.Text + "'");
                MessageBox.Show("Şifre Değiştirildi");
                Size = new Size(275, 225);
                btnyenile.Visible = true;
                panelSifremiUnuttum.Visible = false;
            }
            else
            {
                MessageBox.Show("Cevap yanlış.");
                return;
            }
        }

        private void cmdCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkSifreDegistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            DataTable dt = da.ExecuteDataTable("Select kullanici_ad,kullanici_parola,soru,soru_cevap from tbl_giris where kullanici_ad='" + txtKullaniciAd.Text + "' and kullanici_parola='" + txtKullaniciParola.Text + "'");
            if (dt == null)
            {
                MessageBox.Show("Kullanıcı ad veya parola yanlış.");
                KodDegistir();
                txtKod.Text = "";            
                return;
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı ad veya parola yanlış.");
                KodDegistir();
                txtKod.Text = "";      
                return;
            }
            else
            {
                Size = new Size(275, 240);
                btnyenile.Visible = false;
                panelSifreDegistir.Visible = true;
                panelSifreDegistir.Location = new Point(0, 0);
                txtSifreDegistirCevap.Text = dt.Rows[0][3].ToString();
                txtSifreDegistirKullaniciAd.Text = txtKullaniciAd.Text;
                txtSifreDegistirSifre.Text = txtKullaniciParola.Text;
                txtSifreDegistirSifreTekrar.Text = txtKullaniciParola.Text;
                txtSifreDegistirSoru.Text = dt.Rows[0][2].ToString();
            }
        }

        private void cmdSifreDegistirTamam_Click(object sender, EventArgs e)
        {
            if (txtSifreDegistirKullaniciAd .Text =="" || txtSifreDegistirCevap .Text =="" || txtSifreDegistirSifre .Text =="" || txtSifreDegistirSoru .Text =="" || txtSifreDegistirSifreTekrar .Text=="")
            {
                MessageBox.Show("Boşlukları doldurunuz.");
                return;
            }
            if (txtSifreDegistirSifreTekrar.Text != txtSifreDegistirSifre.Text)
            {
                MessageBox.Show("Uyuşmuyor.");
                return;
            }
            da.Execute("Update tbl_giris set kullanici_ad='" + txtSifreDegistirKullaniciAd.Text + "',kullanici_parola='" + txtSifreDegistirSifre.Text + "',soru='" + txtSifreDegistirSoru.Text + "',soru_cevap='" + txtSifreDegistirCevap.Text + "' where kullanici_ad='" + txtKullaniciAd.Text + "'");
            MessageBox.Show("Gerekli Bilgiler Güncellendi");
            cmdSifreDegistirCikis_Click(sender, e);
        }

        private void cmdSifreDegistirCikis_Click(object sender, EventArgs e)
        {
            Size = new Size(275, 225);
            btnyenile.Visible = true;
            panelSifreDegistir.Visible = false;
            txtSifreDegistirKullaniciAd.Clear ();
            txtSifreDegistirCevap.Clear ();
            txtSifreDegistirSifre.Clear ();
            txtSifreDegistirSoru .Clear ();
            txtSifreDegistirSifreTekrar.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KodDegistir();
        }

        private void txtKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}


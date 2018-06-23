using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace KutuphaneOtomasyonu
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            if (Tag != null)
            {
                string[] veri =Tag.ToString().Split("|".ToCharArray());
                toolStripStatusLabel1.Text = veri[0];
                if (veri[1] == "ADMİN")
                {
                    btnyenikullanici.Enabled = true;
                }
                else
                {
                    btnyenikullanici.Enabled = false;
                }
            }
            lbybaslik.Text = "   KÜTÜPHANE   OTOMASYONU  -------";
            baslik.Interval = 250;
            baslik.Enabled = !baslik.Enabled;
            saattarih.Start();
            kitapsayisi();
            uyesayisi();
            Kontrol();
            iadeGecenMail();
            iadeYaklasanMail();




            }
        private void iadeGecenMail()
        {
            clsEmanetTeslimHatirlatma hatirlatma = new clsEmanetTeslimHatirlatma();
            DataTable dt = hatirlatma.datagrdDoldur();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Gonder(dt.Rows[i][16].ToString(), "Sayın, " + dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString() + "; " + dt.Rows[i][9].ToString() + " isbn nolu kitabın iade tarihi geçmiştir. Lütfen en yakın zamanda kitabı iade edin...");
            }
        }
        private void iadeYaklasanMail()
        {
            clsEmanetTeslimHatirlatma hatirlatma = new clsEmanetTeslimHatirlatma();
            DataTable dt = hatirlatma.datagrdDoldur1();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Gonder(dt.Rows[i][16].ToString(), "Sayın, " + dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString() + "; " + dt.Rows[i][9].ToString() + " isbn nolu kitabın iade tarihi yaklaşmıştır. Lütfen zamanı geçmeden kitabı iade edin yoksa hakkınızda ceza uygulanacaktır...");
            }
        }
        private bool DataDuzelt()
        {
            clsEmanetTeslimHatirlatma hatirlatma = new clsEmanetTeslimHatirlatma();
            DataTable dt = hatirlatma.datagrdDoldur();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][7].ToString().IndexOf("[Kırmızı]") != -1)
                {
                    return true;
                }
                
            }
            return false;
        }
        public void Kontrol()
        {
            if (DataDuzelt() == true)
            {
                timerhatirlatma.Start();
                timerhatirlatma.Interval = 500;
                timerhatirlatma.Enabled = true;


            }
            else{ timerhatirlatma.Enabled=false; btnhatirlat.BackColor = Color.White; }

        }
        private void kitapsayisi()
        {
            string sql = "select count(ISBN_kod) from tbl_kitap";
            lblkitapsayi .Text = da.ExecuteScaler(sql).ToString ();
        }
        private void uyesayisi()
        {
            string sql = "select count(tc) from tbl_uye";
            lbluyesayi .Text  = da.ExecuteScaler(sql).ToString();
        }
        private void baslik_Tick(object sender, EventArgs e)
        {
            string kayanyazi = lbybaslik.Text;
            int adet = kayanyazi.Length;
            string ilkkarekter, sonrasi;
            ilkkarekter = kayanyazi.Substring(0, 1);
            sonrasi = kayanyazi.Substring(1, adet - 1);
            lbybaslik.Text = sonrasi + ilkkarekter;
        }

        private void saattarih_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToShortDateString();
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAnasayfa_MouseMove(object sender, MouseEventArgs e)
        {
           lblkoordinat .Text   = (e.X.ToString() + ":" + e.Y.ToString());
           Kontrol();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblkoordinat.Text = (e.X.ToString() + ":" + e.Y.ToString());
         
        }

        private void btnkitapekle_Click(object sender, EventArgs e)
        {
            frmKitapIslem frm = new frmKitapIslem();
            frm.ShowDialog();
        }

        private void btnyenikullanici_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKullaniciEkle kitap = new frmKullaniciEkle();
            kitap.ShowDialog();
            this.Show();
        }

        private void btnuyeekle_Click(object sender, EventArgs e)
        {
            frmUyeIslem frm = new frmUyeIslem();
            frm.ShowDialog();
        }

        private void btnkutuphaneekle_Click(object sender, EventArgs e)
        {
            frmKutuphaneIslem frm = new frmKutuphaneIslem();
            frm.ShowDialog();
        }

        private void btnpersonelekle_Click(object sender, EventArgs e)
        {
            frmPersonelIslem frm = new frmPersonelIslem();
            frm.ShowDialog();
        }

        private void btnyayineviekle_Click(object sender, EventArgs e)
        {
            frmYayineviIslem frm = new frmYayineviIslem();
            frm.ShowDialog();
        }

        private void btnyazarekle_Click(object sender, EventArgs e)
        {
            frmYazarIslem frm = new frmYazarIslem();
            frm.ShowDialog();
        }

        private void btnkitapver_Click(object sender, EventArgs e)
        {
            frmKitapVermeIslem frm = new frmKitapVermeIslem();
            frm.ShowDialog();
        }

        private void btnkitapal_Click(object sender, EventArgs e)
        {
            frmKitapAlmaIslem frm = new frmKitapAlmaIslem();
            frm.ShowDialog();
        }

        private void kitapİstatistiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapIstatistigi frm = new frmKitapIstatistigi();
            frm.ShowDialog ();
        }

        private void üyeİstatistiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeIstatistik frm = new frmUyeIstatistik();
            frm.ShowDialog();
        }

        private void kütüphaneİstatistiğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKutuphaneIstatistik frm = new frmKutuphaneIstatistik();
            frm.ShowDialog();
        }
          
        private void timerhatirlatma_Tick(object sender, EventArgs e)
        {
            if (timerhatirlatma.Enabled == true)
            {
                if (btnhatirlat.BackColor == Color.White)
                {
                    btnhatirlat.BackColor = Color.Red;
                }
                else
                {
                    btnhatirlat.BackColor = Color.White;
                }
                if (btnteslimkatirlat.BackColor == Color.White)
                {
                    btnteslimkatirlat.BackColor = Color.Red;
                }
                else
                {
                    btnteslimkatirlat.BackColor = Color.White;
                }
            }
 
        }

        private void btnteslimkatirlat_Click(object sender, EventArgs e)
        {
            frmEmanetTeslimHatirlatma frm = new frmEmanetTeslimHatirlatma();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmHakkimizda frm = new frmHakkimizda();
            frm.ShowDialog();
        }

        private void kitapTurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametreKitapTur frm = new frmParametreKitapTur();
            frm.ShowDialog();
        }

        private void kitapYeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametreKitapYeri frm = new frmParametreKitapYeri();
            frm.ShowDialog();
        }

        private void görevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametreGorev frm = new frmParametreGorev();
            frm.ShowDialog();
        }

        private void meslekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametreMeslek frm = new frmParametreMeslek();
            frm.ShowDialog();
        }

        private void öğrenimDurumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametreOgrenimDurum frm = new frmParametreOgrenimDurum();
            frm.ShowDialog();
        }

        private void dilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametreDil frm = new frmParametreDil();
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmHakkimizda frm = new frmHakkimizda();
            frm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmHakkimizda frm = new frmHakkimizda();
            frm.ShowDialog();
        }

        private void yeniYılToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametreYeniYil frm = new frmParametreYeniYil();
            frm.ShowDialog();
        }

        private void üyeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeListesi frm = new frmUyeListesi();
            frm.ShowDialog();
        }

        private void kitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapListesi frm = new frmKitapListesi();
            frm.ShowDialog();
        }

        private void kütüphaneListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKutuphaneListesi frm = new frmKutuphaneListesi();
            frm.ShowDialog();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelListesi frm = new frmPersonelListesi();
            frm.ShowDialog();
        }

        private void yayıneviListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYayineviListesi frm = new frmYayineviListesi();
            frm.ShowDialog();
        }

        private void yazarListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYazarListesi frm = new frmYazarListesi();
            frm.ShowDialog();
        }

        private void bağışListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBagisListesi frm = new frmBagisListesi();
            frm.ShowDialog();
        }

        public bool Gonder(string mailAdres, string mesaj)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("kutuphaneniz@gmail.com");
            
            ePosta.To.Add(mailAdres);

            ePosta.Subject = "Kutuphane Kitap Teslimi";
            
            ePosta.Body = mesaj;
            
            SmtpClient smtp = new SmtpClient();
            
            smtp.Credentials = new System.Net.NetworkCredential("kutuphaneniz@gmail.com", "qawsedrftgyh");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
               
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iadeGecenMail();
            iadeYaklasanMail();
            MessageBox.Show("Mail Gönderilmiştir");
        }

    }
}

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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }
        DataAccesLayer da = new DataAccesLayer();
        private void cmdTamam_Click(object sender, EventArgs e)
        {
            if (txtCevap.Text != "" && txtKullaniciAd.Text != "" && txtSoru.Text != "" && txtKullaniciParola.Text != "" || cmbtur.Text!= "ADMİN" || cmbtur.Text != "USER")
            {
                DataTable dt = da.ExecuteDataTable("Select * from tbl_giris where kullanici_ad='" + txtKullaniciAd.Text + "'");
                if(dt==null)
                {
                   MessageBox.Show("Sistem arızalı.");
                }
                else if(dt.Rows.Count==0)
                {
                    da.Execute("insert into tbl_giris values('" + txtKullaniciAd.Text + "','" + txtKullaniciParola.Text + "','" + cmbtur .Text  + "','" + txtSoru.Text + "','" + txtCevap.Text + "')");               
                    MessageBox.Show("Kayıt başarılı.");
                    txtCevap.Clear();
                    txtKullaniciAd.Clear();
                    txtKullaniciParola.Clear();
                    txtSoru.Clear();
                    return ;
                    
                }
                else
                {
                    MessageBox.Show("Kayıt var.");
                    return ;
                }
            }
            else
            {
                MessageBox.Show("Boşlukları doldurunuz.");
                return;
            }
        }

        private void Çıkış_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsPersonelIslem
    {
        DataAccesLayer da = new DataAccesLayer();
        private string _tc;

        public string zTc
        {
            get { return _tc; }
            set { _tc = value; }
        }
        private string _ad;

        public string zAd
        {
            get { return _ad; }
            set { _ad = value; }
        }
        private string _soyad;

        public string zSoyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
        private string _dogumyer;

        public string zDogumyer
        {
            get { return _dogumyer; }
            set { _dogumyer = value; }
        }
        private string _dogumtarih;

        public string zDogumtarih
        {
            get { return _dogumtarih; }
            set { _dogumtarih = value; }
        }
        private string _cinsiyet;

        public string zCinsiyet
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }
        private string _adres;

        public string zAdres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        private string _il;

        public string zIl
        {
            get { return _il; }
            set { _il = value; }
        }
        private string _ilce;

        public string zIlce
        {
            get { return _ilce; }
            set { _ilce = value; }
        }
        private string _semt;

        public string zSemt
        {
            get { return _semt; }
            set { _semt = value; }
        }
        private string _tel;

        public string zTel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        private string _ceptel;

        public string zCeptel
        {
            get { return _ceptel; }
            set { _ceptel = value; }
        }
        private string _ogrenimdurum;

        public string zOgrenimdurum
        {
            get { return _ogrenimdurum; }
            set { _ogrenimdurum = value; }
        }
        private string _calismadurum;

        public string zCalismadurum
        {
            get { return _calismadurum; }
            set { _calismadurum = value; }
        }
        private string _gorev;

        public string zGorev
        {
            get { return _gorev; }
            set { _gorev = value; }
        }
        private string _kutuphane;

        public string zKutuphane
        {
            get { return _kutuphane; }
            set { _kutuphane = value; }
        }
        private string _email;

        public string zEmail
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _dgr;

        public string zDgr
        {
            get { return _dgr; }
            set { _dgr = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT tc AS Tc, ad AS Ad, soyad AS Soyad, dogum_yer AS Doğum_Yer, dogum_tarih AS Doğum_Tarih, cinsiyet AS Cinsiyet, adres AS Adres, il AS İl, ilce AS İlçe,semt AS Semt, tel AS Telefonu, cep_tel AS Cep_Telefonu, ogrenim_durum AS Ogrenim_Durum, calisma_durum AS Çalişma_Durum, gorev AS Görev,kutuphane AS Çalıştığı_Kütüphane, email AS Email_Adresi FROM tbl_personel order by ad";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public void kaydet()
        {
            string sql = @"select * from tbl_personel where tc=#tc";
            sql = sql.Replace("#tc", zTc);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count == 0)
            {

                sql = @"insert into tbl_personel values (#tc,#ad1,#soyad,#dogumyer,#dogumtarih,#cinsiyet,#adres,#il1,#ilce,#semt,#tel,#ceptel,#ogrenimdurum,#calismadurum,#gorev,#kutuphane,#email)";
                sql = sql.Replace("#tc", zTc);
                sql = sql.Replace("#ad1", "'" + zAd + "'");
                sql = sql.Replace("#soyad", "'" + zSoyad + "'");
                sql = sql.Replace("#adres", "'" + zAdres + "'");
                sql = sql.Replace("#il1", "'" + zIl + "'");
                sql = sql.Replace("#ilce", "'" + zIlce + "'");
                sql = sql.Replace("#semt", "'" + zSemt + "'");
                sql = sql.Replace("#dogumtarih", "'" + zDogumtarih + "'");
                sql = sql.Replace("#dogumyer", "'" + zDogumyer + "'");
                sql = sql.Replace("#ogrenimdurum", "'" + zOgrenimdurum + "'");
                sql = sql.Replace("#cinsiyet", "'" + zCinsiyet + "'");
                sql = sql.Replace("#tel", "'" + zTel + "'");
                sql = sql.Replace("#ceptel", "'" + zCeptel + "'");
                sql = sql.Replace("#email", "'" + zEmail + "'");
                sql = sql.Replace("#calismadurum", "'" + zCalismadurum + "'");
                sql = sql.Replace("#gorev", "'" + zGorev + "'");
                sql = sql.Replace("#kutuphane", "'" + zKutuphane + "'");
                da.Execute(sql);
                zDgr = "Kaydetme Başarılı";
            }
            else { zDgr = "Sistemde Tc si" + " " + zTc  + " " + "Olan Personel Mevcuttur"; }
        }

        public void guncelle()
        {
            string sql = @"select * from tbl_personel where tc=#tc";
            sql = sql.Replace("#tc", zTc);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"update tbl_personel set tc=#tc,ad=#ad1,soyad=#soyad,dogum_tarih=#dogumtarih,cinsiyet=#cinsiyet,adres=#adres,il=#il1,ilce=#ilce,semt=#semt,tel=#tel,cep_tel=#ceptel,email=#email,dogum_yer=#dogumyer,ogrenim_durum=#ogrenimdurum,calisma_durum=#calismadurum,gorev=#gorev,kutuphane=#kutuphane where tc=#tc";

                sql = sql.Replace("#tc", zTc);
                sql = sql.Replace("#ad1", "'" + zAd + "'");
                sql = sql.Replace("#soyad", "'" + zSoyad + "'");
                sql = sql.Replace("#adres", "'" + zAdres + "'");
                sql = sql.Replace("#il1", "'" + zIl + "'");
                sql = sql.Replace("#ilce", "'" + zIlce + "'");
                sql = sql.Replace("#semt", "'" + zSemt + "'");
                sql = sql.Replace("#dogumtarih", "'" + zDogumtarih + "'");
                sql = sql.Replace("#dogumyer", "'" + zDogumyer + "'");
                sql = sql.Replace("#ogrenimdurum", "'" + zOgrenimdurum + "'");
                sql = sql.Replace("#cinsiyet", "'" + zCinsiyet + "'");
                sql = sql.Replace("#tel", "'" + zTel + "'");
                sql = sql.Replace("#ceptel", "'" + zCeptel + "'");
                sql = sql.Replace("#email", "'" + zEmail + "'");
                sql = sql.Replace("#calismadurum", "'" + zCalismadurum + "'");
                sql = sql.Replace("#gorev", "'" + zGorev + "'");
                sql = sql.Replace("#kutuphane", "'" + zKutuphane + "'");
                da.Execute(sql);
                zDgr = "Güncelleme Başarılı";
            }
            else { zDgr = "Sistemde Tc si" + " " + zTc + " " + "Olan Personel Bulunmamaktadır"; }
        }
        public void sil()
        {
            string sql = @"select * from tbl_personel where tc=#tc";
            sql = sql.Replace("#tc", zTc);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"delete from tbl_personel where tc=#tc";
                sql = sql.Replace("#tc", zTc);
                da.Execute(sql);
                zDgr = "Silme Başarılı";
            }
            else { zDgr = "Sistemde Tc si" + " " + zTc + " " + "Olan Personel Bulunmamaktadır"; }

        }
        public void bul()
        {
            string sql = @"select * from tbl_personel where tc=#tc";
            sql = sql.Replace("#tc", zTc);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                zAd = dt.Rows[0]["ad"].ToString();
                zAdres = dt.Rows[0]["adres"].ToString();
                zCeptel = dt.Rows[0]["cep_tel"].ToString();
                zCinsiyet = dt.Rows[0]["cinsiyet"].ToString();
                zDogumtarih = dt.Rows[0]["dogum_tarih"].ToString();
                zEmail = dt.Rows[0]["email"].ToString();
                zIl = dt.Rows[0]["il"].ToString();
                zIlce = dt.Rows[0]["ilce"].ToString();
                zSemt = dt.Rows[0]["semt"].ToString();
                zSoyad = dt.Rows[0]["soyad"].ToString();
                zTc = dt.Rows[0]["tc"].ToString();
                zTel = dt.Rows[0]["tel"].ToString();
                zDogumyer = dt.Rows[0]["dogum_yer"].ToString();
                zOgrenimdurum = dt.Rows[0]["ogrenim_durum"].ToString();
                zCalismadurum = dt.Rows[0]["calisma_durum"].ToString();
                zGorev = dt.Rows[0]["gorev"].ToString();
                zKutuphane = dt.Rows[0]["kutuphane"].ToString();
                zDgr = "Kayıt Bulundu";
            }
            else
            {
                zAd = "";
                zAdres = "";
                zCeptel = "";
                zCinsiyet = "Cinsiyet Seçiniz";
                zDogumtarih = DateTime.Now.ToShortDateString();
                zEmail = "";
                zIl = "İl Seçiniz";
                zIlce = "İlçe Seçiniz";
                zSemt = "Semt Seçiniz";
                zSoyad = "";
                zTel = "";
                zDogumyer = "Doğum Yeri Seçiniz";
                zOgrenimdurum = "Öğrenim Durum Seçiniz";
                zCalismadurum = "Çalısma Durum Seçiniz";
                zGorev = "Görev Seçiniz";
                zKutuphane = "Kütüphane Seçiniz";
                zDgr = "Sistemde Tc si" + " " + zTc + " " + "Olan Personel Bulunmamaktadır";
            }
        }
        public DataTable suzme()
        {
            string sql = @"SELECT tc AS Tc, ad AS Ad, soyad AS Soyad, dogum_yer AS Doğum_Yer, dogum_tarih AS Doğum_Tarih, cinsiyet AS Cinsiyet, adres AS Adres, il AS İl, ilce AS İlçe,semt AS Semt, tel AS Telefonu, cep_tel AS Cep_Telefonu, ogrenim_durum AS Ogrenim_Durum, calisma_durum AS Çalişma_Durum, gorev AS Görev,kutuphane AS Çalıştığı_Kütüphane, email AS Email_Adresi FROM tbl_personel where tc::text like '#tc%' and lower(ad)::text like '#ad%' and lower(soyad)::text like '#soyad%' and calisma_durum::text like '#calismadurum%' order by ad";
            sql = sql.Replace("#tc", zTc);
            sql = sql.Replace("#ad", zAd.ToLower());
            sql = sql.Replace("#soyad", zSoyad.ToLower());
            sql = sql.Replace("#calismadurum", zCalismadurum);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

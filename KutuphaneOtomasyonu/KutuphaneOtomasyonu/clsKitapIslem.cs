using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    public  class clsKitapIslem
    {
        DataAccesLayer da = new DataAccesLayer();
        private static string bagisisbn;

        public static string zBagisisbn
        {
            get { return clsKitapIslem.bagisisbn; }
            set { clsKitapIslem.bagisisbn = value; }
        }
        private string _isbn;

        public string zIsbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        private string _ad;

        public string zAd
        {
            get { return _ad; }
            set { _ad = value; }
        }
        private string _yazar;

        public string zYazar
        {
            get { return _yazar; }
            set { _yazar = value; }
        }
        private string _yayinevi;

        public string zYayinevi
        {
            get { return _yayinevi; }
            set { _yayinevi = value; }
        }
        private string _sayfasayisi;

        public string zSayfasayisi
        {
            get { return _sayfasayisi; }
            set { _sayfasayisi = value; }
        }
        private string _tur;

        public string zTur
        {
            get { return _tur; }
            set { _tur = value; }
        }
        private string _kutuphane;

        public string zKutuphane
        {
            get { return _kutuphane; }
            set { _kutuphane = value; }
        }
        private string _kitapyeri;

        public string zKitapyeri
        {
            get { return _kitapyeri; }
            set { _kitapyeri = value; }
        }
        private string _basimtarih;

        public string zBasimtarih
        {
            get { return _basimtarih; }
            set { _basimtarih = value; }
        }
        private string _baskisayisi;

        public string zBaskisayisi
        {
            get { return _baskisayisi; }
            set { _baskisayisi = value; }
        }
        private string _teminsekli;

        public string zTeminsekli
        {
            get { return _teminsekli; }
            set { _teminsekli = value; }
        }
        private string _kitapicerik;

        public string zKitapicerik
        {
            get { return _kitapicerik; }
            set { _kitapicerik = value; }
        }
        private string _dil;

        public string zDil
        {
            get { return _dil; }
            set { _dil = value; }
        }
        private string _dgr;

        public string zDgr
        {
            get { return _dgr; }
            set { _dgr = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT ISBN_kod ISBN_Kod, ad Kitap_Adı, yazar Yazarı, yayinevi Yayınevi, sayfa_sayisi Sayfa_Sayısı, tur Türü, kutuphane Bulunduğu_Kütüphane, kitap_yeri Bulunduğu_Konum, basim_tarih Basım_Tarihi, baski_sayi Baskı_Sayısı, dil Dil, durum Durum, temin_sekli Temin_Ediliş_Şekli, kitap_icerik_bilgi Kitabın_İçeriği_Hakkında_Bilgi FROM tbl_kitap order by ad";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public void kaydet()
        { 
        string sql = @"select * from tbl_kitap where ISBN_kod=#isbn";
            sql = sql.Replace("#isbn", "'" + zIsbn  + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count == 0)
            {

                sql = @"insert into tbl_kitap values (#isbn,#ad,#yazar,#yayinevi,#sayfasayisi,#tur,#kutuphane,#kitapyeri,#basimtarih,#baskisayisi,#dil,'MEVCUT',#teminsekli,#kitapicerik)";
                sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                sql = sql.Replace("#ad", "'" + zAd + "'");
                sql = sql.Replace("#yazar", "'" + zYazar + "'");
                sql = sql.Replace("#yayinevi", "'" + zYayinevi + "'");
                sql = sql.Replace("#sayfasayisi", "'" + zSayfasayisi + "'");
                sql = sql.Replace("#tur", "'" + zTur + "'");
                sql = sql.Replace("#kutuphane", "'" + zKutuphane + "'");
                sql = sql.Replace("#kitapyeri", "'" + zKitapyeri + "'");
                sql = sql.Replace("#basimtarih", "'" + zBasimtarih + "'");
                sql = sql.Replace("#baskisayisi", "'" + zBaskisayisi + "'");
                sql = sql.Replace("#dil", "'" + zDil + "'");
                sql = sql.Replace("#teminsekli", "'" + zTeminsekli + "'");
                sql = sql.Replace("#kitapicerik", "'" + zKitapicerik + "'");
                da.Execute(sql);
                zDgr ="Kaydetme Başarılı" ;
            }
            else { zDgr = "Sistemde İSBN Kodu" + " " + zIsbn  + " " + "Olan Kitap Mevcuttur"; }
        }

        public void guncelle()
        { 
         string sql = @"select * from tbl_kitap where ISBN_kod=#isbn";
            sql = sql.Replace("#isbn", "'" + zIsbn  + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"update tbl_kitap set ISBN_kod=#isbn,ad=#ad,yazar=#yazar,yayinevi=#yayinevi,sayfa_sayisi=#sayfasayisi,tur=#tur,Kutuphane=#kutuphane,kitap_yeri=#kitapyeri,basim_tarih=#basimtarih,baski_sayi=#baskisayisi,dil=#dil,temin_sekli=#teminsekli,kitap_icerik_bilgi=#kitapicerik where ISBN_kod=#isbn";
                sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                sql = sql.Replace("#ad", "'" + zAd + "'");
                sql = sql.Replace("#yazar", "'" + zYazar + "'");
                sql = sql.Replace("#yayinevi", "'" + zYayinevi + "'");
                sql = sql.Replace("#sayfasayisi", "'" + zSayfasayisi + "'");
                sql = sql.Replace("#tur", "'" + zTur + "'");
                sql = sql.Replace("#kutuphane", "'" + zKutuphane + "'");
                sql = sql.Replace("#kitapyeri", "'" + zKitapyeri + "'");
                sql = sql.Replace("#basimtarih", "'" + zBasimtarih + "'");
                sql = sql.Replace("#baskisayisi", "'" + zBaskisayisi + "'");
                sql = sql.Replace("#dil", "'" + zDil + "'");
                sql = sql.Replace("#teminsekli", "'" + zTeminsekli + "'");
                sql = sql.Replace("#kitapicerik", "'" + zKitapicerik + "'");
                da.Execute(sql);
                zDgr = "Güncelleme Başarılı";
            }
            else { zDgr = "Sistemde İSBN Kodu" + " " + zIsbn + " " + "Olan Kitap Bulunmamaktadır"; }
        }
        public void sil()
        { string sql = @"select * from tbl_kitap where ISBN_kod=#isbn";
            sql = sql.Replace("#isbn", "'" + zIsbn  + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"delete from tbl_kitap where ISBN_kod=#isbn";
                sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                da.Execute(sql);

                sql = @"delete from tbl_bagis where kitap_isbn = #isbn";
                sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                da.Execute(sql);
                zDgr = "Silme Başarılı";
            }
            else { zDgr = "Sistemde İSBN Kodu" + " " + zIsbn + " " + "Olan Kitap Bulunmamaktadır"; }
        
        }
        public void bul()
        { 
         string sql = @"select * from tbl_kitap where ISBN_kod=#isbn";
            sql = sql.Replace("#isbn", "'" + zIsbn  + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                zAd = dt.Rows[0]["ad"].ToString();
                zBasimtarih = dt.Rows[0]["basim_tarih"].ToString();
                zBaskisayisi = dt.Rows[0]["baski_sayi"].ToString();
                zDil = dt.Rows[0]["dil"].ToString();
                zKitapicerik = dt.Rows[0]["kitap_icerik_bilgi"].ToString();
                zKitapyeri = dt.Rows[0]["kitap_yeri"].ToString();
                zKutuphane = dt.Rows[0]["kutuphane"].ToString();
                zSayfasayisi = dt.Rows[0]["sayfa_sayisi"].ToString();
                zTeminsekli = dt.Rows[0]["temin_sekli"].ToString();
                zTur = dt.Rows[0]["tur"].ToString();
                zYayinevi = dt.Rows[0]["yayinevi"].ToString();
                zYazar = dt.Rows[0]["yazar"].ToString();
                zDgr = "Kayıt Bulundu";
            }
            else
            {
                zAd = "";
                zBasimtarih = DateTime.Now.ToShortDateString();
                zBaskisayisi ="";
                zDil = "Dil Seçiniz";
                zKitapicerik = "";
                zKitapyeri = "Kitabın Koyulacağı Yeri Seçiniz";
                zKutuphane = "Kütüphane Seçiniz";
                zSayfasayisi = "";
                zTeminsekli = "Temin Şekli Seçiniz";
                zTur = "Kitap Tür Seçiniz";
                zYayinevi = "Yayınevi Seçiniz";
                zYazar = "Yazar Seçiniz";
                zDgr = "Sistemde İSBN kodu:" + " " +zIsbn +" "+"Olan Kitap Bulunmamaktadır";
            }
        }
        public DataTable suzme()
        {
            string sql = @"SELECT ISBN_kod ISBN_Kod, ad Kitap_Adı, yazar Yazarı, yayinevi Yayınevi, sayfa_sayisi Sayfa_Sayısı, tur Türü, kutuphane Bulunduğu_Kütüphane, kitap_yeri Bulunduğu_Konum, basim_tarih Basım_Tarihi, baski_sayi Baskı_Sayısı, dil Dil, durum Durum, temin_sekli Temin_Ediliş_Şekli, kitap_icerik_bilgi Kitabın_İçeriği_Hakkında_Bilgi FROM tbl_kitap where ISBN_kod::text like '#isbn%' and lower(ad)::text like '#ad%' and lower(tur)::text like '#tur%' and lower(yazar)::text like '#yazar%' order by ad";
            sql = sql.Replace("#isbn", zIsbn );
            sql = sql.Replace("#ad", zAd.ToLower());
            sql = sql.Replace("#yazar", zYazar.ToLower() );
            sql = sql.Replace("#tur", zTur.ToLower() );
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

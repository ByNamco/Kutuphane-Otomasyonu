using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsKitapListesi
    {
        DataAccesLayer da = new DataAccesLayer();
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
        private string _tur;

        public string zTur
        {
            get { return _tur; }
            set { _tur = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT ISBN_kod ISBN_Kod, ad Kitap_Adı, yazar Yazarı, yayinevi Yayınevi, sayfa_sayisi Sayfa_Sayısı, tur Türü, kutuphane Bulunduğu_Kütüphane, kitap_yeri Bulunduğu_Konum, basim_tarih Basım_Tarihi, baski_sayi Baskı_Sayısı, dil Dil, durum Durum, temin_sekli Temin_Ediliş_Şekli, kitap_icerik_bilgi Kitabın_İçeriği_Hakkında_Bilgi FROM tbl_kitap order by ad";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"SELECT ISBN_kod ISBN_Kod, ad Kitap_Adı, yazar Yazarı, yayinevi Yayınevi, sayfa_sayisi Sayfa_Sayısı, tur Türü, kutuphane Bulunduğu_Kütüphane, kitap_yeri Bulunduğu_Konum, basim_tarih Basım_Tarihi, baski_sayi Baskı_Sayısı, dil Dil, durum Durum, temin_sekli Temin_Ediliş_Şekli, kitap_icerik_bilgi Kitabın_İçeriği_Hakkında_Bilgi FROM tbl_kitap where ISBN_kod::text like '#isbn%' and lower(ad)::text like '#ad%' and lower(tur)::text like '#tur%' and lower(yazar)::text like '#yazar%' order by ad";
            sql = sql.Replace("#isbn", zIsbn);
            sql = sql.Replace("#ad", zAd.ToLower());
            sql = sql.Replace("#yazar", zYazar.ToLower());
            sql = sql.Replace("#tur", zTur.ToLower());
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

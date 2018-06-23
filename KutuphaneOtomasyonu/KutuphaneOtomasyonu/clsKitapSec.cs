using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsKitapSec
    {
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
        DataAccesLayer da = new DataAccesLayer();
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT ISBN_kod, ad, yazar, tur, sayfa_sayisi, kitap_icerik_bilgi FROM tbl_kitap WHERE     (durum = 'MEVCUT') order by ad";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"SELECT ISBN_kod, ad, yazar, tur, sayfa_sayisi, kitap_icerik_bilgi FROM tbl_kitap WHERE     (durum = 'MEVCUT') and ISBN_kod::text like '#isbn%' and lower(ad)::text like '#ad%' and lower(tur)::text like '#tur%' and lower(yazar)::text like '#yazar%' order by ad";
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

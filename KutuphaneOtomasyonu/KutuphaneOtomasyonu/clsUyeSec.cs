using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsUyeSec
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
        private string _meslek;

        public string zMeslek
        {
            get { return _meslek; }
            set { _meslek = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT     tc AS Tc, ad AS Ad, soyad AS Soyad, dogum_tarih AS Dogum_Tarih, meslek AS Meslek, tel AS Telefon, cep_tel AS Cep_Telefon, adres AS Adres, semt AS Mahalle,   ilce AS İlce, il AS İl, cinsiyet AS Cinsiyet FROM         tbl_uye order by ad";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"SELECT     tc AS Tc, ad AS Ad, soyad AS Soyad, dogum_tarih AS Dogum_Tarih, meslek AS Meslek, tel AS Telefon, cep_tel AS Cep_Telefon, adres AS Adres, semt AS Mahalle,   ilce AS İlce, il AS İl, cinsiyet AS Cinsiyet FROM         tbl_uye WHERE    tc::text like '#tc%' and lower(ad)::text like '#ad%' and lower(soyad)::text like '#soyad%' and lower(meslek)::text like '#meslek%' order by ad";
            sql = sql.Replace("#tc", zTc);
            sql = sql.Replace("#ad", zAd.ToLower());
            sql = sql.Replace("#soyad", zSoyad.ToLower());
            sql = sql.Replace("#meslek", zMeslek.ToLower());
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

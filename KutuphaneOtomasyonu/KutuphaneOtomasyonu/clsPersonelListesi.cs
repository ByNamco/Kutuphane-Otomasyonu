using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsPersonelListesi
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
        private string _calismadurum;

        public string zCalismadurum
        {
            get { return _calismadurum; }
            set { _calismadurum = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT tc AS Tc, ad AS Ad, soyad AS Soyad, dogum_yer AS Doğum_Yer, dogum_tarih AS Doğum_Tarih, cinsiyet AS Cinsiyet, adres AS Adres, il AS İl, ilce AS İlçe,semt AS Semt, tel AS Telefonu, cep_tel AS Cep_Telefonu, ogrenim_durum AS Ogrenim_Durum, calisma_durum AS Çalişma_Durum, gorev AS Görev,kutuphane AS Çalıştığı_Kütüphane, email AS Email_Adresi FROM tbl_personel order by ad";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
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

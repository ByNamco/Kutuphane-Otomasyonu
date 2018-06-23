using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsKutuphaneListesi
    {
        DataAccesLayer da = new DataAccesLayer();
        private string _kutuphaneno;

        public string zKutuphaneno
        {
            get { return _kutuphaneno; }
            set { _kutuphaneno = value; }
        }
        private string _ad;

        public string zAd
        {
            get { return _ad; }
            set { _ad = value; }
        }
        private string _tur;

        public string zTur
        {
            get { return _tur; }
            set { _tur = value; }
        }
        private string _il;

        public string zIl
        {
            get { return _il; }
            set { _il = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT kutuphane_no AS Kütüphane_No, ad AS Kütüphane_Adı, tur AS Kütüphane_Türü, adres AS Adres, il AS İl, ilce AS İlçe, semt AS Semt, tel AS Tel, fax AS Fax,email AS E_mail FROM tbl_kutuphane order by kutuphane_no";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"SELECT kutuphane_no AS Kütüphane_No, ad AS Kütüphane_Adı, tur AS Kütüphane_Türü, adres AS Adres, il AS İl, ilce AS İlçe, semt AS Semt, tel AS Tel, fax AS Fax,email AS E_mail FROM tbl_kutuphane where kutuphane_no::text like '#kno%' and lower(ad)::text like '#ad1%' and lower(tur)::text like '#tur%' and lower(il)::text like '#il1%' order by kutuphane_no";
            sql = sql.Replace("#kno", zKutuphaneno);
            sql = sql.Replace("#ad1", zAd.ToLower());
            sql = sql.Replace("#tur", zTur.ToLower());
            sql = sql.Replace("#il1", zIl.ToLower());
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

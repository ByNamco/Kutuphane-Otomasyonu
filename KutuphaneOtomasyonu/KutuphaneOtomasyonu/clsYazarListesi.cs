using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsYazarListesi
    {
        DataAccesLayer da = new DataAccesLayer();
        private string _no;

        public string zNo
        {
            get { return _no; }
            set { _no = value; }
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
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT yazar_no AS Yazar_No, ad AS Ad, soyad AS Soyad, otobiyografi AS Otobiyografi FROM tbl_yazar order by yazar_no";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"SELECT yazar_no AS Yazar_No, ad AS Ad, soyad AS Soyad, otobiyografi AS Otobiyografi FROM tbl_yazar where yazar_no::text like '#yno%' and lower(ad)::text like '#ad%' and lower(soyad)::text like '#soyad%' order by yazar_no";
            sql = sql.Replace("#yno", zNo);
            sql = sql.Replace("#ad", zAd.ToLower());
            sql = sql.Replace("#soyad", zSoyad.ToLower());
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

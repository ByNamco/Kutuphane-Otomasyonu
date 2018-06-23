using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsYayineviListesi
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
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT yayinevi_no AS Yayınevi_No, ad AS Ad, adres AS Adres, il AS İl, ilce AS İlçe, semt AS Semt, tel AS Telefon, fax AS Fax, email AS E_mail FROM tbl_yayinevi order by yayinevi_no";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"SELECT yayinevi_no AS Yayınevi_No, ad AS Ad, adres AS Adres, il AS İl, ilce AS İlçe, semt AS Semt, tel AS Telefon, fax AS Fax, email AS E_mail FROM tbl_yayinevi where yayinevi_no::text like '#yno%' and lower(ad)::text like '#ad1%' order by yayinevi_no";
            sql = sql.Replace("#yno", zNo);
            sql = sql.Replace("#ad1", zAd.ToLower());
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

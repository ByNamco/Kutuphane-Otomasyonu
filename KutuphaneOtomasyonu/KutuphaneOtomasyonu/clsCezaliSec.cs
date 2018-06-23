using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsCezaliSec
    {
        DataAccesLayer da = new DataAccesLayer();
        private string _id;

        public string zId
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _tc;

        public string zTc
        {
            get { return _tc; }
            set { _tc = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT     id, uye_tc, kutuphane, sebep, ceza_baslangic_tarih, ceza_bitis_tarih, sonuc FROM         tbl_kara_liste WHERE     (durum = 'AKTİF') order by id";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"SELECT     id, uye_tc, kutuphane, sebep, ceza_baslangic_tarih, ceza_bitis_tarih, sonuc FROM         tbl_kara_liste WHERE     (durum = 'AKTİF') and uye_tc::text like '#utc%' and id::text like '#id%' order by id";
            sql = sql.Replace("#utc", zTc );
            sql = sql.Replace("#id", zId);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

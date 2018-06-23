using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsYazarIslem
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
        private string _otobiyografi;

        public string zOtobiyografi
        {
            get { return _otobiyografi; }
            set { _otobiyografi = value; }
        }
        private string _dgr;

        public string zDgr
        {
            get { return _dgr; }
            set { _dgr = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT yazar_no AS Yazar_No, ad AS Ad, soyad AS Soyad, otobiyografi AS Otobiyografi FROM tbl_yazar order by yazar_no";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public void kaydet()
        {
            string sql = @"select * from tbl_yazar where yazar_no=#yno";
            sql = sql.Replace("#yno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count == 0)
            {

                sql = @"insert into tbl_yazar values (#yno,#ad,#soyad,#oto)";
                sql = sql.Replace("#yno", zNo);
                sql = sql.Replace("#ad", "'" + zAd + "'");
                sql = sql.Replace("#soyad", "'" + zSoyad + "'");
                sql = sql.Replace("#oto", "'" + zOtobiyografi + "'");
                da.Execute(sql);
                zDgr = "Kaydetme Başarılı";
            }
            else { zDgr = "Sistemde Yazar No su" + " " + zNo + " " + "Olan Yazar Mevcuttur"; }
        }

        public void guncelle()
        {
            string sql = @"select * from tbl_yazar where yazar_no=#yno";
            sql = sql.Replace("#yno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"update tbl_yazar set yazar_no=#yno,ad=#ad,soyad=#soyad,otobiyografi=#oto where yazar_no=#yno";
                sql = sql.Replace("#yno", zNo);
                sql = sql.Replace("#ad", "'" + zAd + "'");
                sql = sql.Replace("#soyad", "'" + zSoyad + "'");
                sql = sql.Replace("#oto", "'" + zOtobiyografi + "'");
                da.Execute(sql);
                zDgr = "Güncelleme Başarılı";
            }
            else { zDgr = "Sistemde Yazar No su" + " " + zNo + " " + "Olan Yazar Bulunmamaktadır"; }
        }
        public void sil()
        {
            string sql = @"select * from tbl_yazar where yazar_no=#yno";
            sql = sql.Replace("#yno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"delete from tbl_yazar where yazar_no=#yno";
                sql = sql.Replace("#yno", zNo);
                da.Execute(sql);
                zDgr = "Silme Başarılı";
            }
            else { zDgr = "Sistemde Yazar No su" + " " + zNo + " " + "Olan Yazar Bulunmamaktadır"; }

        }
        public void bul()
        {
            string sql = @"select * from tbl_yazar where yazar_no=#yno";
            sql = sql.Replace("#yno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                zNo = dt.Rows[0]["yazar_no"].ToString();
                zAd = dt.Rows[0]["ad"].ToString();
                zSoyad = dt.Rows[0]["soyad"].ToString();
                zOtobiyografi = dt.Rows[0]["otobiyografi"].ToString();
                zDgr = "Kayıt Bulundu";
            }
            else
            {
                zAd = "";
                zSoyad = "";
                zOtobiyografi = "";
                zDgr = "Sistemde Yazar No su" + " " + zNo + " " + "Olan Yazar Bulunmamaktadır";
            }
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
        public void hazirid()
        {
            string SQL = @"select count(yazar_no) from tbl_yazar";
            zDgr = da.ExecuteScaler(SQL).ToString();


            if (int.Parse(zDgr) == 0)
            {
                zDgr = "1";
            }
            else
            {
                string sql = @"select max(yazar_no) from tbl_yazar";
                zDgr = da.ExecuteScaler(sql).ToString();
                zDgr = (int.Parse(zDgr) + 1).ToString();
            }
        }
    }
    
}

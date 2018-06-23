using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsYayineviIslem
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
        private string _adres;

        public string zAdres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        private string _il;

        public string zIl
        {
            get { return _il; }
            set { _il = value; }
        }
        private string _ilce;

        public string zIlce
        {
            get { return _ilce; }
            set { _ilce = value; }
        }
        private string _semt;

        public string zSemt
        {
            get { return _semt; }
            set { _semt = value; }
        }
        private string _tel;

        public string zTel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        private string _fax;

        public string zFax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        private string _email;

        public string zEmail
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _dgr;

        public string zDgr
        {
            get { return _dgr; }
            set { _dgr = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT yayinevi_no AS Yayınevi_No, ad AS Ad, adres AS Adres, il AS İl, ilce AS İlçe, semt AS Semt, tel AS Telefon, fax AS Fax, email AS E_mail FROM tbl_yayinevi order by yayinevi_no";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public void kaydet()
        {
            string sql = @"select * from tbl_yayinevi where yayinevi_no=#yno";
            sql = sql.Replace("#yno", zNo );
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count == 0)
            {

                sql = @"insert into tbl_yayinevi values (#yno,#ad1,#adres,#il1,#ilce,#semt,#tel,#fax,#email)";
                sql = sql.Replace("#yno", zNo);
                sql = sql.Replace("#ad1", "'" + zAd + "'");
                sql = sql.Replace("#adres", "'" + zAdres + "'");
                sql = sql.Replace("#il1", "'" + zIl + "'");
                sql = sql.Replace("#ilce", "'" + zIlce + "'");
                sql = sql.Replace("#semt", "'" + zSemt + "'");
                sql = sql.Replace("#tel", "'" + zTel + "'");
                sql = sql.Replace("#fax", "'" + zFax + "'");
                sql = sql.Replace("#email", "'" + zEmail + "'");
                da.Execute(sql);
                zDgr = "Kaydetme Başarılı";
            }
            else { zDgr = "Sistemde Yayınevi No su" + " " + zNo + " " + "Olan Yayınevi Mevcuttur"; }
        }

        public void guncelle()
        {
            string sql = @"select * from tbl_yayinevi where yayinevi_no=#yno";
            sql = sql.Replace("#yno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"update tbl_yayinevi set yayinevi_no=#yno,ad=#ad1,adres=#adres,il=#il1,ilce=#ilce,semt=#semt,tel=#tel,fax=#fax,email=#email where yayinevi_no=#yno";
                sql = sql.Replace("#yno", zNo);
                sql = sql.Replace("#ad1", "'" + zAd + "'");
                sql = sql.Replace("#adres", "'" + zAdres + "'");
                sql = sql.Replace("#il1", "'" + zIl + "'");
                sql = sql.Replace("#ilce", "'" + zIlce + "'");
                sql = sql.Replace("#semt", "'" + zSemt + "'");
                sql = sql.Replace("#tel", "'" + zTel + "'");
                sql = sql.Replace("#fax", "'" + zFax + "'");
                sql = sql.Replace("#email", "'" + zEmail + "'");
                da.Execute(sql);
                zDgr = "Güncelleme Başarılı";
            }
            else { zDgr = "Sistemde Yayınevi No su" + " " + zNo  + " " + "Olan Yayınevi Bulunmamaktadır"; }
        }
        public void sil()
        {
            string sql = @"select * from tbl_yayinevi where yayinevi_no=#yno";
            sql = sql.Replace("#yno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"delete from tbl_yayinevi where yayinevi_no=#yno";
                sql = sql.Replace("#yno", zNo);
                da.Execute(sql);
                zDgr = "Silme Başarılı";
            }
            else { zDgr = "Sistemde Yayınevi No su" + " " + zNo + " " + "Olan Yayınevi Bulunmamaktadır"; }

        }
        public void bul()
        {
            string sql = @"select * from tbl_yayinevi where yayinevi_no=#yno";
            sql = sql.Replace("#yno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                zAd = dt.Rows[0]["ad"].ToString();
                zAdres = dt.Rows[0]["adres"].ToString();
                zEmail = dt.Rows[0]["email"].ToString();
                zIl = dt.Rows[0]["il"].ToString();
                zIlce = dt.Rows[0]["ilce"].ToString();
                zSemt = dt.Rows[0]["semt"].ToString();
                zTel = dt.Rows[0]["tel"].ToString();
                zFax = dt.Rows[0]["fax"].ToString();
                zNo  = dt.Rows[0]["yayinevi_no"].ToString();
                zDgr = "Kayıt Bulundu";
            }
            else
            {
                zAd = "";
                zAdres = "";
                zEmail = "";
                zIl = "İl Seçiniz";
                zIlce = "İlçe Seçiniz";
                zSemt = "Semt Seçiniz";
                zTel = "";
                zFax = "";
                zDgr = "Sistemde Yayınevi No su" + " " + zNo + " " + "Olan Yayınevi Bulunmamaktadır";
            }
        }
        public DataTable suzme()
        {
            string sql = @"SELECT yayinevi_no AS Yayınevi_No, ad AS Ad, adres AS Adres, il AS İl, ilce AS İlçe, semt AS Semt, tel AS Telefon, fax AS Fax, email AS E_mail FROM tbl_yayinevi where yayinevi_no::text like '#yno%' and lower(ad)::text like '#ad1%' order by yayinevi_no";
            sql = sql.Replace("#yno", zNo );
            sql = sql.Replace("#ad1", zAd.ToLower());
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
        public void hazirid()
        {
            string SQL = @"select count(yayinevi_no) from tbl_yayinevi";
            zDgr = da.ExecuteScaler(SQL).ToString();


            if (int.Parse(zDgr) == 0)
            {
                zDgr = "1";
            }
            else
            {
                string sql = @"select max(yayinevi_no) from tbl_yayinevi";
                zDgr = da.ExecuteScaler(sql).ToString();
                zDgr = (int.Parse(zDgr) + 1).ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsBagisYapan
    {
        DataAccesLayer da = new DataAccesLayer();
        private string _isbn;

        public string zIsbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        private string _bagistarih;

        public string zBagistarih
        {
            get { return _bagistarih; }
            set { _bagistarih = value; }
        }
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
        private string _tel;

        public string zTel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        private string _adres;

        public string zAdres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        private string _dgr;

        public string zDgr
        {
            get { return _dgr; }
            set { _dgr = value; }
        }
        public void kaydet()
        {

            string sql = @"select * from tbl_bagis where kitap_isbn=#isbn";
            sql = sql.Replace("#isbn", "'" + zIsbn + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count == 0)
            {
          sql = @"select * from tbl_kitap where ISBN_kod=#isbn";
                sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                dt = da.ExecuteDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    sql = @"insert into tbl_bagis values (#isbn,#tc,#ad1,#soyad,#tel,#adres,#bagistarih)";
                    sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                    sql = sql.Replace("#bagistarih", "'" + zBagistarih + "'");
                    sql = sql.Replace("#tc", zTc);
                    sql = sql.Replace("#ad1", "'" + zAd + "'");
                    sql = sql.Replace("#soyad", "'" + zSoyad + "'");
                    sql = sql.Replace("#tel", "'" + zTel + "'");
                    sql = sql.Replace("#adres", "'" + zAdres + "'");
                    da.Execute(sql);

                    sql = @"update tbl_kitap set temin_sekli='bağış' where  ISBN_kod=#isbn";
                    sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                    da.Execute(sql);
                    zDgr = "Kaydetme Başarılı";
                }
                else { zDgr = "Sistemde Kitap İSBN kodu"+" "+zIsbn +" "+"Olan Kitap Mevcuttur"; }
            }
            else { zDgr = "Kayıt Zaten Var"; }
        }

        public void guncelle()
        {
            string sql = @"select * from tbl_bagis where kitap_isbn=#isbn";
            sql = sql.Replace("#isbn", "'" + zIsbn + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"update tbl_bagis set bagis_tarih=#bagistarih,bagis_yapan_tc=#tc,bagis_yapan_ad=#ad1,bagis_yapan_soyad=#soyad,bagis_yapan_tel=#tel,bagis_yapan_adres=#adres where kitap_isbn=#isbn";
                sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                sql = sql.Replace("#bagistarih", "'" + zBagistarih + "'");
                sql = sql.Replace("#tc", "'" + zTc + "'");
                sql = sql.Replace("#ad1", "'" + zAd + "'");
                sql = sql.Replace("#soyad", "'" + zSoyad + "'");
                sql = sql.Replace("#tel", "'" + zTel + "'");
                sql = sql.Replace("#adres", "'" + zAdres + "'");
                da.Execute(sql);
                zDgr = "Güncelleme Başarılı";
            }
            else { zDgr = "Sistemde Kitap İSBN kodu" + " " + zIsbn + " " + "Olan Kitap Bulunmamaktadır"; }
        }
        public void sil()
        {
            string sql = @"select * from tbl_bagis where kitap_isbn=#isbn";
            sql = sql.Replace("#isbn", "'" + zIsbn + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"delete from tbl_bagis where kitap_isbn=#isbn";
                sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                da.Execute(sql);
                zDgr = "Silme Başarılı";
            }
            else { zDgr = "Sistemde Kitap İSBN kodu" + " " + zIsbn + " " + "Olan Kitap Bulunmamaktadır"; }

        }
        public void bul()
        {
            string sql = @"select * from tbl_bagis where kitap_isbn=#isbn";
            sql = sql.Replace("#isbn", "'" + zIsbn + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
             
                zAd = dt.Rows[0]["bagis_yapan_ad"].ToString();
                zAdres =dt.Rows[0]["bagis_yapan_adres"].ToString();
                zBagistarih =dt.Rows[0]["bagis_tarih"].ToString();
                zIsbn =dt.Rows[0]["kitap_isbn"].ToString();
                zSoyad =dt.Rows[0]["bagis_yapan_soyad"].ToString();
                zTc =dt.Rows[0]["bagis_yapan_tc"].ToString();
                zTel = dt.Rows[0]["bagis_yapan_tel"].ToString();
              
                zDgr = "Kayıt Bulundu";
            }
            else
            {
                zAd = "";
                zAdres = "";
                zBagistarih = DateTime.Now.ToShortDateString();
                zIsbn = "";
                zSoyad = "";
                zTc = "";
                zTel = "";
                zDgr = "Sistemde Kitap İSBN kodu" + " " + zIsbn + " " + "Olan Kitap Bulunmamaktadır";
            }
        }
    }
}

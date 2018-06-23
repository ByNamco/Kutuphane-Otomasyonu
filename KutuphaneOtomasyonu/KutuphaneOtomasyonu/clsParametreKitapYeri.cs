using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsParametreKitapYeri
    {
        DataAccesLayer da = new DataAccesLayer();
        private string _dgr;

        public string zDgr
        {
            get { return _dgr; }
            set { _dgr = value; }
        }
        private string _id;

        public string zId
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _tanim;

        public string zTanim
        {
            get { return _tanim; }
            set { _tanim = value; }
        }

        public DataTable datagrdDoldur()
        {
            string SQL = @"select * from tbl_kitap_yer order by id";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public void hazirid()
        {
            string SQL = @"select count(id) from tbl_kitap_yer";
            zDgr = da.ExecuteScaler(SQL).ToString();


            if (int.Parse(zDgr) == 0)
            {
                zDgr = "1";
            }
            else
            {
                string sql = @"select max(id) from tbl_kitap_yer";
                zDgr = da.ExecuteScaler(sql).ToString();
                zDgr = (int.Parse(zDgr) + 1).ToString();
            }
        }

        public void sil()
        {

            string sql = @"select * from tbl_kitap_yer where id =#id";
            sql = sql.Replace("#id", "'" + zId + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                string SQL = @"delete from tbl_kitap_yer  where id = #id";
                SQL = SQL.Replace("#id", "'" + zId + "'");
                da.Execute(SQL);
                zDgr = "Silme Başarılı";
            }
            else
            {
                zDgr = "Girdiğiniz İd Sisteme Kayıtlı Değildir";
            }
        }
        public void kaydet()
        {

            string sql = @"select * from tbl_kitap_yer where id =#id";
            sql = sql.Replace("#id", "'" + zId + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                string SQL = @"insert into tbl_kitap_yer values(#id,#tanim)";
                SQL = SQL.Replace("#id", "'" + zId + "'");
                SQL = SQL.Replace("#tanim", "'" + zTanim + "'");
                da.Execute(SQL);
                zDgr = "Kaydetme Başarılı";
            }
            else
            {
                zDgr = "Kayıt Zaten Var";
            }
        }

        public void guncelle()
        {

            string sql = @"select * from tbl_kitap_yer where id =#id";
            sql = sql.Replace("#id", "'" + zId + "'");
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                string SQL = @"update tbl_kitap_yer set id=#id,tanim=#tanim where id=#id";
                SQL = SQL.Replace("#id", "'" + zId + "'");
                SQL = SQL.Replace("#tanim", "'" + zTanim + "'");
                da.Execute(SQL);
                zDgr = "Güncelleme Başarılı";
            }
            else
            {
                zDgr = "Girdiğiniz İd Sisteme Kayıtlı Değildir";
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsKitapVermeIslem
    {
        DataAccesLayer da = new DataAccesLayer();
        private string _no;

        public string zNo
        {
            get { return _no; }
            set { _no = value; }
        }
        private string _tc;

        public string zTc
        {
            get { return _tc; }
            set { _tc = value; }
        }
        private string _iade;

        public string zIade
        {
            get { return _iade; }
            set { _iade = value; }
        }
        private string _verilis;

        public string zVerilis
        {
            get { return _verilis; }
            set { _verilis = value; }
        }
        private string _alinacak;

        public string zAlinacak
        {
            get { return _alinacak; }
            set { _alinacak = value; }
        }
        private string _isbn;

        public string zIsbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        private string _kutuphane;

        public string zKutuphane
        {
            get { return _kutuphane; }
            set { _kutuphane = value; }
        }
        private string _personel;

        public string zPersonel
        {
            get { return _personel; }
            set { _personel = value; }
        }
        private string _dgr;

        public string zDgr
        {
            get { return _dgr; }
            set { _dgr = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT emanet_no AS Emanet_Nosu, uye_tc AS Üye_Tc, verilis_tarih AS Veriliş_Tarih, alinmasi_gereken_tarih AS Alınması_Gereken_Tarih, iade_tarih AS İade_Tarih,kitap_isbn_kod AS Kitap_ISBN_Kod, kutuphane AS Emanet_Verilen_Kutuphane, personel AS Emaneti_Veren_Personel FROM tbl_emanet";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public void emanetver()
        {
            string sql = @"select * from tbl_emanet where emanet_no=#eno";
            sql = sql.Replace("#eno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                sql = @"select * from tbl_kara_liste where uye_tc=#utc and durum='AKTİF'";
                sql = sql.Replace("#utc", "'" + zTc + "'");
                dt = da.ExecuteDataTable(sql);
                if (dt.Rows.Count == 0)
                {

                    sql = @"insert into tbl_emanet values (#eno,#tc,#verilis,#alinacak,'İADE EDİLMEDİ',#isbn,#kutuphane,#personel)";
                    sql = sql.Replace("#eno", zNo);
                    sql = sql.Replace("#tc", "'" + zTc + "'");
                    sql = sql.Replace("#verilis", "'" + zVerilis + "'");
                    sql = sql.Replace("#alinacak", "'" + zAlinacak + "'");
                    sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                    sql = sql.Replace("#kutuphane", "'" + zKutuphane + "'");
                    sql = sql.Replace("#personel", "'" + zPersonel + "'");
                    da.Execute(sql);
                    sql = @"update tbl_kitap set durum='MEVCUT DEĞİL' where ISBN_kod=#isbn";
                    sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                    da.Execute(sql);
                    zDgr = "-- " + zIsbn + " --" + " ISBN Kodlu Kitap" + "-- " + zTc + " --" + "TC li Üyeye Verildi";
                }
                else { zDgr = "Sistemde Tc si" + " " + zTc + " " + "Olan Üyeye Ait Ceza Bulunmaktadır"; }
            }
            else { zDgr = "Sistemde Emanet No su" + " " + zNo + " " + "Olan Kayıt Mevcuttur"; }
        }

        public void guncelle()
        {
            string sql = @"select * from tbl_emanet where emanet_no=#eno";
            sql = sql.Replace("#eno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"update tbl_emanet set uye_tc=#tc,verilis_tarih=#verilis,alinmasi_gereken_tarih=#alinacak,kutuphane=#kutuphane,personel=#personel where emanet_no=#eno";
                sql = sql.Replace("#eno", zNo);
                sql = sql.Replace("#tc", "'" + zTc + "'");
                sql = sql.Replace("#verilis", "'" + zVerilis + "'");
                sql = sql.Replace("#alinacak", "'" + zAlinacak + "'");
                sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                sql = sql.Replace("#kutuphane", "'" + zKutuphane + "'");
                sql = sql.Replace("#personel", "'" + zPersonel + "'");
                da.Execute(sql);
                zDgr = "Güncelleme Başarılı";
            }
            else { zDgr = "Sistemde Emanet No su" + " " + zNo + " " + "Olan Kayıt Bulunmamaktadır"; }
        }
        public void sil()
        {
            string sql = @"select * from tbl_emanet where emanet_no=#eno";
            sql = sql.Replace("#eno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"select kitap_isbn_kod from tbl_emanet where emanet_no=#eno";
                sql = sql.Replace("#eno", zNo);
                dt = da.ExecuteDataTable(sql);
                zIsbn = dt.Rows[0][0].ToString();
                sql = @"update tbl_kitap set durum='MEVCUT' where ISBN_kod=#isbn";
                sql = sql.Replace("#isbn", "'" + zIsbn + "'");
                da.Execute(sql);
                sql = @"delete from tbl_emanet where emanet_no=#eno";
                sql = sql.Replace("#eno", zNo);
                da.Execute(sql);
                zDgr = "Silme Başarılı";
                sql = @"delete from tbl_kara_liste  where id = #id";
                sql = sql.Replace("#id", "'" + zNo + "'");
                da.Execute(sql);
            }
            else { zDgr = "Sistemde Emanet No su" + " " + zNo + " " + "Olan Kayıt Bulunmamaktadır"; }

        }
        public void hazirid()
        {
            string SQL = @"select count(emanet_no) from tbl_emanet";
            zDgr = da.ExecuteScaler(SQL).ToString();


            if (int.Parse(zDgr) == 0)
            {
                zDgr = "1";
            }
            else
            {
                string sql = @"select max(emanet_no) from tbl_emanet";
                zDgr = da.ExecuteScaler(sql).ToString();
                zDgr = (int.Parse(zDgr) + 1).ToString();
            }
        }
        public DataTable iedilmeyensuzme()
        {
            string sql = @"SELECT emanet_no AS Emanet_Nosu, uye_tc AS Üye_Tc, verilis_tarih AS Veriliş_Tarih, alinmasi_gereken_tarih AS Alınması_Gereken_Tarih, iade_tarih AS İade_Tarih,kitap_isbn_kod AS Kitap_ISBN_Kod, kutuphane AS Emaneti_Verilen_Kutuphane, personel AS Emaneti_Veren_Personel FROM tbl_emanet where emanet_no like '#eno%' and uye_tc like '#tc%' and kitap_isbn_kod like '#isbn%' and iade_tarih='İADE EDİLMEDİ'";
            sql = sql.Replace("#eno", zNo);
            sql = sql.Replace("#tc", zTc);
            sql = sql.Replace("#isbn", zIsbn);
            sql = sql.Replace("#iade", zIade);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
        public DataTable iedilensuzme()
        {
            string sql = @"SELECT emanet_no AS Emanet_Nosu, uye_tc AS Üye_Tc, verilis_tarih AS Veriliş_Tarih, alinmasi_gereken_tarih AS Alınması_Gereken_Tarih, iade_tarih AS İade_Tarih,kitap_isbn_kod AS Kitap_ISBN_Kod, kutuphane AS Emaneti_Verilen_Kutuphane, personel AS Emaneti_Veren_Personel FROM tbl_emanet where emanet_no like '#eno%' and uye_tc like '#tc%' and kitap_isbn_kod like '#isbn%' and iade_tarih !='İADE EDİLMEDİ'";
            sql = sql.Replace("#eno", zNo);
            sql = sql.Replace("#tc", zTc);
            sql = sql.Replace("#isbn", zIsbn);
            sql = sql.Replace("#iade", zIade);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"SELECT emanet_no AS Emanet_Nosu, uye_tc AS Üye_Tc, verilis_tarih AS Veriliş_Tarih, alinmasi_gereken_tarih AS Alınması_Gereken_Tarih, iade_tarih AS İade_Tarih,kitap_isbn_kod AS Kitap_ISBN_Kod, kutuphane AS Emaneti_Verilen_Kutuphane, personel AS Emaneti_Veren_Personel FROM tbl_emanet where emanet_no like '#eno%' and uye_tc like '#tc%' and kitap_isbn_kod like '#isbn%'";
            sql = sql.Replace("#eno", zNo);
            sql = sql.Replace("#tc", zTc);
            sql = sql.Replace("#isbn", zIsbn);
            sql = sql.Replace("#iade", zIade);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

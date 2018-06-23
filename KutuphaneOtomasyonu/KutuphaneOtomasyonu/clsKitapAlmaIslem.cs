using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsKitapAlmaIslem
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
        private string _cezaid;

        public string zCezaid
        {
            get { return _cezaid; }
            set { _cezaid = value; }
        }
        private string _cezabaslangic;

        public string zCezabaslangic
        {
            get { return _cezabaslangic; }
            set { _cezabaslangic = value; }
        }
        private string _cezabitis;

        public string zCezabitis
        {
            get { return _cezabitis; }
            set { _cezabitis = value; }
        }
        private string _cezasebep;

        public string zCezasebep
        {
            get { return _cezasebep; }
            set { _cezasebep = value; }
        }
        private string _cezasonuc;

        public string zCezasonuc
        {
            get { return _cezasonuc; }
            set { _cezasonuc = value; }
        }
       
        public DataTable datagrdDoldur()
        {
            string sql = @"SELECT emanet_no AS Emanet_Nosu, uye_tc AS Üye_Tc, verilis_tarih AS Veriliş_Tarih, alinmasi_gereken_tarih AS Alınması_Gereken_Tarih, iade_tarih AS İade_Tarih,kitap_isbn_kod AS Kitap_ISBN_Kod, kutuphane AS Emaneti_Verilen_Kutuphane, personel AS Emaneti_Veren_Personel FROM tbl_emanet where iade_tarih='İADE EDİLMEDİ' order by emanet_no";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"SELECT emanet_no AS Emanet_Nosu, uye_tc AS Üye_Tc, verilis_tarih AS Veriliş_Tarih, alinmasi_gereken_tarih AS Alınması_Gereken_Tarih, iade_tarih AS İade_Tarih,kitap_isbn_kod AS Kitap_ISBN_Kod, kutuphane AS Emaneti_Verilen_Kutuphane, personel AS Emaneti_Veren_Personel FROM tbl_emanet where emanet_no::text like '#eno%' and uye_tc::text like '#tc%' and kitap_isbn_kod::text like '#isbn%' and iade_tarih='İADE EDİLMEDİ' order by emanet_no";
            sql = sql.Replace("#eno", zNo);
            sql = sql.Replace("#tc", zTc);
            sql = sql.Replace("#isbn", zIsbn);
            sql = sql.Replace("#iade", zIade);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
        public void cezakayit()
        {
            string sql = @"select * from tbl_kara_liste where id=#id";
            sql = sql.Replace("#id", zCezaid );
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count  == 0)
            {
                sql = @"insert into tbl_kara_liste values (#id,#tc,#kutuphane,#sebep,#cbaslangic,#cbitis,#sonuc,'AKTİF')";
                sql = sql.Replace("#id", zCezaid);
                sql = sql.Replace("#tc", "'" + zTc + "'");
                sql = sql.Replace("#kutuphane", "'" + zKutuphane + "'");
                sql = sql.Replace("#sebep", "'" + zCezasebep + "'");
                sql = sql.Replace("#cbaslangic", "'" + zCezabaslangic + "'");
                sql = sql.Replace("#cbitis", "'" + zCezabitis + "'");
                sql = sql.Replace("#sonuc", "'" + zCezasonuc + "'");
                da.Execute(sql);
                zDgr = "Kaydetme Başarılı";
            }
            else { zDgr = "Sistemde İD si" + " " + zCezaid  + " " + "Olan Kayıt Mevcuttur"; }

        }
        public void cezabitir()
        {
            string sql = @"select * from tbl_kara_liste where id=#id";
            sql = sql.Replace("#id", zCezaid);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"update tbl_kara_liste set durum ='PASİF' where id=#id";
                sql = sql.Replace("#id", zCezaid);
                da.Execute(sql);
                zDgr = "İşlem Başarılı";
            }
            else { zDgr = "Sistemde İD si" + " " + zCezaid + " " + "Olan Ceza Bulunmamaktadır"; }

        }
        public void cezaguncelle()
        {
            string sql = @"select * from tbl_kara_liste where id=#id";
            sql = sql.Replace("#id", zCezaid);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                sql = @"update tbl_kara_liste set sebep=#sebep,sonuc=#sonuc,ceza_baslangic_tarih=#cbaslangic,ceza_bitis_tarih=#cbitis where id=#id";
                sql = sql.Replace("#id", zCezaid);
                sql = sql.Replace("#sebep", "'" + zCezasebep + "'");
                sql = sql.Replace("#cbaslangic", "'" + zCezabaslangic + "'");
                sql = sql.Replace("#cbitis", "'" + zCezabitis + "'");
                sql = sql.Replace("#sonuc", "'" + zCezasonuc + "'");
                da.Execute(sql);
                zDgr = "Güncelleme Başarılı";
            }
            else { zDgr = "Sistemde İD si" + " " + zCezaid + " " + "Olan Ceza Bulunmamaktadır"; }

        }


        public void emanetal()
        {
            string sql = @"select * from tbl_emanet where emanet_no=#eno and iade_tarih='İADE EDİLMEDİ'";
            sql = sql.Replace("#eno", zNo);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                
                sql = @"update tbl_emanet set iade_tarih=#iade where emanet_no=#eno";
                sql = sql.Replace("#eno", zNo);
                sql = sql.Replace("#iade","'"+ zIade +"'");
                da.Execute(sql);
                sql = @"update tbl_kitap set durum='MEVCUT' where ISBN_kod=#isbn";
                sql = sql.Replace("#isbn","'"+ zIsbn+"'");
                da.Execute(sql);


                zDgr = zDgr = "-- " + zIsbn + " --" + " ISBN Kodlu Kitap" + "-- " + zTc + " --" + "TC li Üyeden Alındı";
            }
            else { zDgr = "Sistemde Emanet No su" + " " + zNo  + " " + "Olup İade Edilmeyen Kayıt Bulunmamaktadır"; }
        }
        private string _usoyad;

        public string zUsoyad
        {
            get { return _usoyad; }
            set { _usoyad = value; }
        }
        private string _uad;

        public string zUad
        {
            get { return _uad; }
            set { _uad = value; }
        }
        private string _kad;

        public string zKad
        {
            get { return _kad; }
            set { _kad = value; }
        }
        private string _yazarr;

        public string zYazarr
        {
            get { return _yazarr; }
            set { _yazarr = value; }
        }
        private string _turr;

        public string zTurr
        {
            get { return _turr; }
            set { _turr = value; }
        }
        public void bul()
        {
            string sql = @"SELECT     tbl_emanet.emanet_no, tbl_uye.ad, tbl_uye.soyad, tbl_emanet.kitap_isbn_kod, tbl_kitap.ad AS kitap_ad, tbl_kitap.yazar, tbl_kitap.tur, tbl_emanet.kutuphane, 
                      tbl_emanet.personel, tbl_emanet.verilis_tarih, tbl_emanet.alinmasi_gereken_tarih, tbl_emanet.iade_tarih, tbl_emanet.uye_tc
FROM         tbl_emanet INNER JOIN
                      tbl_uye ON tbl_emanet.uye_tc = tbl_uye.tc INNER JOIN
                      tbl_kitap ON tbl_emanet.kitap_isbn_kod = tbl_kitap.ISBN_kod
WHERE     (tbl_emanet.iade_tarih = 'İADE EDİLMEDİ') and emanet_no=#eno";
            sql = sql.Replace("#eno", zNo );
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                zNo = dt.Rows[0]["emanet_no"].ToString();
                zTc = dt.Rows[0]["uye_tc"].ToString();
                zUad = dt.Rows[0]["ad"].ToString();
                zUsoyad = dt.Rows[0]["soyad"].ToString();
                zVerilis = dt.Rows[0]["verilis_tarih"].ToString();
                zAlinacak = dt.Rows[0]["alinmasi_gereken_tarih"].ToString();
                zIsbn = dt.Rows[0]["kitap_isbn_kod"].ToString();
                zKad = dt.Rows[0]["kitap_ad"].ToString();
                zYazarr = dt.Rows[0]["yazar"].ToString();
                zTurr = dt.Rows[0]["tur"].ToString();
                zKutuphane = dt.Rows[0]["kutuphane"].ToString();
                zPersonel = dt.Rows[0]["personel"].ToString();
                zDgr = "Kayıt Bulundu";
  
            }
            else
            {

                zTc = "";
                zUad = "";
                zUsoyad = "";
                zVerilis = "";
                zAlinacak = "";
                zIsbn = "";
                zKad = "";
                zYazarr = "";
                zTurr = "";
                zKutuphane = "";
                zPersonel = "";
                zDgr = "Sistemde Emanet Nosu:"+" "+ zNo +" "+"Olan Kayıt Bulunmamaktadır";
  
            }
        }
    }
}

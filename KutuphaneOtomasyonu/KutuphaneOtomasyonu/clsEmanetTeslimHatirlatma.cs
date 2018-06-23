using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsEmanetTeslimHatirlatma
    { 
        DataAccesLayer da = new DataAccesLayer();
        private string _uyetc;

        public string zUyetc
        {
            get { return _uyetc; }
            set { _uyetc = value; }
        }
        private string _isbn;

        public string zIsbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        public bool hatirlat = false;
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT     tbl_emanet.emanet_no AS Emanet_Nosu, tbl_emanet.uye_tc AS Üye_Tc, tbl_uye.ad, tbl_uye.soyad, tbl_uye.tel, tbl_uye.cep_tel, tbl_emanet.verilis_tarih, 
                      tbl_emanet.alinmasi_gereken_tarih, tbl_emanet.iade_tarih, tbl_emanet.kitap_isbn_kod, tbl_emanet.kutuphane, tbl_emanet.personel, tbl_uye.adres, tbl_uye.semt, 
                      tbl_uye.ilce, tbl_uye.il, tbl_uye.email
FROM         tbl_emanet INNER JOIN
                      tbl_uye ON tbl_emanet.uye_tc = tbl_uye.tc
WHERE     (tbl_emanet.alinmasi_gereken_tarih < '#zaman' and tbl_emanet.iade_tarih = 'İADE EDİLMEDİ') order by tbl_emanet.emanet_no";
            DateTime gun = DateTime.Now.Date;
            SQL = SQL.Replace("#zaman", gun.ToString("dd.MM.yyyy"));
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            DateTime iade = new DateTime();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                iade = DateTime.Parse(dt.Rows[i][7].ToString());
                if (iade <= gun)
                {
                    dt.Rows[i][7] += "[Kırmızı]";
                }

            }
            return dt;
        }
        public DataTable datagrdDoldur1()
        {
            string SQL = @"SELECT     tbl_emanet.emanet_no AS Emanet_Nosu, tbl_emanet.uye_tc AS Üye_Tc, tbl_uye.ad, tbl_uye.soyad, tbl_uye.tel, tbl_uye.cep_tel, tbl_emanet.verilis_tarih, 
                      tbl_emanet.alinmasi_gereken_tarih, tbl_emanet.iade_tarih, tbl_emanet.kitap_isbn_kod, tbl_emanet.kutuphane, tbl_emanet.personel, tbl_uye.adres, tbl_uye.semt, 
                      tbl_uye.ilce, tbl_uye.il, tbl_uye.email
FROM         tbl_emanet INNER JOIN
                      tbl_uye ON tbl_emanet.uye_tc = tbl_uye.tc
WHERE     (tbl_emanet.alinmasi_gereken_tarih < '#zaman' and tbl_emanet.alinmasi_gereken_tarih > '#gun' and tbl_emanet.iade_tarih = 'İADE EDİLMEDİ') order by tbl_emanet.emanet_no";
            DateTime gun = DateTime.Now.Date;
            SQL = SQL.Replace("#zaman", gun.AddDays(4).ToString("dd.MM.yyyy"));
            SQL = SQL.Replace("#gun", gun.ToString("dd.MM.yyyy"));
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }

        public DataTable suzme()
         {
             string SQL = @"SELECT     tbl_emanet.emanet_no AS Emanet_Nosu, tbl_emanet.uye_tc AS Üye_Tc, tbl_uye.ad, tbl_uye.soyad, tbl_uye.tel, tbl_uye.cep_tel, tbl_emanet.verilis_tarih, 
                      tbl_emanet.alinmasi_gereken_tarih, tbl_emanet.iade_tarih, tbl_emanet.kitap_isbn_kod, tbl_emanet.kutuphane, tbl_emanet.personel, tbl_uye.adres, tbl_uye.semt, 
                      tbl_uye.ilce, tbl_uye.il, tbl_uye.email
FROM         tbl_emanet INNER JOIN
                      tbl_uye ON tbl_emanet.uye_tc = tbl_uye.tc
WHERE     (tbl_emanet.iade_tarih = 'İADE EDİLMEDİ') and tbl_emanet.uye_tc::text like '#utc%' and tbl_emanet.kitap_isbn_kod::text like '#isbn%' order by tbl_emanet.emanet_no";
             SQL = SQL.Replace("#utc", zUyetc );
             SQL = SQL.Replace("#isbn", zIsbn );
             DataTable dt = new DataTable();
             dt = da.ExecuteDataTable(SQL);
             DateTime gun = DateTime.Now.Date;
             DateTime iade = new DateTime();
             for (int i = 0; i < dt.Rows.Count; i++)
             {
                 iade = DateTime.Parse(dt.Rows[i][7].ToString());
                 if (iade <= gun)
                 {
                     dt.Rows[i][7] += "[Kırmızı]";
                 }
             }
             return dt;
         }
    }
}

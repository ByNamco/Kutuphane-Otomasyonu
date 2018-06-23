using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsBagisListesi
    {
        DataAccesLayer da = new DataAccesLayer();
        private string _isbn;

        public string zIsbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        private string _bytc;

        public string zBytc
        {
            get { return _bytc; }
            set { _bytc = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"SELECT     kitap_isbn AS Kitap_İSBN_Kod, bagis_yapan_tc AS Bağış_Yapan_Tc, bagis_yapan_ad AS Bağış_Yapan_Ad, bagis_yapan_soyad AS Bağış_Yapan_Soyad,  bagis_yapan_tel AS Bağış_Yapan_Telefon, bagis_yapan_adres AS Bağış_Yapan_Adres, bagis_tarih AS Bağış_Tarih FROM tbl_bagis ORDER BY bagis_yapan_ad";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"SELECT     kitap_isbn AS Kitap_İSBN_Kod, bagis_yapan_tc AS Bağış_Yapan_Tc, bagis_yapan_ad AS Bağış_Yapan_Ad, bagis_yapan_soyad AS Bağış_Yapan_Soyad,  bagis_yapan_tel AS Bağış_Yapan_Telefon, bagis_yapan_adres AS Bağış_Yapan_Adres, bagis_tarih AS Bağış_Tarih FROM tbl_bagis where kitap_isbn::text like '#isbn%' and bagis_yapan_tc::text like '#bytc%' ORDER BY bagis_yapan_ad";
            sql = sql.Replace("#isbn", zIsbn );
            sql = sql.Replace("#bytc", zBytc );
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace KutuphaneOtomasyonu
{
    class clsKitapIstatistik
    {
        DataAccesLayer da = new DataAccesLayer();
        private string _isbn;

        public string zIsbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        private string _ad;

        public string zAd
        {
            get { return _ad; }
            set { _ad = value; }
        }
        private string _yazar;

        public string zYazar
        {
            get { return _yazar; }
            set { _yazar = value; }
        }
        private string _tur;

        public string zTur
        {
            get { return _tur; }
            set { _tur = value; }
        }
        private string _yil;

        public string zYil
        {
            get { return _yil; }
            set { _yil = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"Select ISBN_kod,ad,yazar,tur,
(Select Count(*) From tbl_emanet Where kitap_isbn_kod=tbl_kitap.ISBN_kod) Toplam_Okunma,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=01) Ocak,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=02) şubat,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=03) Mart,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=04) Nisan,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=05) Mayıs,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=06) Haziran,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=07) Temmuz,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=08) Ağustos,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=09) Eylül,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=10) Ekim,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=11) Kasım,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=12) Aralık
From tbl_kitap order by Toplam_Okunma desc";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
   
        public DataTable suzme()
        {
            string sql = @"Select ISBN_kod,ad,yazar,tur,
(Select Count(*) From tbl_emanet Where kitap_isbn_kod=tbl_kitap.ISBN_kod and SUBSTRING(verilis_tarih,7,4)=#yil) Toplam_Okunma,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=01 and SUBSTRING(verilis_tarih,7,4)=#yil) Ocak,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=02 and SUBSTRING(verilis_tarih,7,4)=#yil) şubat,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=03 and SUBSTRING(verilis_tarih,7,4)=#yil) Mart,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=04 and SUBSTRING(verilis_tarih,7,4)=#yil) Nisan,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=05 and SUBSTRING(verilis_tarih,7,4)=#yil) Mayıs,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=06 and SUBSTRING(verilis_tarih,7,4)=#yil) Haziran,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=07 and SUBSTRING(verilis_tarih,7,4)=#yil) Temmuz,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=08 and SUBSTRING(verilis_tarih,7,4)=#yil) Ağustos,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=09 and SUBSTRING(verilis_tarih,7,4)=#yil) Eylül,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=10 and SUBSTRING(verilis_tarih,7,4)=#yil) Ekim,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=11 and SUBSTRING(verilis_tarih,7,4)=#yil) Kasım,
		(Select Count(*) From tbl_emanet Where Kitap_isbn_kod=tbl_kitap.ISBN_kod And SUBSTRING(verilis_tarih,4,2)=12 and SUBSTRING(verilis_tarih,7,4)=#yil) Aralık
From tbl_kitap where ISBN_kod like '#isbn%' and ad like '#ad%' and tur like '#tur%' and yazar like '#yazar%' order by Toplam_Okunma desc";
            sql = sql.Replace("#isbn", zIsbn);
            sql = sql.Replace("#yil", zYil);
            sql = sql.Replace("#ad", zAd);
            sql = sql.Replace("#yazar", zYazar);
            sql = sql.Replace("#tur", zTur);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsKutuphaneIstatistik
    {
        DataAccesLayer da = new DataAccesLayer();
        private string _kutuphaneno;

        public string zKutuphaneno
        {
            get { return _kutuphaneno; }
            set { _kutuphaneno = value; }
        }
        private string _ad;

        public string zAd
        {
            get { return _ad; }
            set { _ad = value; }
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
            string SQL = @"Select kutuphane_no,ad,tur,
(Select Count(*) From tbl_emanet Where kutuphane=tbl_kutuphane.ad) Toplam_Kitap_Verme,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=1) Ocak,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=2) Şubat,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=3) Mart,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=4) Nisan,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=5) Mayıs,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=6) Haziran,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=7) Temmuz,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=8) Ağustos,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=9) Eylül,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=10) Ekim,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=11) Kasım,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=12) Aralık
From tbl_kutuphane order by Toplam_Kitap_Verme desc ";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        public DataTable suzme()
        {
            string sql = @"Select kutuphane_no,ad,tur,
(Select Count(*) From tbl_emanet Where kutuphane=tbl_kutuphane.ad and SUBSTRING(verilis_tarih,7,4)=#yil) Toplam_Kitap_Verme,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=01 and SUBSTRING(verilis_tarih,7,4)=#yil) Ocak,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=02 and SUBSTRING(verilis_tarih,7,4)=#yil) Şubat,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=03 and SUBSTRING(verilis_tarih,7,4)=#yil) Mart,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=04 and SUBSTRING(verilis_tarih,7,4)=#yil) Nisan,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=05 and SUBSTRING(verilis_tarih,7,4)=#yil) Mayıs,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=06 and SUBSTRING(verilis_tarih,7,4)=#yil) Haziran,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=07 and SUBSTRING(verilis_tarih,7,4)=#yil) Temmuz,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=08 and SUBSTRING(verilis_tarih,7,4)=#yil) Ağustos,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=09 and SUBSTRING(verilis_tarih,7,4)=#yil) Eylül,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=10 and SUBSTRING(verilis_tarih,7,4)=#yil) Ekim,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=11 and SUBSTRING(verilis_tarih,7,4)=#yil) Kasım,
		(Select Count(*) From tbl_emanet Where Kutuphane=tbl_kutuphane.ad And SUBSTRING(verilis_tarih,4,2)=12 and SUBSTRING(verilis_tarih,7,4)=#yil) Aralık
From tbl_kutuphane where kutuphane_no like '#no%' and ad like '#ad%' and tur like '#tur%' order by Toplam_Kitap_Verme desc";
            sql = sql.Replace("#no", zKutuphaneno);
            sql = sql.Replace("#ad", zAd);
            sql = sql.Replace("#yil", zYil);
            sql = sql.Replace("#tur", zTur);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
        
    }
}

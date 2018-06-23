using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class clsUyeIstatistik
    {
        DataAccesLayer da = new DataAccesLayer();
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
        private string _meslek;

        public string zMeslek
        {
            get { return _meslek; }
            set { _meslek = value; }
        }
        private string _yil;

        public string zYil
        {
            get { return _yil; }
            set { _yil = value; }
        }
        public DataTable datagrdDoldur()
        {
            string SQL = @"Select tc,ad,soyad,meslek,
(Select Count(*) From tbl_emanet Where uye_tc=tbl_uye.tc) Toplam_Kitap_Okuma,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=1) Ocak,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=2) Şubat,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=3) Mart,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=4) Nisan,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=5) Mayıs,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=6) Haziran,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=7) Temmuz,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=8) Ağustos,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=9) Eylül,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=10) Ekim,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=11) Kasım,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=12) Aralık
From tbl_uye
 order by Toplam_Kitap_Okuma desc";
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(SQL);
            return dt;
        }
        
        public DataTable suzme()
        {
            string sql = @"Select tc,ad,soyad,meslek,
(Select Count(*) From tbl_emanet Where uye_tc=tbl_uye.tc and SUBSTRING(verilis_tarih,7,4)=#yil) Toplam_Kitap_Okuma,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=1 and SUBSTRING(verilis_tarih,7,4)=#yil) Ocak,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=2 and SUBSTRING(verilis_tarih,7,4)=#yil) Şubat,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=3 and SUBSTRING(verilis_tarih,7,4)=#yil) Mart,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=4 and SUBSTRING(verilis_tarih,7,4)=#yil) Nisan,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=5 and SUBSTRING(verilis_tarih,7,4)=#yil) Mayıs,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=6 and SUBSTRING(verilis_tarih,7,4)=#yil) Haziran,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=7 and SUBSTRING(verilis_tarih,7,4)=#yil) Temmuz,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=8 and SUBSTRING(verilis_tarih,7,4)=#yil) Ağustos,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=9 and SUBSTRING(verilis_tarih,7,4)=#yil) Eylül,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=10 and SUBSTRING(verilis_tarih,7,4)=#yil) Ekim,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=11 and SUBSTRING(verilis_tarih,7,4)=#yil) Kasım,
		(Select Count(*) From tbl_emanet Where Uye_tc=tbl_uye.tc And SUBSTRING(verilis_tarih,4,2)=12 and SUBSTRING(verilis_tarih,7,4)=#yil) Aralık
From tbl_uye
 where tc like '#tc%' and ad like '#ad%' and soyad like '#soyad%' and meslek like '#meslek%' order by Toplam_Kitap_Okuma desc";
            sql = sql.Replace("#tc", zTc);
            sql = sql.Replace("#ad", zAd);
            sql = sql.Replace("#yil", zYil);
            sql = sql.Replace("#soyad", zSoyad);
            sql = sql.Replace("#meslek", zMeslek);
            DataTable dt = new DataTable();
            dt = da.ExecuteDataTable(sql);
            return dt;
        }
    }
}

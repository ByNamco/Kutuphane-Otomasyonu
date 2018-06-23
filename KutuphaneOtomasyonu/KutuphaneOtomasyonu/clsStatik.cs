using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KutuphaneOtomasyonu
{
    class clsStatik
    {
        private static string _tc;

        public static string zTc
        {
            get { return clsStatik._tc; }
            set { clsStatik._tc = value; }
        }
        private static string _ad;

        public static string zAd
        {
            get { return clsStatik._ad; }
            set { clsStatik._ad = value; }
        }
        private static string _soyad;

        public static string zSoyad
        {
            get { return clsStatik._soyad; }
            set { clsStatik._soyad = value; }
        }
        private static string _isbn;

        public static string zIsbn
        {
            get { return clsStatik._isbn; }
            set { clsStatik._isbn = value; }
        }
        private static string _kad;

        public static string zKad
        {
            get { return clsStatik._kad; }
            set { clsStatik._kad = value; }
        }
        private static string _yazar;

        public static string zYazar
        {
            get { return clsStatik._yazar; }
            set { clsStatik._yazar = value; }
        }
        private static string _tur;

        public static string zTur
        {
            get { return clsStatik._tur; }
            set { clsStatik._tur = value; }
        }
        private static string _id;

        public static string zId
        {
            get { return clsStatik._id; }
            set { clsStatik._id = value; }
        }
        private static string _sebep;

        public static string zSebep
        {
            get { return clsStatik._sebep; }
            set { clsStatik._sebep = value; }
        }
        private static string _sonuc;

        public static string zSonuc
        {
            get { return clsStatik._sonuc; }
            set { clsStatik._sonuc = value; }
        }
        private static string _baslangic;

        public static string zBaslangic
        {
            get { return clsStatik._baslangic; }
            set { clsStatik._baslangic = value; }
        }
        private static string _bitis;

        public static string zBitis
        {
            get { return clsStatik._bitis; }
            set { clsStatik._bitis = value; }
        }

    }
}

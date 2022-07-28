using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;





namespace OgrenciYonetimSistemiG012
{
    class Ogrenci
    {//DEĞİŞKEN VE GET SET ENUMLARIN OLDUĞU KISIMLAR

        public int No;                                 // ogrenci 1  ---> Ogrenci new0
        public string Ad;                              // ogrenci 2
        public string Soyad;                           // ogrenci 3
        public DateTime DogumTarihi;                   // ogrenci 4
        public CINSIYET Cinsiyet;                      // ogrenci 5
        public SUBE Sube;                              // ogrenci 6
        //public string Aciklama;
        Okul Okul = new Okul();
        public List<OgrenciAdresi> adres = new List<OgrenciAdresi>();
        public List<string> Kitaplar = new List<string>();
        public List<DersNotu> Notlar = new List<DersNotu>();
        public double Ort;
        public List<string> Aciklama = new List<string>();
        public double NotOrt
        {
            get
            {
                Double ort;
                Double sonuc = 0;
                foreach (DersNotu item in this.Notlar)
                {
                    sonuc += item.Not;
                }
                ort = sonuc / this.Notlar.Count;
                this.Ort = ort;
                return ort;
            }
            
        }


        public Ogrenci()
        {

        }
        public Ogrenci(int No, string Ad, string Soyad, DateTime DogumTarihi,
            CINSIYET Cinsiyet, SUBE Sube)
        {
            this.Kitaplar = new List<string>();
            this.Notlar = new List<DersNotu>();
            this.adres = new List<OgrenciAdresi>();
            this.Aciklama = new List<string>();
            this.No = No;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.DogumTarihi = DogumTarihi;
            this.Cinsiyet = Cinsiyet;
            this.Sube = Sube;
        }

        
    }


    public enum DERS_ADI
    {
        Empty,
        Türkçe,
        Matematik,
        Fen,
        Sosyal
    }
    public enum SUBE
    {
        Empty,
        A,
        B,
        C,
        D
    }

    public enum CINSIYET
    {
        Empty,
        Kiz,
        Erkek
    }

}

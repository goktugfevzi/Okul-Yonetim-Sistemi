using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgrenciYonetimSistemiG012
{
    class Okul
    {



        //List<Ogrenci> Ogrenciler;
        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        //public List<Ogrenci> Ogrenci_Liste
        //{
        //    get
        //    {
        //        return Ogrenciler;
        //    }
        //}

        //Ogrenci o = new Ogrenci();  <-----STACK OVERFLOW. SAKIN YABMA
        // public List<DersNotu> DersNotlari = new List<DersNotu>();

        public void OgrenciEkle(int ogrenciNo, string Ad, string Soyad, DateTime
            DogumTarihi, CINSIYET Cinsiyet
           , SUBE Sube)
        {
            Ogrenci o = new Ogrenci();
            o.Ad = Ad;
            o.No = ogrenciNo;
            o.Soyad = Soyad;
            o.DogumTarihi = DogumTarihi;
            o.Cinsiyet = Cinsiyet;
            o.Sube = Sube;
            Ogrenciler.Add(o);

        }
        public void DogumTarihListele(DateTime tarih)
        {                                                                               // <0 − If date1 is earlier than date2
                                                                                        // 0 − If date1 is the same as date2
            List<Ogrenci> TariheGore = new List<Ogrenci>();                             // >0 − If date1 is later than date2
            foreach (Ogrenci item in Ogrenciler)                                        // (1998,2000) --> pozitif
            {                       //büyük olacak       küçük olacak                                              
                if (DateTime.Compare(item.DogumTarihi, tarih) > 0)
                {
                    TariheGore.Add(item);
                }
            }
            if (TariheGore.Count != 0)
            {
                OgrenciListele(TariheGore);
            }
            else
            {
                Console.WriteLine("Bu Tarihten Sonra Doğan Öğrenci Yok");
                //u.DogumTarihineGore();
            }
        }
        public void CinsiyetListele(CINSIYET cinsiyet)
        {
            List<Ogrenci> CinsiyeteGore = new List<Ogrenci>();
            foreach (Ogrenci item in Ogrenciler)
            {
                if (item.Cinsiyet == cinsiyet)
                {
                    CinsiyeteGore.Add(item);
                }
            }
            if (CinsiyeteGore.Count != 0)
            {
                OgrenciListele(CinsiyeteGore);
            }
            else
            {
                Console.WriteLine("Bu Cinsiyete Sahip Öğrenci Yok");
            }
        }
        public void SubeListele(SUBE sube)
        {
            //Ogrenci o = this.Ogrenciler.Where(a => a.Sube == SUBE.B).FirstOrDefault();
            List<Ogrenci> Subesi = new List<Ogrenci>();

            foreach (Ogrenci item in Ogrenciler)
            {

                if (item.Sube == sube)
                {
                    Subesi.Add(item);

                }
                //Subesi.CopyTo(Subesi2);
            }
            if (Subesi.Count != 0)
            {
                OgrenciListele(Subesi);
            }
            else
            {
                Console.WriteLine("Öğrenci bulunamamaktadır.");

            }

        }


        public void OgrenciListele5()
        {
            OgrenciListele(Ogrenciler);
        }
        public void NotEkle(int ogrenciNo, DERS_ADI dersAdi, int not)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            o.Notlar.Add(new DersNotu(Convert.ToString(dersAdi), not));
            foreach (DersNotu item in o.Notlar)
            {
                Console.WriteLine(item.DersAdi + item.Not);
            }
            Console.WriteLine(o.Notlar.Count);
            //o.Notlar = new List<DersNotu>();
            //foreach (Ogrenci item in Ogrenciler)
            //{
            //    if (item.No == ogrenciNo)
            //    {
            //        DersNotu dn = new DersNotu();
            //        dn.DersAdi = Convert.ToString(dersAdi);
            //        dn.Not = not;
            //        item.Notlar.Add(dn);
            //        //DersNotlari.Add(dn);

            //    }
            //}
            //o.Notlar.Add(new DersNotu(Convert.ToString(dersAdi), not));



            //foreach  (Ogrenci item in Notlar )
            //{
            //    Console.WriteLine(o.Notlar.);
            //}
            //öğrencinin türkçe ders notlarının ortalaması.
            //Ogrenci o2 = new Ogrenci();
            //double turkceOrtalama = .Notlar.Where(a => a.DersAdi == "Türkçe").Average(a => a.Not);
            //o.Kitaplar = new List<string>();
        }

        public void AdresEkle(int No, string Il, string Ilce, string Mahalle)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == No).FirstOrDefault();
            o.adres.Add(new OgrenciAdresi(Il, Ilce, Mahalle));
            Console.WriteLine("Adres Eklendi.");
        }

        public void ListeleBunu(int no)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            List<Ogrenci> GeciciListe = new List<Ogrenci>();
            GeciciListe.Add(o);
            OgrenciListele(GeciciListe);

        }
        public void KitapEkle(int No)
        {
            string KitapAdi = "";
            Ogrenci o = this.Ogrenciler.Where(a => a.No == No).FirstOrDefault();
            Console.WriteLine("Eklemek istediğiniz kitap adedi :");
            int adet = int.Parse(Console.ReadLine());
            for (int i = 0; i < adet; i++)
            {
                while (true)
                {
                    Console.Write((i + 1) + ". Kitabı girin: ");
                    KitapAdi = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(KitapAdi))
                    {
                        Console.WriteLine("Lütfen bir kitap adı giriniz: ");
                        continue;
                    }
                    else
                    {
                        o.Kitaplar.Add(KitapAdi);
                        break;
                    }
                }
            }

            Console.WriteLine("Kitap Eklenmiştir.");


            //Uygulama u = new Uygulama();
            //Ogrenci ogrenci = this.Ogrenciler.Where(r => r.No == no).FirstOrDefault();
            //Console.WriteLine(ogrenci.No + " numaralı öğrencinin açıklaması: ");
            //string aciklama = Console.ReadLine();
            //ogrenci.Aciklama.Add(aciklama);
            //Console.WriteLine();
            //Console.WriteLine("Açıklama eklenmiştir.");


        }

        //public double NotOrt(Ogrenci o)
        //{

        //    Double sonuc = 0;


        //    foreach (DersNotu item in o.Notlar)
        //    {
        //        sonuc += item.Not;
        //    }

        //    return sonuc / o.Notlar.Count;

        //}

        public void NotYazdirma(int no)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            Console.WriteLine("Dersin Adı       Notu");
            Console.WriteLine("-------------------- -");
            foreach (DersNotu item in o.Notlar)
            {
                Console.WriteLine(item.DersAdi.PadRight(10) + " " + item.Not);
            }
            //Türkçe			50
            //Türkçe			90
            //Matematik		29
        }
        public void KitapListeleme(int no)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            if (o.Kitaplar.Count != 0)
            {
                List<string> o_kitaplar = new List<string>();
                o_kitaplar = o.Kitaplar.ToList();


                int a = 1;
                foreach (string item in o_kitaplar)
                {
                    Console.WriteLine(a + ". Okuduğu Kitap : " + item);
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine();
                    a++;
                }
            }
            else
            {
                Console.WriteLine("Öğrencinin okuduğu kitap bulunmamaktadır.");
            }
            //for (int i = 0; i < o_kitaplar.Count; i++)
            //{
            //    Console.WriteLine((i + 1) + ". Okuduğu Kitap :");
            //    Console.WriteLine(o_kitaplar[i]);
            //    Console.WriteLine("--------------------------------");
            //    Console.WriteLine();
            //}
        }

        public void SonOkunanKitap(int no)
        {
            Ogrenci o = this.Ogrenciler.Where(r => r.No == no).FirstOrDefault();
            if (o.Kitaplar.Count != 0)
            {
                string kitap = o.Kitaplar.LastOrDefault();
                Console.WriteLine(o.Ad + " isimli öğrencinin en son okuduğu kitap : ");
                Console.WriteLine(kitap);
            }
            else
            {
                Console.WriteLine("Öğrencinin okuduğu kitap bulunmamaktadır.");
            }

        }
        //public void AciklamaGor(int no)
        //{
        //    Ogrenci o = this.Ogrenciler.Where(r => r.No == no).FirstOrDefault();
        //    List<string> o_aciklama = new List<string>();
        //    o_aciklama = o.Aciklama.ToList();
        //    for (int i = 0; i < o_aciklama.Count; i++)
        //    {
        //        Console.WriteLine((i + 1) + ". Açıklama:");
        //        Console.WriteLine(o_aciklama[i]);
        //        Console.WriteLine("--------------------------------");
        //        Console.WriteLine();
        //    }

        public void SemtListele()
        {/*Ogrenci o = this.Ogrenciler.OrderBy()*/
            Console.WriteLine("-----------Adres Görüntüleme--------");
            foreach (Ogrenci item in Ogrenciler)
            {
                if (item.adres.Count != 0)
                {
                    Console.WriteLine("Ad   : " + item.Ad);
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Adres : ");

                    foreach (OgrenciAdresi item2 in item.adres)
                    {
                        Console.WriteLine("İL : " + item2.il);
                        Console.WriteLine("İLÇE : " + item2.ilce);
                        Console.WriteLine("MAHALLE : " + item2.mahalle);
                    }
                }

            }

        }
        public void OgrenciListele(List<Ogrenci> Ogrenciler)
        {
            //Ogrenci o = new Ogrenci();

            Console.WriteLine("Sube".PadRight(15) + "No".PadRight(14) + "Adı Soyadı".PadRight(15) + "Not Ort.".PadRight(16) + "Okuduğu Kitap Say.".PadRight(15));
            Console.WriteLine("--------------------------------------------------------------------------------------");
            foreach (Ogrenci item in Ogrenciler)
            {

                string Sube = Convert.ToString(item.Sube).Trim();
                Double notOrt = item.NotOrt;


                string satir = string.Format("{0}" + "{1}" + "{2}" + " " + "{3}" + "{4}" + "{5}", Convert.ToString(item.Sube).PadRight(15),
                    Convert.ToString(item.No).PadRight(14), item.Ad, item.Soyad.PadRight(16)
                   , Convert.ToString(notOrt).PadRight(15), Convert.ToString(item.Kitaplar.Count).PadRight(10));
                Console.WriteLine(satir);

            }

        }

        public void SinifNotOrt()
        {
            Console.WriteLine("---------Sınıf ortalaması Görüntüleme-------");
            double ort;
            foreach (Ogrenci item in Ogrenciler)
            {
                ort = item.NotOrt;

            }
            Console.WriteLine("Ortalamasını görmek istediğiniz sınıfın şubesi: ");
            string sinif = Console.ReadLine().ToUpper();
            SUBE subem = SinifAl2();
            ort = this.Ogrenciler.Where(r => r.Sube == subem).Average(r => r.Ort);
            Console.WriteLine(sinif + " sınıfının ortalaması: " + ort);
        }




        public void OgrenciGuncelle(int no)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            Console.Write("Öğrencinin adı: ");
            string isim = Console.ReadLine();
            if (!(string.IsNullOrWhiteSpace(isim))) o.Ad = isim;
            Console.Write("Öğrencinin soyadı: ");
            string soyad = Console.ReadLine();
            if (!(string.IsNullOrWhiteSpace(soyad))) o.Soyad = soyad;
            while (true)
            {

                try
                {
                    Console.Write("Öğrencinin doğum tarihi(YIL,AY,GUN): ");
                    string dogumtarihi = Console.ReadLine();
                    if (!(string.IsNullOrWhiteSpace(dogumtarihi))) o.DogumTarihi = Convert.ToDateTime(dogumtarihi);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen doğru giriş yapınız.");
                }
            }
            Console.Write("Öğrencinin cinsiyeti(K/E): ");
            string cinsiyet = Console.ReadLine().ToUpper();
            if (!(string.IsNullOrWhiteSpace(cinsiyet)))
            {
                bool kontrol = true;
                while (kontrol)
                {
                    switch (cinsiyet)
                    {
                        case "E":
                            o.Cinsiyet = CINSIYET.Erkek;
                            kontrol = false;
                            break;
                        case "K":
                            o.Cinsiyet = CINSIYET.Kiz;
                            kontrol = false;
                            break;
                        default:
                            Console.WriteLine("Yanlış bir değer girdiniz.Lütfen tekrar deneyin.");
                            break;
                    }
                }
            }

            SUBE sube = SinifAl2();
            string subem = Convert.ToString(sube);
            if (!(string.IsNullOrWhiteSpace(subem)))
            {
                o.Sube = sube;
            }
            Console.WriteLine(" Öğrenci güncellendi.");
        }



        //Öğrencinin adı:...
        //    Öğrencinin soyadı:...
        //    Öğrencinin doğum tarihi:...
        //    Öğrencinin cinsiyeti(K/E):
        //         Yanlış bir değer girdiniz.Lütfen tekrar deneyin.
        //    Öğrencinin cinsiyeti(K/E):
        //    Öğrencinin sınıf şubesi:
        //    (Hiç bir veri girmeden “Enter” tışına basılırsa, o özellik 
        //    değiştirilmeden sonraki özellik sorulacaktır.)

        //   

        public void OgrenciSil(int No)
        {
            Ogrenci Silinecek;
            //foreach (Ogrenci item in Ogrenciler)
            //{
            //    if(item.No== No)
            //    {
            //        Silinecek = item;
            //        Ogrenciler.Remove(Silinecek);
            //        Console.WriteLine("Öğrenci Silindi.");
            //        break;
            //    }
            //}
            Silinecek = this.Ogrenciler.Where(r => r.No == No).FirstOrDefault();
            Ogrenciler.Remove(Silinecek);
            Console.WriteLine("Öğrenci Silindi.");

        }


        public void BasariliSirala(string Secim, int sayi)
        {
            List<Ogrenci> Basarili = new List<Ogrenci>();
            if (Secim == "basarili")
            {
                Console.WriteLine("-Okuldaki En başarılı 5 öğrenciyi listele-");
                Basarili = this.Ogrenciler.OrderByDescending(t => t.NotOrt).Take(sayi).ToList();
            }
            else
            {
                Console.WriteLine("-Okuldaki En başarısız 3 öğrenciyi listele-");
                Basarili = this.Ogrenciler.OrderBy(t => t.NotOrt).Take(sayi).ToList();

            }

            OgrenciListele(Basarili);
        }
        public void SubeBasariliSirala(SUBE sube, int sayi, string secim)
        {
            List<Ogrenci> Basarili = new List<Ogrenci>();
            if (secim == "basarili")
            {
                Basarili = this.Ogrenciler.Where(i => i.Sube == sube).OrderByDescending(t => t.NotOrt).Take(sayi).ToList();
            }
            else
            {
                Basarili = this.Ogrenciler.Where(i => i.Sube == sube).OrderBy(t => t.NotOrt).Take(sayi).ToList();
            }

            OgrenciListele(Basarili);
        }
        public SUBE SinifAl(string secim)
        {
            SUBE sube = SUBE.Empty;
            bool kont2 = true;
            while (kont2)
            {
                //Console.WriteLine("Hangi Sube Listelensin : ");              

                switch (secim)
                {
                    case "A":
                        sube = SUBE.A;
                        kont2 = false;
                        break;

                    case "B":
                        sube = SUBE.B;
                        kont2 = false;
                        break;

                    case "C":
                        sube = SUBE.C;
                        kont2 = false;
                        break;
                    case "D":
                        sube = SUBE.D;
                        kont2 = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                        break;
                }
            }
            return sube;
        }

        public SUBE SinifAl2()
        {
            SUBE sube = SUBE.Empty;
            bool kont = true;
            while (kont)
            {
                Console.Write("Öğrencinin şubesi: ");
                string secim = Console.ReadLine().ToUpper();
                switch (secim)
                {
                    case "A":
                        sube = SUBE.A;
                        kont = false;
                        break;

                    case "B":
                        sube = SUBE.B;
                        kont = false;
                        break;

                    case "C":
                        sube = SUBE.C;
                        kont = false;
                        break;
                    case "D":
                        sube = SUBE.D;
                        kont = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                        break;
                }
            }
            return sube;
        }

        public SUBE SinifAl3()
        {
            SUBE sube = SUBE.Empty;
            bool kont = true;
            while (kont)
            {
                Console.Write(" Hangi Şube : ");
                string secim = Console.ReadLine().ToUpper();
                switch (secim)
                {
                    case "A":
                        sube = SUBE.A;
                        kont = false;
                        break;

                    case "B":
                        sube = SUBE.B;
                        kont = false;
                        break;

                    case "C":
                        sube = SUBE.C;
                        kont = false;
                        break;
                    case "D":
                        sube = SUBE.D;
                        kont = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                        break;
                }
            }
            return sube;
        }


        public void AciklamaGir(int no)
        {
            Uygulama u = new Uygulama();
            Ogrenci ogrenci = this.Ogrenciler.Where(r => r.No == no).FirstOrDefault();
            Console.WriteLine(ogrenci.No + " numaralı öğrencinin açıklaması: ");
            string aciklama = Console.ReadLine();
            ogrenci.Aciklama.Add(aciklama);
            Console.WriteLine();
            Console.WriteLine("Açıklama eklenmiştir.");

        }

        public void AciklamaGor(int no)
        {
            Ogrenci o = this.Ogrenciler.Where(r => r.No == no).FirstOrDefault();
            List<string> o_aciklama = new List<string>();
            o_aciklama = o.Aciklama.ToList();
            for (int i = 0; i < o_aciklama.Count; i++)
            {
                Console.WriteLine((i + 1) + ". Açıklama:");
                Console.WriteLine(o_aciklama[i]);
                Console.WriteLine("--------------------------------");
                Console.WriteLine();
            }
        }

    }
}

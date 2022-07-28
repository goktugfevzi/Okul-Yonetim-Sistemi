using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgrenciYonetimSistemiG012
{
    class Uygulama
    {//BURADA MENU OLACAK FONSİYONLARIN KABA HALLERİ OLACAK KARMAŞIK OLAN KISIMLAR DEĞİL ÖZELLEŞTİRİLMİŞ KISIMLAR
        //BURDA OLACAK
        Ogrenci Ogrenci = new Ogrenci();
        Okul Okul = new Okul();
        SUBE sube;
        CINSIYET cinsiyet;
        DERS_ADI DersAdi;
        //List<Ogrenci> Ogrenciler;
        public void Calistir()
        {
            SahteVeriGir();
            bool Kont = true;
            bool kont_2 = true;
            Menu();


            //if (e.KeyCode == Keys.Enter)
            //{
            //    Console.WriteLine("Entere Basıldı");
            //}
            while (Kont)
            {
                string yanit;
                string giris = Console.ReadLine();
                switch (giris)
                {
                    case "1":
                        OgrenciEkleme();//TAMAMLANDI
                        break;
                    case "2":
                        NotGir();//TAMAMLANDI
                        break;
                    case "3":
                        OrtalamaGor();//TAMAMLNDI
                        break;
                    case "4":
                        AdresGir();//TAMAMLANDI
                        break;
                    case "5":
                        Okul.OgrenciListele(Okul.Ogrenciler);//TAMAMLANDI
                        break;
                    case "6":
                        SubeListeleme();//TAMAMLANDI
                        break;
                    case "7":
                        NotGoruntule();//TAMAMLANDI
                        break;
                    case "8":
                        Okul.SinifNotOrt();//TAMAMLANDI
                        break;
                    case "9":
                        CinsiyeteGore();//TAMAMLANDI 
                        break;
                    case "10":
                        DogumTarihineGore();//TAMAMLANDI 
                        break;
                    case "11":
                        Okul.SemtListele();//TAMAMLANDI
                        break;
                    case "12":
                        Okul.BasariliSirala("basarili", 5);//TAMAMLANDI
                        break;
                    case "13":
                        Okul.BasariliSirala("Basarisiz", 3);//TAMAMLANDI
                        break;
                    case "14":
                        SubeyeGoreBasari("Basarili");//TAMAMNLANDI
                        break;
                    case "15":
                        SubeyeGoreBasari("Basarisiz");//TAMAMNLANDI         
                        break;
                    case "16":
                        AciklamaGirme();//TAMAMLANDI
                        break;
                    case "17":
                        AciklamaGorme();//TAMAMLANDI
                        break;
                    case "18":
                        KitapGir();//TAMAMLANDI 
                        break;
                    case "19":
                        KitapListele();//TAMAMLANDI
                        break;
                    case "20":
                        SonKitabiListele();//TAMAMLANDI
                        break;
                    case "21":
                        OgrenciSilme();//TAMAMLANDI
                        break;
                    case "22":
                        OgrenciGuncelleme();//TAMAMLANDI
                        break;
                }
                Console.WriteLine("Menüyü tekrar listelemek için “liste”, çıkış yapmak için “çıkış” yazın.");
                while (kont_2)
                {
                    Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
                    yanit = Console.ReadLine().ToLower();
                    if (yanit == "liste")
                    {
                        Kont = true;
                        kont_2 = false;
                    }
                    else if (yanit == "çıkış")
                    {
                        kont_2 = false;
                        Kont = false;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                    }
                }



            }


        }
        public void SonKitabiListele()
        {
            Console.WriteLine("20-Öğrencinin okuduğu son kitabı görüntüle-----------------------------------");
            Console.Write("Son Okuduğu Kitabı Görmek İstediğiniz ");
            int no = KontrolsuzNoIste();
            Okul.SonOkunanKitap(no);
        }

        public void KitapListele()
        {
            Console.WriteLine("19-Öğrencinin okuduğu kitapları listele-------------------------------------");
            Console.Write("Okuduğu Kitapları Görmek İstediğiniz ");
            int no = KontrolsuzNoIste();
            Okul.KitapListeleme(no);
        }
        public void SubeyeGoreBasari(string basari)
        {
            if (basari == "Basarili")
            {
                Console.WriteLine("14-Sınıftaki En başarılı 5 öğrenciyi listele--------------------------");
                Console.WriteLine("Hangi Sınıftaki En başarılı 5 öğrenciyi listelensin : ");
                sube = Okul.SinifAl3();
                Okul.SubeBasariliSirala(sube, 5, "basarili");
            }
            else
            {
                Console.WriteLine("15-Sınıftaki  En başarısız 3 öğrenciyi listele--------------------------");
                Console.WriteLine("Hangi Sınıftaki En başarısız 3 öğrenciyi listelensin : ");
                sube = Okul.SinifAl3();
                Okul.SubeBasariliSirala(sube, 3, "basarisiz");
            }
        }
        public void AciklamaGirme()
        {
            Console.WriteLine("16-Öğrenci için açıklama gir----------------------------");
            Console.WriteLine("Açıklamasını Girmek İstediğiniz Öğrencinin No :");
            int no = KontrolsuzNoIste();
            Console.WriteLine();
            Okul.AciklamaGir(no);
        }
        public void AciklamaGorme()
        {
            Console.WriteLine("17-Öğrencinin açıklamasını gör-----------------------------");
            Console.WriteLine("Açıklamasını Görmek İstediğiniz Öğrencinin No :");
            int no = KontrolsuzNoIste();
            Console.WriteLine();
            Okul.AciklamaGor(no);
        }
        public void DogumTarihineGore()
        {
            Console.WriteLine("----------Doğum Tarihine Göre Görüntüleme------------");
            bool kontrol = true;
            while (kontrol)
            {
                Console.Write("  Listelenmesini istediğiniz Yıl (YIL,AY,GUN) : ");
                string tarihStr = Console.ReadLine();
                DateTime DogumTarihi;
                bool sonuc = DateTime.TryParse(tarihStr, out DogumTarihi);
                if (sonuc)
                {
                    Okul.DogumTarihListele(DogumTarihi);
                    kontrol = false;
                }
                else
                {
                    Console.WriteLine("Lütfen tarihi doğru bir şekilde giriniz!");
                }
            }


        }
        public void CinsiyeteGore()
        {
            Console.WriteLine("--------Cinsiyete Göre Göürntüleme-----------");
            bool kontrol = true;
            while (kontrol)
            {
                Console.WriteLine("Listelemek İstediğiniz Cinsiyeti seciniz : ");
                string secim = Console.ReadLine().ToUpper();
                switch (secim)
                {
                    case "E":
                        cinsiyet = CINSIYET.Erkek;
                        kontrol = false;
                        break;
                    case "K":
                        cinsiyet = CINSIYET.Kiz;
                        kontrol = false;
                        break;
                    default:
                        Console.WriteLine("Yanlış bir değer girdiniz.Lütfen tekrar deneyin.");
                        break;
                }
            }
            Okul.CinsiyetListele(cinsiyet);

        }
        public void NotGoruntule()
        {
            Console.WriteLine("------Not Görüntüleme---------");
            Console.WriteLine("Öğrencinin notlarını görüntüle------------------------------------");
            int no = KontrolsuzNoIste();
            Okul.NotYazdirma(no);
        }

        public void OgrenciSilme()
        {
            Console.WriteLine("21-Öğrenci Sil --------------------------------");
            Console.Write("Silmek İstediğiniz ");
            int no = KontrolsuzNoIste();
            Okul.OgrenciSil(no);
        }


        public void OgrenciGuncelleme()
        {
            Console.WriteLine("22-Öğrenci Güncelle ------------------------------------------");
            Console.WriteLine("Güncellemek İstediğiniz :");
            int no;
            while (true)
            {

                try
                {
                    Console.Write("Öğrencinin numarası:");
                    no = int.Parse(Console.ReadLine());
                    if (NoKontrol(no))
                    {
                        Okul.OgrenciGuncelle(no);
                    }
                    else
                    {
                        Console.WriteLine("Bu numarada bir öğrenci yok.");
                        // eğer numara yanlış girilmişse patlıyor ve switch case döngüsüne devam ediliyor.
                        return;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen doğru giriş yapınız.");
                }
            }


        }




        public void OrtalamaGor()
        {
            Console.WriteLine("-----Ortalama Görüntüleme-------");
            Console.WriteLine("Ortalamasını Görmek İstediğiniz Öğrencinin No :");
            int no = KontrolsuzNoIste();
            Okul.ListeleBunu(no);

        }
        public void AdresGir()
        {
            Console.WriteLine("  --------------- Öğrencinin adresini gir -------------------------");

            int no = KontrolsuzNoIste();
            Console.WriteLine("  İl: ...");
            string Il = Console.ReadLine();
            Console.WriteLine("  İlçe: ...");
            string Ilce = Console.ReadLine();
            Console.WriteLine("  Mahalle: ...");
            string Mahalle = Console.ReadLine();
            Okul.AdresEkle(no, Il, Ilce, Mahalle);

        }
        public void SubeListeleme()
        {
            Console.WriteLine("-------Şubeye Göre Öğrenci Listeleme------");

            sube = Okul.SinifAl3();
            Okul.SubeListele(sube);
        }


        public void SahteVeriGir()
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Hasan";
            o1.Cinsiyet = CINSIYET.Erkek;
            o1.DogumTarihi = new DateTime(1999, 5, 5);
            o1.No = 2;
            o1.Soyad = "Hüseyin";
            o1.Sube = SUBE.B;
            //string a = "eskişehir";
            //string b = "kayseri";
            //string c = "adana";
            o1.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Türkçe), 50));
            o1.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Matematik), 50));
            o1.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Matematik), 70));
            o1.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Türkçe), 80));
            o1.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Türkçe), 30));
            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Ahmet";
            o2.Cinsiyet = CINSIYET.Erkek;
            o2.DogumTarihi = new DateTime(1998, 6, 6);
            o2.No = 1;
            o2.Soyad = "Cem";
            o2.Sube = SUBE.B;
            o2.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Türkçe), 55));
            o2.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Matematik), 90));
            o2.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Matematik), 20));
            o2.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Türkçe), 70));
            o2.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Fen), 60));
            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Ceydq";
            o3.Cinsiyet = CINSIYET.Erkek;
            o3.DogumTarihi = new DateTime(199, 3, 8);
            o3.No = 3;
            o3.Soyad = "Abdul";
            o3.Sube = SUBE.B;
            o3.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Türkçe), 60));
            o3.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Matematik), 90));
            o3.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Matematik), 60));
            o3.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Türkçe), 70));
            o3.Notlar.Add(new DersNotu(Convert.ToString(DERS_ADI.Sosyal), 90));
            Okul.Ogrenciler.Add(o1);
            Okul.Ogrenciler.Add(o2);
            Okul.Ogrenciler.Add(o3);

        }

        public void OgrenciEkleme()
        {
            Console.WriteLine("-Yeni Öğrenci Ekle-");

            string ad, soyad;
            Console.WriteLine("   Öğrenci Ekle---------------------------------------------");

            int no;
            while (true)
            {

                try
                {
                    Console.Write("Öğrencinin numarası:");
                    no = int.Parse(Console.ReadLine());
                    break;


                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen doğru giriş yapınız.");
                }
            }


            Console.Write("  Öğrencinin adı:...");
            ad = Console.ReadLine();
            Console.Write("  Öğrencinin soyadı:...");
            soyad = Console.ReadLine();
            DateTime DogumTarihi;
            while (true)
            {
                Console.Write("  Öğrencinin doğum tarihi (YIL,AY,GUN) : ...");
                string tarihStr = Console.ReadLine();
                bool sonuc = DateTime.TryParse(tarihStr, out DogumTarihi);
                if (!(sonuc))
                {
                    Console.WriteLine("Lütfen tarihi doğru bir şekilde yazınız!");
                }
                else
                {
                    break;
                }
            }


            bool kont = true;
            while (kont)
            {

                Console.Write("  Öğrencinin cinsiyeti(K/ E):      ");
                string secim2 = Console.ReadLine().ToUpper();

                switch (secim2)
                {
                    case "K":
                        cinsiyet = CINSIYET.Kiz;
                        kont = false;
                        break;

                    case "E":
                        cinsiyet = CINSIYET.Erkek;
                        kont = false;
                        break;

                    default:
                        Console.WriteLine(" Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                        break;

                }
            }
            //şube,
            int ilkNo = no;
            int a = 0;
            sube = Okul.SinifAl2();
            while (true)
            {
                if (NoKontrol(no))
                {
                    a++;
                    no += 1;
                    continue;
                }
                else
                {
                    if (a != 0)
                    {
                        Console.WriteLine(ilkNo + " numaralı öğrenci sisteme başarılı bir şekilde" +
                            " eklenmiştir.");

                        Console.WriteLine(" Sistemde " + ilkNo + " numaralı öğrenci olduğu için verdiğiniz" +
                            " öğrenci no : " + (no) + " olarak değiştirildi.");

                    }
                    else
                    {
                        Console.WriteLine(no + " numaralı öğrenci sisteme başarılı bir şekilde" +
                            " eklenmiştir.");
                    }


                    Okul.OgrenciEkle(no, ad, soyad, DogumTarihi, cinsiyet, sube);
                    break;
                }
            }




        }
        public void NotGir()
        {

            Console.WriteLine("  Not Gir------------------------------------------------ -");
            int no = KontrolluNoIste();


            bool kont2 = true;
            while (kont2)
            {
                Console.WriteLine("Eklemek İstediğiniz Ders");
                Console.WriteLine(" Türkçe(T)");
                Console.WriteLine(" Matematik(M)");
                Console.WriteLine(" Fen(F)");
                Console.WriteLine(" Sosyal Bilgiler (B)");

                string secim = Console.ReadLine().ToUpper();

                switch (secim)
                {
                    case "T":
                        DersAdi = DERS_ADI.Türkçe;
                        kont2 = false;
                        break;

                    case "M":
                        DersAdi = DERS_ADI.Matematik;
                        kont2 = false;
                        break;

                    case "F":
                        DersAdi = DERS_ADI.Fen;
                        kont2 = false;
                        break;
                    case "S":
                        DersAdi = DERS_ADI.Sosyal;
                        kont2 = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                        break;
                }
            }
            Console.Write("Eklemek istediğiniz not adedi:");
            int adet = int.Parse(Console.ReadLine());


            for (int i = 0; i < adet; i++)
            {
                Console.Write((i + 1) + ". Notu girin: ");
                int not = int.Parse(Console.ReadLine());

                //aldığım notu öğrenciye burada eklemeliyim.
                if (0 <= not && not < 101)
                {
                    Okul.NotEkle(no, DersAdi, not);
                }
                else
                {
                    Console.WriteLine("  Girdiğiniz değer 0 ve 100 arasında olmalıdır.");
                }
            }
            Console.WriteLine("Bilgiler sisteme girilmiştir.");

        }

        public void KitapGir()
        {
            Console.WriteLine("18-Öğrencinin okuduğu kitabı gir-----------------------------");
            int no = KontrolsuzNoIste();
            Okul.KitapEkle(no);

        }
        public bool NoKontrol(int no)
        {
            foreach (Ogrenci item in Okul.Ogrenciler)
            {
                if (item.No == no)
                {
                    return true;
                }
            }
            return false;
        }

        public int KontrolsuzNoIste()
        {
            int no;
            while (true)
            {

                try
                {
                    Console.Write("Öğrencinin numarası:");
                    no = int.Parse(Console.ReadLine());
                    if (NoKontrol(no))
                    {
                        return no;
                    }
                    else
                    {
                        Console.WriteLine("Bu numarada bir öğrenci yok.");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen doğru giriş yapınız.");
                }
            }
        }

        public int KontrolluNoIste()
        {
            int no;
            while (true)
            {

                try
                {
                    Console.Write("Öğrencinin numarası:");
                    no = int.Parse(Console.ReadLine());
                    if (NoKontrol(no))
                    {
                        Console.WriteLine("Zaten bu numarada bir öğrenci var.");
                    }
                    else
                    {
                        return no;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen doğru giriş yapınız.");
                }
            }
        }

        //public List<Ogrenci> EnBasarili5Ogrenci(List<Ogrenci> liste)
        //{
        //    liste = liste.OrderByDescending(r=>r)
        //}

        //LİSTELEME
        //ADRESLEsadfRE GÖRE SIRALAMA
        //kldfaj   sadf2938















        public void Menu()
        {
            Console.WriteLine(" 1 - Öğrenci Ekle");
            Console.WriteLine(" 2 - Not Gir(Metot ile giriş yapılacak)");
            Console.WriteLine(" 3 - Öğrencinin ortalamasını gör");
            Console.WriteLine(" 4 - Öğrencinin adresini gir");
            Console.WriteLine(" 5-Bütün Öğrencileri Listele");
            Console.WriteLine(" 6-Şubeye Göre Öğrencileri Listele");
            Console.WriteLine(" 7-Öğrencinin notlarını görüntüle(Derse göre sıralayıp listelenecek)");
            Console.WriteLine(" 8-Sınıfın Not Ortalamasını Gör");
            Console.WriteLine(" 9-Cinsiyetine göre öğrenci listele");
            Console.WriteLine(" 10-Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine(" 11-Tüm öğrencileri semtlerine göre sıralayarak listele");
            Console.WriteLine(" 12-Okuldaki En başarılı 5 öğrenciyi listele");
            Console.WriteLine(" 13-Okuldaki En başarısız 3 öğrenciyi listele");
            Console.WriteLine(" 14-Sınıftaki En başarılı 5 öğrenciyi listele");
            Console.WriteLine(" 15-Sınıftaki En başarısız 3 öğrenciyi listele");
            Console.WriteLine(" 16-Öğrenci için açıklama gir");
            Console.WriteLine(" 17-Öğrencinin açıklamasını gör");
            Console.WriteLine(" 18-Öğrencinin okuduğu kitabı gir");
            Console.WriteLine(" 19-Öğrencinin okuduğu kitapları listele");
            Console.WriteLine(" 20-Öğrencinin okuduğu son kitabı görüntüle");
            Console.WriteLine(" 21-Öğrenci sil");
            Console.WriteLine(" 22-Öğrenci güncelle");

        }

    }


































}

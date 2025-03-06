using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace OtoGaleri
{
    internal class Program
    {
        static Araba a = new Araba();
        static List<OtoGaleri> otoGaleri = new List<OtoGaleri>();
        static List<Araba> arabalar = new List<Araba>();
        static OtoGaleri o = new OtoGaleri();
    
        static void Main(string[] args)
        {
            Uygulama();
            KiradakiArabalar();
        }
        static void Uygulama()
        {
            sahteveri();
            
            while (true)
            {
                
                Menu();
                Console.WriteLine();
                string cevap = SecimAl();

                switch (cevap)
                {
                    case "K":
                    case "1":
                        ArabaKirala();
                        break;
                    case "T":
                    case "2":

                        break;
                    case "R":
                    case "3":
                        KiradakiArabalar();
                        break;
                    case "M":
                    case "4":
                        GaleridehiArabalar();
                        break;
                    case "A":
                    case "5":
                        TümArabalar();
                        break;
                    case "I":
                    case "6":
                        Kiralamaİptali();
                        break;
                    case "Y":
                    case "7":
                        ArabaEkle();
                        break;
                    case "S":
                    case "8":
                        ArabaSil();
                        break;
                    case "G":
                    case "9":
                        GaleriBilgileri();
                        break;
                    case "X":
                        cikis();
                        break;
                }
            }
        }
        static void ArabaKirala()
        {
             Console.WriteLine("-Araba Kirala-");
             Console.WriteLine();
             Console.WriteLine();
            string kiralanan;
            do
            {
                Console.Write("Kiralanacak arabanın plakası: ");
                kiralanan = Console.ReadLine();
            } while (ArabaVarmi(kiralanan)==true);
            int uzunluk = kiralanan.Length;
            if (uzunluk == 8)
            {
                if (true)
                {
                    if (true)
                    {
                        o.kiradakiArabaSayisi = kiralanan;
                    }
                }
            }
            else
            {
                Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                ArabaKirala();
            }
        } 
        static void KiradakiArabalar()
        {
            Console.WriteLine("Plaka                Marka        K.Bedeli        Araba Tipi           K.Sayısı         Durum");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            foreach (OtoGaleri o1 in otoGaleri)
            {
                Console.WriteLine("123");
            }
        }
        static void GaleridehiArabalar()
        {
            Console.WriteLine("Plaka                Marka        K.Bedeli        Araba Tipi           K.Sayısı         Durum");
            Console.WriteLine("---------------------------------------------------------------------------------------------");

        }
        static void TümArabalar()
        {
            Console.WriteLine("Plaka                Marka        K.Bedeli        Araba Tipi           K.Sayısı         Durum");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            foreach (Araba o1 in arabalar)
            {
                Console.WriteLine(o1.Plaka + " " + o1.Marka + " " + o1.KiraBedeli + " " + o1.ArabaTipi);
            }
            
        }
        static void Kiralamaİptali()
        {
            
        }
        static void ArabaEkle() 
        {

            string plaka;
            Console.WriteLine("-Araba Ekle-");
            Console.WriteLine();
            Console.WriteLine();
            do
            {
                Console.Write("plaka: ");
                plaka = Console.ReadLine();
            } while (ArabaVarmi(plaka));
            int uzunluk = plaka.Length;
            if (uzunluk == 8)
            {
                a.Plaka = plaka;
            }
            else
            {
                Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                ArabaEkle();
            }
            bool marka;
            do
            {
                Console.Write("marka: ");
                string Marka = Console.ReadLine();
                string sonuc;
                marka = int.TryParse(Marka, out _);
                if (marka == false)
                {
                    a.Marka = Marka;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin. ");
                    Console.WriteLine();
                }
            } while (marka);
            bool kira;
            do
            {
                Console.Write("kira bedeli: ");
                string Kira = Console.ReadLine();
                int sonuc;
                kira = int.TryParse(Kira, out sonuc);
                if (kira == true)
                {
                    a.KiraBedeli = sonuc;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin. ");
                    Console.WriteLine();
                }

            } while (kira != true);
            Console.WriteLine("Araba Tipi:");
            Console.WriteLine("SUV için 1");
            Console.WriteLine("Hatchback için 2");
            Console.WriteLine("Sedan için 3");
            string cevap = Console.ReadLine();
            switch (cevap)
            {
                case "1":
                    a.ArabaTipi = "SVU";
                    break;
                case "2":
                    a.ArabaTipi = "Hatchback";
                    break;
                case "3":
                    a.ArabaTipi = "Sedan";
                    break;
            }
            arabalar.Add(a);
            Console.WriteLine("Araba başarılı bir şekilde eklendi.");
            Console.WriteLine();


        }
        static void ArabaSil() //                 EKSİKLER
                              //Silinmek istenen araba plakasını girin:  36M
                              //Bu şekilde plaka girişi yapamazsınız.Tekrar deneyin.
                              //Silmek istediğiniz arabanın plakasını giriniz:36MN2303
                              //Araba kirada olduğu için silme işlemi gerçekleştirilemedi.

        {
            Console.WriteLine("-Araba Sil-");
            Console.WriteLine();
            if (arabalar.Count == 0)
            {
                Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
            }
            else
            {
                Console.Write("Silinmek istenen araba plakasını girin: ");
                string plaka = Console.ReadLine();

                Araba ogr = null;

                foreach (Araba item in arabalar)
                {
                    if (item.Plaka == plaka)
                    {
                        ogr = item;
                        break;
                    }
                }

                if (ogr != null)
                {
                        Console.WriteLine("Öğrenci silindi.");
                }
                else
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
  
                }

            }
        }
        static void GaleriBilgileri()
        {
            foreach (OtoGaleri item in otoGaleri)
            {
            Console.WriteLine("-Galeri Bilgileri-"                                             );
            Console.WriteLine("Toplam araba sayısı: " + item.ToplamArabaSayisi                 );
            Console.WriteLine("Kiradaki araba sayısı: " + item.kiradakiArabaSayisi             );
            Console.WriteLine("Bekleyen araba sayısı: " + item.BekleyenArabaSayisi             );
            Console.WriteLine("Toplam araba kiralama süresi: " + item.ToplamArabaKiralamaSuresi);
            Console.WriteLine("Toplam araba kiralama adedi: " + item.ToplamArabaKiralamaAdedi  );
            Console.WriteLine("Ciro: " + item.Ciro                                             );
            }
        }
        static void Menu()
        {
            Console.WriteLine("Galeri Otomasyon                   ");
            Console.WriteLine();
            Console.WriteLine("1 - Araba Kirala(K)                ");
            Console.WriteLine("2 - Araba Teslim Al(T)             ");
            Console.WriteLine("3 - Kiradaki Arabaları Listele(R)  ");
            Console.WriteLine("4 - Galerideki Arabaları Listele(M)");
            Console.WriteLine("5 - Tüm Arabaları Listele(A)       ");
            Console.WriteLine("6 - Kiralama İptali(I)             ");
            Console.WriteLine("7 - Araba Ekle(Y)                  ");
            Console.WriteLine("8 - Araba Sil(S)                   ");
            Console.WriteLine("9 - Bilgileri Göster(G)            ");
        }
        static string SecimAl()
        {
            string karakterler = "123456789KTRMAIYSGX";
            int sayac = 0;
            while (true)
            {
                sayac++;
                Console.WriteLine();
                Console.Write("Seçiminiz : ");
                string secim = Console.ReadLine().ToUpper();
                Console.WriteLine();
                int index = karakterler.IndexOf(secim);

                if (index >= 0)
                {
                    return secim;
                }
               
                else
                {
                   
                    if (sayac == 10)
                    {
                        Console.WriteLine("üzgünüm sizi anlamıyorum. program sonlandırılıyor");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                    }
                }
            }
        }
        static bool ArabaVarmi(string plaka)
        {
            
            foreach (Araba item in arabalar)
            {
                if (plaka == item.Plaka)
                {
                    Console.WriteLine("Aynı plakada araba mevcut. Girdiğiniz plakayı kontrol edin.");
                    return true;
                }
            }
            return false;
        }
      static void sahteveri() 
        {
            Araba a = new Araba();
            a.Plaka = "54hz1234";
            a.Marka = "fiat";
            a.KiraBedeli = 50;
            a.ArabaTipi = "3";
            a.Kira = "kirada";
            arabalar.Add(a);
        }
        static void cikis()
        {
            Environment.Exit(0);
        }
    }
}    
 
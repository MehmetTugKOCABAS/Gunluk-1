using System.Reflection.Metadata;

namespace OtoGaleriUygulamasi
{
    internal class Program
    {
        // Kullanıcı ile etkileşime gireceğimiz bütün kodlar program sınıfı içerisinde yazılacak.

        static Galeri OtoGaleri = new Galeri(); // Global

        static void Main(string[] args)
        {
            Uygulama();
        }
        static void Uygulama()
        {
            Menu();
            // switch-case
        }
        static void Menu()
        {
            Console.WriteLine("Galeri Otomasyon                    ");
            Console.WriteLine("1 - Araba Kirala(K)                 ");
            Console.WriteLine("2 - Araba Teslim Al(T)              ");
            Console.WriteLine("3 - Kiradaki Arabaları Listele(R)   ");
            Console.WriteLine("4 - Galerideki Arabaları Listele(M) ");
            Console.WriteLine("5 - Tüm Arabaları Listele(A)        ");
            Console.WriteLine("6 - Kiralama İptali(I)              ");
            Console.WriteLine("7 - Araba Ekle(Y)                   ");
            Console.WriteLine("8 - Araba Sil(S)                    ");
            Console.WriteLine("9 - Bilgileri Göster(G)             ");

        }

        static void ArabaKirala()
        {
            Console.WriteLine("-Araba Kirala-");
            Console.Write("Kiralanacak arabanın plakası: ");
            string plaka = Console.ReadLine();

            // kiralanacak olan arabanın plakası doğru girilmediği sürece tekrar tekrar plaka istemeli

            Console.Write("Kiralama süresi: ");
            int sure = int.Parse(Console.ReadLine());

            OtoGaleri.ArabaKirala(plaka,sure);


        }
        static void ArabaEkle()
        {
            string plaka = "";
            string marka = "";
            float kiralamaBedeli = 0;
            string aTipi = "";
            string arabaTipiSecim = "2";

            if (arabaTipiSecim == "2")
            {
                aTipi = "Hatchback";
            }

            OtoGaleri.ArabaEkle(plaka,marka,kiralamaBedeli,aTipi);
        }

    }
}

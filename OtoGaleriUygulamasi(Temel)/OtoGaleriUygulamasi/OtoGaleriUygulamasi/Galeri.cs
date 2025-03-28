﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OtoGaleriUygulamasi
{
    internal class Galeri
    {
        // Bu sınıfta galeri ile ilgili kodlar yazılacak
        // Galeriye ilişkin herhangi bir verinin değiştirilmesi gerektiğinde, ilgili kodlar burada yazılacak

        public List<Araba> Arabalar = new List<Araba>();

        public int ToplamAracSayisi
        {
            get
            {
                return Arabalar.Count;
            }
        }

        public int KiradakiAracSayisi
        {
            get
            {
                int adet = 0;

                foreach (Araba item in Arabalar)
                {
                    if (item.Durum == "Kirada")
                    {
                        adet++;
                    }
                }

                return adet;
            }
        }

        public int GaleridekiAracSayisi { get; set; }

        public int ToplamAracKiralamaSuresi
        {
            get
            {
                int toplam = 0;
                foreach (Araba item in Arabalar)
                {
                    toplam += item.ToplamKiralanmaSuresi;
                }

                return toplam;
            }
        }

        public int ToplamAracKiralamaAdeti { get; set; }

        public float Ciro {  get; set; }

        public void ArabaKirala(string plaka, int sure)
        {
            // bu plakaya ait arabanın bulunması lazım

            Araba a = null;

            foreach (Araba item in Arabalar)
            {
                if (item.Plaka == plaka)
                {
                    a = item;
                }
            }

            if (a != null)
            {
                a.Durum = "Kirada";
                a.KiralamaSureleri.Add(sure);
            }
        }
        public void ArabaTeslimAl(string plaka)
        {
            // bu plakalı arabayı bul

            Araba a = null;

            foreach (Araba item in Arabalar)
            {
                if (item.Plaka == plaka)
                {
                    a = item;
                }
            }

            if (a !=null)
            {
                a.Durum = "Galeride";
            }



        }

        public void KiralamaIptal(string plaka)
        {
            // arabayı bul

            // a.KiralamaSureleri.RemoveAt
            // KiralamaSureleri listesindeki son elemanı listeden çıkarıyoruz

        }
        public void ArabaEkle(string plaka, string marka, float kiralamaBedeli, string aTipi)
        {
            // parametreden aldığımız bilgiler ile yeni bir araba oluşacak.
            // bu oluşan arbayı Arabalar listesine ekleyeceğiz.

            Araba a = new Araba(plaka,marka,kiralamaBedeli,aTipi);
            this.Arabalar.Add(a);
        }


    }
}

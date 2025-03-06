using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleri
{
    internal class Araba
    {
        // Bu sınıfta araba ile ilgili özellik ve işlemler olmalı

        public string Plaka { get; set; }
        public string Marka { get; set; }
        public float KiraBedeli { get; set; }
        public string ArabaTipi { get; set; }
        public string Kira { get; set; }
       

        public List<int> KiralamaSureleri = new List<int>();


        //public Araba(string plaka, string marka, float kiralamaBedeli, string aracTipi)
        //{
        //    this.Plaka = plaka;
        //    this.Marka = marka;
        //    this.KiraBedeli = kiralamaBedeli;
        //    this.ArabaTipi = aracTipi;
        //    this.Durum = "Galeride";
        //}

        public int KiralanmaSayisi
        {
            get
            {
                return this.KiralamaSureleri.Count;
            }
        }

        public int ToplamKiralanmaSuresi
        {
            get
            {
                return this.KiralamaSureleri.Sum();
            }
        }
    }
}

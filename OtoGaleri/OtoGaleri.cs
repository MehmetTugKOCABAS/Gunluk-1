using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace OtoGaleri
{
    internal class OtoGaleri
    {
    static List<Araba> arabalar = new List<Araba>();

        public int ToplamArabaSayisi { get; set; }
        public string kiradakiArabaSayisi { get; set; }
        public int BekleyenArabaSayisi { get; set; }
        public int ToplamArabaKiralamaSuresi { get; set; }
        public int ToplamArabaKiralamaAdedi { get; set; }
        public int Ciro { get; set; }
    }
}

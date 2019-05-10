using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kitaplar
    {
        public int KitapID { get; set; }
        public string KitapISBN { get; set; }
        public string KitapAdi { get; set; }
        public int KitapSayfaSayisi { get; set; }
        public DateTime KitapBasimTarihi { get; set; }
        public double KitapFiyati { get; set; }
        public double GunlukKiralamaFiyati { get; set; }
        public string YazarAdiSoyadi { get; set; }
        public string YayınEvi { get; set; }
        public string KitapTuru { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kiralama
    {
        public int KiralamaID { get; set; }
        public DateTime KiralamaBaslangicTarihi { get; set; }
        public DateTime KiralamaBitisTarihi { get; set; }
        public Double KiralamaFiyati { get; set; }
        public int KitapID { get; set;}
        public int UyeID { get; set; }
    }
}

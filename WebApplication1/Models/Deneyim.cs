using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Deneyim
    {
        public int DeneyimID { get; set; }
        public int AdayID { get; set; }
        public string FirmaAdi { get; set; }
        public string Pozisyon { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
    }
}

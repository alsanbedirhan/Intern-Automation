using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DeneyimViewModel
    {
        public string AdayAdSoyad { get; set; }
        public string Firma { get; set; }
        public string Pozisyonu { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Egitim
    {
        public int EgitimID { get; set; }
        public int AdayID { get; set; }
        public string EgitimDurumu { get; set; }
        public string OkulAdi { get; set; }
        public string BolumAdi { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime BaslangicTarihi { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime BitisTarihi { get; set; }
    }
}

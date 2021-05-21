using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Aday
    {
        [Key]
        public int AdayId { get; set; }
        public string AdayAd { get; set; }
        public string AdaySoyad { get; set; }
        public string AdayEmail { get; set; }
        public string AdayTelefon { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime AdayDogumTarihi { get; set; }
        public string AdayAdres { get; set; }
    }
}

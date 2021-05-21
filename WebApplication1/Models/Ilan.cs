using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Ilan
    {
        [Key]
        public int IlanID { get; set; }
        public string IlanAciklama { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime IlanBaslangicTarihi { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime IlanBitisTarihi { get; set; }

        public bool IlanAktifMi { get; set; }             
    }
}

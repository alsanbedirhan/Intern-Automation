using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Basvuru
    {
        [Key]
        public int BasvuruID { get; set; }
        public int IlanID { get; set; }
        public int AdayID { get; set; }        
        public int Puan { get; set; }
        public string Durumu { get; set; }
        public string Aciklama { get; set; }             
    }
}

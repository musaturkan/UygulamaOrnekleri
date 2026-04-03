using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Siparis
    {
        [Key]
        public int Id { get; set; }
        public int? YemekId { get; set; }
        public int? MasaId { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? AktifMi { get; set; }

        [ForeignKey("MasaId")]
        public Masa? Masa { get; set; }

        [ForeignKey("YemekId")]
        public Yemek? Yemek { get; set; }

    }
}

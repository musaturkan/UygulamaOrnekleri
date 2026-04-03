using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Yemek
    {
        [Key]
        public int Id { get; set; }
        public  string? Ad { get; set; }
        public float? Fiyat { get; set; }
        public int? YemekTurId { get; set; }
        public int? Kalori { get; set; }

    }
}

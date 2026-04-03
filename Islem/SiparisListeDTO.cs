using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    public class SiparisListeDTO
    {
        public int Id { get; set; }
        public string? YemekAdi { get; set; }
        public decimal? Fiyat { get; set; }
        public DateTime? Tarih { get; set; }
    }
}

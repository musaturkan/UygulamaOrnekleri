using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    public class SiparisDTO
    {
        public int? Id { get; set; }
        public int? YemekId { get; set; }
        public int? MasaId { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? AktifMi { get; set; }
    }
}

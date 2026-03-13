using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    public class KullaniciDTO
    {
        public int? Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? Meslek { get; set; }
        public string? Adres { get; set; }
        public string? Eposta { get; set; }
        public int Maas { get; set; }

    }
}

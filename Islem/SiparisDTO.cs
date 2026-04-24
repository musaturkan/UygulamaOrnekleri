using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    /// <summary>
    /// Record tipleri sadece veri tutmak için kullanılır, davranış barındırmazlar. Record tipleri immutable (değiştirilemez) yapılardır, yani bir record nesnesi oluşturulduktan sonra property değerleri değiştirilemez. Record tipleri değer tipidir, referans tip değildir. Record tipleri, sınıflara göre daha az bellek kullanır ve performans açısından daha hızlıdır. 
    /// Record tipleri, sınıflara göre daha az bellek kullanır ve performans açısından daha hızlıdır.
    /// Record tipleri referans tip değildir, değer tipidir. 
    /// Bu nedenle, record tipleri bellekte stack üzerinde tutulur ve sınıflara göre daha hızlı erişim sağlar. 
    /// Record tipleri, sınıflara göre daha az bellek kullanır çünkü sınıflar heap üzerinde tutulur ve her nesne için ayrı bir bellek alanı ayrılırken, record tipleri stack üzerinde tutulur ve aynı bellek alanını paylaşır.
    /// 
    /// </summary>
    public record SiparisDTOr
    {
        public int? Id { get; init; }
        public int? YemekId { get; init; }
        public int? MasaId { get; init; }
        public DateTime? Tarih { get; init; }
        public bool? AktifMi { get; init; }
        public void Yazdir()
        {
            Console.WriteLine($"Id: {Id}, YemekId: {YemekId}, MasaId: {MasaId}, Tarih: {Tarih}, AktifMi: {AktifMi}");
        }
    }
    public class SiparisDTO
    {
        public int? Id { get; set; }
        public int? YemekId { get; set; }
        public int? MasaId { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? AktifMi { get; set; }
    }
}

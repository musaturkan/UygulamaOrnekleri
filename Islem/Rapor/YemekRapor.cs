using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem.Rapor
{
    public class YemekRapor : IYemekRapor
    {    
        public void MasaRaporuOlustur()
        {

        }
        public void PersonelRaporuOlustur()
        {

        }
        public void YemekRaporuOlustur()
        {
            DataModel.LokantaContext model = new DataModel.LokantaContext();
            var yemekRaporu = model.Siparis
                .GroupBy(s => new { s.YemekId, s.Yemek.Ad })
                .Select(g => new
                {
                    YemekId = g.Key.YemekId,
                    YemekAd = g.Key.Ad,
                    SiparisAdedi = g.Count(),
                    ToplamUcret = g.Sum(s => s.Yemek.Fiyat)
                })
                .ToList();

            var masaRaporu = model.Siparis
                .GroupBy(s => new { s.MasaId, s.Masa.Ad })
                .Select(g => new
                {
                    MasaId = g.Key.MasaId,
                    MasaAdi = g.Key.Ad,
                    SiparisAdedi = g.Count(),
                    ToplamUcret = g.Sum(s => s.Yemek.Fiyat)
                })
                .ToList();

            string filePath = "YemekRaporu2.xlsx";
            //ClosedXML.Excel.XLWorkbook calismaKitabi = new ClosedXML.Excel.XLWorkbook();
            ///Using bloğu, IDisposable arayüzünü uygulayan nesnelerin otomatik olarak temizlenmesini sağlar. 
            ///Bu, kaynakların düzgün bir şekilde serbest bırakılmasını ve bellek sızıntılarının önlenmesini sağlar.
            ///Nesne ile işimiz bittiği anda nesne bellekten temizlenir ve kaynaklar serbest bırakılır. 
            ///Bu, özellikle dosya işlemleri, veritabanı bağlantıları veya ağ bağlantıları gibi kaynakları yöneten nesneler için önemlidir.
            using (ClosedXML.Excel.XLWorkbook calismaKitabi = new ClosedXML.Excel.XLWorkbook())
            {
                var calismaSayfasi = calismaKitabi.Worksheets.Add("Yemek Raporu");
                var calismaSayfasi2 = calismaKitabi.Worksheets.Add("Yemek Raporu2");
                calismaSayfasi2.Cell(1, 1).InsertTable(masaRaporu);
                calismaSayfasi2.Columns().AdjustToContents();

                calismaSayfasi.Cell(1, 1).Value = "Yemek ID";
                calismaSayfasi.Cell(1, 2).Value = "Yemek Adı";
                calismaSayfasi.Cell(1, 3).Value = "Sipariş Adedi";
                calismaSayfasi.Cell(1, 4).Value = "Toplam Ücret";

                int satir = 2;
                foreach (var yemek in yemekRaporu)
                {
                    calismaSayfasi.Cell(satir, 1).Value = yemek.YemekId;
                    calismaSayfasi.Cell(satir, 2).Value = yemek.YemekAd;
                    calismaSayfasi.Cell(satir, 3).Value = yemek.SiparisAdedi;
                    calismaSayfasi.Cell(satir, 4).Value = yemek.ToplamUcret;
                    satir++;
                }

                calismaKitabi.SaveAs(filePath);
            }

        }
    }
}

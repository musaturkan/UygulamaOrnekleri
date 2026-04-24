using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{

    public interface IKullaniciIslem
    {
        bool KullaniciEkle(KullaniciDTO yeniKullanici);
    }
    /// <summary>
    /// Kullanıcı veri işlemlerini yapacak olan sınftır
    /// </summary>
    public class KullaniciIslem:IKullaniciIslem
    {
        public bool KullaniciEkle(KullaniciDTO yeniKullanici)
        {
            ///KullaniciDTO nesnesi ile gelen veriler veri tabanına eklenecek
            ///
            LokantaContext context = new LokantaContext();
            var kullanici = DtoMapper.DtoToEntity<Kullanici,KullaniciDTO>(yeniKullanici);

            //Kullanici kullanici = new Kullanici();
            //kullanici.Ad = yeniKullanici.Ad;
            //kullanici.Soyad = yeniKullanici.Soyad;
            //kullanici.KayitTarihi = DateTime.Now;
            //kullanici.DogumTarihi = yeniKullanici.DogumTarihi;
            //kullanici.KullaniciAdi = yeniKullanici.KullaniciAdi;
            //kullanici.Parola = yeniKullanici.Parola;

            ///DTO nesneleri ile entity dönüşümleri yapan kütüphaneler kullanılabilir
            ///Böylece dönüşüm işleminde oluşan kalabalıktan kurtuluruz
            ///Dönüşüm işlemlerini bir merkezi yere taşımız oluruz
            ///Bu işlem için mesela AutoMapper kütüphanesi kullanılabilir
            ///Kendiy yazdığımız bir generic dönüştürme metodu da kulllanılabilir

            context.Kullanici.Add(kullanici);///Kullanici nesnesini bellekteki context nesnesine ekler ancak henüz veri tabanına kaydetmez
            context.SaveChanges(); ///Veri tabanına ekleme işlemini gerçekleştirir

            return true;
        }
    }
}

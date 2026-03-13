using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    /// <summary>
    /// Kullanıcı veri işlemlerini yapacak olan sınftır
    /// </summary>
    public class KullaniciIslem
    {
        public bool KullaniciEkle(KullaniciDTO yeniKullanici)
        {
            ///KullaniciDTO nesnesi ile gelen veriler veri tabanına eklenecek
            ///
            LokantaContext context = new LokantaContext();
            Kullanici kullanici = new Kullanici();
            kullanici.Ad = yeniKullanici.Ad;
            kullanici.Soyad = yeniKullanici.Soyad;
            kullanici.KayitTarihi = DateTime.Now;
            kullanici.DogumTarihi = yeniKullanici.DogumTarihi;

            context.Kullanici.Add(kullanici);///Kullanici nesnesini bellekteki context nesnesine ekler ancak henüz veri tabanına kaydetmez
            context.SaveChanges(); ///Veri tabanına ekleme işlemini gerçekleştirir

            return true;
        }
    }
}

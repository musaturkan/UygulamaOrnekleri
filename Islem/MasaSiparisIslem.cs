using DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Islem
{
    /// <summary>
    /// Masaların listeleme, sipariş alma, sipariş güncelleme, 
    /// sipariş kapatma gibi işlemler bu sınıf içinde yapılır
    /// </summary>
    public class MasaSiparisIslem
    {
        public List<MasaDTO> MasaListeGetir()
        {
            LokantaContext context = new LokantaContext();
            //var masalar = context.Masa.ToList();
            var masalar = context.Masa.Select(s => new MasaDTO
            {
                Id = s.Id,
                Ad = s.Ad,
                Kapasite = s.Kapasite,
                Kodu = s.Kodu
            }).ToList();

            return masalar;
        }

        public List<Yemek> YemekListeGetir()
        {
            LokantaContext context = new LokantaContext();
            var yemekler = context.Yemek.ToList();
            return yemekler;
        }

        public void SiparisEkle(SiparisDTO siparis)
        {
            LokantaContext context = new LokantaContext();

            var yeniSiparis = DtoMapper.DtoToEntity<Siparis, SiparisDTO>(siparis);

            context.Siparis.Add(yeniSiparis);
            context.SaveChanges();
        }

        public List<SiparisListeDTO> MasaAktifSiparisGetir(int masaId)
        {
            LokantaContext context = new LokantaContext();
            var siparisler = context.Siparis
                                    //.Include("Yemek")
                                    .Include(p=>p.Yemek)
                                    .Where(w => w.MasaId == masaId && w.AktifMi == true)
                                    .Select(s => new SiparisListeDTO
                                    {
                                        Id = s.Id,
                                        YemekAdi = s.Yemek.Ad,
                                        Fiyat = s.Yemek.Fiyat,
                                        Tarih = s.Tarih
                                    })
                                    .ToList();
            return siparisler;
        }
    }
}
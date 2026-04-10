using DataModel;
using Islem;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta
{
    public partial class MasaSiparisAlma : Form
    {
        private IServiceProvider serviceProvider;
        public MasaDTO masaBilgi { get; set; }
        public MasaSiparisAlma( IServiceProvider _serviceProvider)
        {
            //masaBilgi = Masa;
            InitializeComponent();
            serviceProvider = _serviceProvider;
        }

        private void MasaSiparisAlma_Load(object sender, EventArgs e)
        {
            lbl_siparisalmaformbaslik.Text = $"{masaBilgi.Ad} - Sipariş Alma"; /// Sipariş alma formunun başlığına masanın adını ekliyoruz.
            //lbl_siparisalmaformbaslik.Text += masaBilgi.Ad; /// Sipariş alma formunun başlığına masanın adını ekliyoruz.
            /// Burada sipariş alma formu açıldığında yapılacak işlemler olabilir.
            /// Örneğin, masaya ait mevcut siparişlerin getirilmesi gibi.
            /// Burada entity sorguları doğrudan yapılmaz
            /// Entiy sorguları işlem katmanında yapılır.
            /// 
            MasaSiparisIslem masaIslem = serviceProvider.GetRequiredService<MasaSiparisIslem>();//new MasaSiparisIslem();
            
            var yemekListesi = masaIslem.YemekListeGetir();
            cb_YemekListe.DataSource = yemekListesi;
            dgv_AktifMasaSiparisleri.DataSource = masaIslem.MasaAktifSiparisGetir(masaBilgi.Id);
        }

        private void btn_SiparisEkle_Click(object sender, EventArgs e)
        {
            MasaSiparisIslem masaSiparis = Program.serviceProvider.GetService<MasaSiparisIslem>();//new MasaSiparisIslem();
            SiparisDTO yeniSiparis = new SiparisDTO();
            yeniSiparis.MasaId = masaBilgi.Id;
            yeniSiparis.YemekId = (cb_YemekListe.SelectedItem as Yemek).Id;
            yeniSiparis.Tarih = DateTime.Now;
            yeniSiparis.AktifMi = true;
            yeniSiparis.YemekId = cb_YemekListe.SelectedValue as int?;

            masaSiparis.SiparisEkle(yeniSiparis);

            dgv_AktifMasaSiparisleri.DataSource = masaSiparis.MasaAktifSiparisGetir(masaBilgi.Id);
        }

        private void btn_SiparisSil_Click(object sender, EventArgs e)
        {
            SiparisListeDTO secilenSiparis = dgv_AktifMasaSiparisleri.CurrentRow.DataBoundItem as SiparisListeDTO;
            if (secilenSiparis != null)
            {
                MasaSiparisIslem masaSiparis = new MasaSiparisIslem();
                masaSiparis.SiparisSil(secilenSiparis.Id);
                dgv_AktifMasaSiparisleri.DataSource = masaSiparis.MasaAktifSiparisGetir(masaBilgi.Id);
            }
        }
    }
}

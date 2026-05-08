using Islem.Rapor;
using Microsoft.Extensions.DependencyInjection;

namespace Lokanta
{
    public partial class AnaForm : Form
    {
        IYemekRapor yemekRapor;
        public AnaForm(IYemekRapor _yemekRapor)
        {
            yemekRapor = _yemekRapor;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Masa_Click(object sender, EventArgs e)
        {
            // MasaSiparis masaSiparis = new MasaSiparis();
            MasaSiparis masaSiparis = Program.serviceProvider.GetRequiredService<MasaSiparis>(); // Program.serviceProvider.GetService<MasaSiparis>();

            masaSiparis.ShowDialog();
        }

        private void btn_yemek_raporu_Click(object sender, EventArgs e)
        {
            ///her bir yemekten kaç tane sipariþ verildiði raporu exel olarak kaydedilecek
            ///Raporlama iþlemi çin rapor servisi çaðýrýlacak
            //Islem.Rapor.YemekRapor yemekRapor = new Islem.Rapor.YemekRapor();
            yemekRapor.YemekRaporuOlustur();

            MessageBox.Show("Yemek raporu baþarýyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gb_anaEkran_Enter(object sender, EventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Islem.WebAPI.GeoCodingApiServis geoCodingApiServis = new Islem.WebAPI.GeoCodingApiServis();
            var sehir = geoCodingApiServis.AdresToKoordinatAsync("Ankara").Result;
            var bilgi = sehir.results.FirstOrDefault();
            string koordinat = $"Enlem: {bilgi.latitude}, Boylam: {bilgi.longitude}";
            string ad_nufus= $"Þehir: {bilgi.name}, Nüfus: {bilgi.population}";
            lbl_hava_durumu.Text = ad_nufus+" "+koordinat;
        }

    }
}
using Islem;
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
    public partial class MasaSiparis : Form
    {
        public MasaSiparis()
        {
            InitializeComponent();
        }

        //private void DinamikButonClick(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Dinamik butona tıklandı!");
        //}

        private void Masa_Buton_Click(object sender, EventArgs e)
        {
            ///hangi masa tıklandıysa ona göre işlem yapılacak.
            
            var tiklananButon = sender as Button;
            var masaNesne = tiklananButon.Tag as MasaDTO; // Butonun Tag özelliğinden masa bilgilerini alıyoruz.
            //MessageBox.Show($"{masaNesne.Ad} Masa butonuna tıklandı! {masaNesne.Id}"); // Burada hangi masanın tıklandığını göstermek için bir mesaj kutusu açıyoruz.
            MasaSiparisAlma masaSiparisAlma = new MasaSiparisAlma(); // MasaSiparisAlma formuna tıklanan masanın bilgilerini gönderiyoruz.
            masaSiparisAlma.masaBilgi = masaNesne; // MasaSiparisAlma formunun masaBilgi özelliğine tıklanan masanın bilgilerini atıyoruz.
            masaSiparisAlma.ShowDialog(); // MasaSiparisAlma formunu açıyoruz.
            //yeni satır kelmendiaeiu a
        }
        private void MasaSiparis_Load(object sender, EventArgs e)
        {
            ///Burada masa sipariş formu açıldığında yapılacak işlemler olabilir.
            ///Örneğin, masaya ait mevcut siparişlerin getirilmesi gibi.
            ///Veri tabanındaki masaların listesi çekilecek
            ///
            //Button yeniButton = new Button();
            //yeniButton.Text = "Dinamik Buton";
            //yeniButton.Location = new Point(50, 50); // Butonun konumunu ayarlayın
            //yeniButton.Height = 100;
            //yeniButton.Width = 100;
            //yeniButton.BackColor = Color.LightBlue; // Butonun arka plan rengini ayarlayın
            //yeniButton.Click += DinamikButonClick;

            //Controls.Add(yeniButton); // Butonu forma ekleyin

            MasaSiparisIslem masaIslem = new MasaSiparisIslem();
            var masalar = masaIslem.MasaListeGetir();
            int xkonum = 100;
            int ykonum = 100;
            int sayac = 0;
            if (masalar != null)
            {
                ///Burada her bir masa için bir buton oluşturulabilir ve bu butona tıklandığında o masaya ait siparişler gösterilebilir.
                foreach (var siradakimasa in masalar)
                {                  
                
                    if (sayac%5==0)
                    {
                        xkonum = 100;                            
                        ykonum += 100;
                    }
                    Button button = new Button();
                    button.Text = siradakimasa.Ad;
                    button.Height = 100;
                    button.Width = 100;
                    button.FlatStyle = FlatStyle.Flat;
                    button.BackColor = Color.DarkRed;
                    button.ForeColor = Color.White;
                    button.Location = new Point(xkonum, ykonum);
                    button.Click += Masa_Buton_Click;
                    button.Tag = siradakimasa; // Butona masanın ID'sini ekleyelim, böylece tıklandığında hangi masa olduğunu anlayabiliriz.
                    xkonum += 100;   
                    sayac += 1;
                    Controls.Add(button);
                }
            }
        }
    }
}

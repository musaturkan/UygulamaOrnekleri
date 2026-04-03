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
    public partial class MasaSiparisAlma : Form
    {
        MasaDTO masaBilgi { get; set; }
        public MasaSiparisAlma(MasaDTO Masa)
        {
            masaBilgi = Masa;
            InitializeComponent();
        }

        private void MasaSiparisAlma_Load(object sender, EventArgs e)
        {
            lbl_siparisalmaformbaslik.Text = $"{masaBilgi.Ad} - Sipariş Alma"; /// Sipariş alma formunun başlığına masanın adını ekliyoruz.
            //lbl_siparisalmaformbaslik.Text += masaBilgi.Ad; /// Sipariş alma formunun başlığına masanın adını ekliyoruz.
            /// Burada sipariş alma formu açıldığında yapılacak işlemler olabilir.
            /// Örneğin, masaya ait mevcut siparişlerin getirilmesi gibi.
            /// 

        }
    }
}

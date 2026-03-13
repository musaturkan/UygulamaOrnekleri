namespace Ornek1
{
    public partial class AnaForm : Form
    {
        private Random rnd = new Random();
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            //Buton týklandýðýnda çalýþacak kodlar buraya yazýlýr.
            string isim = tb_Ad.Text;
            MessageBox.Show(isim + " Kabede Hacýlar Hu der Allah");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Selamlama Formu";
            BackColor = Color.Aquamarine;
        }

        private void btnMesaj_MouseHover(object sender, EventArgs e)
        {
            btnMesaj.BackColor = SystemColors.Highlight;
            btnMesaj.ForeColor = SystemColors.Info;
        }

        private void btnMesaj_MouseLeave(object sender, EventArgs e)
        {
            //btnMesaj.BackColor = Color.Maroon;
            btnMesaj.BackColor = Color.FromArgb(140, 170, 130);
        }

        private void btn_Renk_Degistir_Click(object sender, EventArgs e)
        {
            int kirmizi = rnd.Next(0, 255);
            int yesil = rnd.Next(0, 255);
            int mavi = rnd.Next(0, 255);
            BackColor = Color.FromArgb(kirmizi, yesil, mavi);


            var tiklananButon = sender as Button;
            tiklananButon.BackColor = BackColor;

        }

        private void btn_ButonElementRenkDegistir_Click(object sender, EventArgs e)
        {

            var formElemenListe = this.Controls;

            foreach (Control element in Controls)
            {

                if (element is Button)
                {
                    int kirmizi = rnd.Next(0, 255);
                    int yesil = rnd.Next(0, 255);
                    int mavi = rnd.Next(0, 255);
                    element.BackColor = Color.FromArgb(kirmizi, yesil, mavi);
                }

            }

        }

        private void btn_masa1_Click(object sender, EventArgs e)
        {

        }

        private void btn_YeniKullaniciEkleForm_Click(object sender, EventArgs e)
        {
            ///Ýkinci bir formu açýyoruz
            KullaniciKayit kayitForm = new KullaniciKayit();
            kayitForm.ShowDialog();

        }
    }
}

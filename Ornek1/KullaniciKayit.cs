using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class KullaniciKayit : Form
    {
        Islem.KullaniciIslem kullaniciIslem = new Islem.KullaniciIslem();
        //bool formDoluMu = true;
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        void textbox_ValidateOlayiEkle(Control.ControlCollection controls)
        {
            foreach (var eleman in controls)
            {
                if (eleman is TextBox metinKutusu)
                {
                    metinKutusu.Validating += tetxBox_dogrulama_Validating;
                }
            }
        }

        void FormValidateIslemi(Control.ControlCollection controls)
        {
            foreach (var eleman in controls)
            {
                if (eleman is TextBox metinKutusu)
                {
                    if (metinKutusu.Tag == "zorunlu" && string.IsNullOrWhiteSpace(metinKutusu.Text))
                    {
                        errorProvider1.SetError(metinKutusu, "Bu alan zorunludur");
                    }
                    else
                    {
                        errorProvider1.SetError(metinKutusu, "");
                    }
                }
            }
        }

        private void btn_KullaniciEkle_Click(object sender, EventArgs e)
        {
            //bool formElemanlariDoluMu = true;

            //if (string.IsNullOrWhiteSpace(tb_Ad.Text))
            //{
            //    tb_Ad.BackColor = Color.DeepPink;
            //    formElemanlariDoluMu = false;
            //}
            //if (string.IsNullOrEmpty(tb_Soyad.Text))
            //{
            //    tb_Soyad .BackColor = Color.DeepPink;
            //    formElemanlariDoluMu = false;
            //}

            //foreach (var element in Controls)
            //{


            //    if (element is TextBox)
            //    {
            //        var metinKutusu = element as TextBox;

            //        if (string.IsNullOrWhiteSpace(metinKutusu.Text))
            //        {
            //            metinKutusu.BackColor = Color.Pink;
            //            formElemanlariDoluMu = false;
            //        }
            //        else 
            //        {
            //            metinKutusu.BackColor= Color.White; 
            //        }
            //    }
            //}

            //FormValidateIslemi(gb_IletisimBilgileri.Controls);
            //FormValidateIslemi(gb_KimlikBilgileir.Controls);
            //FormValidateIslemi(Controls);

            if (errorProvider1.HasErrors == false)
            {
                Islem.KullaniciDTO yeniKullanici = new Islem.KullaniciDTO();
                yeniKullanici.Ad = tb_Ad.Text;
                yeniKullanici.Soyad = tb_Soyad.Text;
                yeniKullanici.DogumTarihi = dtp_DogumTarihi.Value;
                yeniKullanici.Meslek = cb_Meslek.Text;
                yeniKullanici.Adres = tb_Adres.Text;
                yeniKullanici.Eposta = tb_Eposta.Text;
                yeniKullanici.Maas = Convert.ToInt32(nup_Maas.Value);

                //Islem.KullaniciIslem ki = new Islem.KullaniciIslem();
                kullaniciIslem.KullaniciEkle(yeniKullanici);

                MessageBox.Show("Kullanıcı eklendi");
            }
            else
            {
                MessageBox.Show("Tüm form alanlarının doldurunuz");

            }


        }

        private void tb_Maas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(char.IsDigit(e.KeyChar)==false)
            //{ 
            //    e.Handled = true; 
            //}
        }

        //private void tb_Ad_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(tb_Ad.Text))
        //    {
        //        tb_Ad.BackColor = Color.Pink;
        //    }
        //    else
        //    {
        //        tb_Ad.BackColor= Color.White;
        //    }
        //}

        private void tetxBox_dogrulama_Validating(object sender, CancelEventArgs e)
        {

            var metinKutusu = sender as TextBox;
            if (string.IsNullOrWhiteSpace(metinKutusu.Text) && metinKutusu.Tag == "zorunlu")
            {
                //metinKutusu.BackColor = Color.Pink;
                //formDoluMu = false;
                errorProvider1.SetError(metinKutusu, "Bu alan boş geçilemez");
            }
            else
            {
                //metinKutusu.BackColor = Color.White;
                errorProvider1.SetError(metinKutusu, "");
                //formDoluMu = true;
            }
        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {
            textbox_ValidateOlayiEkle(gb_IletisimBilgileri.Controls);
            textbox_ValidateOlayiEkle(gb_KimlikBilgileir.Controls);
            textbox_ValidateOlayiEkle(Controls);
        }
    }
}

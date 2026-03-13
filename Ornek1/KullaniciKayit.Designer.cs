namespace Ornek1
{
    partial class KullaniciKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            tb_Ad = new TextBox();
            tb_Soyad = new TextBox();
            label3 = new Label();
            cb_Meslek = new ComboBox();
            label4 = new Label();
            dtp_DogumTarihi = new DateTimePicker();
            lbl_Adres = new Label();
            tb_Adres = new TextBox();
            label5 = new Label();
            tb_Eposta = new TextBox();
            gb_IletisimBilgileri = new GroupBox();
            gb_KimlikBilgileir = new GroupBox();
            btn_KullaniciEkle = new Button();
            label6 = new Label();
            tb_Maas = new TextBox();
            nup_Maas = new NumericUpDown();
            errorProvider1 = new ErrorProvider(components);
            gb_IletisimBilgileri.SuspendLayout();
            gb_KimlikBilgileir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nup_Maas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 31);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // tb_Ad
            // 
            tb_Ad.Location = new Point(51, 23);
            tb_Ad.Name = "tb_Ad";
            tb_Ad.Size = new Size(276, 23);
            tb_Ad.TabIndex = 2;
            tb_Ad.Tag = "zorunlu";
            tb_Ad.Validating += tetxBox_dogrulama_Validating;
            // 
            // tb_Soyad
            // 
            tb_Soyad.Location = new Point(394, 23);
            tb_Soyad.Name = "tb_Soyad";
            tb_Soyad.Size = new Size(251, 23);
            tb_Soyad.TabIndex = 3;
            tb_Soyad.Tag = "zorunlu";
            tb_Soyad.Validating += tetxBox_dogrulama_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 93);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Meslek";
            // 
            // cb_Meslek
            // 
            cb_Meslek.FormattingEnabled = true;
            cb_Meslek.Items.AddRange(new object[] { "Mühendis", "Mimar", "Şehir Plancısı", "Yazılım Geliştirici", "Veri Tabanı Uzmanı", "Sistem Uzmanı", "Sistem Analisti", "Veri Güvenliği Uzmanı" });
            cb_Meslek.Location = new Point(66, 86);
            cb_Meslek.Name = "cb_Meslek";
            cb_Meslek.Size = new Size(240, 23);
            cb_Meslek.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 94);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 6;
            label4.Text = "Doğum Tarihi";
            // 
            // dtp_DogumTarihi
            // 
            dtp_DogumTarihi.Location = new Point(431, 88);
            dtp_DogumTarihi.Name = "dtp_DogumTarihi";
            dtp_DogumTarihi.Size = new Size(200, 23);
            dtp_DogumTarihi.TabIndex = 7;
            // 
            // lbl_Adres
            // 
            lbl_Adres.AutoSize = true;
            lbl_Adres.Location = new Point(11, 25);
            lbl_Adres.Name = "lbl_Adres";
            lbl_Adres.Size = new Size(37, 15);
            lbl_Adres.TabIndex = 8;
            lbl_Adres.Text = "Adres";
            // 
            // tb_Adres
            // 
            tb_Adres.Location = new Point(59, 29);
            tb_Adres.Multiline = true;
            tb_Adres.Name = "tb_Adres";
            tb_Adres.Size = new Size(264, 151);
            tb_Adres.TabIndex = 9;
            tb_Adres.Validating += tetxBox_dogrulama_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 210);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 10;
            label5.Text = "Eposta:";
            // 
            // tb_Eposta
            // 
            tb_Eposta.Location = new Point(65, 209);
            tb_Eposta.Name = "tb_Eposta";
            tb_Eposta.Size = new Size(263, 23);
            tb_Eposta.TabIndex = 11;
            tb_Eposta.Tag = "zorunlu";
            tb_Eposta.Validating += tetxBox_dogrulama_Validating;
            // 
            // gb_IletisimBilgileri
            // 
            gb_IletisimBilgileri.BackColor = Color.MistyRose;
            gb_IletisimBilgileri.Controls.Add(tb_Adres);
            gb_IletisimBilgileri.Controls.Add(tb_Eposta);
            gb_IletisimBilgileri.Controls.Add(lbl_Adres);
            gb_IletisimBilgileri.Controls.Add(label5);
            gb_IletisimBilgileri.Location = new Point(84, 181);
            gb_IletisimBilgileri.Name = "gb_IletisimBilgileri";
            gb_IletisimBilgileri.Size = new Size(362, 255);
            gb_IletisimBilgileri.TabIndex = 12;
            gb_IletisimBilgileri.TabStop = false;
            gb_IletisimBilgileri.Text = "İletişim Bilgileri";
            // 
            // gb_KimlikBilgileir
            // 
            gb_KimlikBilgileir.BackColor = Color.LightGreen;
            gb_KimlikBilgileir.Controls.Add(tb_Ad);
            gb_KimlikBilgileir.Controls.Add(label1);
            gb_KimlikBilgileir.Controls.Add(dtp_DogumTarihi);
            gb_KimlikBilgileir.Controls.Add(label2);
            gb_KimlikBilgileir.Controls.Add(label4);
            gb_KimlikBilgileir.Controls.Add(tb_Soyad);
            gb_KimlikBilgileir.Controls.Add(cb_Meslek);
            gb_KimlikBilgileir.Controls.Add(label3);
            gb_KimlikBilgileir.Location = new Point(83, 12);
            gb_KimlikBilgileir.Name = "gb_KimlikBilgileir";
            gb_KimlikBilgileir.Size = new Size(922, 159);
            gb_KimlikBilgileir.TabIndex = 13;
            gb_KimlikBilgileir.TabStop = false;
            gb_KimlikBilgileir.Text = "groupBox1";
            // 
            // btn_KullaniciEkle
            // 
            btn_KullaniciEkle.BackColor = Color.SeaGreen;
            btn_KullaniciEkle.Location = new Point(523, 336);
            btn_KullaniciEkle.Name = "btn_KullaniciEkle";
            btn_KullaniciEkle.Size = new Size(118, 100);
            btn_KullaniciEkle.TabIndex = 14;
            btn_KullaniciEkle.Text = "Kaydet";
            btn_KullaniciEkle.UseVisualStyleBackColor = false;
            btn_KullaniciEkle.Click += btn_KullaniciEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 197);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 15;
            label6.Text = "Maaş:";
            // 
            // tb_Maas
            // 
            tb_Maas.Location = new Point(847, 194);
            tb_Maas.Name = "tb_Maas";
            tb_Maas.Size = new Size(139, 23);
            tb_Maas.TabIndex = 16;
            tb_Maas.Tag = "zorunlu";
            tb_Maas.KeyPress += tb_Maas_KeyPress;
            tb_Maas.Validating += tetxBox_dogrulama_Validating;
            // 
            // nup_Maas
            // 
            nup_Maas.Location = new Point(569, 195);
            nup_Maas.Name = "nup_Maas";
            nup_Maas.Size = new Size(246, 23);
            nup_Maas.TabIndex = 17;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // KullaniciKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 748);
            Controls.Add(nup_Maas);
            Controls.Add(tb_Maas);
            Controls.Add(label6);
            Controls.Add(btn_KullaniciEkle);
            Controls.Add(gb_KimlikBilgileir);
            Controls.Add(gb_IletisimBilgileri);
            Name = "KullaniciKayit";
            Text = "KullaniciKayit";
            gb_IletisimBilgileri.ResumeLayout(false);
            gb_IletisimBilgileri.PerformLayout();
            gb_KimlikBilgileir.ResumeLayout(false);
            gb_KimlikBilgileir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nup_Maas).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_Ad;
        private TextBox tb_Soyad;
        private Label label3;
        private ComboBox cb_Meslek;
        private Label label4;
        private DateTimePicker dtp_DogumTarihi;
        private Label lbl_Adres;
        private TextBox tb_Adres;
        private Label label5;
        private TextBox tb_Eposta;
        private GroupBox gb_IletisimBilgileri;
        private GroupBox gb_KimlikBilgileir;
        private Button btn_KullaniciEkle;
        private Label label6;
        private TextBox tb_Maas;
        private NumericUpDown nup_Maas;
        private ErrorProvider errorProvider1;
    }
}
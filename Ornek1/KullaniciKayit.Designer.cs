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
            gb_KimlikBilgileir = new GroupBox();
            label8 = new Label();
            tb_Parola = new TextBox();
            label7 = new Label();
            tb_KullaniciAdi = new TextBox();
            btn_KullaniciEkle = new Button();
            errorProvider1 = new ErrorProvider(components);
            gb_KimlikBilgileir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
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
            tb_Ad.Location = new Point(93, 23);
            tb_Ad.Name = "tb_Ad";
            tb_Ad.Size = new Size(213, 23);
            tb_Ad.TabIndex = 2;
            tb_Ad.Tag = "zorunlu";
            // 
            // tb_Soyad
            // 
            tb_Soyad.Location = new Point(394, 23);
            tb_Soyad.Name = "tb_Soyad";
            tb_Soyad.Size = new Size(251, 23);
            tb_Soyad.TabIndex = 3;
            tb_Soyad.Tag = "zorunlu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 89);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Meslek";
            // 
            // cb_Meslek
            // 
            cb_Meslek.FormattingEnabled = true;
            cb_Meslek.Items.AddRange(new object[] { "Mühendis", "Mimar", "Şehir Plancısı", "Yazılım Geliştirici", "Veri Tabanı Uzmanı", "Sistem Uzmanı", "Sistem Analisti", "Veri Güvenliği Uzmanı" });
            cb_Meslek.Location = new Point(93, 86);
            cb_Meslek.Name = "cb_Meslek";
            cb_Meslek.Size = new Size(213, 23);
            cb_Meslek.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 94);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 6;
            label4.Text = "Doğum Tarihi";
            // 
            // dtp_DogumTarihi
            // 
            dtp_DogumTarihi.Location = new Point(445, 88);
            dtp_DogumTarihi.Name = "dtp_DogumTarihi";
            dtp_DogumTarihi.Size = new Size(200, 23);
            dtp_DogumTarihi.TabIndex = 7;
            // 
            // gb_KimlikBilgileir
            // 
            gb_KimlikBilgileir.BackColor = Color.LightGreen;
            gb_KimlikBilgileir.Controls.Add(label8);
            gb_KimlikBilgileir.Controls.Add(tb_Parola);
            gb_KimlikBilgileir.Controls.Add(label7);
            gb_KimlikBilgileir.Controls.Add(tb_KullaniciAdi);
            gb_KimlikBilgileir.Controls.Add(tb_Ad);
            gb_KimlikBilgileir.Controls.Add(label1);
            gb_KimlikBilgileir.Controls.Add(dtp_DogumTarihi);
            gb_KimlikBilgileir.Controls.Add(label2);
            gb_KimlikBilgileir.Controls.Add(label4);
            gb_KimlikBilgileir.Controls.Add(tb_Soyad);
            gb_KimlikBilgileir.Controls.Add(cb_Meslek);
            gb_KimlikBilgileir.Controls.Add(label3);
            gb_KimlikBilgileir.Location = new Point(73, 35);
            gb_KimlikBilgileir.Name = "gb_KimlikBilgileir";
            gb_KimlikBilgileir.Size = new Size(673, 134);
            gb_KimlikBilgileir.TabIndex = 13;
            gb_KimlikBilgileir.TabStop = false;
            gb_KimlikBilgileir.Text = "Kullanıcı  Kimlik Bilgileri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(337, 65);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 11;
            label8.Text = "Parola:";
            // 
            // tb_Parola
            // 
            tb_Parola.Location = new Point(394, 57);
            tb_Parola.Name = "tb_Parola";
            tb_Parola.Size = new Size(251, 23);
            tb_Parola.TabIndex = 10;
            tb_Parola.Tag = "zorunlu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 57);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 9;
            label7.Text = "Kullanıcı Adı:";
            // 
            // tb_KullaniciAdi
            // 
            tb_KullaniciAdi.Location = new Point(93, 52);
            tb_KullaniciAdi.Name = "tb_KullaniciAdi";
            tb_KullaniciAdi.Size = new Size(213, 23);
            tb_KullaniciAdi.TabIndex = 8;
            tb_KullaniciAdi.Tag = "zorunlu";
            // 
            // btn_KullaniciEkle
            // 
            btn_KullaniciEkle.BackColor = Color.SeaGreen;
            btn_KullaniciEkle.Location = new Point(752, 35);
            btn_KullaniciEkle.Name = "btn_KullaniciEkle";
            btn_KullaniciEkle.Size = new Size(120, 134);
            btn_KullaniciEkle.TabIndex = 14;
            btn_KullaniciEkle.Text = "Kaydet";
            btn_KullaniciEkle.UseVisualStyleBackColor = false;
            btn_KullaniciEkle.Click += btn_KullaniciEkle_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // KullaniciKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 275);
            Controls.Add(btn_KullaniciEkle);
            Controls.Add(gb_KimlikBilgileir);
            Name = "KullaniciKayit";
            Text = "KullaniciKayit";
            Load += KullaniciKayit_Load;
            gb_KimlikBilgileir.ResumeLayout(false);
            gb_KimlikBilgileir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
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
        private GroupBox gb_KimlikBilgileir;
        private Button btn_KullaniciEkle;
        private ErrorProvider errorProvider1;
        private Label label8;
        private TextBox tb_Parola;
        private Label label7;
        private TextBox tb_KullaniciAdi;
    }
}
namespace Ornek1
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMesaj = new Button();
            lblAd = new Label();
            tb_Ad = new TextBox();
            btn_Renk_Degistir = new Button();
            btn_masa1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btn_ButonElementRenkDegistir = new Button();
            btn_YeniKullaniciEkleForm = new Button();
            SuspendLayout();
            // 
            // btnMesaj
            // 
            btnMesaj.BackColor = Color.Maroon;
            btnMesaj.Font = new Font("Segoe UI", 16F);
            btnMesaj.ForeColor = SystemColors.ButtonHighlight;
            btnMesaj.Location = new Point(362, 258);
            btnMesaj.Name = "btnMesaj";
            btnMesaj.Size = new Size(188, 88);
            btnMesaj.TabIndex = 0;
            btnMesaj.Text = "Mesaj Göster";
            btnMesaj.UseVisualStyleBackColor = false;
            btnMesaj.Click += btnMesaj_Click;
            btnMesaj.MouseEnter += btnMesaj_MouseHover;
            btnMesaj.MouseLeave += btnMesaj_MouseLeave;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(311, 203);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(79, 15);
            lblAd.TabIndex = 1;
            lblAd.Text = "Adınızı Giriniz";
            // 
            // tb_Ad
            // 
            tb_Ad.Location = new Point(398, 200);
            tb_Ad.Name = "tb_Ad";
            tb_Ad.Size = new Size(180, 23);
            tb_Ad.TabIndex = 2;
            // 
            // btn_Renk_Degistir
            // 
            btn_Renk_Degistir.Location = new Point(16, 21);
            btn_Renk_Degistir.Name = "btn_Renk_Degistir";
            btn_Renk_Degistir.Size = new Size(87, 58);
            btn_Renk_Degistir.TabIndex = 3;
            btn_Renk_Degistir.Text = "Form Rengini Degiştir";
            btn_Renk_Degistir.UseVisualStyleBackColor = true;
            btn_Renk_Degistir.Click += btn_Renk_Degistir_Click;
            // 
            // btn_masa1
            // 
            btn_masa1.Location = new Point(113, 428);
            btn_masa1.Name = "btn_masa1";
            btn_masa1.Size = new Size(114, 116);
            btn_masa1.TabIndex = 4;
            btn_masa1.Text = "Masa 1";
            btn_masa1.UseVisualStyleBackColor = true;
            btn_masa1.Click += btn_masa1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(248, 428);
            button2.Name = "button2";
            button2.Size = new Size(114, 116);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(394, 428);
            button3.Name = "button3";
            button3.Size = new Size(114, 116);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(535, 428);
            button4.Name = "button4";
            button4.Size = new Size(114, 116);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(673, 428);
            button5.Name = "button5";
            button5.Size = new Size(114, 116);
            button5.TabIndex = 8;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // btn_ButonElementRenkDegistir
            // 
            btn_ButonElementRenkDegistir.Location = new Point(760, 20);
            btn_ButonElementRenkDegistir.Name = "btn_ButonElementRenkDegistir";
            btn_ButonElementRenkDegistir.Size = new Size(86, 60);
            btn_ButonElementRenkDegistir.TabIndex = 9;
            btn_ButonElementRenkDegistir.Text = "Butonların Rengini Değiştir";
            btn_ButonElementRenkDegistir.UseVisualStyleBackColor = true;
            btn_ButonElementRenkDegistir.Click += btn_ButonElementRenkDegistir_Click;
            // 
            // btn_YeniKullaniciEkleForm
            // 
            btn_YeniKullaniciEkleForm.Location = new Point(651, 21);
            btn_YeniKullaniciEkleForm.Name = "btn_YeniKullaniciEkleForm";
            btn_YeniKullaniciEkleForm.Size = new Size(74, 59);
            btn_YeniKullaniciEkleForm.TabIndex = 10;
            btn_YeniKullaniciEkleForm.Text = "Yeni Kullanıcı Ekle";
            btn_YeniKullaniciEkleForm.UseVisualStyleBackColor = true;
            btn_YeniKullaniciEkleForm.Click += btn_YeniKullaniciEkleForm_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(867, 599);
            Controls.Add(btn_YeniKullaniciEkleForm);
            Controls.Add(btn_ButonElementRenkDegistir);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_masa1);
            Controls.Add(btn_Renk_Degistir);
            Controls.Add(tb_Ad);
            Controls.Add(lblAd);
            Controls.Add(btnMesaj);
            DoubleBuffered = true;
            Name = "AnaForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMesaj;
        private Label lblAd;
        private TextBox tb_Ad;
        private Button btn_Renk_Degistir;
        private Button btn_masa1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btn_ButonElementRenkDegistir;
        private Button btn_YeniKullaniciEkleForm;
    }
}

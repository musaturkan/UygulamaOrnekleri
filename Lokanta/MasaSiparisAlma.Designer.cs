namespace Lokanta
{
    partial class MasaSiparisAlma
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
            lbl_siparisalmaformbaslik = new Label();
            cb_YemekListe = new ComboBox();
            btn_SiparisEkle = new Button();
            dgv_AktifMasaSiparisleri = new DataGridView();
            lbl_AktifSiparis = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_AktifMasaSiparisleri).BeginInit();
            SuspendLayout();
            // 
            // lbl_siparisalmaformbaslik
            // 
            lbl_siparisalmaformbaslik.AutoSize = true;
            lbl_siparisalmaformbaslik.Font = new Font("Segoe UI", 18F);
            lbl_siparisalmaformbaslik.ForeColor = Color.DarkOliveGreen;
            lbl_siparisalmaformbaslik.Location = new Point(23, 21);
            lbl_siparisalmaformbaslik.Name = "lbl_siparisalmaformbaslik";
            lbl_siparisalmaformbaslik.Size = new Size(144, 32);
            lbl_siparisalmaformbaslik.TabIndex = 0;
            lbl_siparisalmaformbaslik.Text = "Siparis Alma";
            // 
            // cb_YemekListe
            // 
            cb_YemekListe.DisplayMember = "Ad";
            cb_YemekListe.Font = new Font("Segoe UI", 12F);
            cb_YemekListe.FormattingEnabled = true;
            cb_YemekListe.Location = new Point(23, 81);
            cb_YemekListe.Name = "cb_YemekListe";
            cb_YemekListe.Size = new Size(310, 29);
            cb_YemekListe.TabIndex = 1;
            cb_YemekListe.ValueMember = "Id";
            // 
            // btn_SiparisEkle
            // 
            btn_SiparisEkle.BackColor = Color.DarkRed;
            btn_SiparisEkle.FlatStyle = FlatStyle.Flat;
            btn_SiparisEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_SiparisEkle.ForeColor = SystemColors.ControlLightLight;
            btn_SiparisEkle.Location = new Point(367, 66);
            btn_SiparisEkle.Name = "btn_SiparisEkle";
            btn_SiparisEkle.Size = new Size(106, 45);
            btn_SiparisEkle.TabIndex = 2;
            btn_SiparisEkle.Text = "Ekle";
            btn_SiparisEkle.UseVisualStyleBackColor = false;
            btn_SiparisEkle.Click += btn_SiparisEkle_Click;
            // 
            // dgv_AktifMasaSiparisleri
            // 
            dgv_AktifMasaSiparisleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AktifMasaSiparisleri.DataMember = "SiparisListeDTO";
            dgv_AktifMasaSiparisleri.Location = new Point(12, 248);
            dgv_AktifMasaSiparisleri.Name = "dgv_AktifMasaSiparisleri";
            dgv_AktifMasaSiparisleri.Size = new Size(734, 353);
            dgv_AktifMasaSiparisleri.TabIndex = 3;
            // 
            // lbl_AktifSiparis
            // 
            lbl_AktifSiparis.AutoSize = true;
            lbl_AktifSiparis.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_AktifSiparis.ForeColor = SystemColors.Highlight;
            lbl_AktifSiparis.Location = new Point(13, 207);
            lbl_AktifSiparis.Name = "lbl_AktifSiparis";
            lbl_AktifSiparis.Size = new Size(171, 21);
            lbl_AktifSiparis.TabIndex = 4;
            lbl_AktifSiparis.Text = "Aktif Masa Siparisleri";
            // 
            // MasaSiparisAlma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 613);
            Controls.Add(lbl_AktifSiparis);
            Controls.Add(dgv_AktifMasaSiparisleri);
            Controls.Add(btn_SiparisEkle);
            Controls.Add(cb_YemekListe);
            Controls.Add(lbl_siparisalmaformbaslik);
            Name = "MasaSiparisAlma";
            Text = "MasaSiparisAlma";
            Load += MasaSiparisAlma_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_AktifMasaSiparisleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_siparisalmaformbaslik;
        private ComboBox cb_YemekListe;
        private Button btn_SiparisEkle;
        private DataGridView dgv_AktifMasaSiparisleri;
        private Label lbl_AktifSiparis;
    }
}
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
            // 
            // MasaSiparisAlma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 613);
            Controls.Add(btn_SiparisEkle);
            Controls.Add(cb_YemekListe);
            Controls.Add(lbl_siparisalmaformbaslik);
            Name = "MasaSiparisAlma";
            Text = "MasaSiparisAlma";
            Load += MasaSiparisAlma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_siparisalmaformbaslik;
        private ComboBox cb_YemekListe;
        private Button btn_SiparisEkle;
    }
}
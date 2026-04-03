namespace Lokanta
{
    partial class MasaSiparis
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
            flp_MasaSiparis = new FlowLayoutPanel();
            lbl_SiparisBaslik = new Label();
            SuspendLayout();
            // 
            // flp_MasaSiparis
            // 
            flp_MasaSiparis.AutoScroll = true;
            flp_MasaSiparis.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flp_MasaSiparis.Location = new Point(12, 69);
            flp_MasaSiparis.Name = "flp_MasaSiparis";
            flp_MasaSiparis.Size = new Size(731, 431);
            flp_MasaSiparis.TabIndex = 0;
            // 
            // lbl_SiparisBaslik
            // 
            lbl_SiparisBaslik.AutoSize = true;
            lbl_SiparisBaslik.Font = new Font("Segoe UI", 18F);
            lbl_SiparisBaslik.Location = new Point(12, 18);
            lbl_SiparisBaslik.Name = "lbl_SiparisBaslik";
            lbl_SiparisBaslik.Size = new Size(277, 32);
            lbl_SiparisBaslik.TabIndex = 1;
            lbl_SiparisBaslik.Text = "Masalar için Sipariş Alma";
            // 
            // MasaSiparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(755, 527);
            Controls.Add(lbl_SiparisBaslik);
            Controls.Add(flp_MasaSiparis);
            Name = "MasaSiparis";
            Text = "MasaSiparis";
            Load += MasaSiparis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_MasaSiparis;
        private Label lbl_SiparisBaslik;
    }
}
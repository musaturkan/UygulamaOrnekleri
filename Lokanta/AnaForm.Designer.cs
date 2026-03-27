namespace Lokanta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            gb_anaEkran = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            btn_Masa = new Button();
            gb_anaEkran.SuspendLayout();
            SuspendLayout();
            // 
            // gb_anaEkran
            // 
            gb_anaEkran.Controls.Add(button2);
            gb_anaEkran.Controls.Add(button1);
            gb_anaEkran.Controls.Add(btn_Masa);
            gb_anaEkran.Location = new Point(213, 98);
            gb_anaEkran.Name = "gb_anaEkran";
            gb_anaEkran.Size = new Size(638, 402);
            gb_anaEkran.TabIndex = 0;
            gb_anaEkran.TabStop = false;
            gb_anaEkran.Text = "Yönetim İşlemleri";
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.FlatAppearance.BorderColor = Color.YellowGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button2.Location = new Point(363, 62);
            button2.Name = "button2";
            button2.Size = new Size(134, 104);
            button2.TabIndex = 2;
            button2.Text = "Paket Servisi";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatAppearance.BorderColor = Color.OrangeRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(239, 62);
            button1.Name = "button1";
            button1.Size = new Size(118, 104);
            button1.TabIndex = 1;
            button1.Text = "Rezervasyon";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_Masa
            // 
            btn_Masa.BackColor = Color.LimeGreen;
            btn_Masa.FlatAppearance.BorderColor = Color.LimeGreen;
            btn_Masa.FlatStyle = FlatStyle.Flat;
            btn_Masa.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btn_Masa.Location = new Point(26, 62);
            btn_Masa.Name = "btn_Masa";
            btn_Masa.Size = new Size(207, 104);
            btn_Masa.TabIndex = 0;
            btn_Masa.Text = "Masa";
            btn_Masa.TextAlign = ContentAlignment.MiddleRight;
            btn_Masa.UseVisualStyleBackColor = false;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1012, 591);
            Controls.Add(gb_anaEkran);
            Name = "AnaForm";
            Text = "Lokanta";
            gb_anaEkran.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_anaEkran;
        private Button button1;
        private Button btn_Masa;
        private Button button2;
    }
}

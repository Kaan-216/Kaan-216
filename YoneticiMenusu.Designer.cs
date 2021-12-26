
namespace Proje7
{
    partial class YoneticiMenusu
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
            this.button_kullanicilar = new System.Windows.Forms.Button();
            this.button_urunsayfasi = new System.Windows.Forms.Button();
            this.button_yoneticiekle = new System.Windows.Forms.Button();
            this.button_geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_kullanicilar
            // 
            this.button_kullanicilar.Location = new System.Drawing.Point(12, 12);
            this.button_kullanicilar.Name = "button_kullanicilar";
            this.button_kullanicilar.Size = new System.Drawing.Size(90, 26);
            this.button_kullanicilar.TabIndex = 0;
            this.button_kullanicilar.Text = "Kullanıcı Listesi";
            this.button_kullanicilar.UseVisualStyleBackColor = true;
            this.button_kullanicilar.Click += new System.EventHandler(this.button_kullanicilar_Click);
            // 
            // button_urunsayfasi
            // 
            this.button_urunsayfasi.Location = new System.Drawing.Point(12, 44);
            this.button_urunsayfasi.Name = "button_urunsayfasi";
            this.button_urunsayfasi.Size = new System.Drawing.Size(90, 26);
            this.button_urunsayfasi.TabIndex = 1;
            this.button_urunsayfasi.Text = "Ürün İşlemleri";
            this.button_urunsayfasi.UseVisualStyleBackColor = true;
            this.button_urunsayfasi.Click += new System.EventHandler(this.button_urunsayfasi_Click);
            // 
            // button_yoneticiekle
            // 
            this.button_yoneticiekle.Location = new System.Drawing.Point(12, 108);
            this.button_yoneticiekle.Name = "button_yoneticiekle";
            this.button_yoneticiekle.Size = new System.Drawing.Size(90, 39);
            this.button_yoneticiekle.TabIndex = 2;
            this.button_yoneticiekle.Text = "Yeni Yönetici Ekle";
            this.button_yoneticiekle.UseVisualStyleBackColor = true;
            this.button_yoneticiekle.Click += new System.EventHandler(this.button_yoneticiekle_Click);
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(12, 76);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(90, 26);
            this.button_geri.TabIndex = 3;
            this.button_geri.Text = "Geri Dön";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // YoneticiMenusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.button_yoneticiekle);
            this.Controls.Add(this.button_urunsayfasi);
            this.Controls.Add(this.button_kullanicilar);
            this.Name = "YoneticiMenusu";
            this.Text = "YöneticiMenüsü";
            this.Load += new System.EventHandler(this.YoneticiMenusu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_kullanicilar;
        private System.Windows.Forms.Button button_urunsayfasi;
        private System.Windows.Forms.Button button_yoneticiekle;
        private System.Windows.Forms.Button button_geri;
    }
}
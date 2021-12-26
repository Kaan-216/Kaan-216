
namespace Proje7
{
    partial class SeciliUrunSayfasi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_isim = new System.Windows.Forms.Label();
            this.label_özellikler = new System.Windows.Forms.Label();
            this.label3_aciklama = new System.Windows.Forms.Label();
            this.label_fiyat = new System.Windows.Forms.Label();
            this.label_adet = new System.Windows.Forms.Label();
            this.button_geri = new System.Windows.Forms.Button();
            this.button_satinal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 340);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_isim
            // 
            this.label_isim.AutoSize = true;
            this.label_isim.Location = new System.Drawing.Point(516, 58);
            this.label_isim.Name = "label_isim";
            this.label_isim.Size = new System.Drawing.Size(45, 13);
            this.label_isim.TabIndex = 1;
            this.label_isim.Text = "ürün adı";
            // 
            // label_özellikler
            // 
            this.label_özellikler.AutoSize = true;
            this.label_özellikler.Location = new System.Drawing.Point(544, 157);
            this.label_özellikler.Name = "label_özellikler";
            this.label_özellikler.Size = new System.Drawing.Size(49, 13);
            this.label_özellikler.TabIndex = 2;
            this.label_özellikler.Text = "özellikleri";
            // 
            // label3_aciklama
            // 
            this.label3_aciklama.AutoSize = true;
            this.label3_aciklama.Location = new System.Drawing.Point(544, 250);
            this.label3_aciklama.Name = "label3_aciklama";
            this.label3_aciklama.Size = new System.Drawing.Size(56, 13);
            this.label3_aciklama.TabIndex = 3;
            this.label3_aciklama.Text = "açıklaması";
            this.label3_aciklama.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_fiyat
            // 
            this.label_fiyat.AutoSize = true;
            this.label_fiyat.Location = new System.Drawing.Point(92, 389);
            this.label_fiyat.Name = "label_fiyat";
            this.label_fiyat.Size = new System.Drawing.Size(13, 13);
            this.label_fiyat.TabIndex = 4;
            this.label_fiyat.Text = "0";
            // 
            // label_adet
            // 
            this.label_adet.AutoSize = true;
            this.label_adet.Location = new System.Drawing.Point(228, 389);
            this.label_adet.Name = "label_adet";
            this.label_adet.Size = new System.Drawing.Size(13, 13);
            this.label_adet.TabIndex = 5;
            this.label_adet.Text = "0";
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(713, 12);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(75, 23);
            this.button_geri.TabIndex = 6;
            this.button_geri.Text = "Geri Gel";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // button_satinal
            // 
            this.button_satinal.Location = new System.Drawing.Point(713, 389);
            this.button_satinal.Name = "button_satinal";
            this.button_satinal.Size = new System.Drawing.Size(75, 23);
            this.button_satinal.TabIndex = 8;
            this.button_satinal.Text = "Satın Al";
            this.button_satinal.UseVisualStyleBackColor = true;
            this.button_satinal.Click += new System.EventHandler(this.button_satinal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fiyat =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kalan adet =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ürün açıklaması =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ürün özellikleri =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ürün adı =";
            // 
            // SeciliUrunSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_satinal);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.label_adet);
            this.Controls.Add(this.label_fiyat);
            this.Controls.Add(this.label3_aciklama);
            this.Controls.Add(this.label_özellikler);
            this.Controls.Add(this.label_isim);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SeciliUrunSayfasi";
            this.Text = "SeciliUrunSayfasi";
            this.Load += new System.EventHandler(this.SeciliUrunSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_isim;
        private System.Windows.Forms.Label label_özellikler;
        private System.Windows.Forms.Label label3_aciklama;
        private System.Windows.Forms.Label label_fiyat;
        private System.Windows.Forms.Label label_adet;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.Button button_satinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
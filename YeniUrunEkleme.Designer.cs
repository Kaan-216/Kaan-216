
namespace Proje7
{
    partial class YeniUrunEkleme
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
            this.button_kayitol = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_ürünozellik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_ürünkdv = new System.Windows.Forms.TextBox();
            this.tbox_ürünfiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_ürünaciklama = new System.Windows.Forms.TextBox();
            this.tbox_urunadi = new System.Windows.Forms.TextBox();
            this.button_geri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_urunmiktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_urunagirlik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_urunID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_kayitol
            // 
            this.button_kayitol.Location = new System.Drawing.Point(85, 381);
            this.button_kayitol.Name = "button_kayitol";
            this.button_kayitol.Size = new System.Drawing.Size(105, 57);
            this.button_kayitol.TabIndex = 45;
            this.button_kayitol.Text = "Ürün Ekle";
            this.button_kayitol.UseVisualStyleBackColor = true;
            this.button_kayitol.Click += new System.EventHandler(this.button_kayitol_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ürün özellikleri";
            // 
            // tbox_ürünozellik
            // 
            this.tbox_ürünozellik.Location = new System.Drawing.Point(103, 232);
            this.tbox_ürünozellik.Name = "tbox_ürünozellik";
            this.tbox_ürünozellik.Size = new System.Drawing.Size(185, 20);
            this.tbox_ürünozellik.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ürün kdv oranı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ürün fiyatı";
            // 
            // tbox_ürünkdv
            // 
            this.tbox_ürünkdv.Location = new System.Drawing.Point(103, 284);
            this.tbox_ürünkdv.Name = "tbox_ürünkdv";
            this.tbox_ürünkdv.Size = new System.Drawing.Size(185, 20);
            this.tbox_ürünkdv.TabIndex = 40;
            // 
            // tbox_ürünfiyat
            // 
            this.tbox_ürünfiyat.Location = new System.Drawing.Point(103, 258);
            this.tbox_ürünfiyat.Name = "tbox_ürünfiyat";
            this.tbox_ürünfiyat.Size = new System.Drawing.Size(185, 20);
            this.tbox_ürünfiyat.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ürün açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ürün adı";
            // 
            // tbox_ürünaciklama
            // 
            this.tbox_ürünaciklama.Location = new System.Drawing.Point(103, 206);
            this.tbox_ürünaciklama.Name = "tbox_ürünaciklama";
            this.tbox_ürünaciklama.Size = new System.Drawing.Size(185, 20);
            this.tbox_ürünaciklama.TabIndex = 36;
            this.tbox_ürünaciklama.TextChanged += new System.EventHandler(this.tboxsifre_TextChanged);
            // 
            // tbox_urunadi
            // 
            this.tbox_urunadi.Location = new System.Drawing.Point(103, 180);
            this.tbox_urunadi.Name = "tbox_urunadi";
            this.tbox_urunadi.Size = new System.Drawing.Size(185, 20);
            this.tbox_urunadi.TabIndex = 35;
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(12, 12);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(75, 23);
            this.button_geri.TabIndex = 46;
            this.button_geri.Text = "Geri Gel";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ürün miktarı";
            // 
            // textBox_urunmiktar
            // 
            this.textBox_urunmiktar.Location = new System.Drawing.Point(103, 310);
            this.textBox_urunmiktar.Name = "textBox_urunmiktar";
            this.textBox_urunmiktar.Size = new System.Drawing.Size(185, 20);
            this.textBox_urunmiktar.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Ürün ağırlığı";
            // 
            // textBox_urunagirlik
            // 
            this.textBox_urunagirlik.Location = new System.Drawing.Point(103, 336);
            this.textBox_urunagirlik.Name = "textBox_urunagirlik";
            this.textBox_urunagirlik.Size = new System.Drawing.Size(185, 20);
            this.textBox_urunagirlik.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Eklenecek Ürün ID";
            // 
            // textBox_urunID
            // 
            this.textBox_urunID.Enabled = false;
            this.textBox_urunID.Location = new System.Drawing.Point(119, 154);
            this.textBox_urunID.Name = "textBox_urunID";
            this.textBox_urunID.Size = new System.Drawing.Size(169, 20);
            this.textBox_urunID.TabIndex = 51;
            // 
            // YeniUrunEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_urunID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_urunagirlik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_urunmiktar);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.button_kayitol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbox_ürünozellik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_ürünkdv);
            this.Controls.Add(this.tbox_ürünfiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_ürünaciklama);
            this.Controls.Add(this.tbox_urunadi);
            this.Name = "YeniUrunEkleme";
            this.Text = "YeniUrunEkleme";
            this.Load += new System.EventHandler(this.YeniUrunEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kayitol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_ürünozellik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_ürünkdv;
        private System.Windows.Forms.TextBox tbox_ürünfiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_ürünaciklama;
        private System.Windows.Forms.TextBox tbox_urunadi;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_urunmiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_urunagirlik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_urunID;
    }
}
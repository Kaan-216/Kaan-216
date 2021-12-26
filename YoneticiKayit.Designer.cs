
namespace Proje7
{
    partial class YoneticiKayit
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
            this.tboxmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxsoyisim = new System.Windows.Forms.TextBox();
            this.tboxisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxsifre = new System.Windows.Forms.TextBox();
            this.tboxkullaniciadi = new System.Windows.Forms.TextBox();
            this.button_geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_kayitol
            // 
            this.button_kayitol.Location = new System.Drawing.Point(336, 381);
            this.button_kayitol.Name = "button_kayitol";
            this.button_kayitol.Size = new System.Drawing.Size(105, 57);
            this.button_kayitol.TabIndex = 45;
            this.button_kayitol.Text = "Kayıt ol";
            this.button_kayitol.UseVisualStyleBackColor = true;
            this.button_kayitol.Click += new System.EventHandler(this.button_kayitol_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Email";
            // 
            // tboxmail
            // 
            this.tboxmail.Location = new System.Drawing.Point(336, 290);
            this.tboxmail.Name = "tboxmail";
            this.tboxmail.Size = new System.Drawing.Size(130, 20);
            this.tboxmail.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Soyisim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "İsim";
            // 
            // tboxsoyisim
            // 
            this.tboxsoyisim.Location = new System.Drawing.Point(336, 342);
            this.tboxsoyisim.Name = "tboxsoyisim";
            this.tboxsoyisim.Size = new System.Drawing.Size(130, 20);
            this.tboxsoyisim.TabIndex = 40;
            // 
            // tboxisim
            // 
            this.tboxisim.Location = new System.Drawing.Point(336, 316);
            this.tboxisim.Name = "tboxisim";
            this.tboxisim.Size = new System.Drawing.Size(130, 20);
            this.tboxisim.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // tboxsifre
            // 
            this.tboxsifre.Location = new System.Drawing.Point(336, 264);
            this.tboxsifre.Name = "tboxsifre";
            this.tboxsifre.PasswordChar = '*';
            this.tboxsifre.Size = new System.Drawing.Size(130, 20);
            this.tboxsifre.TabIndex = 36;
            // 
            // tboxkullaniciadi
            // 
            this.tboxkullaniciadi.Location = new System.Drawing.Point(336, 238);
            this.tboxkullaniciadi.Name = "tboxkullaniciadi";
            this.tboxkullaniciadi.Size = new System.Drawing.Size(130, 20);
            this.tboxkullaniciadi.TabIndex = 35;
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(12, 12);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(75, 23);
            this.button_geri.TabIndex = 47;
            this.button_geri.Text = "Geri Gel";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // YoneticiKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.button_kayitol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxsoyisim);
            this.Controls.Add(this.tboxisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxsifre);
            this.Controls.Add(this.tboxkullaniciadi);
            this.Name = "YoneticiKayit";
            this.Text = "YoneticiKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_kayitol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxsoyisim;
        private System.Windows.Forms.TextBox tboxisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxsifre;
        private System.Windows.Forms.TextBox tboxkullaniciadi;
        private System.Windows.Forms.Button button_geri;
    }
}
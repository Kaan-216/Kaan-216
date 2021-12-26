
namespace Proje7
{
    partial class GirisEkrani
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
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxgirissifre = new System.Windows.Forms.TextBox();
            this.tboxgiriskullaniciadi = new System.Windows.Forms.TextBox();
            this.button_kayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_geri_dön = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(237, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 57);
            this.button4.TabIndex = 25;
            this.button4.Text = "Giriş Yap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Şifre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Kullanıcı Adı";
            // 
            // tboxgirissifre
            // 
            this.tboxgirissifre.Location = new System.Drawing.Point(102, 397);
            this.tboxgirissifre.Name = "tboxgirissifre";
            this.tboxgirissifre.PasswordChar = '*';
            this.tboxgirissifre.Size = new System.Drawing.Size(130, 20);
            this.tboxgirissifre.TabIndex = 22;
            // 
            // tboxgiriskullaniciadi
            // 
            this.tboxgiriskullaniciadi.Location = new System.Drawing.Point(102, 354);
            this.tboxgiriskullaniciadi.Name = "tboxgiriskullaniciadi";
            this.tboxgiriskullaniciadi.Size = new System.Drawing.Size(130, 20);
            this.tboxgiriskullaniciadi.TabIndex = 21;
            // 
            // button_kayit
            // 
            this.button_kayit.Location = new System.Drawing.Point(348, 356);
            this.button_kayit.Name = "button_kayit";
            this.button_kayit.Size = new System.Drawing.Size(105, 57);
            this.button_kayit.TabIndex = 26;
            this.button_kayit.Text = "Kayıt Ol";
            this.button_kayit.UseVisualStyleBackColor = true;
            this.button_kayit.Click += new System.EventHandler(this.button_kayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Lütfen giriş yapınız eğer hesabınız yok ise kayıt olunuz.";
            // 
            // button_geri_dön
            // 
            this.button_geri_dön.Location = new System.Drawing.Point(12, 12);
            this.button_geri_dön.Name = "button_geri_dön";
            this.button_geri_dön.Size = new System.Drawing.Size(84, 23);
            this.button_geri_dön.TabIndex = 28;
            this.button_geri_dön.Text = "Geri Dön";
            this.button_geri_dön.UseVisualStyleBackColor = true;
            this.button_geri_dön.Click += new System.EventHandler(this.button_geri_dön_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_geri_dön);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_kayit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxgirissifre);
            this.Controls.Add(this.tboxgiriskullaniciadi);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxgirissifre;
        private System.Windows.Forms.TextBox tboxgiriskullaniciadi;
        private System.Windows.Forms.Button button_kayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_geri_dön;
    }
}
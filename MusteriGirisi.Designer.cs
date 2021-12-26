
namespace projetaslak
{
    partial class MusteriGirisi
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
            this.Giris_lbl = new System.Windows.Forms.Label();
            this.tsk_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.btn_ksifre = new System.Windows.Forms.Button();
            this.btn_kgiris = new System.Windows.Forms.Button();
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.txt_ksifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Giris_lbl
            // 
            this.Giris_lbl.AutoSize = true;
            this.Giris_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Giris_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Giris_lbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Giris_lbl.Font = new System.Drawing.Font("Brush Script MT", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Giris_lbl.Location = new System.Drawing.Point(168, 65);
            this.Giris_lbl.Name = "Giris_lbl";
            this.Giris_lbl.Size = new System.Drawing.Size(473, 74);
            this.Giris_lbl.TabIndex = 1;
            this.Giris_lbl.Text = "RESK COMPANY";
            // 
            // tsk_lbl
            // 
            this.tsk_lbl.AutoSize = true;
            this.tsk_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tsk_lbl.Font = new System.Drawing.Font("Verdana", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.tsk_lbl.Location = new System.Drawing.Point(227, 175);
            this.tsk_lbl.Name = "tsk_lbl";
            this.tsk_lbl.Size = new System.Drawing.Size(363, 23);
            this.tsk_lbl.TabIndex = 2;
            this.tsk_lbl.Text = "Bizi Tercih Ettiğiniz İçin Teşekkürler..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(188, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "(Kullanıcı Adınız, isim-soyisim formatındadır.)";
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.BackColor = System.Drawing.SystemColors.Info;
            this.btn_kullanici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_kullanici.Location = new System.Drawing.Point(191, 285);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(147, 29);
            this.btn_kullanici.TabIndex = 4;
            this.btn_kullanici.Text = "Kullanıcı Adı:";
            this.btn_kullanici.UseVisualStyleBackColor = false;
            // 
            // btn_ksifre
            // 
            this.btn_ksifre.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ksifre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ksifre.Location = new System.Drawing.Point(191, 342);
            this.btn_ksifre.Name = "btn_ksifre";
            this.btn_ksifre.Size = new System.Drawing.Size(147, 29);
            this.btn_ksifre.TabIndex = 5;
            this.btn_ksifre.Text = "Şifre:";
            this.btn_ksifre.UseVisualStyleBackColor = false;
            // 
            // btn_kgiris
            // 
            this.btn_kgiris.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_kgiris.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_kgiris.Location = new System.Drawing.Point(413, 390);
            this.btn_kgiris.Name = "btn_kgiris";
            this.btn_kgiris.Size = new System.Drawing.Size(147, 46);
            this.btn_kgiris.TabIndex = 8;
            this.btn_kgiris.Text = "Giriş Yap";
            this.btn_kgiris.UseVisualStyleBackColor = false;
            this.btn_kgiris.Click += new System.EventHandler(this.btn_kgiris_Click);
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.Location = new System.Drawing.Point(372, 285);
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(218, 27);
            this.txt_kullanici.TabIndex = 9;
            // 
            // txt_ksifre
            // 
            this.txt_ksifre.Location = new System.Drawing.Point(372, 342);
            this.txt_ksifre.Name = "txt_ksifre";
            this.txt_ksifre.Size = new System.Drawing.Size(218, 27);
            this.txt_ksifre.TabIndex = 10;
            this.txt_ksifre.UseSystemPasswordChar = true;
            this.txt_ksifre.TextChanged += new System.EventHandler(this.txt_ksifre_TextChanged);
            // 
            // MusteriGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projetaslak.Properties.Resources.png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_ksifre);
            this.Controls.Add(this.txt_kullanici);
            this.Controls.Add(this.btn_kgiris);
            this.Controls.Add(this.btn_ksifre);
            this.Controls.Add(this.btn_kullanici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsk_lbl);
            this.Controls.Add(this.Giris_lbl);
            this.Name = "MusteriGirisi";
            this.Text = "MusteriGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Giris_lbl;
        private System.Windows.Forms.Label tsk_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.Button btn_ksifre;
        private System.Windows.Forms.Button btn_kgiris;
        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.TextBox txt_ksifre;
    }
}
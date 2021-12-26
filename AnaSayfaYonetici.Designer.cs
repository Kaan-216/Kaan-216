
namespace Proje7
{
    partial class AnaSayfaYonetici
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
            this.label_Bakiye = new System.Windows.Forms.Label();
            this.label_eşittir = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_kullaniciadi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabel_yoneticimenüsü = new System.Windows.Forms.LinkLabel();
            this.button_urunsayfasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Bakiye
            // 
            this.label_Bakiye.AutoSize = true;
            this.label_Bakiye.Location = new System.Drawing.Point(779, 36);
            this.label_Bakiye.Name = "label_Bakiye";
            this.label_Bakiye.Size = new System.Drawing.Size(13, 13);
            this.label_Bakiye.TabIndex = 14;
            this.label_Bakiye.Text = "0";
            // 
            // label_eşittir
            // 
            this.label_eşittir.AutoSize = true;
            this.label_eşittir.Location = new System.Drawing.Point(770, 36);
            this.label_eşittir.Name = "label_eşittir";
            this.label_eşittir.Size = new System.Drawing.Size(13, 13);
            this.label_eşittir.TabIndex = 13;
            this.label_eşittir.Text = "=";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(730, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cüzdan";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_kullaniciadi
            // 
            this.label_kullaniciadi.AutoSize = true;
            this.label_kullaniciadi.Location = new System.Drawing.Point(730, 12);
            this.label_kullaniciadi.Name = "label_kullaniciadi";
            this.label_kullaniciadi.Size = new System.Drawing.Size(35, 13);
            this.label_kullaniciadi.TabIndex = 11;
            this.label_kullaniciadi.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 377);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // linkLabel_yoneticimenüsü
            // 
            this.linkLabel_yoneticimenüsü.AutoSize = true;
            this.linkLabel_yoneticimenüsü.Location = new System.Drawing.Point(621, 12);
            this.linkLabel_yoneticimenüsü.Name = "linkLabel_yoneticimenüsü";
            this.linkLabel_yoneticimenüsü.Size = new System.Drawing.Size(86, 13);
            this.linkLabel_yoneticimenüsü.TabIndex = 15;
            this.linkLabel_yoneticimenüsü.TabStop = true;
            this.linkLabel_yoneticimenüsü.Text = "Yönetici Menüsü";
            this.linkLabel_yoneticimenüsü.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_yoneticimenüsü_LinkClicked);
            // 
            // button_urunsayfasi
            // 
            this.button_urunsayfasi.Location = new System.Drawing.Point(705, 387);
            this.button_urunsayfasi.Name = "button_urunsayfasi";
            this.button_urunsayfasi.Size = new System.Drawing.Size(105, 51);
            this.button_urunsayfasi.TabIndex = 16;
            this.button_urunsayfasi.Text = "Ürün Sayfasına Git";
            this.button_urunsayfasi.UseVisualStyleBackColor = true;
            this.button_urunsayfasi.Click += new System.EventHandler(this.button_urunsayfasi_Click);
            // 
            // AnaSayfaYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.button_urunsayfasi);
            this.Controls.Add(this.linkLabel_yoneticimenüsü);
            this.Controls.Add(this.label_Bakiye);
            this.Controls.Add(this.label_eşittir);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_kullaniciadi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnaSayfaYonetici";
            this.Text = "AnaSayfaYonetici";
            this.Load += new System.EventHandler(this.AnaSayfaYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Bakiye;
        private System.Windows.Forms.Label label_eşittir;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_kullaniciadi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel_yoneticimenüsü;
        private System.Windows.Forms.Button button_urunsayfasi;
    }
}
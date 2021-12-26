
namespace Proje7
{
    partial class AnaSayfaGirisVar
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Bakiye = new System.Windows.Forms.Label();
            this.label_eşittir = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_kullaniciadi = new System.Windows.Forms.Label();
            this.button_urunsayfasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label_Bakiye
            // 
            this.label_Bakiye.AutoSize = true;
            this.label_Bakiye.Location = new System.Drawing.Point(782, 36);
            this.label_Bakiye.Name = "label_Bakiye";
            this.label_Bakiye.Size = new System.Drawing.Size(13, 13);
            this.label_Bakiye.TabIndex = 9;
            this.label_Bakiye.Text = "0";
            // 
            // label_eşittir
            // 
            this.label_eşittir.AutoSize = true;
            this.label_eşittir.Location = new System.Drawing.Point(773, 36);
            this.label_eşittir.Name = "label_eşittir";
            this.label_eşittir.Size = new System.Drawing.Size(13, 13);
            this.label_eşittir.TabIndex = 8;
            this.label_eşittir.Text = "=";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(733, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cüzdan";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_kullaniciadi
            // 
            this.label_kullaniciadi.AutoSize = true;
            this.label_kullaniciadi.Location = new System.Drawing.Point(733, 12);
            this.label_kullaniciadi.Name = "label_kullaniciadi";
            this.label_kullaniciadi.Size = new System.Drawing.Size(35, 13);
            this.label_kullaniciadi.TabIndex = 6;
            this.label_kullaniciadi.Text = "label1";
            // 
            // button_urunsayfasi
            // 
            this.button_urunsayfasi.Location = new System.Drawing.Point(709, 387);
            this.button_urunsayfasi.Name = "button_urunsayfasi";
            this.button_urunsayfasi.Size = new System.Drawing.Size(105, 51);
            this.button_urunsayfasi.TabIndex = 17;
            this.button_urunsayfasi.Text = "Ürün Sayfasına Git";
            this.button_urunsayfasi.UseVisualStyleBackColor = true;
            this.button_urunsayfasi.Click += new System.EventHandler(this.button_urunsayfasi_Click);
            // 
            // AnaSayfaGirisVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.button_urunsayfasi);
            this.Controls.Add(this.label_Bakiye);
            this.Controls.Add(this.label_eşittir);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_kullaniciadi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnaSayfaGirisVar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaSayfaGirisVar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Bakiye;
        private System.Windows.Forms.Label label_eşittir;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_kullaniciadi;
        private System.Windows.Forms.Button button_urunsayfasi;
    }
}


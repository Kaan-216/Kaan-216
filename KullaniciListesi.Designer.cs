
namespace Proje7
{
    partial class KullaniciListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_geri = new System.Windows.Forms.Button();
            this.button_kullanicisil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_secilikullaniciID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1087, 798);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(1189, 12);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(75, 23);
            this.button_geri.TabIndex = 1;
            this.button_geri.Text = "Geri Dön";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // button_kullanicisil
            // 
            this.button_kullanicisil.Location = new System.Drawing.Point(1105, 754);
            this.button_kullanicisil.Name = "button_kullanicisil";
            this.button_kullanicisil.Size = new System.Drawing.Size(159, 56);
            this.button_kullanicisil.TabIndex = 2;
            this.button_kullanicisil.Text = "Kullanıcıyı Sil";
            this.button_kullanicisil.UseVisualStyleBackColor = true;
            this.button_kullanicisil.Click += new System.EventHandler(this.button_kullanicisil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1106, 735);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seçili kullanıcı ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_secilikullaniciID
            // 
            this.textBox_secilikullaniciID.Enabled = false;
            this.textBox_secilikullaniciID.Location = new System.Drawing.Point(1199, 732);
            this.textBox_secilikullaniciID.Name = "textBox_secilikullaniciID";
            this.textBox_secilikullaniciID.Size = new System.Drawing.Size(45, 20);
            this.textBox_secilikullaniciID.TabIndex = 4;
            this.textBox_secilikullaniciID.Text = "0";
            // 
            // KullaniciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 822);
            this.Controls.Add(this.textBox_secilikullaniciID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_kullanicisil);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullaniciListesi";
            this.Text = "KullaniciListesi";
            this.Load += new System.EventHandler(this.KullaniciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.Button button_kullanicisil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_secilikullaniciID;
    }
}
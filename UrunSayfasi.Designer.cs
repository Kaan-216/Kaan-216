
namespace Proje7
{
    partial class UrunSayfasi
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
            this.textBox_seciliurunID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_urunadet = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button_yeniurun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_fiyatgnclleme = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_urunadet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 800);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // button_geri
            // 
            this.button_geri.Location = new System.Drawing.Point(1188, 12);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(75, 23);
            this.button_geri.TabIndex = 2;
            this.button_geri.Text = "Geri Dön";
            this.button_geri.UseVisualStyleBackColor = true;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // textBox_seciliurunID
            // 
            this.textBox_seciliurunID.Enabled = false;
            this.textBox_seciliurunID.Location = new System.Drawing.Point(1218, 41);
            this.textBox_seciliurunID.Name = "textBox_seciliurunID";
            this.textBox_seciliurunID.Size = new System.Drawing.Size(45, 20);
            this.textBox_seciliurunID.TabIndex = 6;
            this.textBox_seciliurunID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1125, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seçili Ürün ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1116, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seçili Ürünün Adetini Düzenle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDown_urunadet
            // 
            this.numericUpDown_urunadet.Location = new System.Drawing.Point(1140, 97);
            this.numericUpDown_urunadet.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_urunadet.Name = "numericUpDown_urunadet";
            this.numericUpDown_urunadet.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_urunadet.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1185, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_yeniurun
            // 
            this.button_yeniurun.Location = new System.Drawing.Point(1116, 744);
            this.button_yeniurun.Name = "button_yeniurun";
            this.button_yeniurun.Size = new System.Drawing.Size(147, 68);
            this.button_yeniurun.TabIndex = 10;
            this.button_yeniurun.Text = "Yeni Ürün Ekle";
            this.button_yeniurun.UseVisualStyleBackColor = true;
            this.button_yeniurun.Click += new System.EventHandler(this.button_yeniurun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1113, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seçili Ürünün Fiyatını Düzenle";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_fiyatgnclleme
            // 
            this.textBox_fiyatgnclleme.Location = new System.Drawing.Point(1143, 177);
            this.textBox_fiyatgnclleme.Name = "textBox_fiyatgnclleme";
            this.textBox_fiyatgnclleme.Size = new System.Drawing.Size(117, 20);
            this.textBox_fiyatgnclleme.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1185, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Onayla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UrunSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 824);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_fiyatgnclleme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_yeniurun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_urunadet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_seciliurunID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunSayfasi";
            this.Text = "UrunSayfasi";
            this.Load += new System.EventHandler(this.UrunSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_urunadet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.TextBox textBox_seciliurunID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_urunadet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_yeniurun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_fiyatgnclleme;
        private System.Windows.Forms.Button button2;
    }
}
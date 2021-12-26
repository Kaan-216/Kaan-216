
namespace Proje7
{
    partial class AnaSayfaGirisYok
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
            this.linkLabel_girisyap = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_urunsayfasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_girisyap
            // 
            this.linkLabel_girisyap.AutoSize = true;
            this.linkLabel_girisyap.Location = new System.Drawing.Point(739, 12);
            this.linkLabel_girisyap.Name = "linkLabel_girisyap";
            this.linkLabel_girisyap.Size = new System.Drawing.Size(49, 13);
            this.linkLabel_girisyap.TabIndex = 5;
            this.linkLabel_girisyap.TabStop = true;
            this.linkLabel_girisyap.Text = "Giriş Yap";
            this.linkLabel_girisyap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_girisyap_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 381);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button_urunsayfasi
            // 
            this.button_urunsayfasi.Location = new System.Drawing.Point(683, 387);
            this.button_urunsayfasi.Name = "button_urunsayfasi";
            this.button_urunsayfasi.Size = new System.Drawing.Size(105, 51);
            this.button_urunsayfasi.TabIndex = 17;
            this.button_urunsayfasi.Text = "Ürün Sayfasına Git";
            this.button_urunsayfasi.UseVisualStyleBackColor = true;
            this.button_urunsayfasi.Click += new System.EventHandler(this.button_urunsayfasi_Click);
            // 
            // AnaSayfaGirisYok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_urunsayfasi);
            this.Controls.Add(this.linkLabel_girisyap);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnaSayfaGirisYok";
            this.Text = "AnaSayfaGirisYok";
            this.Load += new System.EventHandler(this.AnaSayfaGirisYok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_girisyap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_urunsayfasi;
    }
}
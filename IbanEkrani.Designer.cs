
namespace Proje7
{
    partial class IbanEkrani
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kartnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_kontrol = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yatırılacak iban numarası";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(147, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "TR11 1111 1111 1111 1111";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Banka Adı";
            // 
            // textBox_kartnum
            // 
            this.textBox_kartnum.Enabled = false;
            this.textBox_kartnum.Location = new System.Drawing.Point(147, 88);
            this.textBox_kartnum.Name = "textBox_kartnum";
            this.textBox_kartnum.Size = new System.Drawing.Size(187, 20);
            this.textBox_kartnum.TabIndex = 10;
            this.textBox_kartnum.Text = "Kiraat Bankası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hesap sahibi ismi ";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(147, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Mehmet Kaan ALTUN";
            // 
            // button_kontrol
            // 
            this.button_kontrol.Location = new System.Drawing.Point(221, 181);
            this.button_kontrol.Name = "button_kontrol";
            this.button_kontrol.Size = new System.Drawing.Size(136, 51);
            this.button_kontrol.TabIndex = 18;
            this.button_kontrol.Text = "Kontrol";
            this.button_kontrol.UseVisualStyleBackColor = true;
            this.button_kontrol.Click += new System.EventHandler(this.button_kontrol_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.Location = new System.Drawing.Point(12, 12);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(81, 28);
            this.button_iptal.TabIndex = 19;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Eğer ibana parayı yatırdıysanız lütfen aşşağıdaki kontrol butonuna tıklayınız.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(82, 198);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 23);
            this.progressBar1.Step = 3;
            this.progressBar1.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            // 
            // IbanEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 264);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_kontrol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_kartnum);
            this.Name = "IbanEkrani";
            this.Text = "IbanEkrani";
            this.Load += new System.EventHandler(this.IbanEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kartnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_kontrol;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
    }
}
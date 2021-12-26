using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Proje7
{
    public partial class IbanEkrani : Form
    {
        public IbanEkrani()
        {
            InitializeComponent();
        }

        private void IbanEkrani_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            progressBar1.Maximum = 3;
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 3)
            {
            progressBar1.Value++;
            }
            else
            {
            timer1.Stop();
            Bakiye.bakiye_ekle(Iban.yuklenenmiktar2);
            Iban.yuklenenmiktar2 = 0;
            MessageBox.Show("Kontroller Tamamlandı Ödeme Başarılı");
            Cuzdan yeniforma = new Cuzdan();
            yeniforma.Show();
            this.Close();
                
            }
            
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            Cuzdan yeniforma = new Cuzdan();
            yeniforma.Show();
            this.Close();
        }

        private void button_kontrol_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }
    }
}




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje7
{
    public partial class KrediKartiEkrani : Form
    {
        public static int kimgeldiacaba;
        
        public KrediKartiEkrani()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_öde_Click(object sender, EventArgs e)
        {
            if ( textBox_kartnum.Text.Length == 16 && textBox_cvc.Text.Length == 3 )
            {
                if (kimgeldiacaba==1)
                {
                    Bakiye.bakiye_ekle(KrediKartı.yuklenenmiktar);
                    KrediKartı.yuklenenmiktar = 0;
                    MessageBox.Show("Ödeme başarılı");
                    Cuzdan yeniforma = new Cuzdan();
                    yeniforma.Show();
                    this.Close();
                }
                else if (kimgeldiacaba==2)
                {
                    MessageBox.Show("Siparişiniz başarıyla verilmiştir iyi alışverişler.");
                    OdemeSayfasi forma = new OdemeSayfasi();
                    forma.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı kart bilgileri lütfen tekrar deneyiniz.");
            }

        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            Cuzdan yeniforma = new Cuzdan();
            yeniforma.Show();
            this.Close();
        }

        private void KrediKartiEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}

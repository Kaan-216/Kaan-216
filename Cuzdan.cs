using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje7
{
    public partial class Cuzdan : Form
    {
        
        public Cuzdan()
        {
            InitializeComponent();
        }

        public void yenile()
        {
            label_cuzdan_kullaniciadi.Text = aktifkullanici.aktifkullanici_kullaniciadi;
            label_aktifbakiye.Text = aktifkullanici.aktifkullanici_Bakiye.ToString();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            if (aktifkullanici.aktifkullanici_yoneticidurumu == 0)
            {
                AnaSayfaGirisVar yeniform = new AnaSayfaGirisVar();
                yeniform.Show();
                this.Hide();
            }
            else
            {
                AnaSayfaYonetici yeniforma = new AnaSayfaYonetici();
                yeniforma.Show();
                this.Hide();
            }
        }

        private void button_10tl_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                KrediKartı.odemeoncesi_kk(10);
                this.Close();
            }
            else if (checkBox2.Checked == true)
            {
                Iban.odeme_oncesi_iban(10);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
            }
        }

        private void button_50tl_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                KrediKartı.odemeoncesi_kk(50);
                this.Close();
            }
            else if (checkBox2.Checked == true)
            {
                Iban.odeme_oncesi_iban(50);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
            }
        }

        private void button_20tl_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                KrediKartı.odemeoncesi_kk(20);
                this.Close();
            }
            else if (checkBox2.Checked == true)
            {
                Iban.odeme_oncesi_iban(20);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
            }
        }

        private void button_100tl_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                KrediKartı.odemeoncesi_kk(100);
                this.Close();
            }
            else if (checkBox2.Checked == true)
            {
                Iban.odeme_oncesi_iban(100);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
            }
        }

        private void button_500tl_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                KrediKartı.odemeoncesi_kk(500);
                this.Close();
            }
            else if (checkBox2.Checked == true)
            {
                Iban.odeme_oncesi_iban(500);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
            }
        }

        private void button_200tl_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                KrediKartı.odemeoncesi_kk(200);
                this.Close();
            }
            else if (checkBox2.Checked == true)
            {
                Iban.odeme_oncesi_iban(200);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
            }
        }

        private void button_yukle_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                KrediKartı.odemeoncesi_kk(Convert.ToInt32(textBox_bakiye_ekle_miktar.Text));
                this.Close();
            }
            else if (checkBox2.Checked == true)
            {
                Iban.odeme_oncesi_iban(Convert.ToInt32(textBox_bakiye_ekle_miktar.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
            }
        }

        private void Cuzdan_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }
    }
}

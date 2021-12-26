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
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void button_kayitol_Click(object sender, EventArgs e)
        {
            Müsteri yenikullanici = new Müsteri(tboxisim.Text, tboxsoyisim.Text, tboxkullaniciadi.Text, tboxsifre.Text, tboxmail.Text);

            MessageBox.Show("Başarıyla kayıt olundu.");

            GirisEkrani yeniform = new GirisEkrani();
            yeniform.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tboxmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tboxsoyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tboxsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tboxkullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            GirisEkrani yeniekran = new GirisEkrani();
            yeniekran.Show();
            this.Hide();
        }
    }
}

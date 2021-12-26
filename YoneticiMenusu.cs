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
    public partial class YoneticiMenusu : Form
    {
        public YoneticiMenusu()
        {
            InitializeComponent();
        }

        private void YoneticiMenusu_Load(object sender, EventArgs e)
        {

        }

        private void button_kullanicilar_Click(object sender, EventArgs e)
        {
            KullaniciListesi yeniform = new KullaniciListesi();
            yeniform.Show();
            this.Close();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            AnaSayfaYonetici yeniform = new AnaSayfaYonetici();
            yeniform.Show();
            this.Close();
        }

        private void button_yoneticiekle_Click(object sender, EventArgs e)
        {
            YoneticiKayit yeniform = new YoneticiKayit();
            yeniform.Show();
            this.Close();
        }

        private void button_urunsayfasi_Click(object sender, EventArgs e)
        {
            UrunSayfasi yeniform = new UrunSayfasi();
            yeniform.Show();
            this.Close();
        }
    }
}

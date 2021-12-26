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
    public partial class YoneticiKayit : Form
    {
        public YoneticiKayit()
        {
            InitializeComponent();
        }

        private void button_kayitol_Click(object sender, EventArgs e)
        {
            Yonetici yenikullanici = new Yonetici(tboxisim.Text, tboxsoyisim.Text, tboxkullaniciadi.Text, tboxsifre.Text, tboxmail.Text);

            MessageBox.Show("Yeni yönetici başarıyla kayıt edildi.");

            YoneticiMenusu yeniform = new YoneticiMenusu();
            yeniform.Show();
            this.Hide();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            YoneticiMenusu yeniforma = new YoneticiMenusu();
            yeniforma.Show();
            this.Close();
        }
    }
}

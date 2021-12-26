using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Proje7
{
    public partial class YeniUrunEkleme : Form
    {
        public YeniUrunEkleme()
        {
            InitializeComponent();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            YoneticiMenusu yeniforma = new YoneticiMenusu();
            yeniforma.Show();
            this.Close();
        }

        private void tboxsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void yenile()
        {
            StreamReader sr = new StreamReader("C:\\Users\\echol\\source\\repos\\Proje7\\Proje7\\ürünID.txt");
            textBox_urunID.Text = sr.ReadToEnd();
            sr.Close();
        }
        
        private void YeniUrunEkleme_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void button_kayitol_Click(object sender, EventArgs e)
        {
            SqlCommand sqlurunekle = new SqlCommand("Insert into urunData (urun_isim,urun_ozellikler,urun_aciklama,urun_fiyat,urun_adet,urun_kdvoran,urun_agirlik) values (@isim,@özellikler,@aciklama,@fiyat,@adet,@kdvoran,@agirlik)", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlurunekle.Parameters.AddWithValue("@isim", tbox_urunadi.Text);
            sqlurunekle.Parameters.AddWithValue("@özellikler", tbox_ürünozellik.Text);
            sqlurunekle.Parameters.AddWithValue("@aciklama", tbox_ürünaciklama.Text);
            sqlurunekle.Parameters.AddWithValue("@fiyat", tbox_ürünfiyat.Text);
            sqlurunekle.Parameters.AddWithValue("@adet", textBox_urunmiktar.Text);
            sqlurunekle.Parameters.AddWithValue("@kdvoran", tbox_ürünkdv.Text);
            sqlurunekle.Parameters.AddWithValue("@agirlik", textBox_urunagirlik.Text);

            sqlurunekle.ExecuteNonQuery();

            TextWriter tw = new StreamWriter("C:\\Users\\echol\\source\\repos\\Proje7\\Proje7\\ürünID.txt");
            tw.Write((Convert.ToInt32(textBox_urunID.Text) + 1).ToString());
            tw.Close();

            MessageBox.Show("Yeni ürün başarıyla vitrinlerde yerini aldı.");
        }
    }
}

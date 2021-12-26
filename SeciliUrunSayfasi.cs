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
    public partial class SeciliUrunSayfasi : Form
    {
        int urunID = UrunSayfasi.seciliID_form;
        public static int kimgeldi=2;
        public static string urun_isim;
        public static int urun_fiyat;
        public static int urun_kdvoran;
        public static int urun_adet;
        public static int urun_agirlik;
        
        public SeciliUrunSayfasi()
        {
            InitializeComponent();
        }

        private void SeciliUrunSayfasi_Load(object sender, EventArgs e)
        {
            SqlCommand urunsayfasi = new SqlCommand("Select * from urunData where urun_ID=@urunid", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            urunsayfasi.Parameters.AddWithValue("@urunid", urunID);

            SqlDataAdapter da2 = new SqlDataAdapter(urunsayfasi);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);
            urunsayfasi.ExecuteNonQuery();

            label_fiyat.Text = dt2.Rows[0]["urun_fiyat"].ToString();
            label_isim.Text = dt2.Rows[0]["urun_isim"].ToString();
            label3_aciklama.Text = dt2.Rows[0]["urun_aciklama"].ToString();
            label_adet.Text = dt2.Rows[0]["urun_adet"].ToString();
            label_özellikler.Text = dt2.Rows[0]["urun_ozellikler"].ToString();
            urun_isim = dt2.Rows[0]["urun_isim"].ToString();
            urun_fiyat = Convert.ToInt32(dt2.Rows[0]["urun_fiyat"]);
            urun_adet = Convert.ToInt32(dt2.Rows[0]["urun_adet"]);
            urun_kdvoran = Convert.ToInt32(dt2.Rows[0]["urun_kdvoran"]);
            urun_agirlik = Convert.ToInt32(dt2.Rows[0]["urun_agirlik"]);

            pictureBox1.Image = Image.FromFile($@"C:\Users\echol\Desktop\Pictures\{urunID}.png");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            if (SeciliUrunSayfasi.kimgeldi == 1)
            {
                AnaSayfaGirisVar forma = new AnaSayfaGirisVar();
                forma.Show();
                this.Close();
            }
            else if (SeciliUrunSayfasi.kimgeldi == 2)
            {
                AnaSayfaGirisYok forma = new AnaSayfaGirisYok();
                forma.Show();
                this.Close();
            }
            else
            {
                AnaSayfaYonetici forma = new AnaSayfaYonetici();
                forma.Show();
                this.Close();
            }
        }

        private void button_satinal_Click(object sender, EventArgs e)
        {
            OdemeSayfasi forma = new OdemeSayfasi();
            forma.Show();
            this.Hide();
        }
    }
}

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
    public partial class GirisEkrani : Form
    {
        public static int kimgeldi2=2;
        
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand sqlgirisyapma = new SqlCommand("Select * from Userdata where kullaniciadi = @kullaniciadi and sifre = @sifre ", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlgirisyapma.Parameters.AddWithValue("@kullaniciadi", tboxgiriskullaniciadi.Text);
            sqlgirisyapma.Parameters.AddWithValue("@sifre", tboxgirissifre.Text);

            SqlDataAdapter da2 = new SqlDataAdapter(sqlgirisyapma);
            DataTable dt2 = new DataTable();

            da2.Fill(dt2);

            if (dt2.Rows.Count > 0)
            {
                MessageBox.Show("Giriş başarılı");

                aktifkullanici.aktifkullanici_isim = dt2.Rows[0]["isim"].ToString();
                aktifkullanici.aktifkullanici_soyisim = dt2.Rows[0]["soyisim"].ToString();
                aktifkullanici.aktifkullanici_kullaniciadi = dt2.Rows[0]["kullaniciadi"].ToString();
                aktifkullanici.aktifkullanici_sifre = dt2.Rows[0]["sifre"].ToString();
                aktifkullanici.aktifkullanici_email = dt2.Rows[0]["email"].ToString();
                aktifkullanici.aktifkullanici_Bakiye = Convert.ToInt32(dt2.Rows[0]["bakiye"]);
                aktifkullanici.aktifkullanici_yoneticidurumu = Convert.ToInt32(dt2.Rows[0]["yoneticidurumu"]);
                aktifkullanici.aktifkullanici_userID = Convert.ToInt32(dt2.Rows[0]["userID"]);
                aktifkullanici.aktifkullanici_sehir = dt2.Rows[0]["sehir"].ToString();
                aktifkullanici.aktifkullanici_ilce = dt2.Rows[0]["ilce"].ToString();
                aktifkullanici.aktifkullanici_mahalle = dt2.Rows[0]["mahalle"].ToString();
                aktifkullanici.aktifkullanici_sokak = dt2.Rows[0]["sokak"].ToString();
                aktifkullanici.aktifkullanici_bina_no = Convert.ToInt32(dt2.Rows[0]["bina_no"]);
                aktifkullanici.aktifkullanici_kat_no = Convert.ToInt32(dt2.Rows[0]["kat_no"]);
                aktifkullanici.aktifkullanici_daire_no = Convert.ToInt32(dt2.Rows[0]["daire_no"]);

                if ( aktifkullanici.aktifkullanici_yoneticidurumu == 0 ) 
                {
                    AnaSayfaGirisVar yeniform = new AnaSayfaGirisVar();
                    yeniform.Show();
                    this.Hide();
                    GirisEkrani.kimgeldi2 = 1;
                }
                else
                {
                    AnaSayfaYonetici yeniforma = new AnaSayfaYonetici();
                    yeniforma.Show();
                    this.Hide();
                    GirisEkrani.kimgeldi2 = 3;
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya sifre hatalı.");
            }
        }

        private void button_kayit_Click(object sender, EventArgs e)
        {
            KayitEkrani yeniforma = new KayitEkrani();
            yeniforma.Show();
            this.Hide();
        }

        private void button_geri_dön_Click(object sender, EventArgs e)
        {
            AnaSayfaGirisYok yeniformb = new AnaSayfaGirisYok();
            yeniformb.Show();
            this.Hide();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}

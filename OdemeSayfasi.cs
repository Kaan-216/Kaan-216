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
    public partial class OdemeSayfasi : Form
    {
        public int case1 = 5;
        public OdemeSayfasi()
        {
            InitializeComponent();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            SeciliUrunSayfasi forma = new SeciliUrunSayfasi();
            forma.Show();
            this.Hide();
        }

        private void label_özellikler_Click(object sender, EventArgs e)
        {

        }

        private void yenile()
        {
            int kdv = (SeciliUrunSayfasi.urun_fiyat * SeciliUrunSayfasi.urun_kdvoran/100);
            label_kdv.Text = (numericUpDown.Value*kdv).ToString();
            Ödeme.ödenecek_miktar = (SeciliUrunSayfasi.urun_fiyat + kdv)*numericUpDown.Value;
            label_odenecek_miktar.Text = Ödeme.ödenecek_miktar.ToString();
            label_ürünfiyat.Text = (SeciliUrunSayfasi.urun_fiyat*numericUpDown.Value).ToString();
            label_urunisim.Text = numericUpDown.Value.ToString()+" tane "+SeciliUrunSayfasi.urun_isim+" için:";
            label_adetfiyat.Text = SeciliUrunSayfasi.urun_fiyat.ToString();
            label_cuzdan.Text = "Cüzdanım ile satın al = " + aktifkullanici.aktifkullanici_Bakiye.ToString();
            textBox1.Text = aktifkullanici.aktifkullanici_sehir;
            textBox2.Text = aktifkullanici.aktifkullanici_mahalle;
            textBox3.Text = aktifkullanici.aktifkullanici_sokak;
            textBox4.Text = aktifkullanici.aktifkullanici_bina_no.ToString();
            textBox5.Text = aktifkullanici.aktifkullanici_kat_no.ToString();
            textBox6.Text = aktifkullanici.aktifkullanici_daire_no.ToString();
            textBox7.Text = aktifkullanici.aktifkullanici_email;
        }
        
        private void OdemeSayfasi_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            yenile();
        }

        private void button_cuzdan_Click(object sender, EventArgs e)
        {

        }

        private void button_kredikarti_Click(object sender, EventArgs e)
        {

        }

        private void button_çek_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_cuzdan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cuzdan.Checked == false)
            {
                case1 = 5;
            }
            else
            {
                case1 = 1;
            }
            checkBox_cek.Checked = false;
            checkBox_kredikarti.Checked = false;
            checkBox_nakit.Checked = false;
        }

        private void checkBox_kredikarti_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_kredikarti.Checked == false)
            {
                case1 = 5;
            }
            else
            {
                case1 = 2;
            }
            checkBox_cek.Checked = false;
            checkBox_cuzdan.Checked = false;
            checkBox_nakit.Checked = false;
        }

        private void checkBox_cek_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cek.Checked == false)
            {
                case1 = 5;
            }
            else
            {
                case1 = 3;
            }
            checkBox_cuzdan.Checked = false;
            checkBox_kredikarti.Checked = false;
            checkBox_nakit.Checked = false;
        }

        private void checkBox_nakit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nakit.Checked == false)
            {
                case1 = 5;
            }
            else
            {
                case1 = 4;
            }
            checkBox_cek.Checked = false;
            checkBox_kredikarti.Checked = false;
            checkBox_cuzdan.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox_adresimikaydet.Checked==true)
            {
                SqlCommand adresekle = new SqlCommand("Update Userdata set sehir=@sehir,mahalle=@mahalle,sokak=@sokak,bina_no=@binano,kat_no=@katno,daire_no=@daireno where userID=@guserID", SqlFile.SqlVariables.baglanti);
                SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

                adresekle.Parameters.AddWithValue("@sehir", textBox1.Text);
                adresekle.Parameters.AddWithValue("@mahalle", textBox2.Text);
                adresekle.Parameters.AddWithValue("@sokak", textBox3.Text);
                adresekle.Parameters.AddWithValue("@binano", textBox4.Text);
                adresekle.Parameters.AddWithValue("@katno", textBox5.Text);
                adresekle.Parameters.AddWithValue("@daireno", textBox6.Text);
                adresekle.Parameters.AddWithValue("@guserID", aktifkullanici.aktifkullanici_userID);

                adresekle.ExecuteNonQuery();
                
                aktifkullanici.aktifkullanici_sehir = textBox1.Text;
                aktifkullanici.aktifkullanici_ilce = textBox7.Text;
                aktifkullanici.aktifkullanici_mahalle = textBox2.Text;
                aktifkullanici.aktifkullanici_sokak = textBox3.Text;
                aktifkullanici.aktifkullanici_bina_no = Convert.ToInt32(textBox4.Text);
                aktifkullanici.aktifkullanici_kat_no = Convert.ToInt32(textBox5.Text);
                aktifkullanici.aktifkullanici_daire_no = Convert.ToInt32(textBox6.Text);
            }
            if (textBox1.Text ==" " || textBox2.Text==" " || textBox3.Text==" " ||textBox4.Text=="0" ||textBox5.Text=="0" ||textBox6.Text=="0" || textBox7.Text==" ")
            {
                MessageBox.Show("Lütfen adres satırlarını ve emailinizi kontrol ediniz.");
            }
            else
            {
                switch (case1)
                {
                    case 1:
                        Bakiye.bakiye_dusur(Ödeme.ödenecek_miktar);
                        MessageBox.Show("Siparişiniz başarıyla tarafımıza ulaşmıştır iyi alışverişler.");
                        break;
                    case 2:
                        KrediKartiEkrani.kimgeldiacaba = 2;
                        KrediKartiEkrani forma = new KrediKartiEkrani();
                        forma.Show();
                        this.Hide();
                        break;
                    case 3:

                        break;
                    case 4 :
                        MessageBox.Show("Siparişiniz kapıda ödeme alınmak için tarafımıza ulaşmıştır iyi alışverişler.");
                        break;

                    default: MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz");
                        break;
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class UrunSayfasi : Form
    {
        int seciliID;
        public static int seciliID_form;
        
        public UrunSayfasi()
        {
            InitializeComponent();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            YoneticiMenusu yeniforma = new YoneticiMenusu();
            yeniforma.Show();
            this.Close();
        }

        private void UrunSayfasi_Load(object sender, EventArgs e)
        {
            sayfayiyenile();
        }

        public void sayfayiyenile()
        {
            SqlCommand listelemekomutu = new SqlCommand("Select * from urunData", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            SqlDataAdapter da = new SqlDataAdapter(listelemekomutu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            numericUpDown_urunadet.Value= Convert.ToInt32(dataGridView1.CurrentRow.Cells["urun_adet"].Value);
            int guncelfiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells["urun_fiyat"].Value);
            textBox_fiyatgnclleme.Text = guncelfiyat.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            seciliID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["urun_ID"].Value);
            textBox_seciliurunID.Text = seciliID.ToString();
            int guncelfiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells["urun_fiyat"].Value);
            textBox_fiyatgnclleme.Text = guncelfiyat.ToString();
            numericUpDown_urunadet.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["urun_adet"].Value);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlurundegisim = new SqlCommand("Update urunData set urun_adet=@yeniadet where urun_ID=@gurun_ID", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlurundegisim.Parameters.AddWithValue("@yeniadet", numericUpDown_urunadet.Value);
            sqlurundegisim.Parameters.AddWithValue("@gurun_ID", seciliID);

            sqlurundegisim.ExecuteNonQuery();
            sayfayiyenile();
        }

        private void button_yeniurun_Click(object sender, EventArgs e)
        {
            YeniUrunEkleme yeniurunekleme1 = new YeniUrunEkleme();
            yeniurunekleme1.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlurundegisim = new SqlCommand("Update urunData set urun_fiyat=@yenifiyat where urun_ID=@gurun_ID", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlurundegisim.Parameters.AddWithValue("@yenifiyat", Convert.ToInt32(textBox_fiyatgnclleme.Text));
            sqlurundegisim.Parameters.AddWithValue("@gurun_ID", seciliID);

            sqlurundegisim.ExecuteNonQuery();
            sayfayiyenile();
        }
    }
}

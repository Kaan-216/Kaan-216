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
    public partial class KullaniciListesi : Form
    {
        int seciliID;
        public KullaniciListesi()
        {
            InitializeComponent();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            YoneticiMenusu yeniforma = new YoneticiMenusu();
            yeniforma.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void sayfayiyenile()
        {
            SqlCommand listelemekomutu = new SqlCommand("Select * from UserData", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            SqlDataAdapter da = new SqlDataAdapter(listelemekomutu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void KullaniciListesi_Load(object sender, EventArgs e)
        {
            sayfayiyenile();
        }

        private void button_kullanicisil_Click(object sender, EventArgs e)
        {
            if (seciliID==1)
            {
                MessageBox.Show("Ana yöneticiyi silemezsiniz.");
            }
            else
            {
                SqlCommand kullanici_sil = new SqlCommand("Delete from UserData where userID=@gid", SqlFile.SqlVariables.baglanti);
                SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

                kullanici_sil.Parameters.AddWithValue("@gid", seciliID);
                kullanici_sil.ExecuteNonQuery();

                sayfayiyenile();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            seciliID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["userID"].Value);
            textBox_secilikullaniciID.Text = seciliID.ToString();
        }
    }
}

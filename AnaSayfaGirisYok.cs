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
    public partial class AnaSayfaGirisYok : Form
    {
        int seciliID;
        public AnaSayfaGirisYok()
        {
            InitializeComponent();
        }

        private void linkLabel_girisyap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisEkrani yeniekran = new GirisEkrani();
            yeniekran.Show();
            this.Hide();
        }
        public void sayfayiyenile()
        {
            SqlCommand listelemekomutu = new SqlCommand("Select * from urunData", SqlFile.SqlVariables.baglanti);
            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            SqlDataAdapter da = new SqlDataAdapter(listelemekomutu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AnaSayfaGirisYok_Load(object sender, EventArgs e)
        {
            sayfayiyenile();
        }

        private void button_urunsayfasi_Click(object sender, EventArgs e)
        {
            UrunSayfasi.seciliID_form = seciliID;
            SeciliUrunSayfasi.kimgeldi = 2;
            SeciliUrunSayfasi form = new SeciliUrunSayfasi();
            form.Show();
            this.Hide();
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            seciliID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["urun_ID"].Value);
        }
    }
}

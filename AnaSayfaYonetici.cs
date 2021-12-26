﻿using System;
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
    public partial class AnaSayfaYonetici : Form
    {
        int seciliID;
        public AnaSayfaYonetici()
        {
            InitializeComponent();
            label_kullaniciadi.Text = aktifkullanici.aktifkullanici_kullaniciadi;
            label_Bakiye.Text = aktifkullanici.aktifkullanici_Bakiye.ToString();
        }

        private void linkLabel_yoneticimenüsü_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YoneticiMenusu yeniforma = new YoneticiMenusu();
            yeniforma.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cuzdan yeniforma = new Cuzdan();
            yeniforma.Show();
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

        private void AnaSayfaYonetici_Load(object sender, EventArgs e)
        {
            sayfayiyenile();
        }

        private void button_urunsayfasi_Click(object sender, EventArgs e)
        {
            UrunSayfasi.seciliID_form = seciliID;
            SeciliUrunSayfasi.kimgeldi = 3;
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

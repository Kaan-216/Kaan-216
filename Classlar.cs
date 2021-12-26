namespace Proje7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;
    using System.Data;

    class Müsteri
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        public string email { get; set; }
        public string sehir { get; set; }
        public string mahalle { get; set; }
        public string sokak { get; set; }
        public int bina_no { get; set; }
        public int kat_no { get; set; }
        public int daire_no { get; set; }
        public int bakiye = 0;
        public int yoneticidurumu = 0;

        public Müsteri() 
        {
        }
        public Müsteri(string gisim, string gsoyisim, string gkullaniciadi, string gsifre, string gemail)
        {
            isim = gisim;
            soyisim = gsoyisim;
            kullaniciadi = gkullaniciadi;
            sifre = gsifre;
            email = gemail;
            string bosluk = " ";
            int sifir = 0;

            SqlCommand sqlkayitolma = new SqlCommand("Insert into UserData (isim,soyisim,kullaniciadi,sifre,email,bakiye,yoneticidurumu,sehir,mahalle,sokak,bina_no,kat_no,daire_no,ilce) values (@isim,@soyisim,@kullaniciadi,@sifre,@email,@bakiye,@yoneticidurumu,@sehir,@mahalle,@sokak,@bina_no,@kat_no,@daire_no,@ilce)", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlkayitolma.Parameters.AddWithValue("@isim", isim);
            sqlkayitolma.Parameters.AddWithValue("@soyisim", soyisim);
            sqlkayitolma.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
            sqlkayitolma.Parameters.AddWithValue("@sifre", sifre);
            sqlkayitolma.Parameters.AddWithValue("@email", email);
            sqlkayitolma.Parameters.AddWithValue("@bakiye", bakiye);
            sqlkayitolma.Parameters.AddWithValue("@yoneticidurumu", yoneticidurumu);
            sqlkayitolma.Parameters.AddWithValue("@sehir", bosluk);
            sqlkayitolma.Parameters.AddWithValue("@mahalle", bosluk);
            sqlkayitolma.Parameters.AddWithValue("@sokak", bosluk);
            sqlkayitolma.Parameters.AddWithValue("@bina_no", sifir);
            sqlkayitolma.Parameters.AddWithValue("@kat_no", sifir);
            sqlkayitolma.Parameters.AddWithValue("@daire_no", sifir);
            sqlkayitolma.Parameters.AddWithValue("@ilce", bosluk);


            sqlkayitolma.ExecuteNonQuery();
        }

    }

        class Yonetici : Müsteri
        {
            public Yonetici(string gisim, string gsoyisim, string gkullaniciadi, string gsifre, string gemail)
            {
            isim = gisim;
            soyisim = gsoyisim;
            kullaniciadi = gkullaniciadi;
            sifre = gsifre;
            email = gemail;
            yoneticidurumu = 1;
            string bosluk = " ";
            int sifir = 0;

            SqlCommand sqlkayitolma = new SqlCommand("Insert into UserData (isim,soyisim,kullaniciadi,sifre,email,bakiye,yoneticidurumu,sehir,mahalle,sokak,bina_no,kat_no,daire_no,ilce) values (@isim,@soyisim,@kullaniciadi,@sifre,@email,@bakiye,@yoneticidurumu,@sehir,@mahalle,@sokak,@bina_no,@kat_no,@daire_no,@ilce)", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            sqlkayitolma.Parameters.AddWithValue("@isim", isim);
            sqlkayitolma.Parameters.AddWithValue("@soyisim", soyisim);
            sqlkayitolma.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
            sqlkayitolma.Parameters.AddWithValue("@sifre", sifre);
            sqlkayitolma.Parameters.AddWithValue("@email", email);
            sqlkayitolma.Parameters.AddWithValue("@bakiye", bakiye);
            sqlkayitolma.Parameters.AddWithValue("@yoneticidurumu", yoneticidurumu);
            sqlkayitolma.Parameters.AddWithValue("@sehir", bosluk);
            sqlkayitolma.Parameters.AddWithValue("@mahalle", bosluk);
            sqlkayitolma.Parameters.AddWithValue("@sokak", bosluk);
            sqlkayitolma.Parameters.AddWithValue("@bina_no", sifir);
            sqlkayitolma.Parameters.AddWithValue("@kat_no", sifir);
            sqlkayitolma.Parameters.AddWithValue("@daire_no", sifir);
            sqlkayitolma.Parameters.AddWithValue("@ilce", bosluk);

            sqlkayitolma.ExecuteNonQuery();
            }
        }

        class Siparis : Müsteri
        {
            public int siparis_tarih { get; set; }
            public string siparis_durum { get; set; }
        }

        abstract class Ödeme : Siparis
        {
            public static decimal ödenecek_miktar { get; set; }
        
        }

        class Bakiye : Ödeme
        {
            
            public static void bakiye_ekle(int miktar)
            {
                
                SqlCommand bakiyeekle = new SqlCommand("Update Userdata set bakiye=@bakiye where userID=@guserID", SqlFile.SqlVariables.baglanti);
                SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

                aktifkullanici.aktifkullanici_Bakiye = aktifkullanici.aktifkullanici_Bakiye + miktar;
                bakiyeekle.Parameters.AddWithValue("@bakiye", aktifkullanici.aktifkullanici_Bakiye);
                bakiyeekle.Parameters.AddWithValue("@guserID", aktifkullanici.aktifkullanici_userID);

                bakiyeekle.ExecuteNonQuery();
            }
            public static void bakiye_dusur(decimal miktar)
            {

                SqlCommand bakiyedusur = new SqlCommand("Update Userdata set bakiye=@bakiye where userID=@guserID", SqlFile.SqlVariables.baglanti);
                SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

                aktifkullanici.aktifkullanici_Bakiye = Convert.ToInt32(aktifkullanici.aktifkullanici_Bakiye - miktar);
                bakiyedusur.Parameters.AddWithValue("@bakiye", aktifkullanici.aktifkullanici_Bakiye);
                bakiyedusur.Parameters.AddWithValue("@guserID", aktifkullanici.aktifkullanici_userID);

                bakiyedusur.ExecuteNonQuery();
            }

    }

        class KrediKartı : Ödeme
        {
            public static int yuklenenmiktar;
            public static void odemeoncesi_kk(int yuklenecekmiktar)
            {
            KrediKartiEkrani.kimgeldiacaba = 1;
            KrediKartiEkrani forma = new KrediKartiEkrani();
            forma.Show();
            yuklenenmiktar = yuklenecekmiktar;
            }
        }

        class Nakit : Ödeme
        {
           
        }

        class Çek : Ödeme
        {
            public string Isim { get; set; }
            public int BankID { get; set; }
            
        }
    

        class Iban : Bakiye
        {
            public static int yuklenenmiktar2;
            public static void odeme_oncesi_iban(int yuklenecekmiktar2)
            {
            IbanEkrani forma = new IbanEkrani();
            forma.Show();
            yuklenenmiktar2 = yuklenecekmiktar2;
            }
        }

        class SiparisDetay : Siparis
        {

        }

        class Urun : SiparisDetay
        {
        public static string urun_isim { get; set; }
        public static string urun_aciklamasi { get; set; }
        public static string urun_ozellikleri { get; set; }
        public static int urun_fiyat { get; set; }
        public static int urun_adet { get; set; }

        public Urun()
        {
        }

        public Urun(string gurun_isim, string gurun_acıklama, string gurun_ozellikleri, int gurun_fiyat, int gurun_adet)
        {
            urun_isim = gurun_isim;
            urun_aciklamasi = gurun_acıklama;
            urun_ozellikleri = gurun_ozellikleri;
            urun_fiyat = gurun_fiyat;
            urun_adet = gurun_adet;

            SqlCommand urunekle = new SqlCommand("Insert into urunData (urun_isim,urun_aciklama,urun_ozellikler,urun_fiyat,urun_adet) values (@urun_isim,@urun_aciklama,@urun_ozellikler,@urun_fiyat,@urun_adet)", SqlFile.SqlVariables.baglanti);

            SqlFile.SqlVariables.BaglantiKontrol(SqlFile.SqlVariables.baglanti);

            urunekle.Parameters.AddWithValue("@urun_isim", urun_isim);
            urunekle.Parameters.AddWithValue("@urun_aciklama", urun_aciklamasi);
            urunekle.Parameters.AddWithValue("@urun_ozellikler", urun_ozellikleri);
            urunekle.Parameters.AddWithValue("@urun_fiyat", urun_fiyat);
            urunekle.Parameters.AddWithValue("@urun_adet", urun_adet);


            urunekle.ExecuteNonQuery();
        }
            
        }

        public class aktifkullanici
        {
            public static string aktifkullanici_isim = null;
            public static string aktifkullanici_soyisim = null;
            public static string aktifkullanici_kullaniciadi = null;
            public static string aktifkullanici_sifre = null;
            public static string aktifkullanici_email = null;
            public static string aktifkullanici_mahalle = null;
            public static string aktifkullanici_ilce = null;
            public static string aktifkullanici_sehir = null;
            public static string aktifkullanici_sokak = null;
            public static int aktifkullanici_bina_no =0; 
            public static int aktifkullanici_kat_no =0;
            public static int aktifkullanici_daire_no =0;
            public static int aktifkullanici_yoneticidurumu = 0;
            public static int aktifkullanici_Bakiye = 0;
            public static int aktifkullanici_userID = 0;
    }
    }

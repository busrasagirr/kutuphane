using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer
{
    public class DLL  //ÇALIŞMAM GEREKEN YER!
    {
        SqlConnection con;  
        SqlCommand cmd;    
        int donendeger;
        int donendeger1;
        int donendeger2;

        public DLL()
        {
            con=new SqlConnection("Server=DESKTOP-B9UNDHL;Database=KutuphaneDB;Integrated Security=TRUE");
        }
        public void BaglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            else
                con.Close();
        }
        public int SistemKontrol(Kullanicilar K)
        {
            try
            {
                cmd = new SqlCommand("select count(*) from Kullanicilar where  KullaniciAdi=@KullaniciAdi and KullaniciSifre=@KullaniciSifre", con);
                cmd.Parameters.Add("@KullaniciAdi", SqlDbType.NVarChar).Value = K.KullaniciAdi;
                cmd.Parameters.Add("@KullaniciSifre", SqlDbType.NVarChar).Value = K.KullaniciSifre;
                BaglantiAyarla();
                donendeger = (int)cmd.ExecuteScalar();   //tek bir değer döndürdüğümüz için ExecuteScalar kullanılır!
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return donendeger;
        }

        #region ÜYELER:
        public int UyeEkle(Uyeler U)
        {
            try
            {
                cmd = new SqlCommand("insert into Uyeler (UyeAdi,UyeSoyadi,UyeDogumTarihi,UyeTel,UyeMail,UyeAdres) values (@UyeAdi, @UyeSoyadi, @UyeDogumTarihi, @UyeTel, @UyeMail, @UyeAdres)", con);
                
                cmd.Parameters.Add("@UyeAdi", SqlDbType.NVarChar).Value = U.UyeAdi;
                cmd.Parameters.Add("@UyeSoyadi", SqlDbType.NVarChar).Value = U.UyeSoyadi;
                cmd.Parameters.Add("@UyeDogumTarihi", SqlDbType.DateTime).Value = U.UyeDogumTarihi;
                cmd.Parameters.Add("@UyeTel", SqlDbType.NVarChar).Value = U.UyeTel;
                cmd.Parameters.Add("@UyeMail", SqlDbType.NVarChar).Value = U.UyeMail;
                cmd.Parameters.Add("@UyeAdres", SqlDbType.NVarChar).Value =U.UyeAdres;
                
                BaglantiAyarla();
                donendeger = cmd.ExecuteNonQuery();   // Sql -i execute eder.!
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return donendeger;
        }
        public int UyeDuzenle(Uyeler U)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Uyeler set UyeAdi=@UyeAdi,UyeSoyadi=@UyeSoyadi,UyeDogumTarihi=@UyeDogumTarihi,UyeTel=@UyeTel,UyeMail=@UyeMail,UyeAdres=@UyeAdres  where UyeID=@UyeID", con);
                cmd.Parameters.Add("@UyeID", SqlDbType.Int).Value = U.UyeID;
                cmd.Parameters.Add("@UyeAdi", SqlDbType.NVarChar).Value = U.UyeAdi;
                cmd.Parameters.Add("@UyeSoyadi", SqlDbType.NVarChar).Value = U.UyeSoyadi;
                cmd.Parameters.Add("@UyeDogumTarihi", SqlDbType.DateTime).Value = U.UyeDogumTarihi;
                cmd.Parameters.Add("@UyeTel", SqlDbType.NVarChar).Value = U.UyeTel;
                cmd.Parameters.Add("@UyeMail", SqlDbType.NVarChar).Value = U.UyeMail;
                cmd.Parameters.Add("@UyeAdres", SqlDbType.NVarChar).Value = U.UyeAdres;

                BaglantiAyarla();
                donendeger = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return donendeger;
        }
        public int UyeSil(int UyeID)
        {
            try
            {
                cmd = new SqlCommand("delete Uyeler where UyeID=@UyeID", con);
                cmd.Parameters.Add("@UyeID", SqlDbType.Int).Value =UyeID;
                BaglantiAyarla();
                donendeger = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return donendeger;
        }
        public DataTable UyeListeleView()
        {
            DataTable dt1 = new DataTable();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select * From Uyeler", con);
                adp.Fill(dt1);   //Fill : dt1 table -ı, adp üzerinden doldur.
                return dt1;
            }
            catch (Exception)
            {
                return dt1;
            }
        }
        #endregion

        #region KİTAPLAR:

        public int KitapEkle(Kitaplar K)
        {
            try
            {
                cmd = new SqlCommand("insert into Kitaplar (KitapISBN,KitapAdi,KitapSayfaSayisi,KitapBasimTarihi,YazarAdiSoyadi,YayınEvi,KitapFiyati,GunlukKiralamaFiyati,KitapTuru) values (@KitapISBN, @KitapAdi, @KitapSayfaSayisi, @KitapBasimTarihi, @YazarAdiSoyadi, @YayınEvi,@KitapFiyati,@GunlukKiralamaFiyati,@KitapTuru)", con);

                cmd.Parameters.Add("@KitapISBN", SqlDbType.NVarChar).Value =K.KitapISBN;
                cmd.Parameters.Add("@KitapAdi", SqlDbType.NVarChar).Value =K.KitapAdi;
                cmd.Parameters.Add("@KitapSayfaSayisi", SqlDbType.Int).Value =K.KitapSayfaSayisi ;
                cmd.Parameters.Add("@KitapBasimTarihi", SqlDbType.DateTime).Value =K.KitapBasimTarihi;
                cmd.Parameters.Add("@YazarAdiSoyadi", SqlDbType.NVarChar).Value =K.YazarAdiSoyadi;
                cmd.Parameters.Add("@YayınEvi", SqlDbType.NVarChar).Value =K.YayınEvi;
                cmd.Parameters.Add("@KitapFiyati",SqlDbType.Money).Value=K.KitapFiyati;
                cmd.Parameters.Add("@GunlukKiralamaFiyati", SqlDbType.Money).Value = K.GunlukKiralamaFiyati;
                cmd.Parameters.Add("@KitapTuru", SqlDbType.NVarChar).Value = K.KitapTuru;

                BaglantiAyarla();
                donendeger1 = cmd.ExecuteNonQuery();   // Sql -i execute eder.!
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return donendeger1;
        }
        public int KitapDuzenle(Kitaplar K)
        {
            try
            {
                cmd = new SqlCommand("UPDATE Kitaplar set KitapISBN=@KitapISBN,KitapAdi=@KitapAdi,KitapSayfaSayisi=@KitapSayfaSayisi,KitapBasimTarihi=@KitapBasimTarihi,YazarAdiSoyadi=@YazarAdiSoyadi,YayınEvi=@YayınEvi,KitapFiyati=@KitapFiyati,GunlukKiralamaFiyati=@GunlukKiralamaFiyati,KitapTuru=@KitapTuru  where KitapID=@KitapID", con);
                cmd.Parameters.Add("@KitapID", SqlDbType.Int).Value = K.KitapID;
                cmd.Parameters.Add("@KitapISBN", SqlDbType.NVarChar).Value =K.KitapISBN;
                cmd.Parameters.Add("@KitapAdi", SqlDbType.NVarChar).Value =K.KitapAdi;
                cmd.Parameters.Add("@KitapSayfaSayisi", SqlDbType.Int).Value = K.KitapSayfaSayisi;
                cmd.Parameters.Add("@KitapBasimTarihi", SqlDbType.DateTime).Value = K.KitapBasimTarihi;
                cmd.Parameters.Add("@YazarAdiSoyadi", SqlDbType.NVarChar).Value = K.YazarAdiSoyadi;
                cmd.Parameters.Add("@YayınEvi", SqlDbType.NVarChar).Value = K.YayınEvi;
                cmd.Parameters.Add("@KitapFiyati", SqlDbType.Money).Value = K.KitapFiyati;
                cmd.Parameters.Add("@GunlukKiralamaFiyati", SqlDbType.Money).Value = K.GunlukKiralamaFiyati;
                cmd.Parameters.Add("@KitapTuru", SqlDbType.NVarChar).Value = K.KitapTuru;

                BaglantiAyarla();
                donendeger1 = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return donendeger1;
        }
        public int KitapSil(int KitapID)
        {
            try
            {
                cmd = new SqlCommand("delete Kitaplar where KitapID=@KitapID", con);
                cmd.Parameters.Add("@KitapID", SqlDbType.Int).Value = KitapID;
                BaglantiAyarla();
                donendeger1 = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return donendeger1;
        }
        public DataTable KitapListeleView()
        {
            DataTable dt3 = new DataTable();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select * From Kitaplar", con);
                adp.Fill(dt3);   
                return dt3;
            }
            catch (Exception)
            {
                return dt3;
            }
        }

        #endregion

        #region KİTAP KİRALA:

        public int KitapKirala(Kiralama kk)
        {
            try
            {
                cmd = new SqlCommand("insert into Kiralama (KiralamaBaslangicTarihi,KiralamaBitisTarihi,KiralamaFiyati,KitapID,UyeID) values(@KiralamaBaslangicTarihi, @KiralamaBitisTarihi,@KiralamaFiyati, @KitapID, @UyeID)", con);
                
                cmd.Parameters.Add("@KiralamaBaslangicTarihi", SqlDbType.Date).Value = kk.KiralamaBaslangicTarihi;
                cmd.Parameters.Add("@KiralamaBitisTarihi", SqlDbType.Date).Value = kk.KiralamaBitisTarihi;
                cmd.Parameters.Add("@KiralamaFiyati", SqlDbType.Money).Value = kk.KiralamaFiyati;
                cmd.Parameters.Add("@KitapID", SqlDbType.Int).Value = kk.KitapID;
                cmd.Parameters.Add("@UyeID", SqlDbType.Int).Value = kk.UyeID;

                BaglantiAyarla();
                donendeger2 = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return donendeger2;
        }
        public int KiralamaDuzenle(Kiralama kd)
        {
            try
            {
                cmd = new SqlCommand("update Kiralama set KiralamaBaslangicTarihi=@KiralamaBaslangicTarihi,KiralamaBitisTarihi=@KiralamaBitisTarihi,KiralamaFiyati=@KiralamaFiyati,KitapID=@KitapID,UyeID=@UyeID where KiralamaID=@KiralamaID",con);

                cmd.Parameters.Add("@KiralamaID", SqlDbType.Int).Value = kd.KiralamaID;
                cmd.Parameters.Add("@KiralamaBaslangicTarihi", SqlDbType.Date).Value = kd.KiralamaBaslangicTarihi;
                cmd.Parameters.Add("@KiralamaBitisTarihi", SqlDbType.Date).Value = kd.KiralamaBitisTarihi;
                cmd.Parameters.Add("@KiralamaFiyati", SqlDbType.Money).Value = kd.KiralamaFiyati;
                cmd.Parameters.Add("@KitapID", SqlDbType.Int).Value = kd.KitapID;
                cmd.Parameters.Add("@UyeID", SqlDbType.Int).Value = kd.UyeID;

                BaglantiAyarla();
                donendeger2 = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return donendeger2;
        }
        public int KiralamaSil(int KiralamaID)
        {
            try
            {
                cmd = new SqlCommand("delete Kiralama where KiralamaID=@KiralamaID", con);
                cmd.Parameters.Add("@KiralamaID", SqlDbType.Int).Value = KiralamaID;
                BaglantiAyarla();
                donendeger2 = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                BaglantiAyarla();
            }
            return donendeger2;
        }


        public DataTable KiralaView()
        {
            DataTable dt = new DataTable();
            try
            {                //inner join yapmam gerekiyor!!!!!!!!!
                SqlDataAdapter adp = new SqlDataAdapter("select KiralamaID,KiralamaBaslangicTarihi,KiralamaBitisTarihi,kk.UyeID,UyeAdi,UyeSoyadi,kk.KitapID,KitapAdi,GunlukKiralamaFiyati,KitapFiyati from Kiralama kk inner join  Kitaplar k on k.KitapID=kk.KitapID inner join  Uyeler u on u.UyeID=kk.UyeID", con);   
                adp.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        public DataTable UyeSecView()
        {
            DataTable dt5 = new DataTable();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select UyeID,UyeAdi,UyeSoyadi,UyeMail from Uyeler", con);
                adp.Fill(dt5);
                return dt5;
            }
            catch (Exception)
            {
                return dt5;
            }
        }
        public DataTable KitapSecView()
        {
            DataTable dt6 = new DataTable();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select KitapID,KitapISBN,KitapAdi,GunlukKiralamaFiyati,KitapFiyati from Kitaplar", con);
                adp.Fill(dt6);
                return dt6;
            }
            catch (Exception)
            {
                return dt6;
            }
        }
        
        #endregion



    }
}

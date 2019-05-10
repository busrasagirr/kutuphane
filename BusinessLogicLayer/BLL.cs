using System;
//using Entities;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLL
    {
        DatabaseLogicLayer.DLL dll;

        public BLL()
        {
            dll = new DatabaseLogicLayer.DLL();
        }
        public int SistemKontrol(string kullaniciadi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(sifre))
            {
                return dll.SistemKontrol(new Entities.Kullanicilar()
                {
                    KullaniciAdi = kullaniciadi,
                    KullaniciSifre = sifre
                });
            }
            else return -1;
        }

        #region ÜYELER:
        public int UyeEkle(string isim, string soyisim, DateTime dogumtarihi, string telefonNo, string uyemail, string uyeAdres)
        {
            if (!string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) )
            {
                return dll.UyeEkle(new Entities.Uyeler()  //Kayıt işlemini döndürsün!
                {
                    UyeAdi = isim,
                    UyeSoyadi = soyisim,
                    UyeDogumTarihi = dogumtarihi,
                    UyeTel = telefonNo,
                    UyeMail = uyemail,
                    UyeAdres = uyeAdres
                    
                });
            }
            else
            {
                return -1;  //Hata oluştuğunda -1 dönsün.!
            }
        }
        public int UyeDuzenle(int UyeID ,string isim, string soyisim, DateTime dogumtarihi, string telefonNo, string uyemail, string uyeAdres)
        {
            if (UyeID!= 0)
            {
                return dll.UyeDuzenle(new Entities.Uyeler()  //Güncelleme işlemini döndürsün! Rehberdeki kaydı güncelliyoruz!
                {
                    UyeID = UyeID,
                    UyeAdi = isim,
                    UyeSoyadi = soyisim,
                    UyeDogumTarihi = dogumtarihi,
                    UyeTel = telefonNo,
                    UyeMail = uyemail,
                    UyeAdres = uyeAdres
                });
            }
            else
            {
                return -1;  //hata oluştuğunda -1 dönsün.!
            }
        }
        public int UyeSil(int UyeID)
        {
            if (UyeID != 0)
            {
                return dll.UyeSil(UyeID);
            }
            else
                return -1;
        }

        public DataTable UyeListeleView()    //Sunum katmanıma bir table gönderecek!
        {
            DataTable dt2 = dll.UyeListeleView();
            return dt2;
        }
        #endregion

        #region KİTAPLAR:

        public int KitapEkle(string kitapISBN, string kitapAdi, int kitapSayfaSayisi, DateTime kitapBasimTarihi, string yazarAdiSoyadi, string yayinEvi, double kitapFiyati, double gunlukKiralamaFiyati, string kitapTuru)
        {
            if (!string.IsNullOrEmpty(kitapISBN) && !string.IsNullOrEmpty(kitapAdi))
            {
                return dll.KitapEkle(new Entities.Kitaplar()  
                {
                    KitapISBN = kitapISBN,
                    KitapAdi = kitapAdi,
                    KitapSayfaSayisi = kitapSayfaSayisi,
                    KitapBasimTarihi = kitapBasimTarihi,
                    YazarAdiSoyadi = yazarAdiSoyadi,
                    YayınEvi = yayinEvi,
                    KitapFiyati= kitapFiyati,
                    GunlukKiralamaFiyati= gunlukKiralamaFiyati,
                    KitapTuru=kitapTuru

                });
            }
            else
            {
                return -1;  
            }
        }
        public int KitapDuzenle(int KitapID, string kitapISBN, string kitapAdi, int kitapSayfaSayisi, DateTime kitapBasimTarihi, string yazarAdiSoyadi, string yayinEvi, double kitapFiyati, double gunlukKiralamaFiyati, string kitapTuru)
        {
            if (KitapID!=0)
            {
                return dll.KitapDuzenle(new Entities.Kitaplar()
                {
                    KitapID = KitapID,
                    KitapISBN=kitapISBN,
                    KitapAdi=kitapAdi,
                    KitapSayfaSayisi=kitapSayfaSayisi,
                    KitapBasimTarihi=kitapBasimTarihi,
                    YazarAdiSoyadi=yazarAdiSoyadi,
                    YayınEvi=yayinEvi,
                    KitapFiyati=kitapFiyati,
                    GunlukKiralamaFiyati=gunlukKiralamaFiyati,
                    KitapTuru=kitapTuru
                });
            }
            else
            {
                return -1;  
            }
        }
        public int KitapSil(int KitapID)
        {
            if (KitapID != 0)
            {
                return dll.KitapSil(KitapID);
            }
            else
                return -1;
        }

        public DataTable KitapListeleView()   
        {
            DataTable dt4 = dll.KitapListeleView();
            return dt4;
        }
        
        #endregion

        #region KİTAP KİRALA:   !!!!!!!!!!!!
        public int KitapKirala(DateTime kiralamaBaslangicTarihi,DateTime kiralamaBitisTarihi,double kiralamaFiyati,int kitapID,int uyeID)
        {                       
            if (kitapID != 0 && uyeID != 0)
            {
                //TimeSpan kalangun = kiralamaBaslangicTarihi - kiralamaBitisTarihi;
                //double gun = kalangun.TotalDays;
                return dll.KitapKirala(new Entities.Kiralama()
                {
                    KiralamaBaslangicTarihi = kiralamaBaslangicTarihi,
                    KiralamaBitisTarihi = kiralamaBitisTarihi,
                    KiralamaFiyati = kiralamaFiyati,
                    KitapID = kitapID,
                    UyeID = uyeID
                });
            }
            else
                return -1;
        }
        public int KiralamaDuzenle(int kiralamaID,DateTime kiralamaBaslangicTarihi,DateTime kiralamaBitisTarihi,double kiralamaFiyati,int kitapID,int uyeID)
        {
            if (kiralamaID != 0)
            {
                return dll.KiralamaDuzenle(new Entities.Kiralama()
                {
                    KiralamaID = kiralamaID,
                    KiralamaBaslangicTarihi = kiralamaBaslangicTarihi,
                    KiralamaBitisTarihi = kiralamaBitisTarihi,
                    
                    KiralamaFiyati = kiralamaFiyati,
                    KitapID = kitapID,
                    UyeID = uyeID
                });
            }
            else
                return -1;
        }
        public int KiralamaSil(int KiralamaID)
        {
            if (KiralamaID != 0)
            {
                return dll.KiralamaSil(KiralamaID);
            }
            else
                return -1;
        }


        public DataTable KiralaView()
        {
            DataTable dt0 = dll.KiralaView();
            return dt0;
        }
        public DataTable UyeSecView()   
        {
            DataTable dt7 = dll.UyeSecView();
            return dt7;
        }
        public DataTable KitapSecView()   
        {
            DataTable dt8 = dll.KitapSecView();
            return dt8;
        }


        #endregion


    }
}

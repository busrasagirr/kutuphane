using System;
using Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class AnaForm : Form
    {
        BusinessLogicLayer.BLL bll;
        int UyeID;
        int kitapID;
        int kiralamaID;

        public AnaForm()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            ListeGoster();
            KitapGoster();
            KiralamaGoster();
        }

        #region ÜYELER:
        private void ListeGoster()
        {
            dgv_uyeler.DataSource = bll.UyeListeleView();    //yeni eklenen kaydı görebilmek için bunu metoda aldık, metodu da anaform da çağırdık!
        }
        private void dgv_uyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UyeID = (int)dgv_uyeler.CurrentRow.Cells[0].Value;
            txt_uyeadi.Text = dgv_uyeler.CurrentRow.Cells[1].Value.ToString();
            txt_uyesoyadi.Text = dgv_uyeler.CurrentRow.Cells[2].Value.ToString();
            dateTime_dogumtarihi.Text = dgv_uyeler.CurrentRow.Cells[3].Value.ToString();
            txt_telefon.Text = dgv_uyeler.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dgv_uyeler.CurrentRow.Cells[5].Value.ToString();
            txt_adres.Text = dgv_uyeler.CurrentRow.Cells[6].Value.ToString();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int donenveri = bll.UyeEkle(txt_uyeadi.Text, txt_uyesoyadi.Text, dateTime_dogumtarihi.Value, txt_telefon.Text, txt_email.Text, txt_adres.Text);

            if (donenveri > 0)
            {
                MessageBox.Show("Yeni Kayıt Eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeGoster();
                KiralamaGoster();
            }
            else
                MessageBox.Show("Kayıt Eklenemedi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int donendeger = bll.UyeDuzenle(UyeID, txt_uyeadi.Text, txt_uyesoyadi.Text, dateTime_dogumtarihi.Value, txt_telefon.Text, txt_email.Text, txt_adres.Text);

            if (donendeger > 0)
            {
                MessageBox.Show("Üye Güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeGoster();
                KiralamaGoster();
            }
            else
                MessageBox.Show("Üye Değiştirilemedi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            int donenveri = bll.UyeSil(UyeID);
            if (donenveri > 0)
            {
                MessageBox.Show("Üye Silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListeGoster();
                KiralamaGoster();
            }
            else
                MessageBox.Show("Üye Silinemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);   
        }
        #endregion

/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region KİTAPLAR:
        private void KitapGoster()
        {
            dgv_kitaplistele.DataSource = bll.KitapListeleView();   
        }
        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            int donenveri1 = bll.KitapEkle(txt_isbn.Text, txt_kitapadi.Text,Convert.ToInt32(txt_sayfasayisi.Text), datetp_basimtarihi.Value, txt_yazar.Text,txt_yayinevi.Text, Convert.ToDouble(txt_kitapfiyat.Text), Convert.ToDouble(txt_gunlukkiralama.Text), cmb_kitapturu.Text);

            if (donenveri1 > 0)
            {
                MessageBox.Show("Yeni Kitap Eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KitapGoster();
                KiralamaGoster();
            }
            else
                MessageBox.Show("Kitap Eklenemedi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            int donendeger1 = bll.KitapDuzenle(kitapID, txt_isbn.Text, txt_kitapadi.Text, Convert.ToInt32(txt_sayfasayisi.Text), datetp_basimtarihi.Value, txt_yazar.Text, txt_yayinevi.Text, Convert.ToDouble(txt_kitapfiyat.Text), Convert.ToDouble(txt_gunlukkiralama.Text),cmb_kitapturu.Text);

            if (donendeger1 > 0)
            {
                MessageBox.Show("Kitap Güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KitapGoster();
                KiralamaGoster();
            }
            else
                MessageBox.Show("Kitap Değiştirilemedi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_kitapsil_Click(object sender, EventArgs e)    
        {
            int donenveri1 = bll.KitapSil(kitapID);
            if (donenveri1 > 0)
            {
                MessageBox.Show("Kitap Silindi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KitapGoster();
                KiralamaGoster();
            }
            else
                MessageBox.Show("Kitap Silinemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dgv_kitaplistele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapID = (int)dgv_kitaplistele.CurrentRow.Cells[0].Value;
            txt_isbn.Text = dgv_kitaplistele.CurrentRow.Cells[1].Value.ToString();
            txt_kitapadi.Text = dgv_kitaplistele.CurrentRow.Cells[2].Value.ToString();
            txt_sayfasayisi.Text = dgv_kitaplistele.CurrentRow.Cells[3].Value.ToString();
            datetp_basimtarihi.Text = dgv_kitaplistele.CurrentRow.Cells[4].Value.ToString();
            txt_kitapfiyat.Text = dgv_kitaplistele.CurrentRow.Cells[5].Value.ToString();
            txt_gunlukkiralama.Text = dgv_kitaplistele.CurrentRow.Cells[6].Value.ToString();
            txt_yazar.Text = dgv_kitaplistele.CurrentRow.Cells[7].Value.ToString();
            txt_yayinevi.Text = dgv_kitaplistele.CurrentRow.Cells[8].Value.ToString();
            cmb_kitapturu.Text = dgv_kitaplistele.CurrentRow.Cells[9].Value.ToString();
        }

        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region KİTAP KİRALAMA:

        private void KiralamaGoster()
        {
            dgv_kitapsec.DataSource = bll.KitapSecView();    
            dgv_uyesec.DataSource = bll.UyeSecView();
            dgv_kirala.DataSource = bll.KiralaView();
        }
        private void dgv_kitapsec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_kitapidsec.Text = dgv_kitapsec.CurrentRow.Cells[0].Value.ToString();
            lbl_kitapadisec.Text = dgv_kitapsec.CurrentRow.Cells[2].Value.ToString();
            lbl_gunlukkfsec.Text = dgv_kitapsec.CurrentRow.Cells[3].Value.ToString();
            lbl_fiyatsec.Text = dgv_kitapsec.CurrentRow.Cells[4].Value.ToString();
        }
        private void dgv_uyesec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_uyeidsec.Text = dgv_uyesec.CurrentRow.Cells[0].Value.ToString();
            lbl_adsec.Text = dgv_uyesec.CurrentRow.Cells[1].Value.ToString();
            lbl_soyadsec.Text = dgv_uyesec.CurrentRow.Cells[2].Value.ToString();
            
        }
        
        private void btn_kirala_Click(object sender, EventArgs e)
        {
            int donenveri = bll.KitapKirala(dtp_baslangictarihi.Value,dtp_bitistarihi.Value, Convert.ToDouble(lbl_fiyatsec.Text),Convert.ToInt32(lbl_kitapidsec.Text),Convert.ToInt32(lbl_uyeidsec.Text));

            if (donenveri > 0)
            {
                MessageBox.Show("Kitap Kiralandı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KiralamaGoster();
            }
            else
                MessageBox.Show("Kitap Kiralanamadı", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_kiralamaduzenle_Click(object sender, EventArgs e)
        {                 //burası sıkıntılı
            int donenveri = bll.KiralamaDuzenle(kiralamaID, dtp_baslangictarihi.Value, dtp_bitistarihi.Value, Convert.ToDouble(lbl_fiyatsec.Text), Convert.ToInt32(lbl_kitapidsec.Text), Convert.ToInt32(lbl_uyeidsec.Text));

            if (donenveri > 0)
            {
                MessageBox.Show("Kiralama Düzeltildi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KiralamaGoster();
            }
            else
                MessageBox.Show("Kiralama Düzeltilemedi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_kiralamasil_Click(object sender, EventArgs e)
        {
            int donenveri = bll.KiralamaSil(kiralamaID);
            if (donenveri > 0)
            {
                MessageBox.Show("Kiralama İşlemi Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KiralamaGoster();
            }
            else
                MessageBox.Show("Kiralama İşlemi Silinemedi!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void dgv_kirala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kiralamaID = (int)dgv_kirala.CurrentRow.Cells[0].Value;
            dtp_baslangictarihi.Text = dgv_kirala.CurrentRow.Cells[1].Value.ToString();
            dtp_bitistarihi.Text = dgv_kirala.CurrentRow.Cells[2].Value.ToString();
            lbl_uyeidsec.Text = dgv_kirala.CurrentRow.Cells[3].Value.ToString();
            lbl_adsec.Text = dgv_kirala.CurrentRow.Cells[4].Value.ToString();
            lbl_soyadsec.Text = dgv_kirala.CurrentRow.Cells[5].Value.ToString();
            lbl_kitapidsec.Text = dgv_kirala.CurrentRow.Cells[6].Value.ToString();
            lbl_kitapadisec.Text = dgv_kirala.CurrentRow.Cells[7].Value.ToString();
            lbl_gunlukkfsec.Text = dgv_kirala.CurrentRow.Cells[8].Value.ToString();
            lbl_fiyatsec.Text = dgv_kirala.CurrentRow.Cells[9].Value.ToString();
        }


        //select KiralamaID,KiralamaBaslangicTarihi,KiralamaBitisTarihi,UyeAdi,UyeSoyadi,KitapAdi,GunlukKiralamaFiyati,KitapFiyati from Kiralama kk inner join  Kitaplar k on k.KitapID=kk.KitapID inner join  Uyeler u on u.UyeID=kk.UyeID 
        #endregion

        
    }
}

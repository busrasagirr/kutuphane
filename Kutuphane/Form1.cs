using System;
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
    public partial class Form1 : Form
    {
        BusinessLogicLayer.BLL bll;

        public Form1()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            int gelendeger = bll.SistemKontrol(txt_kullaniciadi.Text, txt_kullanicisifre.Text);
            if (gelendeger > 0)
            {
                AnaForm af = new AnaForm();
                af.Show();
            }
            else
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre Girişi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

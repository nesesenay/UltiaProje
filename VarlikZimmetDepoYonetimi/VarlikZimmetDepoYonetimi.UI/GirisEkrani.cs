using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlikZimmetDepoYonetimi.DAL;
using VarlikZimmetDepoYonetimi.DTO;
using VarlikZimmetDepoYonetimi.MyProvider;

namespace VarlikZimmetDepoYonetimi.UI
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void brnGirisYap_Click(object sender, EventArgs e)
        {

            KullaniciGirisiDAL kullaniciGirisi = new KullaniciGirisiDAL();
            List<Kullanici> kullaniciListem = kullaniciGirisi.KullaniciGirisi();
            KullaniciGirisiDogrula(kullaniciListem);

        }

        public void KullaniciGirisiDogrula(List<Kullanici> kullaniciBilgileri)
        {
            foreach (var kullanici in kullaniciBilgileri)
            {
                if (kullanici.KullaniciEmail == txtEmail.Text && kullanici.KullaniciSifre == Convert.ToInt32(txtPassword.Text))
                {
                    MessageBox.Show("Başarılı şekilde giriş yapılmıştır.");
                    Menu menu = new Menu(kullanici);
                    menu.Show();
                    break;
                }
                
               
            }
        }


    }
}

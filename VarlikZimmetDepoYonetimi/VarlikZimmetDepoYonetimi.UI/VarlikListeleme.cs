using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlikZimmetDepoYonetimi.DAL;
using VarlikZimmetDepoYonetimi.DTO;

namespace VarlikZimmetDepoYonetimi.UI
{
    public partial class VarlikListeleme : Form
    {

        Kullanici kullanici;

        bool sidebarExpand;
        public VarlikListeleme()
        {
            InitializeComponent();
        
        }

        public VarlikListeleme(Kullanici kullanici) : this()
        {
            this.kullanici = kullanici;
        }
        private void VarlikListeleme_Load(object sender, EventArgs e)
        {
            ChangeBackgroundColor();
            TumListeyiYuke();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MenuAcilisiniZamanla();
        }
    
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

   
        public void TumListeyiYuke()
        {
            btnEkibiminVarliklari.ForeColor = Color.Black;
            btnVarliklarim.ForeColor = Color.Black;
            btnTumVarliklar.ForeColor = Color.DarkBlue;
         

            VarlikListesiDAL varlikListem = new VarlikListesiDAL();
            List<Urun> urunler = varlikListem.VarliklariListele(kullanici.EkipID,kullanici.SirketID);

            VarlikTablosunuDoldur(urunler);
        }

        public void PersonelListesiniYukle()
        {
            btnTumVarliklar.ForeColor = Color.Black;
            btnEkibiminVarliklari.ForeColor = Color.Black;
            btnVarliklarim.ForeColor = Color.DarkBlue;

            PersonelVarlikListesiDAL personelVarlikListem = new PersonelVarlikListesiDAL();
            List<Urun> personelUrunler = personelVarlikListem.PersonelVarlikListele(kullanici.KullaniciID);

            VarlikTablosunuDoldur(personelUrunler);
        }

        public void EkipListesiniYukle()
        {
            btnTumVarliklar.ForeColor = Color.Black;
            btnVarliklarim.ForeColor = Color.Black;
            btnEkibiminVarliklari.ForeColor = Color.DarkBlue;
          

            EkipVarlikListesiDAL ekipVarlikListesi = new EkipVarlikListesiDAL();
            List<Urun> ekipUrunleri = ekipVarlikListesi.EkipVarliklariniListele(kullanici.KullaniciID,kullanici.EkipID, kullanici.SirketID);

            VarlikTablosunuDoldur(ekipUrunleri);
        }

        public void PoweUserListesiniYukle()
        {


            PoweUserDAL poweUserListesi = new PoweUserDAL();
            List<Urun> powerUserUrunleri = poweUserListesi.TumVarliklariListele();

            VarlikTablosunuDoldur(powerUserUrunleri);
        }

        private void VarlikTablosunuDoldur(List<Urun> urunler)
        {
            tableVarlik.Controls.Clear();
            int i = 0;
            Label label1;
          
            foreach (var urun in urunler)
            {
                tableVarlik.RowCount = urunler.Count;
                tableVarlik.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

                tableVarlik.Controls.Add(new CheckBox(), 0, i);
                tableVarlik.Controls.Add(label1 = new Label() { Text = urun.KayitNumarasi.ToString(), ForeColor = Color.DarkBlue }, 1, i);
                tableVarlik.Controls.Add(new Label() { Text = urun.Barkod.ToString() }, 2, i);
                tableVarlik.Controls.Add(new Label() { Text = urun.UrunTipi }, 3, i);
                tableVarlik.Controls.Add(new Label() { Text = urun.GüncelFiyat.ToString() }, 4, i);
                tableVarlik.Controls.Add(new Label() { Text = urun.Marka }, 5, i);
                tableVarlik.Controls.Add(new Label() { Text = urun.Model }, 6, i);


                label1.Click += Label1_Click;
                   
                i++;
            }
           
            }

        private void Label1_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            Varlik varlik = new Varlik(lbl.Text, kullanici);
            varlik.Show();
            
        }


        public void ChangeBackgroundColor()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Gainsboro;
                }
            }
        }

        public void MenuAcilisiniZamanla()
        {
            if (sidebarExpand)
            {
                // sidebar genişse, küçült.
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void btnTumVarliklar_Click(object sender, EventArgs e)
        {
            switch (kullanici.KullaniciRoluID)
            {
                case 1:
                case 2:
                    TumListeyiYuke();
                    break;
                default:
                    PoweUserListesiniYukle();
                    break;
            }
         


        }

        private void btnEkibiminVarliklari_Click(object sender, EventArgs e)
        {
            EkipListesiniYukle();
        }

        private void btnVarliklarim_Click(object sender, EventArgs e)
        {
            PersonelListesiniYukle();
        }


        
    }
}

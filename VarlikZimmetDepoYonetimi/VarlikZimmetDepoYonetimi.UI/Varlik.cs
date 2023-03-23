using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VarlikZimmetDepoYonetimi.DAL;
using VarlikZimmetDepoYonetimi.DTO;

namespace VarlikZimmetDepoYonetimi.UI
{
    public partial class Varlik : Form
    {

        List<Urun> urunler;


        string kayitNo;
        Kullanici kullanici;
        public Varlik()
        {
            InitializeComponent();
        }

        public Varlik(string kayitNo, Kullanici kullanici) : this()
        {
            this.kayitNo = kayitNo;
            this.kullanici = kullanici;
        }

        private void Varlik_Load(object sender, EventArgs e)
        {
            TumListeyiYuke();
           
        }

        public void TumListeyiYuke()
        {
            VarlikDAL varliklar = new VarlikDAL();
            urunler = varliklar.VarlikDetay();

            KullaniciGirisiDAL kullanicilar = new KullaniciGirisiDAL();
            List<Kullanici> kullaniciListesi = kullanicilar.KullaniciGirisi();

            VarlikTablosunuDoldur(urunler, kullaniciListesi);
            FormDoldur(urunler);
        }


        public void FormDoldur(List<Urun> urunler)
        {
            foreach (var urun in urunler)
            {

                cmbMarka.Items.Add(urun.Marka);
                cmbModel.Items.Add(urun.Model);
                cmbMaliyetParaBirimi.Items.Add(urun.FiyatParaBirimi);
                cmbUrunGuncelFiyatBirimi.Items.Add(urun.FiyatParaBirimi);
                cmbUrunTipi.Items.Add(urun.UrunTipi);

                cmbGarantilimi.Items.Add("Evet");
                cmbGarantilimi.Items.Add("Hayır");

                if (kayitNo == urun.KayitNumarasi.ToString())
                {
                    lblBarkodNo.Text = kayitNo.ToString();
                    txtBarkod.Text = urun.Barkod.ToString();
                    txtAciklama.Text = urun.UrunAciklama;
                    txtUrunMaliyeti.Text = urun.Maliyet.ToString();
                    txtUrunGuncelFiyat.Text = urun.GüncelFiyat.ToString();
                    dateUrunGiris.Value = urun.KayitTarihi;

                    cmbMarka.SelectedItem = urun.Marka;
                    cmbModel.SelectedItem = urun.Model;
                    cmbUrunGuncelFiyatBirimi.SelectedItem = urun.FiyatParaBirimi;
                    cmbUrunTipi.SelectedItem = urun.UrunTipi;
                    cmbMaliyetParaBirimi.SelectedItem = urun.FiyatParaBirimi;

                    if (urun.Garantilimi)
                    {
                        cmbGarantilimi.SelectedItem = "Evet";
                    }
                    else
                    {
                        cmbGarantilimi.SelectedItem = "Hayır";
                    }

                    if (urun.Barkod != null)
                    {
                        checkBoxBarkod.Checked = true;
                    }
                    else
                    {
                        checkBoxBarkod.Checked = false;
                    }

                }
            }
        }

        public void VarlikTablosunuDoldur(List<Urun> urunler, List<Kullanici> kullanicilar)
        {
            tableVarlik.Controls.Clear();
            int i = 0;

            foreach (Urun urun in urunler)
            {
                foreach (Kullanici kullanici in kullanicilar)
                {
                    if (kayitNo == urun.KayitNumarasi.ToString() && kullanici.KullaniciID == urun.KullaniciID)
                    {
                        tableVarlik.Controls.Add(new Label() { Text = urun.KayitTarihi.ToString() }, 0, i);
                        tableVarlik.Controls.Add(new Label() { Text = kullanici.KullaniciAdi + ' ' + kullanici.KullaniciSoyadi }, 1, i);
                        tableVarlik.Controls.Add(new Label() { Text = urun.UrunDurumu }, 2, i);
                        tableVarlik.Controls.Add(new Label() { Text = urun.UrunSonIslem }, 3, i);
                        tableVarlik.Controls.Add(new Label() { Text = urun.KayitTarihi.ToString() }, 4, i);
                        tableVarlik.Controls.Add(new Label() { Text = kullanici.KullaniciAdi + ' ' + kullanici.KullaniciSoyadi }, 5, i);
                        tableVarlik.Controls.Add(new Label() { Text = kullanici.KullaniciEkibi }, 6, i);
                        tableVarlik.Controls.Add(new Label() { Text = urun.UrunAciklama }, 7, i);
                        i++;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZimmetAtama zimmetAtama = new ZimmetAtama();
            zimmetAtama.Show();
        }
    }
}

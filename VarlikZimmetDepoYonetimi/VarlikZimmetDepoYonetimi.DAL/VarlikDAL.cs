using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikZimmetDepoYonetimi.DTO;
using VarlikZimmetDepoYonetimi.MyProvider;

namespace VarlikZimmetDepoYonetimi.DAL
{
    public class VarlikDAL
    {
        public List<Urun> VarlikDetay()
        {
            MSSQLProvider conn = new MSSQLProvider("select * from VarlikList");



            conn.Open();

            SqlDataReader rdr = conn.ExcuteredaerOlustur();

            List<Urun> urunListesi = new List<Urun>();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Urun urun = new Urun();
                    urun.KayitNumarasi = rdr.GetDecimal(0);
                    urun.Barkod = rdr.GetGuid(1);
                    urun.UrunTipi = rdr.GetString(2);
                    urun.GüncelFiyat = rdr.GetDecimal(3);
                    urun.FiyatParaBirimi = rdr.GetString(4);
                    urun.Marka = rdr.GetString(5);
                    urun.Model = rdr.GetString(6);
                    urun.UrunDurumu = rdr.GetString(7);
                    urun.UrunSonIslem = rdr.GetString(8);
                    urun.KayitTarihi = rdr.GetDateTime(9);
                    urun.KullaniciID = rdr.GetInt32(10);
                    urun.UrunAciklama = rdr.GetString(11);
                    urun.Maliyet = rdr.GetDecimal(12);
                    urun.Garantilimi = rdr.GetBoolean(13);
                    urun.UrunID = rdr.GetInt32(14);

                    urunListesi.Add(urun);
                }
            }

            conn.Close();

            return urunListesi;
        }
    }
}

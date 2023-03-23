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
    public class EkipVarlikListesiDAL
    {
        public List<Urun> EkipVarliklariniListele(int kullaniciID, int ekipID, int sirketID)
        {
            MSSQLProvider conn = new MSSQLProvider($"exec EkibeGoreVarlikFiltreleme {kullaniciID},{ekipID},{sirketID};");



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

                    urunListesi.Add(urun);
                }
            }

            conn.Close();

            return urunListesi;
        }
    }
}

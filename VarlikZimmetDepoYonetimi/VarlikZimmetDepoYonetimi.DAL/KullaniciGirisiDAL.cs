using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikZimmetDepoYonetimi.DTO;
using VarlikZimmetDepoYonetimi.MyProvider;

namespace VarlikZimmetDepoYonetimi.DAL 
{
    public class KullaniciGirisiDAL
    {

        public List<Kullanici> KullaniciGirisi() {

            MSSQLProvider conn = new MSSQLProvider("select * from KullaniciTable");

            conn.Open();

            SqlDataReader rdr = conn.ExcuteredaerOlustur();

            List<Kullanici> kullaniciListem = new List<Kullanici>();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Kullanici kullanici = new Kullanici();
                    kullanici.KullaniciEmail = rdr.GetString(0);
                    kullanici.KullaniciSifre = rdr.GetInt32(1);
                    kullanici.EkipID = rdr.GetInt32(2);
                    kullanici.SirketID = rdr.GetInt32(3);
                    kullanici.KullaniciID = rdr.GetInt32(4);
                    kullanici.KullaniciAdi = rdr.GetString(5);
                    kullanici.KullaniciSoyadi = rdr.GetString(6);
                    kullanici.KullaniciRoluID = rdr.GetInt32(7);
                    kullanici.KullaniciEkibi = rdr.GetString(8);

                    kullaniciListem.Add(kullanici);
                }
            }

            conn.Close();

            return kullaniciListem;
        }


       
    }
}

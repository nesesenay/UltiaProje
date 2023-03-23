using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetimi.DTO
{
    public class Kullanici
    {

        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string KullaniciEkibi { get; set; }
        public int KullaniciID { get; set; }
        public string KullaniciEmail { get; set; }
        public int KullaniciSifre { get; set; }
        public int EkipID { get; set; }
        public int SirketID { get; set; }
        public int KullaniciRoluID { get; set; }
      
    }
}

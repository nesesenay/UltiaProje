using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetimi.DTO
{
    public class UrunDetay
    {
        public int UrunTipiID { get; set; }
        public decimal UrununGuncelFiyati { get; set; }
        public int UrunMarkaID { get; set; }
        public int UrunModelID { get; set; }
        public DateTime UrunGirisTarihi { get; set; }
        public int UrunMaliyetiID { get; set; }
    }
}

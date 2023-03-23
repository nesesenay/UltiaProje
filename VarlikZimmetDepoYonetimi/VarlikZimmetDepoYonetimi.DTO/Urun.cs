using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetimi.DTO
{
    public class Urun
    {
        public decimal KayitNumarasi { get; set; }
        public int UrunID { get; set; }
        public Guid Barkod { get; set; }
        public string UrunTipi { get; set; }
        public decimal GüncelFiyat { get; set; }
        public decimal Maliyet { get; set; }
        public string FiyatParaBirimi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string UrunDurumu { get; set; }
        public string UrunSonIslem { get; set; }
        public int KullaniciID { get; set; }
        public string UrunAciklama { get; set; }
        public bool Garantilimi { get; set; }
    }

    
}

using System;

namespace Yesilyurt_Ciftci_Kayit.Entities
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string UrunCesidi { get; set; }
        public int KullaniciId { get; set; }
        public DateTime CreateTime { get; set; }


    }
}

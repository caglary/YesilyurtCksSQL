using System;

namespace Yesilyurt_Ciftci_Kayit.Entities
{
    public class YemBitkisi
    {
        public int Id { get; set; }
        public int CksId { get; set; }
        public int UrunId { get; set; }
        public int DosyaNo { get; set; }
        public DateTime MuracaatTarihi { get; set; }
        public string EkilisYili { get; set; }
        public string AraziMahalle { get; set; }
        public string Ada { get; set; }
        public string Parsel { get; set; }
        public string MuracaatAlani { get; set; }
        public string TespitEdilenAlan { get; set; }
        public string KontrolTarihi { get; set; }
        public string KontrolEdenler { get; set; }
        public string Note { get; set; }
        public string KontrolDurumu { get; set; }
        public int KullaniciId { get; set; }
        public DateTime CreateTime { get; set; }

    }
}

using System;
namespace Yesilyurt_Ciftci_Kayit.Entities
{
    public class SertifikaliTohum
    {
        public int Id { get; set; }
        public int CksId { get; set; }
        public int FirmaId { get; set; }
        public int UrunId { get; set; }
        public int DosyaNo { get; set; }
        public DateTime MuracaatTarihi { get; set; }
        public string SertifikaNo { get; set; }
        public string FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string Miktari { get; set; }
        public string BirimFiyati { get; set; }
        public string ToplamMaliyet { get; set; }
        public string Note { get; set; }
        public string OdemeDurumu { get; set; }
        public int KullaniciId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

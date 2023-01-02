using System;
namespace Yesilyurt_Ciftci_Kayit.Entities.PrintTablo
{
    public class SertifikaliTohumPrint
    {
        public string TcKimlikNo { get; set; }
        public string IsimSoyisim { get; set; }
        public int DosyaNo { get; set; }
        public DateTime MuracaatTarihi { get; set; }
        public string FirmaAdi { get; set; }
        public string UrunAdi { get; set; }
        public string Miktari { get; set; }
        public string OdemeDurumu { get; set; }
    }
}

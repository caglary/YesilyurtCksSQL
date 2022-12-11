using System;

namespace Yesilyurt_Ciftci_Kayit.Entities.PrintTablo
{
    public class YemBitkileriPrint
    {
     
        public int DosyaNo { get; set; }
        public string TcKimlikNo { get; set; }
        public string IsimSoyisim { get; set; }
        public DateTime BasvuruTarih { get; set; }
        public string AraziMahalle { get; set; }
        public string Urun { get; set; }
        public string Ada { get; set; }
        public string Parsel { get; set; }
        public string MuracaatAlani { get; set; }      
        public string KontrolDurumu { get; set; }
        public string TespitEdilenAlan { get; set; }
    }
}

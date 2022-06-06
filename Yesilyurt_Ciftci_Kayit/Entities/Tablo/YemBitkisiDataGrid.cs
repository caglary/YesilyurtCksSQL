using System;
namespace Yesilyurt_Ciftci_Kayit.Entities.Tablo
{
    public class YemBitkisiDataGrid
    {
        /*
            YemBitkileri.DosyaNo,
            Urun.UrunAdi,
            YemBitkileri.EkilisYili,
            YemBitkileri.AraziMahalle,
            YemBitkileri.Ada,
            YemBitkileri.Parsel,
            YemBitkileri.MuracaatAlani,
            YemBitkileri.MuracaatTarihi
         */
        public int Id { get; set; }
        public int DosyaNo { get; set; }
        public string UrunAdi { get; set; }
        public string EkilisYili { get; set; }
        public string AraziMahalle { get; set; }
        public string Ada { get; set; }
        public string Parsel { get; set; }
        public string MuracaatAlani { get; set; }
        public DateTime MuracaatTarihi { get; set; }
        public int CksId { get; set; }
        public string KontrolDurumu { get; set; }
        public string TespitEdilenAlan { get; set; }
    }
}

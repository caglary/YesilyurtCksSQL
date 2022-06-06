namespace Yesilyurt_Ciftci_Kayit.Entities.Tablo
{
    public  class FarkOdemesiDataGrid
    {
        /*
            FarkOdemesi.DosyaNo,
            Firma.FirmaAdi,
            Urun.UrunAdi,
            FarkOdemesi.Miktari,
            FarkOdemesi.Note,
            FarkOdemesi.OdemeDurumu
         */
        public int Id { get; set; }
        public int DosyaNo { get; set; }
        public string FirmaAdi { get; set; }
        public string UrunAdi { get; set; }
        public string Miktari { get; set; }
        public string Note { get; set; }
        public string OdemeDurumu { get; set; }
    }
}

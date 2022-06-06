namespace Yesilyurt_Ciftci_Kayit.Entities.Tablo
{
    public class SertifikaliTohumDataGrid
    {
        /*
         SertifikaliTohum.DosyaNo,
         Firma.FirmaAdi,
         Urun.UrunAdi,
         SertifikaliTohum.Miktari,
         SertifikaliTohum.Note,
         SertifikaliTohum.OdemeDurumu
         
         */
        public int Id { get; set; }
        public int DosyaNo { get; set; }
        public string FirmaAdi { get; set; }
        public string UrunAdi { get; set; }
        public string Miktari { get; set; }
        public string Note { get; set; }
        public string OdemeDurumu { get; set; }
        public int CksId { get; set; }
    }
}

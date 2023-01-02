using System;
namespace Yesilyurt_Ciftci_Kayit.Entities
{
    public class Firma
    {
        public int Id { get; set; }
        public string FirmaAdi { get; set; }
        public string VergiNo { get; set; }
        public string Note { get; set; }
        public int KullaniciId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

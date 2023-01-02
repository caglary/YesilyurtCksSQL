using System;
namespace Yesilyurt_Ciftci_Kayit.Entities
{
    public class Edevlet
    {
        public int Id { get; set; }
        public int CksId { get; set; }
        public string DosyaNoEdevlet { get; set; }
        public int KullaniciId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

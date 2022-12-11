using System;

namespace Yesilyurt_Ciftci_Kayit.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string Yetki { get; set; }
        public DateTime CreateTime { get; set; }
    
    }
}

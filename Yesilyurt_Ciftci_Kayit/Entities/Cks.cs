using System;

namespace Yesilyurt_Ciftci_Kayit.Entities
{
    public class Cks
    {
        public int Id { get; set; }
        public int CiftciId { get; set; }
        public int DosyaNo { get; set; }

     
        public string Note { get; set; }
        public int KullaniciId { get; set; }
        public DateTime CreateTime { get; set; }

        public string EvrakKayitNo { get; set; }
        public string HavaleEdilenPersonel { get; set; }
        public string MuracaatYeri { get; set; }

    }
}

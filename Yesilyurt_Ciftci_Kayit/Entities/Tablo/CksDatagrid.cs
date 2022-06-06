using System;
namespace Yesilyurt_Ciftci_Kayit.Entities.Tablo
{
    public class CksDatagrid
    {
        public int Id { get; set; }
        public int DosyaNo  { get; set; }
        public string TcKimlikNo { get; set; }
        public string IsimSoyisim { get; set; }
        public string BabaAdi { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string KoyMahalle { get; set; }
        public string Note { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

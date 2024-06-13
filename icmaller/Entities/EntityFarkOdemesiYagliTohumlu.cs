using System;

namespace icmaller.Entities
{
    public class EntityFarkOdemesiYagliTohumlu
    {
        public int id { get; set; }
        public int sira_no { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string mahalle_koy { get; set; }
        public string isletme_adi { get; set; }
        public string baba_adi { get; set; }
        public DateTime? dogum_tarihi { get; set; }
        public string kimlikNo { get; set; }
        public string dilekce_no { get; set; }
        public string urun_grubu { get; set; }
        public decimal destege_tabi_alan { get; set; }
        public decimal destege_tabi_uretim_miktari { get; set; }
        public decimal satis_miktari { get; set; }
        public decimal destege_tabi_miktar { get; set; }
        public decimal destek_tutari { get; set; }
    }
}

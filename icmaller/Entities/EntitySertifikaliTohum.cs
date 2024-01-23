using System;

namespace icmaller.Entities
{
    public class EntitySertifikaliTohum
    {

        public int id { get; set; }
        public int sira_no { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string mahalle_koy { get; set; }
        public string isletmeNo { get; set; }
        public string dilekce_no { get; set; }
        public string isletme_adi { get; set; }

        public string baba_adi { get; set; }
        public DateTime? dogum_tarihi { get; set; }
        public string tur { get; set; }
        public decimal fatura_miktari { get; set; }
        public decimal destekleme_alani { get; set; }
        public decimal destekleme_miktari { get; set; }
    

    }
}

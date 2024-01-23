using System;

namespace icmaller.Entities
{
    public class EntityMgd
    {

        public int id { get; set; }
        public int sira_no { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string mahalle_koy { get; set; }
        public string dilekce_no { get; set; }
        public string isletme_adi { get; set; }
        public string baba_adi { get; set; }
        public DateTime? dogum_tarihi { get; set; }
        public string tc_vergi_no { get; set; }
        public decimal mazot_alani { get; set; }
        public decimal mazot_destekleme_tutari { get; set; }
        public decimal gubre_alani { get; set; }
        public decimal gubre_destekleme_tutari { get; set; }
        public decimal toplam_destekleme_tutari { get; set; }



    }
}

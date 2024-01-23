using System;

namespace icmaller.Entities
{
    public class EntityYemBitkileri
    {

        public int id { get; set; }
        public int sira_no { get; set; }
        public string kimlikNo { get; set; }
        public string dilekce_no { get; set; }
        public string mahalle_koy { get; set; }
        public string isletme_adi { get; set; }
        public string baba_adi { get; set; }
        public DateTime? dogum_tarihi { get; set; }
        public decimal yonca_kuru { get; set; }
        public decimal yonca_sulu { get; set; }
        public decimal korunga { get; set; }
        public decimal fig { get; set; }
        public decimal hububat_grubu { get; set; }
        public decimal diger_cok_yillik { get; set; }
        public decimal diger_tek_yillik { get; set; }
        public decimal diger_silajlik_kuru { get; set; }
        public decimal diger_silajlik_sulu { get; set; }
        public decimal silajlik_misir_kuru { get; set; }
        public decimal silajlik_misir_sulu { get; set; }

        public decimal yapay_cayit_mera { get; set; }
        public decimal su_kisiti_olan_havzalar { get; set; }
        public decimal desteğe_tabi_alan { get; set; }
        public decimal destek_tutari { get; set; }



    }
}

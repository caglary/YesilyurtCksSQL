using System;

namespace icmaller.Entities
{
    public class EntityKatiOrganik
    {
        public int Id { get; set; }
        public int Sira_no { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mahalle_koy { get; set; }
        public string Dilekce_no { get; set; }
        public string Isletme_adi { get; set; }
        public string Baba_adi { get; set; }
        public DateTime? Dogum_tarihi { get; set; }
        public string KimlikNo { get; set; }
        
        
        public decimal KatiOrganikUrun { get; set; }
        public decimal KatiOrganikToprakDüzenleyici { get; set; }
        public decimal KatiOrganomineralUrun { get; set; }
        public decimal KaplamaGubre { get; set; }
        public decimal OrganikGubre { get; set; }
        public decimal DesteklenenAlan{ get; set; }
        public decimal DesteklemeMiktari{ get; set; }


    }
}

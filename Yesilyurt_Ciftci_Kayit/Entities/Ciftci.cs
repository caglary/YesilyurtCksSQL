using System;
namespace Yesilyurt_Ciftci_Kayit.Entities
{
    public class Ciftci
    {
       
        public int Id { get; set; }
        public string TcKimlikNo { get; set; }
        public string IsimSoyisim { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
        public string DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string MedeniDurum { get; set; }
        public string CepTelefonu { get; set; }
        public string EvTelefonu { get; set; }
        public string Email { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string MahalleKoy { get; set; }
        public string Not { get; set; }
        public int KullaniciId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

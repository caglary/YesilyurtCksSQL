namespace Yesilyurt_Ciftci_Kayit.Entities.icmaller
{
    public class icmalMgd
    {
        public int Id { get; set; }
        public string KimlikNo { get; set; }

        public decimal MazotAlani { get; set; }
        public decimal MazotDesteklemeMiktari { get; set; }
        public decimal GubreAlani { get; set; }
        public decimal GubreDesteklemeMiktari { get; set; }
        public decimal ToplamDesteklemeMiktari { get; set; }
        public decimal VergiKesintisi { get; set; }
        public decimal NetOdenecekTutar { get; set; }


    }
}

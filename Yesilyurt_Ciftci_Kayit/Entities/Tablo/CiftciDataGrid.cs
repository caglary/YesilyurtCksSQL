namespace Yesilyurt_Ciftci_Kayit.Entities.Tablo
{
    public class CiftciDataGrid
    {
        //TcKimlikNo,NameSurname,FatherName,MotherName,Village,createtime
        public int Id { get; set; }
        public string TcKimlikNo { get; set; }
        public string IsimSoyisim { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
        public string MahalleKoy { get; set; }
        public string CreateTime { get; set; }
    }
}

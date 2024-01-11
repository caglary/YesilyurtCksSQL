using System;
using System.Linq;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
        public static void farkOdemesiKayitEkle2023()
        {
            //Fark ödemesi destekleme müracaat listesini programa işlemek için yazıldı. 
            //Kayıtlar 2023 yılı için veritabanını kullanıyor.
            try
            {
                Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year = "2023";
                string connectionString = Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.Get();
                Console.WriteLine(connectionString);
                ConsoleKeyInfo cki;
                CksManager cksManager = new CksManager();
                CiftciManager ciftciManager = new CiftciManager();
                FarkOdemesiManager farkOdemesiManager = new FarkOdemesiManager();

                listele(farkOdemesiManager, cksManager, ciftciManager);
            etiket:
                Console.Write("Tc numarası giriniz: ");

                string tc = Console.ReadLine();
                var cks = cksManager.GetByTc(tc);
                var ciftci = ciftciManager.GetAll().Where(I => I.TcKimlikNo == tc).FirstOrDefault();
                if (ciftci == null)
                {
                    Console.WriteLine("tc bulunamadı");
                    goto etiket;
                }
                Console.WriteLine(ciftci.IsimSoyisim + " (2023 yılı çks dosya no : " + cks.DosyaNo + " )");
                var benzerCksKaydiVarMi = farkOdemesiManager.GetAll().Where(I => I.CksId == cks.Id).FirstOrDefault();
                if (benzerCksKaydiVarMi != null)
                {
                    Console.WriteLine("tc numarasına ait kayıt mevcuttur.");
                    goto etiket;
                }
                FarkOdemesi farkOdemesi = new FarkOdemesi();
                farkOdemesi.CksId = cks.Id;

                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                {
                    goto etiket;
                }

                if (Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year == "2023")
                {
                    farkOdemesi.FirmaId = 10;
                    farkOdemesi.UrunId = 29;
                    farkOdemesi.DosyaNo = 0;
                    farkOdemesi.MuracaatTarihi = Convert.ToDateTime("01/01/2000");
                    farkOdemesi.FaturaNo = "0000";
                    farkOdemesi.FaturaTarihi = Convert.ToDateTime("01/01/2000");
                    farkOdemesi.Miktari = "0";
                    farkOdemesi.BirimFiyati = "0";
                    decimal miktar = Convert.ToDecimal(farkOdemesi.Miktari);
                    decimal birimFiyati = Convert.ToDecimal(farkOdemesi.BirimFiyati);
                    decimal toplamMaliyet = miktar * birimFiyati;
                    farkOdemesi.ToplamMaliyet = toplamMaliyet.ToString();
                    farkOdemesi.Note = "fatura bilgileri kayıt altına alınmadı.";

                    farkOdemesi.KullaniciId = 1;
                    int result = farkOdemesiManager.Add(farkOdemesi);
                    if (result == 1)
                    {
                        listele(farkOdemesiManager, cksManager, ciftciManager);
                        goto etiket;
                    }

                }




                Console.ReadLine();
            }
            catch (Exception)
            {

                //hata fırlat...
            }
        }
        private static void listele(FarkOdemesiManager farkOdemesiManager, CksManager cksManager, CiftciManager ciftciManager)
        {
            var liste = farkOdemesiManager.GetAll();

            if (liste.Count >= 10)
            {
                Console.WriteLine("Toplam Kişi Sayısı : " + liste.Count);
                Console.WriteLine("--------------------------");
                for (int i = liste.Count - 1; i > liste.Count - 10; i--)
                {
                    var cks = cksManager.GetAll().Where(I => I.Id == liste[i].CksId).FirstOrDefault();
                    var ciftci = ciftciManager.GetAll().Where(I => I.Id == cks.CiftciId).FirstOrDefault();

                    Console.WriteLine("isim : " + ciftci.IsimSoyisim + "   2023 çks dosya no : " + liste[i].CksId + "   Tc No:" + ciftci.TcKimlikNo);

                }
                Console.WriteLine("--------------------------");
            }


        }


    }

}

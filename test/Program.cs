using icmaller.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Xml;
using Yesilyurt_Ciftci_Kayit.Entities;
using Yesilyurt_Ciftci_Kayit.Manager;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1-) 2024 Yılı Sertifikalı Tohum Müracaat Listesi Kayıt Ekranı");
            Console.WriteLine("2-) 2023 Yılı Fark Ödemesi Müracaat Listesi Kayıt Ekranı");
        etiket:
            string secim = Console.ReadLine();
            if (secim == "1") sertifikaliTohumListeEkle();
            else if (secim == "2") farkOdemesiKayitEkle2023();
            
            else
            {
                Console.WriteLine("hatalı seçim yaptınız.Tekrar deneyin");
                goto etiket;

            }



        }
        private static void sertifikaliTohumListeEkle()
        {
            
            Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year = "2024";
            string connectionString = Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.Get();
            Console.WriteLine(connectionString);

            CksManager cksManager = new CksManager();
            CiftciManager ciftciManager = new CiftciManager();
            SertifikaliTohumManager sertifikaliTohumManager = new SertifikaliTohumManager();

            void listele()
            {
                var listeToplam = sertifikaliTohumManager.GetAll_SertifikaliTohum_ForPrint();

                Console.WriteLine("\n--------------------------------------------------------------------------------------");
                Console.WriteLine("*****" + Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year + " YILI SERTİFİKALI TOHUM MÜRACAAT LİSTESİ *****");
                Console.WriteLine("--------------------------------------------------------------------------------------\n");
                int counter = 0;
                foreach (var item in listeToplam)
                {
                    if (counter==10)
                    {
                        goto devam;
                    }
                    Console.WriteLine($"{item.DosyaNo} {item.IsimSoyisim} {item.TcKimlikNo} ");
                    counter++;

                }
                devam:
                Console.WriteLine("\nToplam : " + listeToplam.Count + " kişi mevcuttur.");
                Console.WriteLine("--------------------------------------------------------------------------------------\n");
            }
            listele();
        etiket:
            Console.Write("Tc numarası giriniz: ");
                   
            string tc = Console.ReadLine();
            tc= tc.Trim();

        

            if (tc.Length != 11)
            {
                Console.WriteLine("Tc kimlik no eksik girdiniz.");
                goto etiket;
            }
            var cks = cksManager.GetByTc(tc);
            var ciftci = ciftciManager.GetAll().Where(I => I.TcKimlikNo == tc).FirstOrDefault();
            if (ciftci == null)
            {
                Console.WriteLine("tc bulunamadı");
                goto etiket;
            }

            var kayit = sertifikaliTohumManager.GetAll_SertifikaliTohum_ForPrint().Where(I => I.TcKimlikNo == tc).FirstOrDefault();
            if (kayit != null)
            {
                Console.WriteLine($"{kayit.DosyaNo} {kayit.TcKimlikNo} {kayit.IsimSoyisim}  - (Eklemek istediğiniz T.C. kimlik numaralı kayıt listede mevcut)");

                Console.WriteLine("");
                goto etiket;
            }
            try
            {
                int result = sertifikaliTohumManager.Add(new SertifikaliTohum
                {
                    BirimFiyati = "0",
                    CksId = cks.Id,
                    FirmaId = 10,
                    KullaniciId = 2,
                    Miktari = "0",
                    FaturaTarihi = Convert.ToDateTime("01/01/2000"),
                    CreateTime = DateTime.Now,
                    DosyaNo = cks.DosyaNo,
                    FaturaNo = "bilinmiyor",
                    MuracaatTarihi = Convert.ToDateTime("01/01/2000"),
                    Note = "fatura bilgisi kayıt edilmedi.",
                    OdemeDurumu = "0",
                    SertifikaNo = "bilinmiyor",
                    ToplamMaliyet = "0",
                    UrunId = 29

                });
                if (result != 1)
                {
                    Console.WriteLine("HATA : kayıt yapılamadı.");
                    goto etiket;
                }
                listele();
            }
            catch (Exception exception)
            {

                Console.WriteLine("\n"+exception.Message+"\n");
            }
           



            goto etiket;
        }
        private static void xmlIntro()
        {
            // XML dosya yolunu belirtin
            string xmlFilePath = "C:\\Users\\cagla\\Downloads\\Rapor_Fiziksel_Dilekce_Kaydı_Uretici_Detayında_Basvuru_Bilgileri.xml";

            try
            {
                // XmlDocument nesnesini oluşturun ve XML dosyasını yükleyin
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                // XmlNamespaceManager oluşturun ve xmlns tanımını ekleyin
                XmlNamespaceManager nsManager = new XmlNamespaceManager(xmlDoc.NameTable);
                nsManager.AddNamespace("ns", xmlDoc.DocumentElement.NamespaceURI);

                // XPath ifadesiyle belirli bir düğümü seçme
                XmlNodeList detailsNodes = xmlDoc.SelectNodes("//ns:Details_Collection/ns:Details", nsManager);

                if (detailsNodes != null)
                {
                    foreach (XmlNode detailsNode in detailsNodes)
                    {
                        // Her bir detay düğümündeki özelliklere erişme
                        string textbox16Value = detailsNode.Attributes["FileConfirmPersonel"].Value;
                        string idNoValue = detailsNode.Attributes["IdNo"].Value;
                        string nameValue = detailsNode.Attributes["Name"].Value;
                        string surnameValue = detailsNode.Attributes["Surname"].Value;

                        Console.WriteLine($"Textbox16: {textbox16Value}, IdNo: {idNoValue}, Name: {nameValue}, Surname: {surnameValue}");
                    }
                }
                else
                {
                    Console.WriteLine("Belirtilen XPath ifadesine uygun düğüm bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"XML okuma hatası: {ex.Message}");
            }

            Console.Read();
        }
        private static void DatabaseToJsonYazdir()
        {
            DatabaseToJson("YesilyurtDb2024", "select *  from icmal_fark_odemesi_2023", "FarkÖdemesiListe");
            DatabaseToJson("YesilyurtDb2024", "select  * from icmal_sertifikali_tohum_2023", "SertifikalıTohumListe");
            DatabaseToJson("YesilyurtDb2024", "select * from icmal_yem_bitkileri_2023", "YemBitkileriListe");
            DatabaseToJson("YesilyurtDb2024", "select *  from icmal_mgd_2023", "MgdListe");

            // JSON dosyasının yolunu belirtin
            string jsonFilePath = "FarkÖdemesiListe" + ".json";

            // JSON dosyasındaki veriyi okuyun
            string jsonData = File.ReadAllText(jsonFilePath);

            // JSON verisini C# nesnesine dönüştürün
            List<icmaller.Entities.EntityFarkOdemesi> data = JsonConvert.DeserializeObject<List<EntityFarkOdemesi>>(jsonData);
            // Listeyi yazdır
            Console.WriteLine("Liste İçeriği:");


            foreach (var item in data)
            {
                Console.WriteLine(item.isletme_adi);
            }
        }

        public static void DatabaseToJson(string database, string query, string fileName)
        {
            // Veritabanı bağlantı dizesi
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=" + database + ";Trusted_Connection=True;";

            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL sorgusu
                string sqlQuery = query;

                // SQL komutunu oluştur
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Verileri oku
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // JSON için liste oluştur
                        List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();

                        // Verileri oku ve liste oluştur
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader[i];
                            }

                            data.Add(row);
                        }

                        // Listeyi JSON'a dönüştür
                        string jsonData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);

                        // JSON'u dosyaya yaz
                        string filePath = fileName + ".json";

                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            sw.Write(jsonData);
                        }

                        Console.WriteLine("JSON verileri dosyaya başarıyla kaydedildi. Dosya Yolu: " + filePath);
                    }
                }
            }
        }
        public static void cks2024EdevletKayitEkle()
        {
            try
            {
                Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year = "2024";
                string connectionString = Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.Get();
                Console.WriteLine(connectionString);
                CksManager cksManager = new CksManager();
                CiftciManager ciftciManager = new CiftciManager();

            etiket:
            tc_gir:
                Console.Write("Tc numarası giriniz: ");
                string tc = Console.ReadLine();
                if (string.IsNullOrEmpty(tc))
                {
                    goto tc_gir;
                }
                var ciftci = ciftciManager.GetAll().Where(I => I.TcKimlikNo == tc).FirstOrDefault();
                if (ciftci == null)
                {
                    Console.WriteLine("tc bulunamadı");
                    goto etiket;
                }

                Console.WriteLine(ciftci.IsimSoyisim);


                cksManager.Add(new Cks
                {
                    CiftciId = ciftci.Id,
                    CreateTime = DateTime.Now,
                    DosyaNo = cksManager.DosyaNoFactory(),
                    EvrakKayitNo = "bilinmiyor",
                    HavaleEdilenPersonel = "bilinmiyor",
                    KullaniciId = 2,
                    MuracaatYeri = "E-Devlet Üzerinden yapılan başvuru",
                    Note = ""



                });


                //listele
                var liste = cksManager.GetAllCksDataGrid();

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(liste[i].DosyaNo + " -> " + liste[i].IsimSoyisim);
                }
                goto etiket;

            }
            catch (Exception)
            {


            }
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
                    farkOdemesi.DosyaNo = cks.DosyaNo;
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

            void listele(FarkOdemesiManager farkOdemesiManager, CksManager cksManager, CiftciManager ciftciManager)
            {
                var liste = farkOdemesiManager.GetAll();

                if (liste.Count >= 10)
                {
                    Console.WriteLine("\n--------------------------------------------------------------------------------------");
                    Console.WriteLine("***** " + Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year + " YILI HUBUBAT BAKLAGİL VE DANE MISIR FARK ÖDEMESİ MÜRACAAT LİSTESİ *****");
                    Console.WriteLine("--------------------------------------------------------------------------------------\n");


                    Console.WriteLine("Toplam Kişi Sayısı : " + liste.Count);
                    Console.WriteLine("--------------------------");
                    for (int i = liste.Count - 1; i > liste.Count - 10; i--)
                    {
                        var cks = cksManager.GetAll().Where(I => I.Id == liste[i].CksId).FirstOrDefault();
                        var ciftci = ciftciManager.GetAll().Where(I => I.Id == cks.CiftciId).FirstOrDefault();

                        Console.WriteLine("isim : " + ciftci.IsimSoyisim + "   2023 çks dosya no : " + liste[i].DosyaNo + "   Tc No:" + ciftci.TcKimlikNo);

                    }
                    Console.WriteLine("--------------------------");
                }


            }



        }


        


    }

}

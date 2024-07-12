using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace word_test
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year = "2024";
            Database database = new Database();

            Console.WriteLine(database.getConnectionString());
            SqlDataReader items = database.items();
            List<EntitySablon> list = new List<EntitySablon>();
            while (items.Read())
            {

                EntitySablon entitySablon = new EntitySablon();
                entitySablon.dosyaNo = items.GetInt32(0);
                entitySablon.kimlikNo = items.GetString(1);
                entitySablon.isim = items.GetString(2);
                entitySablon.urun = items.GetString(3);
                entitySablon.ada = items.GetString(4);
                entitySablon.parsel = items.GetString(5);
                entitySablon.alan = items.GetString(6);
                entitySablon.ekilisYili = items.GetString(7);
                entitySablon.mahalleKoy = items.GetString(8).ToUpper();
                list.Add(entitySablon);



            };
            items.Close();
            database.BaglantiAyarla();
            Console.WriteLine(list.Count);
            var x = 0;

            var listByKimlikNo = list.GroupBy(I => I.kimlikNo);
            var listByMahalle = list.GroupBy(I => I.mahalleKoy);
            //tc numaraları ile liste geldi
            foreach (var mahalleListeParsel in listByMahalle)
            {
                //isim listesi
                var mahalledekiIsimler = mahalleListeParsel.GroupBy(I => I.isim);

                foreach (var isim in mahalledekiIsimler)
                {
                    List<EntitySablon> kayitlar = new List<EntitySablon>();
                    foreach (var isimAitParseller in isim)
                    {
                        //ismini geldi.
                        EntitySablon kayit = new EntitySablon();
                        kayit.alan = isimAitParseller.alan;
                        kayit.parsel = isimAitParseller.parsel;
                        kayit.kimlikNo = isimAitParseller.kimlikNo;
                        kayit.dosyaNo = isimAitParseller.dosyaNo;
                        kayit.urun = isimAitParseller.urun;
                        kayit.ekilisYili = isimAitParseller.ekilisYili;
                        kayit.isim = isimAitParseller.isim;
                        kayit.kimlikNo = isimAitParseller.kimlikNo;
                        kayit.mahalleKoy = isimAitParseller.mahalleKoy;
                        kayit.ada=isimAitParseller.ada;
                        kayitlar.Add(kayit);


                        Console.WriteLine(isimAitParseller.isim + " " + isimAitParseller.mahalleKoy + " " + isimAitParseller.ada + " " + isimAitParseller.parsel);


                    }
                    Console.WriteLine(kayitlar.Count);

                    if (kayitlar.Count <= 5)  {
                        
                        //printPdf(kayitlar, 1,0, kayitlar.Count);      
                    }
                    else if (kayitlar.Count > 5 && kayitlar.Count<=10) {

                        //printPdf(kayitlar, 1, 0, 5);
                        printPdf(kayitlar, 2, 5, kayitlar.Count);

                    }
                    else if (kayitlar.Count > 10 && kayitlar.Count <= 15) {
                        printPdf(kayitlar, 1, 0, 5);
                        printPdf(kayitlar, 2, 5, 10);
                        printPdf(kayitlar, 3, 10, kayitlar.Count);

                    }
                    else if (kayitlar.Count > 15 && kayitlar.Count <= 20) {

                        printPdf(kayitlar, 1, 0, 5);
                        printPdf(kayitlar, 2, 5, 10);
                       
                        printPdf(kayitlar, 3, 10, 15);
                        printPdf(kayitlar, 4, 15, kayitlar.Count);


                    }
                    else if (kayitlar.Count > 20 && kayitlar.Count <= 25) {
                        printPdf(kayitlar, 1, 0, 5);
                        printPdf(kayitlar, 2, 5, 10);

                        printPdf(kayitlar, 3, 10, 15);
                        printPdf(kayitlar, 4, 15, 20);
                        printPdf(kayitlar, 5, 20, kayitlar.Count);

                    }
                    else if (kayitlar.Count > 25 && kayitlar.Count <= 30) {
                        printPdf(kayitlar, 1, 0, 5);
                        printPdf(kayitlar, 2, 5, 10);
                        printPdf(kayitlar, 3, 10, 15);
                        printPdf(kayitlar, 4, 15, 20);
                        printPdf(kayitlar, 5, 20, 25);
                        printPdf(kayitlar, 6, 25, kayitlar.Count);

                        }

                }
            }






        }

        static void printPdf(List<EntitySablon> kayitlar,int pageNo,int startNo,int stopNo)
        {
            Microsoft.Office.Interop.Word.Application app;
            Microsoft.Office.Interop.Word.Document doc;
            object objMiss = Missing.Value;
            object tmpFile = "C:\\Users\\caglar.yurdakul\\Documents\\x\\" + kayitlar[0].isim.ToLower() +pageNo.ToString()+ ".pdf";
            object fileLocation = @"C:\\Users\\caglar.yurdakul\\Desktop\\tutanak_sablon\\sablon" + pageNo+".docx";

            app = new Microsoft.Office.Interop.Word.Application();
            doc = app.Documents.Open( fileLocation, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss);
            try
            {


                void findAndReplace(object findText, object replaceText)
                {
                    app.Selection.Find.Execute(ref findText, true, true, false, false, false, true, false, 1, ref replaceText, 2, false, false, false, false);
                };
                findAndReplace("[mahalle]", kayitlar[0].mahalleKoy.ToUpper());
                findAndReplace("[isim]", kayitlar[0].isim.ToUpper());
                findAndReplace("[tcno]", kayitlar[0].kimlikNo.ToUpper());


                int sablonNumaralari = 0;
                //en fazla 5 adet kayıt gelecek
                for (int i = startNo; i < stopNo; ++i)
                {
                    if (i < 5) sablonNumaralari = i;
                    else if (i >= 5 || i < 10) sablonNumaralari = i % 5;
                    
                    if (kayitlar[i].urun == null)
                    {
                        findAndReplace("[yembitkisi" + sablonNumaralari + "]", " ");
                    }
                    else
                    {
                        findAndReplace("[yembitkisi" + sablonNumaralari + "]", kayitlar[i].urun);
                    }

                    if (kayitlar[i].ada == null)
                    {
                        findAndReplace("[ada" + sablonNumaralari + "]", "0");
                    }
                    else
                    {
                        findAndReplace("[ada" + sablonNumaralari + "]", kayitlar[i].ada);
                    }

                    if (kayitlar[i].parsel == null)
                    {
                        findAndReplace("[parsel" + sablonNumaralari + "]", "0");
                    }
                    else
                    {
                        findAndReplace("[parsel" + sablonNumaralari + "]", kayitlar[i].parsel);
                    }

                    if (kayitlar[i].alan == null)
                    {
                        findAndReplace("[alan" + sablonNumaralari + "]", "0");
                    }
                    else
                    {
                        findAndReplace("[alan" + sablonNumaralari + "]", kayitlar[i].alan);
                    }

                    if (kayitlar[i].ekilisYili == null)
                    {
                        findAndReplace("[ekilistarih" + sablonNumaralari + "]", "0");
                    }
                    else
                    {
                        findAndReplace("[ekilistarih" + sablonNumaralari + "]", kayitlar[i].ekilisYili);
                    }



                }

                //Formu temizliyoruz...
                findAndReplace("[yembitkisi0]", "");
                findAndReplace("[yembitkisi1]", "");
                findAndReplace("[yembitkisi2]", "");
                findAndReplace("[yembitkisi3]", "");
                findAndReplace("[yembitkisi4]", "");

                findAndReplace("[ada0]", "");
                findAndReplace("[ada1]", "");
                findAndReplace("[ada2]", "");
                findAndReplace("[ada3]", "");
                findAndReplace("[ada4]", "");

                findAndReplace("[parsel0]", "");
                findAndReplace("[parsel1]", "");
                findAndReplace("[parsel2]", "");
                findAndReplace("[parsel3]", "");
                findAndReplace("[parsel4]", "");

                findAndReplace("[alan0]", "");
                findAndReplace("[alan1]", "");
                findAndReplace("[alan2]", "");
                findAndReplace("[alan3]", "");
                findAndReplace("[alan4]", "");

                findAndReplace("[ekilistarih0]", "");
                findAndReplace("[ekilistarih1]", "");
                findAndReplace("[ekilistarih2]", "");
                findAndReplace("[ekilistarih3]", "");
                findAndReplace("[ekilistarih4]", "");

                findAndReplace("[tespitalan0]", "");
                findAndReplace("[tespitalan1]", "");
                findAndReplace("[tespitalan2]", "");
                findAndReplace("[tespitalan3]", "");
                findAndReplace("[tespitalan4]", "");





                doc.ExportAsFixedFormat(tmpFile.ToString(), Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);



            }
            catch (Exception exception)
            {

           
                Console.WriteLine(exception.Message);
            }
            finally
            {
                doc.Close(WdSaveOptions.wdDoNotSaveChanges, WdOriginalFormat.wdOriginalDocumentFormat, false);
                app.Quit(WdSaveOptions.wdDoNotSaveChanges);
            }
           

          
        }

    }

    public class Database : Yesilyurt_Ciftci_Kayit.Database.BaseDal
    {
        public SqlDataReader items()
        {

            command = new System.Data.SqlClient.SqlCommand("SELECT CKS.DosyaNo,Ciftciler.TcKimlikNo,Ciftciler.NameSurname,urun.UrunAdi,YemBitkileri.Ada,YemBitkileri.Parsel,YemBitkileri.MuracaatAlani,YemBitkileri.EkilisYili, YemBitkileri.AraziMahalle FROM [YesilyurtDb2024].[dbo].[YemBitkileri]  inner join Urun on YemBitkileri.UrunId=Urun.Id  inner join Cks on Cks.Id=YemBitkileri.CksId  inner join Ciftciler on cks.CiftciId=Ciftciler.Id", connect);
            BaglantiAyarla();
            return command.ExecuteReader();


        }
        public string getConnectionString()
        {
            return Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.Get();
        }

    }
    public class EntitySablon
    {
        public int dosyaNo { get; set; }
        public string kimlikNo { get; set; }
        public string isim { get; set; }
        public string urun { get; set; }
        public string ada { get; set; }
        public string parsel { get; set; }
        public string alan { get; set; }
        public string ekilisYili { get; set; }
        public string mahalleKoy { get; set; }
    }
}

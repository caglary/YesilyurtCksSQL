using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace word_test
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Yesilyurt_Ciftci_Kayit.Utilities.ConnectionString.year = "2024";
            Database database = new Database();
        
            Console.WriteLine( database.getConnectionString());
            SqlDataReader items= database.items();
            List<EntitySablon> list = new List<EntitySablon>(); 
            while (items.Read()) { 
            
                EntitySablon entitySablon = new EntitySablon();
                entitySablon.dosyaNo = items.GetInt32(0);
                entitySablon.kimlikNo = items.GetString(1);
                entitySablon.isim = items.GetString(2);
                entitySablon.urun = items.GetString(3);
                entitySablon.ada = items.GetString(4);
                entitySablon.parsel = items.GetString(5);
                entitySablon.alan = items.GetString(6);
                entitySablon.ekilisYili=items.GetString(7);
                entitySablon.mahalleKoy=items.GetString(8);
                list.Add(entitySablon);
                //Console.WriteLine(entitySablon.dosyaNo.ToString() + " " + entitySablon.kimlikNo + " " + entitySablon.isim + " " + entitySablon.urun + " " + entitySablon.ada + " " + entitySablon.parsel + " " + entitySablon.alan + " " + entitySablon.ekilisYili + " " + entitySablon.mahalleKoy + " ");


            };
            items.Close();
            database.BaglantiAyarla();
            Console.WriteLine(list.Count);
            var x = 0;
            foreach (var item in list)
            {
                printPdf(item.mahalleKoy);
                x++;
                if(x==3) return;
            }
           




        }

        static void printPdf(string isim)
        {
            Microsoft.Office.Interop.Word.Application app;
            Microsoft.Office.Interop.Word.Document doc;
            object objMiss = Missing.Value;
            object tmpFile = "C:\\Users\\caglar.yurdakul\\Documents\\"+isim.ToLower()+".pdf";
            object fileLocation = @"C:\Users\caglar.yurdakul\Documents\sablon.docx";

            app = new Microsoft.Office.Interop.Word.Application();
            doc = app.Documents.Open(ref fileLocation, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss);
            try
            {


                void findAndReplace(object findText, object replaceText)
                {
                    app.Selection.Find.Execute(ref findText, true, true, false, false, false, true, false, 1, ref replaceText, 2, false, false, false, false);
                };
                findAndReplace("[mahalle]", isim.ToUpper());
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
        public SqlDataReader items() {
           
            command = new System.Data.SqlClient.SqlCommand("SELECT CKS.DosyaNo,Ciftciler.TcKimlikNo,Ciftciler.NameSurname,urun.UrunAdi,YemBitkileri.Ada,YemBitkileri.Parsel,YemBitkileri.MuracaatAlani,YemBitkileri.EkilisYili, YemBitkileri.AraziMahalle FROM [YesilyurtDb2024].[dbo].[YemBitkileri]  inner join Urun on YemBitkileri.UrunId=Urun.Id  inner join Cks on Cks.Id=YemBitkileri.CksId  inner join Ciftciler on cks.CiftciId=Ciftciler.Id",connect);
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

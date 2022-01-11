using System.Collections.Generic;
using System.IO;
using Yesilyurt_Ciftci_Kayit.Entities;

namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public static class RequiredLists
    {
        public static List<string> VillageNameList()
        {
            var initiliazeList = new List<string> { "BAHÇEBAŞI", "KARACAÖREN", "GOP", "MERKEZ", "SEKÜCEK", "ÇIKRIK", "ÇERKEZDANİŞMENT", "DAMLALI", "BÜĞET", "ŞEHİTLER", "ÇIRDAK", "KUŞÇU", "KAVUNLUK", "DOĞLACIK", "YAĞMUR", "EKİNLİ", "YENİKÖY", "GÜNDOĞAN", "SİVRİ", "KARAGÖZGÖLLÜALAN", "KARAOLUK", "YÜZÜNCÜYIL", "EVRENPAŞA" };
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = currentDirectory + @"\Villages.txt";
            if (File.Exists(path))
            {
                var result = File.ReadLines(path);
                List<string> villageList = new List<string>();
                foreach (string name in result)
                {
                    villageList.Add(name);
                }
                villageList.Sort();
                return villageList;
            }
            else
            {
                FileStream fs = File.Create(path);
                fs.Close();
                var writer = new StreamWriter(path);
                foreach (var VARIABLE in initiliazeList)
                {
                    writer.WriteLine(VARIABLE);
                }
                writer.Close();
                initiliazeList.Sort();
                return initiliazeList;
            }
        }
        public static List<string> ProductList()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = currentDirectory + @"\products.txt";
            var initiliazeList = new List<string> { "ARPA", "BUĞDAY", "YULAF", "TRİTİKALE", "PATATES", "S.MISIR", "YONCA", "KORUNGA" };
            if (File.Exists(path))
            {
                var result = File.ReadLines(path);
                List<string> products = new List<string>();
                foreach (string productName in result)
                {
                    products.Add(productName);
                }
                return products;
            }
            else
            {
                File.Create(path).Close();
                var writer = new StreamWriter(path);
                foreach (var itemProduct in initiliazeList)
                {
                    writer.WriteLine(itemProduct);
                }
                writer.Close();
                return initiliazeList;
            }
        }
        public static List<Firma> CompanyList()
        {
            return new List<Firma>();
            //string currentDirectory = Directory.GetCurrentDirectory();
            //string path = currentDirectory + @"\Company.json";
            //if (!File.Exists(path))
            //{
            //    File.Create(path).Close();
            //    return new List<Company>();
            //}
            //else
            //{
            //    string JsonOkunanData = File.ReadAllText(path);
            //    return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Company>>(JsonOkunanData);
            //}
        }
        public static List<string> GenderList()
        {
            return new List<string> { "Erkek", "Kadın" };
        }
        public static List<string> MaritalStatusList()
        {
            return new List<string> { "Evli", "Bekar", "Boşanmış" };
        }
        public static List<string> YearList()
        {
            return new List<string> { "2020", "2021" };
        }
    }
}

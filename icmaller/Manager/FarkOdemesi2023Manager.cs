using icmaller.Database;
using icmaller.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace icmaller.Manager
{
    public class FarkOdemesi2023Manager
    {

       
        private List<EntityFarkOdemesi> Get(string tc)
        {
            try
            {
                List<EntityFarkOdemesi> datas = GetAll();
                var result = from data in datas
                             where data.kimlikNo == tc
                             select data;
                return result.ToList();
            }
            catch (Exception ex)
            {

                throw ex;

            }


        }

        private static List<EntityFarkOdemesi> GetAll()
        {
            // JSON dosyasının yolunu belirtin
            string jsonFilePath = "FarkÖdemesiListe" + ".json";

            // JSON dosyasındaki veriyi okuyun
            string jsonData = File.ReadAllText(jsonFilePath);

            // JSON verisini JArray nesnesine dönüştürme
            JArray jsonArray = JArray.Parse(jsonData);
            List<EntityFarkOdemesi> liste = new List<EntityFarkOdemesi>();
            // JObject üzerinde foreach döngüsü
            foreach (var property in jsonArray)
            {
                EntityFarkOdemesi entity = new EntityFarkOdemesi();
                entity.baba_adi = property["baba_adi"].ToString();
                entity.destege_tabi_alan = Convert.ToDecimal(property["destege_tabi_alan(da)"].ToString());
                entity.destege_tabi_miktar = Convert.ToDecimal(property["destege_tabi_miktar(kg)"].ToString());
                entity.destege_tabi_uretim_miktari = Convert.ToDecimal(property["destege_tabi_uretim_miktari(kg)"].ToString());
                entity.destek_tutari = Convert.ToDecimal(property["destek_tutari(TL)"].ToString());
                entity.dilekce_no = property["dilekce_no"].ToString();

                //gelen string değeri datetime olarak dönüştüremedim. o yüzden bu kısımda doğum tarihi eksik olacak.


                entity.id = Convert.ToInt32(property["id"].ToString());
                entity.il = property["il"].ToString();
                entity.ilce = property["ilce"].ToString();
                entity.isletme_adi = property["isletme_adi"].ToString();
                entity.kimlikNo = property["kimlikNo"].ToString();
                entity.mahalle_koy = property["mahalle_koy"].ToString();
                entity.satis_miktari = Convert.ToDecimal(property["satis_miktari(kg)"].ToString());
                entity.sira_no = Convert.ToInt32(property["sira_no"].ToString());
                entity.urun_grubu = property["urun_grubu"].ToString();



                liste.Add(entity);
            }

            return liste;
        }

        public List<string> Mesaj(string tc)
        {
            var liste = Get(tc);
            if (liste == null || liste.Count == 0)
            {
                List<string> bosListe = new List<string>();
                bosListe.Add("2023 yılı Fark Ödemesi Desteği bulunmamaktadır.");


                return bosListe;
            };
            decimal toplamDestekTutari = 0;
            List<string> urunGrubu = new List<string>();
            foreach (var item in liste)
            {
                urunGrubu.Add("\tÜrün : " + item.urun_grubu);
                urunGrubu.Add("\tSatış Miktarı : " + Convert.ToInt32(item.satis_miktari) + "  (kg)");
                urunGrubu.Add("\tDestek Tutarı : " + item.destek_tutari + " TL");
                toplamDestekTutari += item.destek_tutari;
            }
            string baslik = "2023 Yılı Fark Ödemesi Desteği\n";
            List<string> result = new List<string>();
            result.Add(baslik);


            foreach (var item in urunGrubu)
            {
                result.Add(item);
            }


            result.Add("\n\tToplam Destek Miktarı : " + toplamDestekTutari.ToString());
            return result;
        }
        public decimal FarkOdemesiDestekTutari(string tc)
        {
            var result = Get(tc);
            decimal destekTutari = 0;
            if (result == null) return destekTutari = 0;

            foreach (var item in result)
            {
                destekTutari += item.destek_tutari;
            }
            return destekTutari;
        }
        public List<string> ToplamRapor()
        {
            List<string> result = new List<string>();
            var datas = GetAll();

            string toplamKisi = datas.Count.ToString();
            string toplamDestekMiktari = datas.Sum(x => x.destek_tutari).ToString("#,##0.##");
            result.Add(toplamKisi);
            result.Add(toplamDestekMiktari);
            return result;

        }
    }
}

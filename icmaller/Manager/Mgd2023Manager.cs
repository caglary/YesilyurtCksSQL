using icmaller.Database;
using icmaller.Entities;
using System;
using System.Collections.Generic;

namespace icmaller.Manager
{
    public class Mgd2023Manager
    {
        Mgd2023Dal _dal;
        public Mgd2023Manager()
        {
            _dal=new Database.Mgd2023Dal();
        }    

        private List<EntityMgd> Get(string tc)
        {
            try
            {
           
                var result = _dal.Get(tc);
                List<EntityMgd> kayitlar = new List<EntityMgd>();
                while (result.Read())
                {
                    EntityMgd entityMgd = new EntityMgd();
                    entityMgd.sira_no = Convert.ToInt32(result[1]);
                    entityMgd.il = result[2].ToString();
                    entityMgd.ilce= result[3].ToString();
                    entityMgd.mahalle_koy= result[4].ToString();
                    entityMgd.dilekce_no= result[5].ToString();
                    entityMgd.isletme_adi= result[6].ToString();
                    entityMgd.baba_adi= result[7].ToString();
                    if (DBNull.Value.Equals(result[8]))
                        entityMgd.dogum_tarihi = DateTime.MinValue;
                    else
                        entityMgd.dogum_tarihi = Convert.ToDateTime(result[8]);
                    entityMgd.tc_vergi_no = result[9].ToString();
                    entityMgd.mazot_alani = Convert.ToDecimal(result[10]);
                    entityMgd.mazot_destekleme_tutari=Convert.ToDecimal(result[11]);
                    entityMgd.gubre_alani= Convert.ToDecimal(result[12]);
                    entityMgd.gubre_destekleme_tutari= Convert.ToDecimal(result[13]);
                    entityMgd.toplam_destekleme_tutari= Convert.ToDecimal(result[14]);


                    kayitlar.Add(entityMgd);
                }
                result.Close();
                return kayitlar;
            }
            catch (Exception)
            {

                return null;

            }
            finally
            {
                _dal.BaglantiAyarla();
            }
            
        }
        public List<string> Mesaj(string tc)
        {
            var liste = Get(tc);
            if (liste == null || liste.Count == 0)
            {
                List<string> bosListe = new List<string>();
                bosListe.Add("2023 yılı MGD Desteği bulunmamaktadır.");
               

                return bosListe;
            };
          
           
            string baslik = "2023 Yılı Mazot ve Gübre Desteği\n";
            List<string> result = new List<string>();
            result.Add(baslik);
           
            result.Add("\t2023 Yılı Dilekçe No: "+liste[0].dilekce_no);
            result.Add("\tMahalle - Köy : " + liste[0].mahalle_koy);
            result.Add("\tAdı Soyadı: " + liste[0].isletme_adi);
            result.Add("\tBaba Adı: " + liste[0].baba_adi);
            result.Add("\tDoğum Tarihi: " + liste[0].dogum_tarihi);
            result.Add("\tToplama Alan : " + liste[0].mazot_alani+" (da)");
            result.Add("\tToplam Destek Miktarı : " + liste[0].toplam_destekleme_tutari+" (TL)");

            return result;
        }
        public decimal MgdDestekTutari(string tc)
        {
            var result=Get(tc);
            
            decimal destekTutari = 0;
            if (result == null) return destekTutari = 0;
            foreach (var item in result)
            {
                destekTutari += item.toplam_destekleme_tutari;
            }
            return destekTutari;
        }
        public List<string> ToplamRapor()
        {
          
            List<string> result = new List<string>();
             string toplamKisi=_dal.ToplamKayitSayisi().ToString();
             string toplamDestekMiktari=_dal.ToplamDestekTutari().ToString("#,##0.##");
            result.Add(toplamKisi);
            result.Add(toplamDestekMiktari);
            return result;
            
        }


    }
}

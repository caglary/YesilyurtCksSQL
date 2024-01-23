using icmaller.Database;
using icmaller.Entities;
using System.Collections.Generic;
using System;

namespace icmaller.Manager
{
    public class YemBitkileri2023Manager
    {
        YemBitkileri2023Dal _dal;
        public YemBitkileri2023Manager()
        {
            _dal=new YemBitkileri2023Dal();
        }
        private List<EntityYemBitkileri> Get(string tc)
        {
            try
            {
 
                var result = _dal.Get(tc);
                List<EntityYemBitkileri> kayitlar = new List<EntityYemBitkileri>();
                while (result.Read())
                {
                    EntityYemBitkileri yemBitkileri = new EntityYemBitkileri();
                    yemBitkileri.sira_no = Convert.ToInt32(result[1]);
                    yemBitkileri.kimlikNo = result[2].ToString();
                    yemBitkileri.dilekce_no = result[3].ToString();
                    yemBitkileri.mahalle_koy= result[4].ToString();
                    yemBitkileri.isletme_adi = result[5].ToString();
                    yemBitkileri.baba_adi = result[6].ToString();
                   
                    if (DBNull.Value.Equals(result[7]))
                        yemBitkileri.dogum_tarihi = DateTime.MinValue;
                    else
                        yemBitkileri.dogum_tarihi= Convert.ToDateTime(result[7]);
                    yemBitkileri.yonca_kuru = Convert.ToDecimal(result[8]);
                    yemBitkileri.yonca_sulu = Convert.ToDecimal(result[9]);
                    yemBitkileri.korunga= Convert.ToDecimal(result[10]);
                    yemBitkileri.fig= Convert.ToDecimal(result[11]);
                    yemBitkileri.hububat_grubu= Convert.ToDecimal(result[12]);
                    yemBitkileri.diger_cok_yillik= Convert.ToDecimal(result[13]);
                    yemBitkileri.diger_tek_yillik = Convert.ToDecimal(result[14]);
                    yemBitkileri.diger_silajlik_kuru = Convert.ToDecimal(result[15]);
                    yemBitkileri.diger_silajlik_sulu= Convert.ToDecimal(result[16]);
                    yemBitkileri.silajlik_misir_kuru= Convert.ToDecimal(result[17]);
                    yemBitkileri.silajlik_misir_sulu= Convert.ToDecimal(result[18]);
                    yemBitkileri.yapay_cayit_mera= Convert.ToDecimal(result[19]);
                    yemBitkileri.su_kisiti_olan_havzalar= Convert.ToDecimal(result[20]);
                    yemBitkileri.desteğe_tabi_alan = Convert.ToDecimal(result[21]);
                    yemBitkileri.destek_tutari = Convert.ToDecimal(result[22]);



                    kayitlar.Add(yemBitkileri);
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
                bosListe.Add("2023 yılı Yem Bitkileri Desteği bulunmamaktadır.");
               

                return bosListe;
            };
            decimal toplamDestekTutari = 0;
            List<string> urunGrubu = new List<string>();
            foreach (var item in liste)
            {
                if (item.yonca_kuru != 0) urunGrubu.Add("\nYonca (Kuru) : " + item.yonca_kuru);
                if (item.yonca_sulu != 0) urunGrubu.Add("\nYonca (Sulu) : " + item.yonca_sulu);
                if (item.korunga != 0) urunGrubu.Add("\nKorunga : " + item.korunga);
                if (item.fig != 0) urunGrubu.Add("\nFiğ : " + item.fig);
                if (item.hububat_grubu != 0) urunGrubu.Add("\nHububat (Yulaf) : " + item.hububat_grubu);
                if (item.diger_cok_yillik != 0) urunGrubu.Add("\nDiğer çok yıllık : " + item.diger_cok_yillik);
                if (item.diger_tek_yillik != 0) urunGrubu.Add("\nDiğer tek yıllık : " + item.diger_tek_yillik);
                if (item.diger_silajlik_kuru != 0) urunGrubu.Add("\nDiğer silajlık kuru : " + item.diger_silajlik_kuru);
                if (item.diger_silajlik_sulu != 0) urunGrubu.Add("\nDiğer silajlık sulu : " + item.diger_silajlik_sulu);
                if (item.diger_silajlik_kuru != 0) urunGrubu.Add("\nSilajlık mısır kuru : " + item.diger_silajlik_kuru);
                if (item.diger_silajlik_sulu != 0) urunGrubu.Add("\nSilajlık mısır sulu : " + item.diger_silajlik_sulu);

                if (item.yapay_cayit_mera != 0) urunGrubu.Add("\nYapay çayır mera: " + item.yapay_cayit_mera);
                if (item.su_kisiti_olan_havzalar != 0) urunGrubu.Add("\nSu kısıtı olan havzalar: " + item.su_kisiti_olan_havzalar);

                urunGrubu.Add("\nToplam Alan : " + item.desteğe_tabi_alan);
                urunGrubu.Add("\nDestek Tutarı : " + item.destek_tutari);

            }
            string baslik = "2023 Yılı Yem Bitkisi Desteği\n";
            List<string> result = new List<string>();

            result.Add(baslik);
         
            foreach (var item in urunGrubu)
            {
                result.Add(item);
            }
            
            
            
            return result;
        }

        public decimal YemBitkileriDestekTutari(string tc)
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
            string toplamKisi = _dal.ToplamKayitSayisi().ToString();
            string toplamDestekMiktari = _dal.ToplamDestekTutari().ToString("#,##0.##");
            result.Add(toplamKisi);
            result.Add(toplamDestekMiktari);
            return result;

        }
    }
}

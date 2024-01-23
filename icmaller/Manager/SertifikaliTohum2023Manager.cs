using icmaller.Database;
using icmaller.Entities;
using System.Collections.Generic;
using System;

namespace icmaller.Manager
{
    public class SertifikaliTohum2023Manager
    {
        SertifikaliTohum2023Dal _dal;
        public SertifikaliTohum2023Manager()
        {
            _dal=new SertifikaliTohum2023Dal();
        }
        public List<EntitySertifikaliTohum> Get(string tc)
        {
            try
            {

                var result = _dal.Get(tc);
                List<EntitySertifikaliTohum> kayitlar = new List<EntitySertifikaliTohum>();
                while (result.Read())
                {
                    EntitySertifikaliTohum sertifikaliTohum = new EntitySertifikaliTohum();
                    sertifikaliTohum.sira_no = Convert.ToInt32(result[1]);
                    sertifikaliTohum.il = result[2].ToString();
                    sertifikaliTohum.ilce = result[3].ToString();
                    sertifikaliTohum.mahalle_koy = result[4].ToString();
                    sertifikaliTohum.isletmeNo= result[5].ToString();
                    sertifikaliTohum.dilekce_no = result[6].ToString();
                    sertifikaliTohum.baba_adi = result[7].ToString();
                    if (DBNull.Value.Equals(result[8]))
                        sertifikaliTohum.dogum_tarihi = DateTime.MinValue;
                    else
                        sertifikaliTohum.dogum_tarihi = Convert.ToDateTime(result[8]);
                    sertifikaliTohum.tur= result[9].ToString();
                    sertifikaliTohum.fatura_miktari = Convert.ToDecimal(result[10]);    
                    sertifikaliTohum.destekleme_alani= Convert.ToDecimal(result[11]);
                    sertifikaliTohum.destekleme_miktari= Convert.ToDecimal(result[12]);


                    kayitlar.Add(sertifikaliTohum);
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
                bosListe.Add("2023 yılı Sertifikalı Tohum Desteği bulunmamaktadır.");
           

                return bosListe;
            };

            List<string> urunGrubu = new List<string>();
            decimal toplamDestekTutari = 0;
            foreach (var item in liste)
            {
                urunGrubu.Add("Ürün : " + item.tur);
                urunGrubu.Add("Fatura Miktarı : " + Convert.ToInt32(item.fatura_miktari) + "  (kg))");
                urunGrubu.Add("Destek Tutarı : " + item.destekleme_miktari + " TL");
                toplamDestekTutari += item.destekleme_miktari;
            }
            string baslik = "2023 Yılı Sertifikalı Tohum Desteği\n";
          
            List<string> result = new List<string>();
            result.Add(baslik);
            

            foreach (var item in urunGrubu)
            {
                result.Add(item);
            }


            result.Add("\nTOPLAM DESTEK : " + toplamDestekTutari.ToString());
            return result;
        }
        public decimal SertifikaliTohumDestekTutari(string tc)
        {
            var result = Get(tc);
            decimal destekTutari = 0;
            if (result == null) return destekTutari = 0;

            foreach (var item in result)
            {
                destekTutari += item.destekleme_miktari;
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

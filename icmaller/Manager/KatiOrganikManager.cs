using icmaller.Database;
using icmaller.Entities;
using System.Collections.Generic;
using System;

namespace icmaller.Manager
{
    public class KatiOrganikManager
    {


        KatiOrganik2023Dal _dal;
        public KatiOrganikManager()
        {
            _dal = new KatiOrganik2023Dal();
        }
        public List<EntityKatiOrganik> Get(string tc)
        {




            try
            {

                var result = _dal.Get(tc);
                List<EntityKatiOrganik> kayitlar = new List<EntityKatiOrganik>();

                while (result.Read())
                {

                    kayitlar.Add(new EntityKatiOrganik
                    {
                        Sira_no = result.IsDBNull(1) ? 0 : result.GetInt32(1),
                        Il = result.IsDBNull(2) ? "" : result.GetString(2),
                        Ilce = result.IsDBNull(3) ? "" : result.GetString(3),
                        Mahalle_koy = result.IsDBNull(4) ? "" : result.GetString(4),
                        Dilekce_no = result.IsDBNull(5) ? "" : result.GetString(5),
                        Isletme_adi = result.IsDBNull(6) ? "" : result.GetString(6),
                        Baba_adi = result.IsDBNull(7) ? "" : result.GetString(7),
                        Dogum_tarihi = result.IsDBNull(8) ? DateTime.MinValue : result.GetDateTime(8),
                        KimlikNo = result.IsDBNull(9) ? "" : result.GetString(9),
                        KatiOrganikUrun = result.IsDBNull(10) ? 0 : result.GetDecimal(10),
                        KatiOrganikToprakDüzenleyici = result.IsDBNull(11) ? 0 : result.GetDecimal(11),
                        KatiOrganomineralUrun = result.IsDBNull(12) ? 0 : result.GetDecimal(12),
                        KaplamaGubre = result.IsDBNull(13) ? 0 : result.GetDecimal(13),
                        OrganikGubre = result.IsDBNull(14) ? 0 : result.GetDecimal(14),
                        DesteklenenAlan = result.IsDBNull(15) ? 0 : result.GetDecimal(15),
                        DesteklemeMiktari = result.IsDBNull(16) ? 0 : result.GetDecimal(16),



                    });

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
                bosListe.Add("2023 yılı Katı Organik-Organomineral Gübre Desteği bulunmamaktadır.");


                return bosListe;
            };

            List<string> urunGrubu = new List<string>();
            decimal toplamDestekTutari = 0;
            foreach (var item in liste)
            {
                urunGrubu.Add("Ürün : " + item.KatiOrganomineralUrun);
                urunGrubu.Add("Desteklenen Alan : " + item.DesteklenenAlan + "  (da))");
                urunGrubu.Add("Destek Tutarı : " + item.DesteklemeMiktari + " TL");
                toplamDestekTutari += item.DesteklemeMiktari;
            }
            string baslik = "2023 Yılı Katı Organik-Organomineral Gübre Desteği\n";

            List<string> result = new List<string>();
            result.Add(baslik);


            foreach (var item in urunGrubu)
            {
                result.Add(item);
            }


            result.Add("\nTOPLAM DESTEK : " + toplamDestekTutari.ToString());
            return result;
        }
        public decimal KatiOrganikDestekTutari(string tc)
        {
            var destekTutari = _dal.DestekTutari(tc);
            if (string.IsNullOrEmpty(destekTutari)) { return 0; }
            return Convert.ToDecimal(destekTutari);
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

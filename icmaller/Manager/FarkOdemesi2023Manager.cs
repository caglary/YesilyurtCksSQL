using icmaller.Database;
using icmaller.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace icmaller.Manager
{
    public class FarkOdemesi2023Manager
    {

        FarkOdemesi2023Dal _dal;
        public FarkOdemesi2023Manager()
        {
            _dal=new FarkOdemesi2023Dal();
        }

        private List<EntityFarkOdemesi> Get(string tc)
        {
            try
            {
               var result=_dal.Get(tc);
                List<EntityFarkOdemesi> kayitlar = new List<EntityFarkOdemesi>();
                while (result.Read())
                {
                    EntityFarkOdemesi entity=new EntityFarkOdemesi();
                    entity.sira_no = Convert.ToInt32(result[1]);
                    entity.il = result[2].ToString();
                    entity.ilce = result[3].ToString();
                    entity.mahalle_koy = result[4].ToString();
                    entity.isletme_adi = result[5].ToString();
                    entity.baba_adi = result[6].ToString();
                    if (DBNull.Value.Equals(result[7]))
                        entity.dogum_tarihi = DateTime.MinValue;
                    else
                        entity.dogum_tarihi = Convert.ToDateTime(result[7]);
                    entity.kimlikNo = result[8].ToString();
                    entity.dilekce_no = result[9].ToString();
                    entity.urun_grubu = result[10].ToString();
                    entity.destege_tabi_alan = Convert.ToDecimal(result[11]);
                    entity.destege_tabi_uretim_miktari = Convert.ToDecimal(result[12]);
                    entity.satis_miktari = Convert.ToDecimal(result[13]);
                    entity.destege_tabi_miktar = Convert.ToDecimal(result[14]);
                    entity.destek_tutari = Convert.ToDecimal(result[15]);
                    kayitlar.Add(entity);
                }
                result.Close();
                return kayitlar;
            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {
                _dal.BaglantiAyarla();
            }

        }

        public  List<EntityFarkOdemesi> GetAll()
        {
            try
            {
                var result = _dal.GetAll();
                List<EntityFarkOdemesi> kayitlar = new List<EntityFarkOdemesi>();
                while (result.Read())
                {
                    EntityFarkOdemesi entity = new EntityFarkOdemesi();
                    entity.sira_no = Convert.ToInt32(result[1]);
                    entity.il = result[2].ToString();
                    entity.ilce = result[3].ToString();
                    entity.mahalle_koy = result[4].ToString();
                    entity.isletme_adi = result[5].ToString();
                    entity.baba_adi = result[6].ToString();
                    if (DBNull.Value.Equals(result[7]))
                        entity.dogum_tarihi = DateTime.MinValue;
                    else
                        entity.dogum_tarihi = Convert.ToDateTime(result[7]);
                    entity.kimlikNo = result[8].ToString();
                    entity.dilekce_no = result[9].ToString();
                    entity.urun_grubu = result[10].ToString();
                    entity.destege_tabi_alan = Convert.ToDecimal(result[11]);
                    entity.destege_tabi_uretim_miktari = Convert.ToDecimal(result[12]);
                    entity.satis_miktari = Convert.ToDecimal(result[13]);
                    entity.destege_tabi_miktar = Convert.ToDecimal(result[14]);
                    entity.destek_tutari = Convert.ToDecimal(result[15]);
                    kayitlar.Add(entity);
                }
                result.Close();
                return kayitlar;
            }
            catch (Exception ex)
            {

                throw ex;

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

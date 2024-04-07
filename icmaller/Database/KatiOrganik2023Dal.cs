using System;
using System.Data.SqlClient;

namespace icmaller.Database
{
    public class KatiOrganik2023Dal: BaseDal
    {
        public SqlDataReader Get(string tc)
        {
            //aranan tc bilgilerini listeden getirir.
            command = new SqlCommand("select * from icmal_kati_organik_organomineral_gubre_odemesi_2023 where kimlikNo=@tc", connect);
            command.Parameters.Add("@tc", System.Data.SqlDbType.NVarChar).Value = tc;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int ToplamKayitSayisi()
        {
            //Listedeki kayıt sayısını döndürür.
            try
            {
                command = new SqlCommand("select  count(*) from icmal_kati_organik_organomineral_gubre_odemesi_2023 ", connect);
                BaglantiAyarla();
                int kayitSayisi = Convert.ToInt32(command.ExecuteScalar());
                return kayitSayisi;
            }
            catch (Exception ex)
            {

                //throw ex;
            }
            finally
            {
                BaglantiAyarla();
            }

        }
        public decimal ToplamDestekTutari()
        {
            //Toplam verilen destekleme miktarını döndürür...
            try
            {
                command = new SqlCommand("select sum([Destekleme Miktarı (TL)]) from icmal_kati_organik_organomineral_gubre_odemesi_2023 ", connect);
                BaglantiAyarla();
                decimal kayitSayisi = Convert.ToDecimal(command.ExecuteScalar());
                return kayitSayisi;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                BaglantiAyarla();
            }

        }
        public string DestekTutari(string tc)
        {
            //tc numarasına ait destekleme tutarını döndürür.
            try
            {
                command = new SqlCommand("select sum([Destekleme Miktarı (TL)]) from icmal_kati_organik_organomineral_gubre_odemesi_2023 where kimlikNo=@tc ", connect);
                command.Parameters.Add("@tc", System.Data.SqlDbType.NVarChar).Value = tc;
                BaglantiAyarla();
                return command.ExecuteScalar().ToString();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                BaglantiAyarla();
            }

        }
    }
}

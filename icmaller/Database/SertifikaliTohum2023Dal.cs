using System;
using System.Data.SqlClient;

namespace icmaller.Database
{
    public class SertifikaliTohum2023Dal:BaseDal
    {
        public SqlDataReader Get(string tc)
        {

            command = new SqlCommand("select * from icmal_sertifikali_tohum_2023 where isletmeNo=@tc", connect);
            command.Parameters.Add("@tc", System.Data.SqlDbType.NVarChar).Value = tc;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int ToplamKayitSayisi()
        {
            try
            {
                command = new SqlCommand("select  count(*) from icmal_sertifikali_tohum_2023 ", connect);
                BaglantiAyarla();
                int kayitSayisi = Convert.ToInt32(command.ExecuteScalar());
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
        public decimal ToplamDestekTutari()
        {
            try
            {
                command = new SqlCommand("select  sum([destekleme_miktari (TL)]) from icmal_sertifikali_tohum_2023 ", connect);
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

    }
}

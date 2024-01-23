using System;
using System.Data.SqlClient;

namespace icmaller.Database
{
    public class FarkOdemesi2023Dal:BaseDal
    {
        public SqlDataReader Get(string tc)
        {

            command = new SqlCommand("select * from icmal_fark_odemesi_2023 where kimlikNo=@tc", connect);
            command.Parameters.Add("@tc", System.Data.SqlDbType.NVarChar).Value = tc;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int ToplamKayitSayisi()
        {
            try
            {
                command = new SqlCommand("select count(*)  from icmal_fark_odemesi_2023 ", connect);
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
                command = new SqlCommand("select sum([destek_tutari(TL)])  from icmal_fark_odemesi_2023 ", connect);
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

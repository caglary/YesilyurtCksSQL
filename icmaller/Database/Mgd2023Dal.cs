using System;
using System.Data.SqlClient;

namespace icmaller.Database
{
    public class Mgd2023Dal : BaseDal
    {
        public SqlDataReader Get(string tc)
        {

            command = new SqlCommand("select * from icmal_mgd_2023 where tc_vergi_no=@tc", connect);
            command.Parameters.Add("@tc", System.Data.SqlDbType.NVarChar).Value = tc;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int ToplamKayitSayisi()
        {
            try
            {
                command = new SqlCommand("select count(*) from icmal_mgd_2023 ", connect);
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
                command = new SqlCommand("select sum([toplam_destekleme_tutari (TL)]) from icmal_mgd_2023 ", connect);
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

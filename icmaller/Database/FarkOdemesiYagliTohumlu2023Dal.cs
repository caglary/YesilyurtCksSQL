using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icmaller.Database
{
    public class FarkOdemesiYagliTohumlu2023Dal:BaseDal
    {
        public SqlDataReader Get(string tc)
        {

            command = new SqlCommand("select * from [icmal_fark_odemesi_yagli_tohumlu_2023] where kimlikNo=@tc", connect);
            command.Parameters.Add("@tc", System.Data.SqlDbType.NVarChar).Value = tc;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public SqlDataReader GetAll()
        {

            command = new SqlCommand("select * from [icmal_fark_odemesi_yagli_tohumlu_2023] ", connect);

            BaglantiAyarla();
            return command.ExecuteReader();
        }
        public int ToplamKayitSayisi()
        {
            try
            {
                command = new SqlCommand("SELECT kimlikNo FROM [YesilyurtDb2024].[dbo].[icmal_fark_odemesi_yagli_tohumlu_2023] group by kimlikNo", connect);
                BaglantiAyarla();
                var result = command.ExecuteReader();
                List<String> list = new List<String>();
                while (result.Read())
                {
                    list.Add(result[0].ToString());
                }
                return list.Count;
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
                command = new SqlCommand("select sum([destek_tutari(TL)])  from [icmal_fark_odemesi_yagli_tohumlu_2023] ", connect);
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

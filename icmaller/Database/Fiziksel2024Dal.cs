using System.Data.SqlClient;

namespace icmaller.Database
{
    public class Fiziksel2024Dal:BaseDal
    {
        public SqlDataReader Get(string tc)
        {

            command = new SqlCommand("select * from cks_2024_fiziksel where tc_kimlik_no=@tc", connect);
            command.Parameters.Add("@tc", System.Data.SqlDbType.NVarChar).Value = tc;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
    }
}

using System.Data.SqlClient;

namespace icmaller.Database
{
    public class Edevlet2024Dal:BaseDal
    {
        public SqlDataReader Get(string tc)
        {

            command = new SqlCommand("select * from cks_2024_e_devlet where tc_kimlik_no=@tc", connect);
            command.Parameters.Add("@tc", System.Data.SqlDbType.NVarChar).Value = tc;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
    }
}

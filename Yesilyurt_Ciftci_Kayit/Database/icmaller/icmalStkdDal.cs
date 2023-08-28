using System.Data;
using System.Data.SqlClient;

namespace Yesilyurt_Ciftci_Kayit.Database.icmaller
{
    public class icmalStkdDal : BaseDal
    {
        public SqlDataReader GetAll(string kimlikNo)
        {
            command = new SqlCommand("select * from [YesilyurtDb2023].[dbo].[icmal_stkd_2023] where [İşletme No]=@kimlikNo ", connect);
            command.Parameters.Add("@kimlikNo", SqlDbType.NVarChar).Value = kimlikNo;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

    }
}

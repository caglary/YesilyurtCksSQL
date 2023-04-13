using System.Data;
using System.Data.SqlClient;

namespace Yesilyurt_Ciftci_Kayit.Database.icmaller
{
    public class icmalStkdDal : BaseDal
    {
        public SqlDataReader GetAll(string kimlikNo)
        {
            command = new SqlCommand("select * from icmal_stkd where kimlikNo=@kimlikNo ", connect);
            command.Parameters.Add("@kimlikNo", SqlDbType.NVarChar).Value = kimlikNo;
            BaglantiAyarla();
            return command.ExecuteReader();
        }

    }
}

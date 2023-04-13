using System.Data.SqlClient;
using System.Data;

namespace Yesilyurt_Ciftci_Kayit.Database.icmaller
{
    public class icmalMgdDal : BaseDal
    {
        public SqlDataReader GetAll(string kimlikNo)
        {
            command = new SqlCommand("select * from icmal_mgd where kimlikNo=@kimlikNo ", connect);
            command.Parameters.Add("@kimlikNo", SqlDbType.NVarChar).Value = kimlikNo;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
    }
}

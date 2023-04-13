using System.Data.SqlClient;
using System.Data;

namespace Yesilyurt_Ciftci_Kayit.Database.icmaller
{
    public class icmalKoogDal : BaseDal
    {
        public SqlDataReader GetAll(string kimlikNo)
        {
            command = new SqlCommand("select * from icmal_KOOG where kimlikNo=@kimlikNo ", connect);
            command.Parameters.Add("@kimlikNo", SqlDbType.NVarChar).Value = kimlikNo;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
    }
}

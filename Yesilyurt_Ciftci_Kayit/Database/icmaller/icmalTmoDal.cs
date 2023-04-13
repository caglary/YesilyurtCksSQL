using System.Data;
using System.Data.SqlClient;

namespace Yesilyurt_Ciftci_Kayit.Database.icmaller
{
    public class icmalTmoDal : BaseDal
    {
        public SqlDataReader GetAll(string kimlikNo)
        {
            command = new SqlCommand("select * from icmal_tmo where kimlikNo=@kimlikNo ", connect);
            command.Parameters.Add("@kimlikNo", SqlDbType.NVarChar).Value = kimlikNo;
            BaglantiAyarla();
            return command.ExecuteReader();
        }
    }
}

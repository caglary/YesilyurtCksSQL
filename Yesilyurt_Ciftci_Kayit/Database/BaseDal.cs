using System.Data.SqlClient;

namespace Yesilyurt_Ciftci_Kayit.Database
{
    public class BaseDal
    {
        public SqlConnection connect;
        public SqlCommand command;
        public SqlDataReader reader;
        public int result;
        public BaseDal()
        {
            connect = new SqlConnection();
            connect.ConnectionString = Utilities.ConnectionString.Get();


        }
        public void BaglantiAyarla()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
            else
                connect.Close();
        }
      
    }
}

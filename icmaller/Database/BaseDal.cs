using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace icmaller.Database
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
            connect.ConnectionString = ConnectionString.Get();
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

using System;

namespace icmaller.Database

{
    public static class ConnectionString
    {
        public static string year = "2024";
        public static string Get()
        {
            string connectionString = "";
            string machineName = Environment.MachineName;

            string Lenovo2024 = @"Server=M601102-0009;Database=YesilyurtDb2024;User Id=sa;Password=Password.123;";


            string Work2024 = @"Server=M601102-0009;Database=YesilyurtDb2024;User Id=sa;Password=Password.123;";


            string Year = year;


            if (machineName == "M601102-0009")
            {
                connectionString = Lenovo2024;
             
            }
            else
            {
                connectionString = Work2024;

            }



            return connectionString;
        }
        public static string TeachYearFromFile()
        {
           
            string whichYear = year;
            return year;
    }
    }
}

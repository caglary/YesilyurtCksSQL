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

            string Lenovo2024 = @"Server=DESKTOP-JLF6L6G\SQLEXPRESS;Database=YesilyurtDb2024;Trusted_Connection=True;";


            string Work2024 = @"data source=M601102-0003\SQLEXPRESS; Initial Catalog=YesilyurtDb2024;Trusted_Connection=True;";


            string Year = year;


            if (machineName == "DESKTOP-JLF6L6G")
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

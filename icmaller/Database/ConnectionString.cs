﻿using System;

namespace icmaller.Database

{
    public static class ConnectionString
    {
        public static string year = "2024";
        public static string Get()
        {
            string connectionString = "";
            string machineName = Environment.MachineName;

            string Lenovo2024 = @"Server=localhost\SQLEXPRESS;Database=YesilyurtDb2024;Trusted_Connection=True;";


            string Work2024 = @"data source=M601102-0042\SQLEXPRESS; Initial Catalog=YesilyurtDb2024;User Id=sa;Password=caglar.123;Trusted_Connection=True;";


            string Year = year;


            if (machineName == "DESKTOP-ITQCLKI")
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

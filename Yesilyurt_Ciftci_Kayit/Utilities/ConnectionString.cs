using System;

namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public static class ConnectionString
    {
        public static string year = "";
        public static string Get()
        {
            string connectionString = "";
            string machineName = Environment.MachineName;
            string Lenovo2022 = @"Server=localhost\SQLEXPRESS;Database=YesilyurtDb2022;Trusted_Connection=True;";
            string Lenovo2021 = @"Server=localhost\SQLEXPRESS;Database=YesilyurtDb2021;Trusted_Connection=True;";
            string Lenovo2023 = @"Server=localhost\SQLEXPRESS;Database=YesilyurtDb2023;Trusted_Connection=True;";
            string Lenovo2024 = @"Server=localhost\SQLEXPRESS;Database=YesilyurtDb2024;Trusted_Connection=True;";


            string Work2022 = @"data source=M601102-0042\SQLEXPRESS; Initial Catalog=YesilyurtDb2022;User Id=sa;Password=caglar.123;Trusted_Connection=True;";
            string Work2021 = @"data source=M601102-0042\SQLEXPRESS; Initial Catalog=YesilyurtDb2021;User Id=sa;Password=caglar.123;Trusted_Connection=True;";
            string Work2023 = @"data source=M601102-0042\SQLEXPRESS; Initial Catalog=YesilyurtDb2023;User Id=sa;Password=caglar.123;Trusted_Connection=True;";
            string Work2024 = @"data source=M601102-0042\SQLEXPRESS; Initial Catalog=YesilyurtDb2024;User Id=sa;Password=caglar.123;Trusted_Connection=True;";


            string Year = year;


            if (machineName == "DESKTOP-ITQCLKI")
            {
                switch (Year)
                {
                    case "2021":
                        connectionString = Lenovo2021;
                        break;
                    case "2022":
                        connectionString = Lenovo2022;
                        break;
                    case "2023":
                        connectionString = Lenovo2023;
                        break;
                    case "2024":
                        connectionString = Lenovo2024;
                        break;
                    default:
                        connectionString = Lenovo2023;
                        break;
                }
             
            }
            else
            {
                switch (Year)
                {
                    case "2021":
                        connectionString = Work2021;
                        break;
                    case "2022":
                        connectionString = Work2022;
                        break;
                    case "2023":
                        connectionString = Work2023;
                        break;
                    case "2024":
                        connectionString = Work2024;
                        break;
                    default:
                        connectionString = Work2023;
                        break;
                }
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

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
            string Lenovo2022 = @"Server=M601102-0009;Database=YesilyurtDb2022;User Id=sa;Password=Password.123;";
            string Lenovo2021 = @"Server=M601102-0009;Database=YesilyurtDb2021;User Id=sa;Password=Password.123;";
            string Lenovo2023 = @"Server=M601102-0009;Database=YesilyurtDb2023;User Id=sa;Password=Password.123;";
            string Lenovo2024 = @"Server=M601102-0009;Database=YesilyurtDb2024;User Id=sa;Password=Password.123;";


            string Work2022 = @"Server=M601102-0012;Database=YesilyurtDb2022;User Id=sa;Password=Password.123;";
            string Work2021 = @"Server=M601102-0012;Database=YesilyurtDb2021;User Id=sa;Password=Password.123;";
            string Work2023 = @"Server=M601102-0012;Database=YesilyurtDb2023;User Id=sa;Password=Password.123;";
            string Work2024 = @"Server=M601102-0012;Database=YesilyurtDb2024;User Id=sa;Password=Password.123;";


            string Year = year;


            if (machineName == "M601102-0009")
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

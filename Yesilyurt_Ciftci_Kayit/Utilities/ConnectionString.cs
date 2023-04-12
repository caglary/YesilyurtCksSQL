using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public static class ConnectionString
    {
        public static string year = "";
        public static string Get()
        {
            string machineName = Environment.MachineName;
            string Lenovo2022 = @"Server=localhost\SQLEXPRESS;Database=YesilyurtDb2022;Trusted_Connection=True;";
            string Lenovo2021 = @"Server=localhost\SQLEXPRESS;Database=YesilyurtDb2021;Trusted_Connection=True;";
            string Lenovo2023 = @"Server=localhost\SQLEXPRESS;Database=YesilyurtDb2023;Trusted_Connection=True;";
            string Work2022 = @"data source=M601102-0042\SQLEXPRESS; Initial Catalog=YesilyurtDb2022;User Id=sa;Password=caglar.123;Trusted_Connection=True;";
            string Work2021 = @"data source=M601102-0042\SQLEXPRESS; Initial Catalog=YesilyurtDb2021;User Id=sa;Password=caglar.123;Trusted_Connection=True;";
            string Work2023 = @"data source=M601102-0042\SQLEXPRESS; Initial Catalog=YesilyurtDb2023;User Id=sa;Password=caglar.123;Trusted_Connection=True;";
            string Year = year;

            if (machineName == "DESKTOP-ITQCLKI")
            {
                //Lenovo
                if (Year == "2021")
                {
                    return Lenovo2021;
                }
                else if (Year == "2023")
                {
                    return Lenovo2023;
                }
                else
                {
                    return Lenovo2022;
                }
            }
        
            if (Year == "2021")
            {
                return Work2021;
            }
            else if (Year == "2023")
            {
                return Work2023;
            }
            else
            {
                return Work2022;
            }
        }
        public static string TeachYearFromFile()
        {
           
            string whichYear = year;
            return year;
    }
    }
}

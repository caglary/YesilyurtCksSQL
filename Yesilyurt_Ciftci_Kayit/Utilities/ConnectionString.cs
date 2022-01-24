﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public static class ConnectionString
    {
        public static string Get()
        {
            string machineName = Environment.MachineName;

            string Lenovo2022 = @"data source=DESKTOP-HF3B47B\SQLEXPRESS; Initial Catalog=YesilyurtDb2022; Integrated security=true";
            string Lenovo2021 = @"data source=DESKTOP-HF3B47B\SQLEXPRESS; Initial Catalog=YesilyurtDb2021; Integrated security=true";

            string Work2022 = @"data source=M601102-0043; Initial Catalog=YesilyurtDb2022;User Id=sa;Password=caglar.123;Trusted_Connection=True;";
            string Work2021 = @"data source=M601102-0043; Initial Catalog=YesilyurtDb2021;User Id=sa;Password=caglar.123;Trusted_Connection=True;";

      
            string Year = TeachYearFromFile();

            if (machineName == "DESKTOP-HF3B47B")
            {
                //Lenovo
                if (Year == "2021")
                {
                    return Lenovo2021;
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
            else
            {
                return Work2022;
            }


        }

        public static string TeachYearFromFile()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = currentDirectory + @"\Year.txt";
            if (File.Exists(path))
            {

                var result = File.ReadLines(path);
                List<string> satirlar = new List<string>();
                foreach (string satir in result)
                {
                    satirlar.Add(satir);
                }

                return satirlar[0];

            }
            else
            {
                FileStream fs = File.Create(path);
                fs.Close();
                var writer = new StreamWriter(path);
                writer.Write("2022");
                writer.Close();
                var result = File.ReadLines(path);
                List<string> satirlar = new List<string>();
                foreach (string satir in result)
                {
                    satirlar.Add(satir);
                }

                return satirlar[0];
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesilyurt_Ciftci_Kayit.Database;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Environment.MachineName);
            Console.Read();
           
        }
    }
    class ekayit
    {
        public int id { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string tc { get; set; }
        public string tarih { get; set; }
    }
}

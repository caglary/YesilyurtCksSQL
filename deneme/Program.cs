using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sonuc=hesapla(1,2,3,23);
            Console.WriteLine(sonuc);
            Console.ReadLine();


        }

        static double hesapla(params double[] x)
        {
            double total = 0;
            foreach (var item in x)
            {
                total += item;
            }
            double sonuc=total/x.Length;
            return sonuc;
        }
    }
}

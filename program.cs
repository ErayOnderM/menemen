using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nNİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vize;
            double final;
            double not;

            vize = 0;
            final = 0;

            Console.WriteLine("Lütfen vize değerinizi giriniz");
            vize = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            Console.WriteLine("Lütfen final değerinizi giriniz");
            final = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            not = (vize * 0.4) + (final * 0.6);


            
            Console.Clear();

            if (not >= 65)
            {
                Console.WriteLine("Geçtin");
            }
            else
            {
                Console.WriteLine("KALDIN");
            }

            Console.ReadKey();

        }
    }
}


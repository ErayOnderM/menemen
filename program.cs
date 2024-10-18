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




             Random random = new Random();

 int sayi1, sayi2, sonuc, giris;

 sayi1 = random.Next(0, 101);
 sayi2 = random.Next(0, 101);

 sonuc = sayi1 + sayi2;

 Console.WriteLine($"s1={sayi1}, s2={sayi2}");
 giris = Convert.ToInt32( Console.ReadLine() );
 Console.Clear();

 if (sonuc == giris) 
     Console.WriteLine("Bildin");
 else
     Console.WriteLine("Bilemedin");

  Console.ReadKey();




             int sayi1, sayi2;
 sayi1 = Convert.ToInt32(Console.ReadLine());
 sayi2 = Convert.ToInt32(Console.ReadLine());

 if (sayi1 > sayi2)
 {
     Console.WriteLine(sayi1);
 }

 else if (sayi1 < sayi2)
 {
     Console.WriteLine(sayi2);





 }
 else Console.WriteLine("Eşit");

        }
    }
}


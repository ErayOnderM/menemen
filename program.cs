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
/*kullanıcının gireceğ, sayının pozitif veya negatif oldupnu ekrana yazan programı yazınız

int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi == 0)
{
    Console.WriteLine("sayı nötr");
}
else if (sayi > 0)
{
    Console.WriteLine("sayı pozitif");
}
else
{
    Console.WriteLine("sayı negatif");
}

Console.ReadKey();
*/





//kulllanıcının gireceği negatif sayıyı pozitif sayıya çeviren prıgramı yazınız. kullanıcı pozitif girerse bir şey yapılmayacak

/*
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi < 0)
{
    sayi = sayi * (-1);
    Console.WriteLine(sayi);
}
else
{
    Console.WriteLine(sayi);
}
Console.ReadKey();
*/




//geçme notu 65 oolan bir ders için kullanıcıdan vize finalnotlarını alıp ortalmayı hesaplayıp öğrencinin geçtiğini veya kaldığını ekrana yazan programı yazınız
//geçme notu vize notunun yüzde %40ı ile final notunun % 60 ı toplanarak heaplanmaktadır

/*
double vize = Convert.ToInt32(Console.ReadLine());
double final = Convert.ToInt32(Console.ReadLine());
double sayi;

sayi = (vize * (0.4) + final * (0.6));

if (sayi >= 65)
{
    Console.WriteLine("Geçtin");
}
else
{
    Console.WriteLine("Geçemedin");
}

Console.ReadKey();
*/

//kullanıcıdan 1 ile 7 arasında bir sayı isteyip kullanıcının girdiği sayıya göre haftanın hangi günü olduğunu ekrana yazan programı yaz
//1- pazartesi 2- salı 3- çarşamba ... 7- pazar eğer kullanıcı 1-7 dışında sayı girerse yanlış sayı yazdın diye ekrana yazsın

/*
Console.WriteLine("sayı gir moruk");
int gün = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (gün == 1) { Console.WriteLine("pazartesi"); }
else if (gün == 2) { Console.WriteLine("salı"); }
else if (gün == 3) { Console.WriteLine("çarşamba"); }
else if (gün == 4) { Console.WriteLine("perşembe"); }
else if (gün == 5) { Console.WriteLine("cuma"); }
else if (gün == 6) { Console.WriteLine("cumartesi"); }
else if (gün == 7) { Console.WriteLine("pazar"); }
else { Console.WriteLine("yanlış sayı girdin enayi"); }

Console.ReadKey();
*/

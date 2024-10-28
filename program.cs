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
  /*
  Console.WriteLine("lütfen işlem yapacağınız iki sayı girin");
  int x = Convert.ToInt32(Console.ReadLine());
  int y = Convert.ToInt32(Console.ReadLine());
  Console.Clear();
  Console.WriteLine("[1]toplama");
  Console.WriteLine("[2]çıkarma");
  Console.WriteLine("[3]çarpma");
  Console.WriteLine("[4]bölme");
  Console.WriteLine("işlem yapmak için 1-4 e kadar sayı girin");
  int sayi = Convert.ToInt32(Console.ReadLine());
  Console.Clear();

  if (sayi == 1) Console.WriteLine(x + y); 
  else if (sayi == 2) Console.WriteLine(x - y);
  else if (sayi == 3) Console.WriteLine(x * y);
  else if (sayi > 4) Console.WriteLine(x / y);
  else Console.WriteLine("1-4 e kadar sayı gir");
  Console.ReadKey();
  */

  Console.BackgroundColor = ConsoleColor.Red;

  Console.WriteLine("[1]toplama");
  Console.WriteLine("[2]çıkarma");
  Console.WriteLine("[3]çarpma");
  Console.WriteLine("[4]bölme");
  Console.WriteLine("işlem yapmak için 1-4 e kadar sayı girin");

  int sayi = Convert.ToInt32(Console.ReadLine());
  int sonuc = 0;
  Console.WriteLine("işlem yapacağınız iki sayıyı girin");

  int x = Convert.ToInt32(Console.ReadLine());
  int y = Convert.ToInt32(Console.ReadLine());

  switch (sayi)
  {
      case 1:
          sonuc = x + y; break;
      case 2:
          sonuc = x - y; break;
      case 3:
          sonuc = x * y; break;
      case 4:
          sonuc = x / y; break;
      default:
          Console.WriteLine("erenin götü kadar kafan var mı?"); break;
         
  }
  Console.WriteLine("sonuç budur" + sonuc);
      Console.ReadKey();





 
            Console.WriteLine("yıl girin");
            int yıl = Convert.ToInt32(Console.ReadLine());

            if (yıl & 4 == 0) 
            {
                Console.WriteLine("şubat 29 çekiyor");
            }
            else
            {
                Console.WriteLine("şubat 28 çeker");
            }
                Console.ReadKey();




            

            Console.Write("Maaşınız kaç tl? :");
            int maas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kaç parça ürettiniz? :");
            int parcaSayisi = Convert.ToInt32(Console.ReadLine());

            int prim = 0;

            if (parcaSayisi >= 1 && parcaSayisi <= 5)
                prim = parcaSayisi * 100;
            else if (parcaSayisi >= 6 && parcaSayisi <= 20)
                prim = parcaSayisi * 125;
            else if (parcaSayisi >= 21 && parcaSayisi <= 50)
                prim = parcaSayisi * 160;
            else if (parcaSayisi >= 51) 
                prim = parcaSayisi * 200;
            int toplamUcret = maas + prim;
            Console.Clear();
            Console.WriteLine($"Maaşınız: {maas}");
            Console.WriteLine($"Aldığınız prim : {prim}");
            Console.WriteLine($"Aldığınız toplam maaş: {toplamUcret}");
            Console.ReadKey();






 /* bir kişi alışveriş sırasında 3 tane  ayakkabı almıştır. kişiye aldığı her bir ayakkabının fiyatı sorulacak ve tutara indirim hesaplanacaktır
  * toplam tutar 1500 ve üzerinde ise yüzde 8 toplam tutar 2000 ve üzerinde ise yüzde 12 indirim uygulanacaktır buna kişiye ayakkabıların fiyatını sorup
  * 
  * - toplam tutar
  * -indirim tutar
  * -ödemesi gereke tutar
  * hesaplayan ekrana yazan pogramı yaz*/


 Console.Write("a1 fiyat");
 double a1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("a2 fiyat");
 double a2 = Convert.ToInt32(Console.ReadLine());
 Console.Write("a3 fiyat");
 double a3 = Convert.ToInt32(Console.ReadLine());
 double top= a1 + a2 + a3;
 double topTutar = 0;
 if (top >= 1500 && top < 2000)
     {
     topTutar = top - ((top * 8) / 100);
     }
 else if (top >= 2000)
     {
     topTutar = top - ((top * 12) / 100);
     }
 Console.Write($"Toplam tutar  {top}");
 Console.Write($"ödemesi gereken  {topTutar} ");
 Console.ReadKey();

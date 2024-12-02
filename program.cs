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
//kullanıcının gireceğ, sayının pozitif veya negatif oldupnu ekrana yazan programı yazınız

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









//kullanıcıdan 1 ile 7 arasında bir sayı isteyip kullanıcının girdiği sayıya göre haftanın hangi günü olduğunu ekrana yazan programı yaz
//1- pazartesi 2- salı 3- çarşamba ... 7- pazar eğer kullanıcı 1-7 dışında sayı girerse yanlış sayı yazdın diye ekrana yazsın


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


           //bir işçinin maaşını sor yaptığı ürün sayısını zor 

            

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

    Console.Write("1. ayakkabının fiyatını girin: ");
    double ayakkabi1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("2. ayakkabının fiyatını girin: ");
    double ayakkabi2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("3. ayakkabının fiyatını girin: ");
    double ayakkabi3 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

    

    double toplamTutar = ayakkabi1 + ayakkabi2 + ayakkabi3;

    
    double indirimOrani = 0.0;
    if (toplamTutar >= 2000)
    {
        indirimOrani = 0.12; 
    }
    else if (toplamTutar >= 1500)
    {
        indirimOrani = 0.08; 
    }
    double indirimTutari = toplamTutar * indirimOrani;

    
    double odemeGerekenTutar = toplamTutar - indirimTutari;
        
  
    Console.WriteLine($"Toplam Tutar: {toplamTutar:F2} TL");
    Console.WriteLine($"İndirim Tutarı: {indirimTutari:F2} TL");
    Console.WriteLine($"Ödenmesi Gereken Tutar: {odemeGerekenTutar:F2} TL");
        Console.ReadKey();





 float sayi = 15.591f;

 Console.WriteLine(Math.Round(sayi));
 Console.WriteLine(Math.Round(sayi , 1));
 Console.WriteLine(Math.Round(sayi , 2));
 Console.WriteLine("----------------------------------");
 Console.WriteLine("yukarı yuvarlama");
 Console.WriteLine(Math.Ceiling(sayi));
 Console.WriteLine(Math.Ceiling(14.001f));
 Console.WriteLine("----------------------------------");
 Console.WriteLine("aşağı yuvarlama");
 Console.WriteLine(Math.Floor(sayi));
 Console.WriteLine(Math.Floor(74.99f));
 Console.ReadKey();






 //ToLower
 string kelime = "   NevŞ  Ehir? "; // 3 boşluk başta , 2 sonda
 string yeni = kelime.ToLower();
 Console.WriteLine(yeni);
 Console.WriteLine(kelime.ToUpper());

 int uzunluk = kelime.Length;
 Console.WriteLine(uzunluk);

 // string ifadelerin başındaki ve sonundaki boşlukarı kaldırır
 string k1 = kelime.Trim();
 Console.WriteLine(k1);
 // string ifadenin başındaki boşlukları kaldırır 
 Console.WriteLine(kelime.TrimStart() + '.');






 string k2 = "Bilgisayar Programcılığı";

 bool sonuc = k2.Contains("a");
 Console.WriteLine(sonuc);
 
 Console.WriteLine( k2.Contains("A") );
 Console.WriteLine( k2.Contains("say") );
 Console.WriteLine( k2.Contains("e") );

 if (sonuc == true)
 {
     Console.WriteLine("ifade a harfini içermektedir");
 }
 else
 {
     Console.WriteLine("ifade a harfini içermemektedir");
 }

 

 k2.StartsWith("B");









 string kelime1 = "Bilgisayar Programcılığı";

 //1 den başlar ve geri kalanları kopyalar
 string k3 = kelime1.Substring(1);
 Console.WriteLine(k3);

 //1 den başlar ve 4 karakter kopyalar
 string k4 = kelime1.Substring(1,4);
 Console.WriteLine(k4);



 Console.WriteLine("Adınız: ");
 string isim= Console.ReadLine();

 string ilkKarakter = isim.Substring(0,1);
 int uzunluk1 = isim.Length;
 string maskeli = ilkKarakter.PadRight(uzunluk1 , '*');








            //diziler array
            /*
            int[] yaslar = new int[5];

            string[] isimler = new string[5];
            Console.WriteLine("1. isim nedir? ");
            isimler[0] = "Ahmet";
            isimler[1] = "Mahmut";
            isimler[2] = "Ela";
            isimler[3] = "Cuma";
            isimler[4] = "Zehra";

            Console.WriteLine(isimler[3]);
            Console.WriteLine("-----------");
            Console.WriteLine(yaslar[2]);
            Console.WriteLine("-----------");


            Console.ReadKey();
            */

            string[] isimler = new string[5];

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write($"{i + 1}.isim nedir?");
                isimler[i] = Console.ReadLine(); 
            }
            Console.WriteLine("isimler alındı yazdırmak için bir tuşa basın");
            Console.ReadKey();
            for (int i = 0;i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.WriteLine("Tersten sıralanmış liste için tuşa bas");
            Console.ReadKey();
            for(int i = isimler.Length-1; i>=0; i--)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.WriteLine("program bitti bir tuşa basın");
            Console.ReadKey();












int[] sayilar = { 10, 9, 33, 96, 28, 24, 19, 7, 68, 28 };

//dizideki eleman sayısı 
int elemanSayisi = sayilar.Length;
Console.WriteLine($"Eleman sayısı : {elemanSayisi}");

//en büyük sayı 
int enBuyukSayi = sayilar.Max();
Console.WriteLine($"En büyük sayı : {enBuyukSayi}");

//en küçük sayı 
int enKucukSayi = sayilar.Min();
Console.WriteLine($"En küçük sayı : {enKucukSayi}");

//toplam 
int toplam = sayilar.Sum();
Console.WriteLine($"Eleman sayısı : {toplam}");

//ortalama 
double ortalama = sayilar.Average();
Console.WriteLine($"Eleman sayısı : {ortalama}");




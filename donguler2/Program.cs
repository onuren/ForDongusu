using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü
            //for (int sayac=0;sayac<=10;sayac++)
            //{
            //    Console.WriteLine(sayac);
            //}
            #endregion

            #region 0-100 arasında 4 e bölünebilen sayıların listesi

            //for(int sayi=0;sayi<=100;sayi++)
            //{
            //    if(sayi%4==0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //}


            #endregion

            #region for döngüsü i 

            //for(int i=0;i<=100;i++)
            //{
            //    if(i%4==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            #endregion

            #region 0-100 arasında 4e bölünebilen kaç sayı var

            //int j = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i%4==0)
            //    {
            //        j++;
            //    }
            //}
            //Console.WriteLine(j);

            #endregion

            #region 0-100 arasındaki 5ebölünen sayıların toplamı

            //int j = 0;
            //int toplam = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        j++;
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("Adedi: "+j);
            //Console.WriteLine("Toplamları: "+toplam);

            #endregion

            #region Tek basamaklı çarpım tablosu

            //Console.WriteLine("Bir değer giriniz:");
            //int Sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i+" x "+Sayi+" = "+ (i*Sayi));
            //}


            #endregion

            #region iç içe döngü

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("aa");
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine("b");
            //    }
            //}

            #endregion

            #region tüm çarpım tablosu

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine(i+" x "+j+" = "+(i*j));
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region a - z arası karakterleri yazdırın

            //for (int i=97;i<=122;i++)
            //{
            //    char j = Convert.ToChar(i);
            //    Console.WriteLine(j);
            //}

            #endregion

            #region Z-A arası karakterler

            //for (int i =90 ; i >=65 ; i--)
            //{
            //    Console.WriteLine(Convert.ToChar(i));
            //}

            #endregion

            #region uygulama

            //string satir = "";
            //for (int i = 0; i < 5; i++)
            //{
            //    satir = satir + "*";
            //    Console.WriteLine(satir);
            //}

            #endregion

            #region uygulama

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}

            #endregion

            #region kullanıcıdan alınan asal sayı mı?

            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool asalmi = true;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine("asal değildir");
                    asalmi = false;
                    break;
                }
            }
            if (asalmi == true)
            {
                Console.WriteLine("asal");
            }

            #endregion
        }
    }
}

using System;

namespace CSharp_Donguler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Cycles
            #region While
            //int index = 1;
            //while (index <  11)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            // 1 ile 100 arasında kaç tane çift sayı vardır ?
            //int index = 1;
            //int sonuc = 0;
            //while (index < 101)
            //{
            //    if (index % 2 == 0)
            //        sonuc++;
            //    index++;
            //}
            //Console.WriteLine(sonuc);

            // 1 ile 100 arasında ki sayıların toplamı ?
            // 1 2 3 .......... 100
            // 100 * 101 / 2 = 5050
            //int index = 1;
            //int toplam = 0;
            //while (index < 101)
            //{
            //    if (!(index % 2 == 0)) // ! değildir anlamına gelir değerin zıttını alır.
            //        toplam = toplam + index;
            //    index++;
            //}
            //Console.WriteLine(toplam);

            ////continue
            //index = 1;
            //while (index <= 10)
            //{
            //    if (index == 2)
            //    {
            //        index++;
            //        continue;
            //    }
            //    Console.WriteLine(index);
            //    index++;
            //}
            ////break
            //index = 1;
            //toplam = 0;
            //while (index < 101)
            //{
            //    if (!(index % 2 == 0)) 
            //        toplam = toplam + index;
            //    if(toplam > 1000)
            //    {
            //        break;
            //    }
            //    index++;
            //}

            //Console.WriteLine(toplam);
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            ////int sayi = 0;
            //while (sayi >= 0)
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    //int new_sayi = Convert.ToInt32(Console.ReadLine());
            //    //if(new_sayi < 0)
            //    //{
            //    //    break;
            //    //}
            //}
            #endregion

            #region do-while 
            // while dan tek farkı şudur => do while en az 1 kere çalışır
            //int sayi = 0;
            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //} while (sayi >= 0);
            #endregion

            #region For
            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region İç içe döngüler
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("#");
            //Console.WriteLine("##");
            //Console.WriteLine("####");
            //Console.WriteLine("#####");
            //Console.WriteLine("######");
            //Console.WriteLine("#######");
            #endregion

            #region Dik Üçgen Çizme
            //for (int satir = 16; satir >= 1; satir--)
            //{
            //    for (int bosluk = 1; bosluk <= 16-satir; bosluk++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int sutun = 1; sutun <= satir; sutun++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            //Kare çizimi
            //for (int i = 0; i < 15; i++)
            //{
            //    for (int j = 0; j < 15; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Asal Sayilar
            //for (int i = 2; i < 100; i++)
            //{
            //    bool isAsal = true;
            //    for (int j = 2; j <= i; j++)
            //    {
            //        var sonuc = i % j;
            //        if (sonuc == 0 && i != j)
            //        {
            //            isAsal = false;
            //            break;
            //        }
            //    }
            //    if (isAsal)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Faktoriyel
            //for (int i = 1; i < 20; i++)
            //{
            //    Console.Write($"{i}! = ");
            //    decimal carpim = 1;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        carpim *= j;
            //    }
            //    Console.WriteLine(carpim);
            //}
            #endregion

            #region En büyük ile en küçük farkı
            //double enBuyuk = double.MinValue;
            //double enKucuk = double.MaxValue;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{i+1}. sayıyı giriniz");
            //    double sayi = Convert.ToDouble(Console.ReadLine());
            //    if(sayi > enBuyuk)
            //    {
            //        enBuyuk = sayi;
            //    }
            //    if(sayi < enKucuk)
            //    {
            //        enKucuk = sayi;
            //    }
            //}
            //Console.WriteLine($"En büyük değer = {enBuyuk}, en küçük değer = {enKucuk} , fark = {enBuyuk - enKucuk}");
            #endregion

            #region Tek ve çift toplamlarının farkı
            //int ciftToplam = 0;
            //int tekToplam = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{i + 1}. sayıyı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if(sayi % 2 == 0)
            //    {
            //        ciftToplam += sayi;
            //    }
            //    else
            //    {
            //        tekToplam += sayi;
            //    }
            //}
            //Console.WriteLine($"Çift toplam = {ciftToplam}, Tek toplam = {tekToplam}, Fark = {ciftToplam - tekToplam}");
            #endregion
            #endregion
        }
    }
}

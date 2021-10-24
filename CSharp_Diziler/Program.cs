using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sebep
            //Evde denemeyin ! 
            //int sayi1 = 0, sayi2 = 0, sayi3 = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i + 1}. sayıyı giriniz");
            //    if (i == 0)
            //    {
            //        sayi1 = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (i == 1)
            //    {
            //        sayi2 = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else if (i == 2)
            //    {
            //        sayi3 = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine(sayi1);
            //Console.WriteLine(sayi2);
            //Console.WriteLine(sayi3);
            #endregion

            #region Sonuc - Diziler
            //int[] sayilar = new int[10]; // index numaraları 0 dan başlar dizi uzunluğu - 1 e kadar devam eder.
            //sayilar[0] = 89;//atama işlemi yapılıyor
            //sayilar[1] = 80;
            //Console.WriteLine(sayilar[0]); // 0.index deki değer okunuyor
            //sayilar[0] = "str"; hatalı atama  işlemi
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. sayıyı giriniz.");
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int j = 0; j < sayilar.Length; j++)
            //{
            //    Console.WriteLine(sayilar[j]);
            //}

            //int toplam = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    toplam += sayilar[i];
            //}
            //Console.WriteLine(toplam);
            //int enBuyuk = int.MinValue;
            //int enKucuk = int.MaxValue;
            //int enKucukIndex = 0;
            //int enBuyukIndex = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if(sayilar[i] > enBuyuk)
            //    {
            //        enBuyuk = sayilar[i];
            //        enBuyukIndex = i;
            //    }
            //    if(sayilar[i] < enKucuk)
            //    {
            //        enKucuk = sayilar[i];
            //        enKucukIndex = i;
            //    }
            //}

            //int temp = sayilar[enKucukIndex];
            //sayilar[enKucukIndex] = sayilar[enBuyukIndex];
            //sayilar[enBuyukIndex] = temp;

            //Console.WriteLine($"En büyük sayı = {enBuyuk}, En küçük sayı = {enKucuk}");
            #endregion

            #region Sorting

            //for (int i = 0; i <= sayilar.Length - 1; i++)
            //{
            //    for (int j = 1; j <= sayilar.Length - 1; j++)
            //    {
            //        if(sayilar[j-1] > sayilar[j])
            //        {
            //            int temp = sayilar[j - 1];
            //            sayilar[j - 1] = sayilar[j];
            //            sayilar[j] = temp;
            //        }
            //    }

            //    for (int x = 0; x < sayilar.Length; x++)
            //    {
            //        Console.Write($"{sayilar[x]}-");
            //    }
            //    Console.WriteLine("----------------------------");
            //}

            // Quick sort algoritmasını kullanarak sıralama işlemini yapınız.
            #endregion

            #region Diziler 2
            //string değerler aynı zamanda bir char array idir.
            //string stringArray = "CSharp Diziler konusuna hoşgeldiniz";
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    var ch = stringArray[i];
            //    Console.WriteLine(ch);
            //}

            //Uygulama
            //kullanıcıdan bir cümle alacaksınız. girilen cümle içinde sizin kendi belirlediğiniz harften kaç adet girilmiş ise onu ekrana yazdıracaksınız.
            #endregion

            #region Collection
            // Uzuuuun yöntem
            //int[] girilenSayilar = new int[0];
            //int[] tempSayilar = new int[0];
            //int index = 0;
            //for (; ;)
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 0; i < tempSayilar.Length; i++)
            //    {
            //        girilenSayilar[i] = tempSayilar[i];
            //    }  
            //    if(sayi < 0)
            //    {
            //        break;
            //    }
            //    tempSayilar = girilenSayilar;
            //    girilenSayilar = new int[girilenSayilar.Length + 1];
            //    girilenSayilar[index] = sayi;
            //    index++;
            //}

            //Collections
            //Tip güvenliğini sağlamazlar
            //Birden fazla tipte değer alabilir.
            //ArrayList girilenSayilar = new ArrayList();
            //for(; ; )
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi < 0) break;
            //    girilenSayilar.Add(sayi);
            //}
            //girilenSayilar.Add("Test");
            //girilenSayilar.Remove("Test");

            //Generic Collections
            //Tipe bağlı koleksiyon
            //List<string> girilenSayilar = new List<string>();
            //for (; ; )
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi < 0) break;
            //    girilenSayilar.Add(sayi.ToString());
            //}

            // Cümleyi tersten yazdırma
            //Console.WriteLine("Cümle giriniz");
            //string cumle = Console.ReadLine();
            //for (int i = cumle.Length - 1; i >= 0 ; i++)
            //{
            //    Console.Write("Test");
            //}
            //Console.WriteLine();


            #endregion

            #region Foreach
            List<int> sayilar = new List<int>() { 1, 2, 3, 5, 6, 9 };
            foreach(int item in sayilar)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Random
            Random random = new Random();
            int value = random.Next(0, 100);
            int[] sayilarDizi = new int[] { 1, 2, 3 };
            if (sayilarDizi.Contains(2)) { 
                //2 değeri dizide vardır
            }
            #endregion
        }
    }
}

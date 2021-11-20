using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Methods
{
    class Program
    {
        //Pascal notasyonu --- WriteToScreen
        //Camelcase --- writeToScreen

        public static void EkranaYazdir()
        {
            Sirala();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Eskişehir");
            }
            Console.WriteLine("*******************************");
        }

        public static void WriteToScreen(string sentence, int count = 1)
        {
            //Sentence değerinin harflerini alfabetik olarak sıralayıp yazdırın
            Sirala();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(sentence);
            }
            Console.WriteLine("*******************************");
        }

        public static void Sirala()
        {

        }

        static void Main(string[] args)
        {
            #region Initial
            //SOLID
            //Single Responsibility Principle
            //Open-Closed Principle
            //Liskov Substitution Principle
            //Interface Segregation
            //Dependency Inversion
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> numbers2 = new List<int>() { 5, 6, 32, 41, 9 };
            //foreach (var item in numbers2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Metodlar - Parametresiz geriye değer döndürmeyen static metodlar
            //Console.WriteLine("Ankara");
            //Console.WriteLine("Ankara");
            //Console.WriteLine("Ankara");
            //Console.WriteLine("Ankara");
            //Console.WriteLine("Ankara");
            //EkranaYazdir();
            //EkranaYazdir();
            //EkranaYazdir();
            //EkranaYazdir();
            //EkranaYazdir();
            #endregion
            #region Metodlar - Parametreli geriye değer döndürmeyen static metodlar
            //WriteToScreen("Ankara", 3);
            //WriteToScreen("Ad Soyad", 5);
            //WriteToScreen("01-01-0001", 2);
            #endregion
            #region Uygulama -1 

            //List<int> numbers1 = new List<int>() { 2, 5, 69, 36, 33, 98 };
            //EnBuyukDegerBul(numbers1);

            //List<int> numbers2 = new List<int>() { 2, 5, 69, 36 };
            //EnBuyukDegerBul(numbers2);

            //List<int> numbers3 = new List<int>() { 2, 5, 69, 36, 33, 98, 99, 77 };
            //EnBuyukDegerBul(numbers3);

            //char a = 'a';
            //ToUpper(a);
            //char b = 'b';
            //ToUpper(b);
            //char c = 'c';
            //ToUpper(c);


            #endregion
            #region Uygulama - 2
            // Kullanıcıdan cümleler alacaksınız. Aldığınız cümleleri cümle alma işlemi tamamlandıktan sonra cümle içindeki küçük harfleri büyük, büyük harfleri küçüğe dönüştüren programı yazınız.
            //List<string> sentences = new List<string>();
            ////string[] sentencesArray = new string[3];
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine("Cümle giriniz");
            //    string sentence = Console.ReadLine();
            //    sentences.Add(sentence);
            //}
            //foreach (string item in sentences)
            //{
            //    for(int i=0; i< item.Length; i++)
            //    {
            //        char character = item[i];
            //        WriteToUpperOrToLower(character);
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Metodlar - Parametresiz geriye değer döndüren static metodlar
            string result = SelamVer();
            Console.WriteLine(result);
            #endregion
            #region Metodlar - Parametreli geriye değer döndüren static metodlar
            //int toplam = Topla(1, 6);
            //Console.WriteLine(toplam);
            #endregion
            #region Uygulama - 3
            //Uygulama
            //Char ve int tipinde 2 değer alan ve değerlerden büyük olanı geriye döndüren metod.
            //int maxValue = CompareCharAndInt('A', 90);
            //Console.WriteLine(maxValue);
            ////2 adet liste alıp bu listelerden eleman sayısının küçük olanını geriye getiren bir metod.
            //var response = CompareListByCount(new List<string>() { "Esk", "Ank", "Bur" }, new List<string>() { "Ist", "Ant" });
            //foreach (var item in response)
            //{
            //    Console.WriteLine(item);
            //}

            ////1 Liste alıp liste içerisinde çift sayıların toplamını geriye döndüren bir metod.
            //var sum = CalculateSumOfEvenNumbersOfList(new List<int>() { 2, 4, 6, 8, 9, 99, 97, 71 });
            //Console.WriteLine(sum);
            ////1 Liste içerisinde ki asal sayıları ekrana yazdıran bir metod.
            //WritePrimeNumberInList(new List<int>() { 1, 2, 3, 6, 39, 7, 99, 67, 91, 71, 23 });
            ////3 adet int tipte parametre alıp bu değerleri büyükten küçüğe doğru sıralayıp bir liste halinde geriye değer döndüren metod.
            //var sortedList = SortToList(2, 36, 34, 1, 96, 77, 45);
            #endregion
            #region Static olmayan metodlar
            Program ali = new Program(); // nesne(instance) oluşturulur.
            ali.WriteHello();
            ali.WriteHello("Test");
            ali.WriteHello("Test","Test");
            ali.WriteHello("Test","10");

            #endregion

            //Uygulama
            //2 Adet listeyi tek liste halinde geriye döndüren static olmayan metodu tanımlayınız.
            //Bir Liste içerisinde ki sayıları, yine gönderilen bir sayı ile çarparak elemanları değiştiren metodu yazınız.
            //Bir cümleyi tersten yazdıran metodu tanımlayınız.
        }

        //Overload metodlar
        public void WriteHello()
        {
            Console.WriteLine("Hello");
        }

        public void WriteHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void WriteHello(string name,string surname)
        {
            Console.WriteLine($"Hello {name} {surname}");
        }

        public void WriteHello(string name, int yas)
        {
            Console.WriteLine($"Hello {name} {yas}");
        }

        public void WriteHello(string name, double year)
        {
            Console.WriteLine($"Hello {name} {year}");
        }

        public static List<int> SortToList(params int[] numbers)
        {
            var list = numbers.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[j] > list[j - 1])
                    {
                        int temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }

        public static int CalculateSumOfEvenNumbersOfList(List<int> numbers)
        {
            int toplam = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    toplam = toplam + item;
                    //toplam+=item;
                }
            }
            return toplam;
        }

        public static void WritePrimeNumberInList(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                bool isPrime = true;
                for (int i = 2; i < item; i++)
                {
                    if (item % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && item > 1)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static List<string> CompareListByCount(List<string> list1, List<string> list2)
        {
            var result = list1;
            if (list2.Count < list1.Count)
            {
                result = list2;
            }
            return result;
        }

        public static int CompareCharAndInt(char character, int number)
        {
            int result = number;
            if (character > number)
            {
                result = character;
            }
            return result;
            //if(character > number)
            //{
            //    return character;
            //}
            //else
            //{
            //    return number;
            //}
        }

        public static void WriteToUpperOrToLower(char character)
        {
            if (character >= 'a' && character <= 'z')
            {
                char newCharacter = Convert.ToChar(character - 32);
                Console.Write(newCharacter);
            }
            else if (character >= 'A' && character <= 'Z')
            {
                char newCharacter = Convert.ToChar(character + 32);
                Console.Write(newCharacter);
            }
            else
            {
                Console.Write(character);
            }
        }

        public static void ToUpper(char character)
        {
            int asciiValue = character - 32;
            char result = Convert.ToChar(asciiValue);
            Console.WriteLine(result);
        }

        public static void EnBuyukDegerBul(List<int> numbers)
        {
            int maxValue = int.MinValue;
            foreach (var item in numbers)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                }
            }
            Console.WriteLine($"En büyük değer = {maxValue}");
        }

        //public static void Topla(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
        public static int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        public static string SelamVer()
        {
            string str = "Selam";
            return str;
        }
    }
}

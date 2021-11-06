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
            #region Metodlar - Parametresiz geriye değer döndürmeyen static metodlar
            //Console.WriteLine("Ankara");
            //Console.WriteLine("Ankara");
            //Console.WriteLine("Ankara");
            //Console.WriteLine("Ankara");
            //Console.WriteLine("Ankara");
            EkranaYazdir();
            EkranaYazdir();
            EkranaYazdir();
            EkranaYazdir();
            EkranaYazdir();
            #endregion
            #region Metodlar - Parametreli geriye değer döndürmeyen static metodlar
            WriteToScreen("Ankara", 3);
            WriteToScreen("Ad Soyad", 5);
            WriteToScreen("01-01-0001", 2);
            #endregion
            #region Uygulama -1 

            List<int> numbers1 = new List<int>() { 2, 5, 69, 36, 33, 98 };
            EnBuyukDegerBul(numbers1);

            List<int> numbers2 = new List<int>() { 2, 5, 69, 36 };
            EnBuyukDegerBul(numbers2);

            List<int> numbers3 = new List<int>() { 2, 5, 69, 36, 33, 98, 99, 77 };
            EnBuyukDegerBul(numbers3);

            char a = 'a';
            ToUpper(a);
            char b = 'b';
            ToUpper(b);
            char c = 'c';
            ToUpper(c);


            #endregion
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

    }
}

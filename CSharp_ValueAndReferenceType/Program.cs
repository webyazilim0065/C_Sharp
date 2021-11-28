using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ValueAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value (değer) tipleri
            int sayi = 10;
            int sayi2 = sayi;
            sayi = 15;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi2);

            //Referans tip
            Araba araba = new Araba("Opel");
            Araba araba2 = araba;

            araba2.Marka = "Ford";

            Console.WriteLine("Araba = " + araba.Marka);
            Console.WriteLine("Araba2 = " + araba2.Marka);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler (Variables)
            //string değişken tipi metinsel ifadeleri kabul eden bir değişken tipidir. Metinsel ifadeler çift tırnak arasına yazılır.
            string initial = "Variables subject";
            Console.WriteLine("Something");
            Console.WriteLine(initial);
            //Tam sayılar
            byte byte_sayi = 255; //byte 8-bitlik bir alan kaplar alabileceği max değer 255dir minumum değer ise 0 dır;
            //byte sayi1 = -14; Hatalı tanımlama
            sbyte sbyte_sayi = -128; //-128 ile 127 değerleri dahil aralığını kabul eder.
            short short_sayi = 32767; //-32768 ile 32767 arasında değer alır.
            ushort ushort_sayi = 45; // 0 ile 65535 arasında değer alır;
            int int_sayi = -65; //-2.147.483.648 ile 2.147.483.648 arasında değer alır.
            uint uint_sayi = 1500; //0 ile 4.294.967.295 arasında değer alır.
            long long_sayi = 87_879_798_798_979; //-10 üzeri 20 ile 10 üzeri 20 arasında değer alır.
            ulong ulong_sayi = 654564646; // 0 ile 2 x 10 üzeri 20 arasında değer alır.

            //Ondalıklı değerler
            float float_sayi = -14.7f; // 1.5 x 10 üzeri 45 ile 3.4 x 10 üzeri 38 arasında değer alır. (32 bit)
            double double_sayi = -12.78; // (64 bittir.)5.0 x 10 üzeri 324 ile 1.7 x 10 üzeri 308 
            decimal decimal_sayi = -14.8m;  //128 bittir.±1.0 x 10 üzeri 28 ile ±7.9 x 10 üzeri 28

            //Karakter
            char character = '.'; // 16 bittir. tek tırnak olarak tek karakter tanımlanır

            //Mantıksal değer (0 yada 1) (True yada false)
            bool bool_deger = true;

            var variable_something = true;
            var variableSomething = "test";

            initial = "Something variable";
            Console.WriteLine(initial);
        }
    }
}

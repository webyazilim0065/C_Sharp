using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama operatörü
            // = 
            string str = "Atama operatörü";
            //Aritmetik operatörler
            // + - * / %
            int toplam = 1 + 3 - 5 + 9;
            toplam = (1 + 3) * 4 - 9 / 3;
            int kalan = 15 % 6;
            //Tekil operatörler
            kalan++;
            kalan--;
            kalan -= 3;
            kalan = kalan - 4;
            kalan += 6;
            kalan = kalan + 5;
            Console.WriteLine(kalan);
            Console.WriteLine(toplam);
            str = "1" + "2"; //Birleştirme operatörü
            str += "3";
            str = "6" + 1 + (9 + 3);
            Console.WriteLine(str);
            string str_value = 6 + 1 + "1" + (14d / 5);
            Console.WriteLine(str_value);

            //Karşılaştırma operatörleri
            // < > == != >= <=  
            // Çıktısı daima bool tiptedir.
            bool bool_condition = 1 > 2;
            bool_condition = 2 == 2;
            bool_condition = 2 != 3;
            bool_condition = 2 >= 2;
            bool_condition = 2 < 3;

            //Mantıksal Operatörler
            // && (ve)
            // || (veya)
            // Çıktısı daima bool tipinde değerdir.
            bool _mnt = (1 > 2 && 3 < 4) || 2 == 2;
            Console.WriteLine(_mnt);

        }
    }
}

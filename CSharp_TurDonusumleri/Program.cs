using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilinçsiz Tür Dönüşümü
            byte byte_sayi = 250;
            short short_sayi = byte_sayi;
            int int_sayi = short_sayi;
            long long_sayi = int_sayi;
            float float_sayi = long_sayi;
            double double_sayi = float_sayi;
            //Bilinçli Tür dönüşümü
            string x = Convert.ToString(byte_sayi);
            x = byte_sayi.ToString();
            short_sayi = Convert.ToInt16(byte_sayi);
            double dbl_sayi = 15.78;
            long_sayi = Convert.ToInt64(dbl_sayi);
            Console.WriteLine(long_sayi);
            string str_ = "256000";
            int_sayi = Convert.ToInt32(str_);
            Console.WriteLine(int_sayi);
            byte_sayi = Convert.ToByte(255);
            Console.WriteLine(byte_sayi);

            char ch = 'a';
            int _ch = ch - 32; // char özel bir değişken tipidir. İçerisinde karaktere ait ascii kodu barındırır. Char değerini inte aatarken karakterin ascii değeri elde edilir. Küçük harfle büyük harfler arasındaki değer farkı 32 dir. küçük a = 97 iken büyük A = 65 dir ve Z ye kadar bu şekilde artarak 68,69..... şeklinde devam eder.
            ch = (char)_ch; // int değeri char a dönüştürmek için bilinçli tür dönüşümü yapılır.
            Console.WriteLine(ch);
            //int int_ch = ch; // char > int bilinçsiz
            //ch =Convert.ToChar(95); // int > char bilinçli
            //Console.WriteLine(int_ch);
            //Console.WriteLine(ch);
            //Console.WriteLine("Bir küçük karakter giriniz");
            //string read = Console.ReadLine();//çıktısı daima stringdir;
            //Console.WriteLine("Okunan değer = " + read);

            //Uygulama
            // Boxing ve unboxing incelenecek
            // Koşulları incelenecek
            // Döngüler incelenecek
            // Kullanıcıdan bir küçük harf alacaksınız. Aldığınız küçük harfi büyük harfe dönüştürüp ekrana yazdıracaksınız.
            // Kullanıcıdan bir büyük harf alacaksınız. Aldığınız büyük harfi küçük harfe dönüştürüp ekrana yazdıracaksınız.

            //Console.WriteLine("Küçük harf giriniz !");
            ////string str = Console.ReadLine();
            ////char harf = Convert.ToChar(str);
            //char harf = Convert.ToChar(Console.ReadLine());
            //int ascii_harf = harf;
            //int buyuk_ascii_harf = ascii_harf - 32;
            //char buyukharf = Convert.ToChar(buyuk_ascii_harf);
            //Console.WriteLine("Harfinizin büyük hali = " + buyukharf + " şeklindedir");

            Console.WriteLine("Büyük harf giriniz !");
            //string str = Console.ReadLine();
            //char harf = Convert.ToChar(str);
            char harf = Convert.ToChar(Console.ReadLine());
            int ascii_harf = harf;
            int kucuk_ascii_harf = ascii_harf + 32;
            char kucukharf = Convert.ToChar(kucuk_ascii_harf);
            Console.WriteLine("Harfinizin küçük hali = " + kucukharf + " şeklindedir");
        }
    }
}

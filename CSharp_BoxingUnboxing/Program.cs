using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //debug yöntemini kullanmak için break point eklendikten sonra f5 ile yada start ile proje çalıştırılır. F10 ile adım adım ilerletilir. F5 ile varsa bir sonraki break pointe kadar yoksa proje kaldığı yerden devam  eder.
            //string str = "23";
            object boxing = 23; // boxing
            //string unboxing = Convert.ToString(boxing); //unboxing
            //Console.WriteLine(unboxing);
            string fault = Convert.ToString(boxing);// hata yok
            fault = (string)boxing;//hatalı // boxing işlemi sırasında object değişkene atılan değer hangi tipteyse o şekilde dışarıya cast işlemi ile çıkarılmalıdır. Convert.To.... işleminde herhangi bir kısıt yoktur.
            Console.WriteLine(fault);

        }
    }
}

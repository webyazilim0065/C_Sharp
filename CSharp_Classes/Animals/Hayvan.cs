using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes.Animals
{
    public class Hayvan
    {
        public int Boy { get; set; }
        public int Kilo { get; set; }
        public string YasamAlani { get; protected set; }

        public virtual void SesCikar()
        {
            Console.WriteLine("Hayvan ses çıkardı");
        }

        public void NefesAl()
        {
            Console.WriteLine("Hayvan nefes aldı");
        }
    }
}

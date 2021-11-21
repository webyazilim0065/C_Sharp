using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes.Electronics
{
    public class BeyazEsya : Elektronik
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public void Calistir()
        {
            Console.WriteLine("Çalıştı");
        }
    }
}

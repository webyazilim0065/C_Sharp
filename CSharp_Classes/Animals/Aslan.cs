using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes.Animals
{
    public class Aslan : Hayvan
    {
        public Aslan(bool yeleliMi)
        {
            YeleliMi = yeleliMi;
            YasamAlani = "Kara";
        }

        public bool YeleliMi { get; set; }

        public override void SesCikar()
        {
            Console.WriteLine("Aslan kükredi");
        }

        public override string ToString()
        {
            var result = $"Yeleli aslan mi ? = {(this.YeleliMi == true ? "Evet" : "Hayır")} Yaşam alanı = {this.YasamAlani}";
            return result;
        }
    }
}

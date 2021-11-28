using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes.Animals
{
    public class Kartal : Hayvan
    {
        public Kartal(int kanatGenisligi, string gagaTipi)
        {
            KanatGenisligi = kanatGenisligi;
            GagaTipi = gagaTipi;
            YasamAlani = "Kara/Hava";
        }

        public int KanatGenisligi { get; set; }
        public string GagaTipi { get; set; }

        public override void SesCikar()
        {
            Console.WriteLine("Kartal ses çıkardı");
        }

        public override string ToString()
        {
            var result = $"Kanat genişliği = {this.KanatGenisligi} Gaga Tipi = {this.GagaTipi} Yaşam alanı = {this.YasamAlani}";
            return result;
        }
    }
}

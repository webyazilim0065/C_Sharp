using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes.Animals
{
    public class Yunus : Hayvan
    {
        public Yunus(int yuzgecSayisi, bool kafaDeligiVarmi)
        {
            YuzgecSayisi = yuzgecSayisi;
            KafaDeligiVarmi = kafaDeligiVarmi;
            YasamAlani = "Su";
        }

        public int YuzgecSayisi { get; set; }
        public bool KafaDeligiVarmi { get; set; }

        //Override
        public override void SesCikar()
        {
            Console.WriteLine("Yunus ses çıkardı");
        }

        public override string ToString()
        {
            var result = $"Yüzgeç sayısı = {this.YuzgecSayisi} Kafa deliği var mı ? = {(this.KafaDeligiVarmi == true ? "Evet" : "Hayır")} Yaşam alanı = {this.YasamAlani}";
            return result;
        }
    }
}

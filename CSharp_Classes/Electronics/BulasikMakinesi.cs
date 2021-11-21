using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes.Electronics
{
    public class BulasikMakinesi : BeyazEsya
    {
        //BulasikMakinesi BeyazEsya sınıfından türetilmiş bir alt sınıftır
        //Properties
        //public string Marka { get; set; }
        //public string Model { get; set; }
        public int ProgramSayisi { get; private set; } //public get; private set;
        public string BarkodNo { get; } // readonly

        //Encapsulation Kapsülleme
        private string UretimNumarasi;

        public string UretimNo
        {
            get { return UretimNumarasi; }
            set { UretimNumarasi = $"{DateTime.Now.Year}-{value}"; }
        }


        public BulasikMakinesi(string marka,string model,int programSayisi)
        {
            Marka = marka;
            Model = model;
            ProgramSayisi = programSayisi;
            BarkodNo = Guid.NewGuid().ToString();
            CalismaVolt = 220;
        }
    }
}

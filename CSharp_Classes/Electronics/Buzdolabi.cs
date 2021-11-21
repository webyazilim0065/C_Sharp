using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes.Electronics
{
    public class Buzdolabi : BeyazEsya
    {
        //Properties
        //public string Marka { get; set; }
        //public string Model { get; set; }
        public int Hacim { get; private set; } //public get; private set;
        public string BarkodNo { get; } // readonly

        //Encapsulation Kapsülleme
        private string UretimNumarasi;

        public string UretimNo
        {
            get { return UretimNumarasi; }
            set { UretimNumarasi = $"{DateTime.Now.Year}-{value}"; }
        }


        public Buzdolabi(string marka, string model, int hacim)
        {
            Marka = marka;
            Model = model;
            Hacim = hacim;
            BarkodNo = Guid.NewGuid().ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes.Electronics
{
    public class CamasirMakinesi : BeyazEsya
    {
        //Bir alt class sadece bir class tan türeyebilir.
        //Çoklu kalıtım yapılamaz.
        private int DevirSayisi;
        public string EnerjiSinifi;
        //public string Marka;
        //public string Model;
        public Random rnd;
        public CamasirMakinesi()
        {
            rnd = new Random();
        }


        public int GetDevirSayisi()
        {
            return this.DevirSayisi;
        }

        public CamasirMakinesi(int devirSayisi)
        {
            DevirSayisi = devirSayisi;
            rnd = new Random();
        }

        public CamasirMakinesi(int devirSayisi,string enerjiSinifi)
        {
            DevirSayisi = devirSayisi;
            EnerjiSinifi = enerjiSinifi;
            rnd = new Random();
        }

        public CamasirMakinesi(int devirSayisi, string enerjiSinifi,string marka)
        {
            DevirSayisi = devirSayisi;
            EnerjiSinifi = enerjiSinifi;
            Marka = marka;
            rnd = new Random();
        }

        public CamasirMakinesi(int devirSayisi, string enerjiSinifi, string marka,string model)
        {
            DevirSayisi = devirSayisi;
            EnerjiSinifi = enerjiSinifi;
            Marka = marka;
            Model = model;
            rnd = new Random();
        }

        public void Calistir()
        {
            Console.WriteLine("Çamaşır makinesi çalıştı");
            SuAl();
        }

        public int DevirSayisiOgren()
        {
            var result = rnd.Next(0, this.DevirSayisi);
            return result;
        }

        public void Durdur()
        {
            Console.WriteLine("Çamaşır makinesi durdu");
        }

        private void SuAl()
        {
            Console.WriteLine("Çamaşır makinesi su alıyor");
        }
    }
}

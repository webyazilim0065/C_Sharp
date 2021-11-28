using CSharp_Classes.Animals;
using CSharp_Classes.Electronics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Class Initial
            //            People p = new People("","");
            //            p.Name = "Test";
            //            p.Surname = "Test";
            //            p.BirthYear = 2000;
            //            p.Email = "test@test.com.tr";

            //            People p2 = new People();
            //            p2.Name = "Test";
            //            p2.Surname = "Testoğlu";
            //            p2.BirthYear = 1990;

            //            People p3 = new People("Ali", "Test");
            //            People p4 = new People();

            //            List<People> people = new List<People>();
            //            people.Add(p);
            //            people.Add(p2);
            //            people.Add(p3);

            //            foreach (var item in people)
            //            {
            //                Console.WriteLine($"{item.Name} {item.Surname} {item.BirthYear} {item.Email} {item.CalculateOfPersonAge()} {item.ChildrenNames.Count}");
            //            }
            //            //p.CalculateOfPersonAge();
            #endregion

            #region Class Continue && Erişim Belirleyici
            //CamasirMakinesi camasirMakinesi = new CamasirMakinesi(1000, "A+++", "Bosch", "TR897T");
            ////camasirMakinesi = new CamasirMakinesi(2000, "A+++", "Bosch", "TR897T");
            ////camasirMakinesi.DevirSayisi = 1500;
            //camasirMakinesi.Calistir();
            //Console.WriteLine($"Çamaşır makinesi {camasirMakinesi.DevirSayisiOgren()} devir ile dönüyor");
            ////camasirMakinesi.SuAl();
            //Console.WriteLine($"Çamaşır makinesi {camasirMakinesi.DevirSayisiOgren()} devir ile dönüyor"); 
            //Console.WriteLine($"Çamaşır makinesi {camasirMakinesi.DevirSayisiOgren()} devir ile dönüyor"); 
            //Console.WriteLine($"Çamaşır makinesi {camasirMakinesi.DevirSayisiOgren()} devir ile dönüyor");
            //camasirMakinesi.Durdur();

            //Console.WriteLine($"{camasirMakinesi.Marka} {camasirMakinesi.Model} {camasirMakinesi.EnerjiSinifi} {camasirMakinesi.GetDevirSayisi()}");

            //BulasikMakinesi bulasikMakinesi = new BulasikMakinesi("Bosch", "TS745T", 5);
            //bulasikMakinesi.UretimNo = "TRY73226";

            //bulasikMakinesi.Calistir();
            ////bulasikMakinesi.ProgramSayisi = 6;
            //Console.WriteLine($"{bulasikMakinesi.Marka} {bulasikMakinesi.Model} {bulasikMakinesi.ProgramSayisi} {bulasikMakinesi.BarkodNo} {bulasikMakinesi.UretimNo}");

            //Buzdolabi buzdolabi = new Buzdolabi("Beko", "BB8966T", 530);

            //List<CamasirMakinesi> camasirMakinesis = new List<CamasirMakinesi>();
            //camasirMakinesis.Add(camasirMakinesi);
            ////camasirMakinesis.Add(bulasikMakinesi);

            //List<BeyazEsya> beyazEsyas = new List<BeyazEsya>();
            //beyazEsyas.Add(camasirMakinesi);
            //beyazEsyas.Add(bulasikMakinesi);
            //beyazEsyas.Add(buzdolabi);

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(camasirMakinesi);
            //arrayList.Add(bulasikMakinesi);
            //arrayList.Add("str");

            #endregion

            #region Overriding

            Aslan aslan = new Aslan(true);
            //aslan.YasamAlani = "Su";
            Aslan disiAslan = new Aslan(false);

            Kartal kartal = new Kartal(1500, "sivri");
            Kartal disiKartal = new Kartal(1000, "oval");

            Yunus yunus = new Yunus(2, true);
            Yunus disiYunus = new Yunus(3, false);

            List<Hayvan> hayvanlar = new List<Hayvan>()
            {
                kartal,
                disiKartal,
                yunus,
                disiYunus
            };
            hayvanlar.Add(aslan);
            hayvanlar.Add(disiAslan);


            //foreach (var item in hayvanlar)
            //{
            //   if(item is Aslan castAslan)
            //    {
            //        //var a = (Aslan)item;
            //        //string result = "Evet";
            //        //if (!castAslan.YeleliMi)
            //        //{
            //        //    result = "Hayır";
            //        //}
            //        //Console.WriteLine("Yeleli aslan mi ? " + result);
            //        Console.WriteLine($"Yeleli aslan mi ? = {(castAslan.YeleliMi == true ? "Evet" : "Hayır")} Yaşam alanı = {castAslan.YasamAlani}"); //Ternary if
            //        Console.WriteLine(castAslan.ToString());
            //    }
            //   else if(item is Kartal castKartal)
            //    {
            //        //Console.WriteLine($"Kanat genişliği = {castKartal.KanatGenisligi} Gaga Tipi = {castKartal.GagaTipi} Yaşam alanı = {castKartal.YasamAlani}");
            //        Console.WriteLine(castKartal.ToString());
            //    }
            //   else if(item is Yunus castYunus)
            //    {
            //        Console.WriteLine($"Yüzgeç sayısı = {castYunus.YuzgecSayisi} Kafa deliği var mı ? = {(castYunus.KafaDeligiVarmi == true ? "Evet" : "Hayır")} Yaşam alanı = {castYunus.YasamAlani}");
            //    }

            //    item.SesCikar();
            //}

            foreach (var item in hayvanlar)
            {
                Console.WriteLine(item.ToString());
                item.SesCikar();
            }

            #endregion
        }
    }
}

using System;
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
            People p = new People("","");
            p.Name = "Test";
            p.Surname = "Test";
            p.BirthYear = 2000;
            p.Email = "test@test.com.tr";

            People p2 = new People();
            p2.Name = "Test";
            p2.Surname = "Testoğlu";
            p2.BirthYear = 1990;

            People p3 = new People("Ali", "Test");
            People p4 = new People();

            List<People> people = new List<People>();
            people.Add(p);
            people.Add(p2);
            people.Add(p3);

            foreach (var item in people)
            {
                Console.WriteLine($"{item.Name} {item.Surname} {item.BirthYear} {item.Email} {item.CalculateOfPersonAge()} {item.ChildrenNames.Count}");
            }
            //p.CalculateOfPersonAge();
        }
    }
}

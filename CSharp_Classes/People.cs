using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Classes
{
    public class People
    {
        public People() // Default Constructor // Parametresiz Yapıcı metod
        {
            this.ChildrenNames = new List<string>();
        }

        public People(string name, string surname) // Parametreli Constructor
        {
            this.Name = name;
            this.Surname = surname;
            this.ChildrenNames = new List<string>();
        }

        public string Name = "Ahmet";
        public string Surname;
        public string Email;
        public int BirthYear;
        public List<string> ChildrenNames;

        public int CalculateOfPersonAge(int birthYear)
        {
            int age = DateTime.Now.Year - birthYear;
            return age;
        }

        public string CalculateOfPersonAge()
        {
            int age = DateTime.Now.Year - this.BirthYear;
            return age.ToString();
        }
    }
}

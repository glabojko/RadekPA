using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RadekPA
{
    public class Human
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Sex { get; set; }
        int Age { get; set; }
        

        public Human(string firstName, string lastName, string sex, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Age = age;
            
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, age: {Age}.";
        }

        public void ChangeName(string name)
        {
            FirstName = name;
        }

        public string Metoda()
        {
            return "zawory";
        }

    }
}

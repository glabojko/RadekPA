using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadekPA
{
    public class Manager : Employee
    {
        private string Name { get; }

        double AnnualBonus { get; set; }
        int Laptop { get; set; } = 1;
        int Phone { get; set; } = 1;
        string Position { get; set; } = "Manager";
        int Loyalty { get; set; } = 40;


        public Manager(string firstName, string lastName, string sex, int age, int skillLevel, string employer, string position, double salary, int yearsEmployed) : base(firstName, lastName, sex, age, skillLevel, employer, position, salary, yearsEmployed)
        {
            Name = firstName;
        }

        public void LosePhone()
        {
            Phone--;
        }

        public override string ToString()
        {
            
            if (Phone > 0) 
            {
                return base.ToString() + $"I mam służbowy telefon sztuk {Phone}";
            }
            return base.ToString() + $"I chyba zajebali mi służbowy telefon, bo teraz mam sztuk {Phone}";
        }
        
        public string LoyaltyAnnouncement()
        {


            return $"My name is {Name} I am a Manager and I have {Loyalty} loyalty points";
        }
    }
}

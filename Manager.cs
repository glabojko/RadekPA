using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadekPA
{
    public class Manager : Employee
    {
        double AnnualBonus { get; set; }
        int Laptop { get; set; } = 1;
        int Phone { get; set; } = 1;
        string Position { get; set; } = "Manager";
        int Loyalty { get; set; }

        public Manager(string firstName, string lastName, string sex, int age, int skillLevel, string employer, string position, double salary, int yearsEmployed)  : 
            base(firstName, lastName, sex, age, skillLevel, employer, position, salary, yearsEmployed)
        {
            
        }

        public void LosePhone()
        {
            Phone--;
        }
    }
}

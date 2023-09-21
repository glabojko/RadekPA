using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadekPA
{
    public class Specialist : Employee
    {
        int SkillLevel { get; set; }
        int MedicalInsurane { get; set; } = 2000;
        int MultiSportCar { get; set; } = 1;

        public Specialist(string firstName, string lastName, string sex, int age, int skillLevel, string employer, string position, double salary, int yearsEmployed) :
            base(firstName, lastName, sex, age, skillLevel, employer, position, salary, yearsEmployed)
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"I mam ubezpieczenie medyczne w wysokości {MedicalInsurane} zł.";
        }
    }
}

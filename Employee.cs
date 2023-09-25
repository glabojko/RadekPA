using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadekPA
{
    public class Employee : Human
    {
        internal object firstName;

        string Employer { get; set; }
        string Position { get; set; }
        double Salary { get; set; }
        int YearsEmployed { get; set; }
        int SkillLevel { get; set; }
        public static object Name { get; protected set; }

        public Employee(string firstName,
                        string lastName,
                        string sex,
                        int age,
                        int skillLevel,
                        string employer,
                        string position,
                        double salary,
                        int yearsEmployed
                        ) : base(firstName, lastName, sex, age)
        {
            Employer = employer;
            Position = position;
            Salary = salary;
            YearsEmployed = yearsEmployed;
            SkillLevel = skillLevel;
            
        }

        public override string ToString()
        {
            if (Salary > 1000) {
                return base.ToString() + $"Pracuję w: {Employer} i dostaję {Salary} wypłaty." + " Jestem kurewsko bogaty(a)!";
            }
            return base.ToString() + $"Pracuję w: {Employer} i dostaję {Salary} wypłaty.";
        }

        public void Rise()
        {
            if (YearsEmployed > 2)
            {
                Salary = Salary * 1.1;
            }
        }

        public string PromoteToSpecialist()
        {
            if (SkillLevel > 50)
            {
                return "Hey! I don't wont to be an ordinary worker anymore. Make me a specialist!";
            }
            else
            {
                return "Your skill level is not high enough to be specialist";
            }
        }


    }
}

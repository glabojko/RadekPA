﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadekPA
{
    public class Employee : Man
    {
        
        string Employer { get; set; }
        string Position { get; set; }
        double Salary { get; set; }
        int YearsEmployed { get; set; }
        int SkillLevel { get; set; }

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
            if (Salary > 505) {
                return base.ToString() + $"{Employer} and he gets {Salary}" + " I am rich";
            }
            return base.ToString() + $"{Employer} and he gets {Salary}";
        }

        public void Rise()
        {
            Salary = Salary * 1.1;
        }


    }
}
using Assignment01_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_1.Company
{
   class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public double Salary { get; set; }
        public HireDate HireDate { get; set; }
        private Gender gender;

        public Gender Gender
        {
            get => gender;
            set { if (value == Gender.M || value == Gender.F) gender = value; }
        }

        public Employee(int id, string name, SecurityLevel sec, double salary, HireDate hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            Security = sec;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Security: {2}, Salary: {3:C}, Hire Date: {4}, Gender: {5}",
                ID, Name, Security, Salary, HireDate, Gender);
        }
    }
}

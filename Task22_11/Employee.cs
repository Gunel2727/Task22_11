using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22_11
{
    internal class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Salary { get; set; }
        public Employee(string name, string surname,DateTime birthday, int salary)
        {
            Salary = salary;
            Name = name;
            SurName = surname;
            BirthDay = birthday;
        }

    }
}

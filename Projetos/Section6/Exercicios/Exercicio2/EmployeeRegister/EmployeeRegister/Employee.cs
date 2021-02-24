using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EmployeeRegister
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalaty(double percent) 
        {
            Salary += (percent / 100) * Salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}

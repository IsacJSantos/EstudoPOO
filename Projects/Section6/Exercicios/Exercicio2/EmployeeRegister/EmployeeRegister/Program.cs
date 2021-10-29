using System;
using System.Globalization;
using System.Collections.Generic;

namespace EmployeeRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeeList.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
          
            while (true) 
            {
                Console.Write("Enter the employee id that will have salary increase: ");
                int idIncrease = int.Parse(Console.ReadLine());
                Employee employee = employeeList.Find(x => x.Id == idIncrease);

                if (employee != null) 
                {
                    Console.Write("Enter the porcentage: ");
                    double percent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    employee.IncreaseSalaty(percent);
                    break;
                }        
                else 
                {
                    Console.WriteLine("This Id does not exist!");
                }
                   
            }
            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach (var item in employeeList)
            {
                Console.WriteLine(item);
            }


        }
    }
}

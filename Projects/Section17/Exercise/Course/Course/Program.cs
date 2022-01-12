using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double inputSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(',');
                    string name = s[0];
                    string email = s[1];
                    double salary = double.Parse(s[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }
            Console.WriteLine($"Email of people whose salary is more than {inputSalary}: ");
            var emails = list.Where(e => e.salary > inputSalary).OrderBy(e => e.Email).Select(e => e.Email);

            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine();

            var sum = list.Where(e => e.Name[0] == 'M').Select(e => e.salary).Sum();
            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

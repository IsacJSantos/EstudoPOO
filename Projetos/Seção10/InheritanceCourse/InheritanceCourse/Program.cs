using InheritanceCourse.Entities;
using System;

namespace InheritanceCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8530,"Isac Santos",1830,1000);

            Console.WriteLine(account.Balance);

        }
    }
}

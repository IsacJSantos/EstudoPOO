using System;
using LinkedListProject.Entities;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Add(3);
            Console.WriteLine(list);
            list.Add(5);
            Console.WriteLine(list);
            list.Add(7);
            Console.WriteLine(list);
            list.Add(6);
            Console.WriteLine(list);
        }
    }
}

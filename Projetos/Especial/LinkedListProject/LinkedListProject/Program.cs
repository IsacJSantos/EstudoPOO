﻿using System;
using LinkedListProject.Entities;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> list = new LinkedList<String>();

            int option;
            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter a word: ");
                        string number = (Console.ReadLine());
                        list.Add(number);
                        break;
                    case 2:
                        Console.WriteLine(list);
                        break;
                    default:
                        Console.WriteLine("Ending program...");
                        break;
                }

            } while (option != 3 );
            
        }

        static void ShowMenu() 
        {
            Console.WriteLine("1 - Add a new element");
            Console.WriteLine("2 - Show the list");
            Console.WriteLine("3 - Exit");
        }
    }
}

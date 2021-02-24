using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the array lenght X: ");
            int arrayLenghtX = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the array lenght Y: ");
            int arrayLenghtY = int.Parse(Console.ReadLine());

            Array2D array = new Array2D(arrayLenghtX, arrayLenghtY);

            for (int i = 0; i < arrayLenghtX; i++)
            {
                Console.WriteLine("Enter values for the column in row " + i);
                string stringLine = Console.ReadLine();
                array.SetValues(i, stringLine);
            }

            Console.WriteLine();

            Console.WriteLine("Main Diagonal");
            Console.WriteLine(array.GetMainDiaognal());

            Console.WriteLine();
            
            Console.Write("Negative Numbers = " + array.GetNegativeNumbers());

        }

       
    }
}

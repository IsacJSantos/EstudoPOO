using System;

namespace MatrixExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Array2D array = new Array2D(row,column);

            Console.WriteLine("Enter the values");
            for (int i = 0; i < row; i++)
            {
                string line = Console.ReadLine();
                array.SetValues(i, line);
            }

            array.PrintAllPositions(8);
        }
    }
}

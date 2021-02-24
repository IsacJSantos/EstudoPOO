using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixExercise
{
    class Array2D
    {
        public int[,] Matrix { get; private set; }

        public Array2D(int row, int column)
        {
            Matrix = new int[row, column];
        }

        public void SetValues(int row,string line) 
        {
            string[] s = line.Split(' ');

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Matrix[row, i] = int.Parse(s[i]);
            }

        }
        public void PrintAllPositions(int value)
        {

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == value)
                    {
                        Console.WriteLine("Position: " + i + "," + j);

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + Matrix[i, j - 1]);
                        }

                        if (j < (Matrix.GetLength(1) - 1))
                        {
                            Console.WriteLine("Right: " + Matrix[i, j + 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + Matrix[i - 1, j]);
                        }

                        if (i < (Matrix.GetLength(0) - 1))
                        {
                            Console.WriteLine("Down: " + Matrix[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}

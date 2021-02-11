using System;
using System.Collections.Generic;
using System.Text;

namespace Matriz
{
    class Array2D
    {
        int[,] matrix;
        public Array2D(int row, int column)
        {
            matrix = new int[row, column];
        }

        public void SetValues(int row, string lineSplit)
        {
            string[] s = lineSplit.Split(" ");

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[row, i] = int.Parse(s[i]);
            }
        }

        public string GetMainDiaognal() 
        {
            string diagonal = "";

            for (int  i = 0;  i < matrix.GetLength(0);  i++)
            {
                diagonal +=  matrix[i, i] + " "; 
            }

            return diagonal;
        }

        public int GetNegativeNumbers() 
        {
            int negativeNumbers = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        negativeNumbers++;
                    }
                }

            }

            return negativeNumbers;
        }

    }
}

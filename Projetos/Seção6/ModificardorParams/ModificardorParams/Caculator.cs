using System;
using System.Collections.Generic;
using System.Text;

namespace ModificardorParams
{
    class Caculator
    {
        public static int Sum(params int[] n)
        {
            int result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                result += n[i];
            }
            return result;
        }
    }
}

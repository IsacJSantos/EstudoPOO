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
        // both ref and out are code smell
        public static void Triple(ref int x) 
        {
            x *= 3;
        }
        public static void Triple(int x, out int result) 
        {
            x *= 3;
            result = x;
        }
    }
}

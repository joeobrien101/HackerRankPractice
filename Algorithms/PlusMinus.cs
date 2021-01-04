using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class PlusMinus
    {
        public static void plusMinus(int[] arr)
        {
            int PlusCount = 0;
            int MinusCount = 0;
            int ZeroCount = 0;

            foreach(int i in arr)
            {
                if (i > 0)
                {
                    PlusCount++;
                }
                else if (i < 0)
                {
                    MinusCount++;
                }
                else if (i == 0)
                {
                    ZeroCount++;
                }
            }

            Console.WriteLine((double)PlusCount / (double)arr.Length);
            Console.WriteLine((double)MinusCount / (double)arr.Length);
            Console.WriteLine((double)ZeroCount / (double)arr.Length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(int[] ar)
        {
            int max = 0;
            Array.Sort(ar);
            Array.Reverse(ar);

            foreach (int i in ar)
            {
                if (i == ar[0])
                {
                    max++;
                }
            }
            return max;
        }
    }
}

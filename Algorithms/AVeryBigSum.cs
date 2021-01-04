using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class AVeryBigSum
    {
        public static long aVeryBigSum(long[] ar)
        {
            long sum = 0;

            foreach(long num in ar)
            {
                sum = sum + num;
            }
            return sum;
        }
    }
}

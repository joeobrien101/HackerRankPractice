using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Arrays
{
    public static class NewYearChaos
    {

        public static void minimumBribes(int[] q)
        {
            int count = 0;

            for(int i=1; i< q.Length; i++)
            {
                if(q[i] > (i + 2) || q[i] < (i - 2))
                {
                    Console.WriteLine("Too chaotic");

                    return;
                }

                if(q[i]!= i)
                {
                    for (int j = 1; j < q.Length; j++)
                    {
                        if (j == i)
                        {
                            count = count + Math.Abs(i-j);
                        }
                    }
                }

                


            }
            Console.WriteLine(count);

        }
    }
}


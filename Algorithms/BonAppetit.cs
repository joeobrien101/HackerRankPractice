using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class BonAppetit
    {
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int annaSum = 0;

            for(int i=0; i<bill.Count; i++)
            {
                if (!(i == k))
                {
                    annaSum = annaSum + bill[i];
                }
            }

            int annaFinal = annaSum / 2;

            if (b > annaFinal)
            {
                Console.WriteLine(b-annaFinal);
            }
            else
            {
                Console.WriteLine("Bon Appetit");
            }
        }
    }
}

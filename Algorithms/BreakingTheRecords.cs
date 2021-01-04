using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class BreakingTheRecords
    {

        public static int[] breakingRecords(int[] scores)
        {
            int max = scores[0];
            int min = scores[0];

            int maxCount = 0;
            int minCount = 0;

            foreach(int score in scores)
            {
                if (score > max)
                {
                    max = score;
                    maxCount++;
                }
                if (score < min)
                {
                    min = score;
                    minCount++;
                }
            }
            return new int[] { maxCount, minCount };

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class CountingValleys
    {
        public static int countingValleys(int n, string s)
        {
            int valleyCount = 0;

            int level = 0;

            char[] trip = s.ToCharArray();

            foreach(char step in trip)
            {
                int tempLevel = level;

                if (step.Equals('U'))
                {
                    level++;
                }
                else if (step.Equals('D'))
                {
                    level--;
                }

                if(tempLevel == -1 && level == 0)
                {
                    valleyCount++;
                }

            }
            return valleyCount;
        }
    }
}

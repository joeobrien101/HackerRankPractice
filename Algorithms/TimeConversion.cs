using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class TimeConversion
    {
        public static string timeConversion(string s)
        {
            string NewHours;

            string[] split = s.Split(':');

            string hours = split[0];
            string minutes = split[1];
            string seconds = split[2].Substring(0,2);
            string time = split[2].Substring(2,2);

            if (time.Equals("PM") && Int32.Parse(hours)<12)
            {
                NewHours = (Int32.Parse(hours) + 12).ToString();
            }
            else if(time.Equals("AM") && Int32.Parse(hours) == 12)
            {
                NewHours = "00";
            }
            else
            {
                NewHours = hours;
            }
            return NewHours + ":" + minutes + ":" + seconds;
        }
    }
}

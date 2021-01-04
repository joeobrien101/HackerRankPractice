using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class GradingStudents
    {

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> FinalGrades = new List<int>();

            foreach(int grade in grades)
            {
                int remainder = grade % 5;
                if (grade < 38)
                {
                    FinalGrades.Add(grade);
                }
                else if(grade >= 38 && (grade % 5) == 3)
                {
                    FinalGrades.Add(grade + 2);
                }
                else if(grade >= 38 && (grade % 5) == 4)
                {
                    FinalGrades.Add(grade + 1);
                }
                else
                {
                    FinalGrades.Add(grade);
                }
            }
            return FinalGrades;
        }
    }
}

using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            int b = 0;

            foreach (var student in Students)
            {
                if (averageGrade > student.AverageGrade)
                {
                    b++;
                }
            }

            if (b >= 0.8 * Students.Count)
                return 'A';
            else if (b >= 0.6 * Students.Count)
                return 'B';
            else if (b >= 0.4 * Students.Count)
                return 'C';
            else if (b >= 0.2 * Students.Count)
                return 'D';
            else
                return 'F';
        }
    }
}

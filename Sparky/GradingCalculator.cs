using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class GradingCalculator
    {
        public int Score { get; set; }
        public int AttendancePercentage { get; set; }
        public string GetGrade()
        {
            if (Score > 90 && AttendancePercentage > 70)
                return "A";
            else
                if (Score > 80 && AttendancePercentage > 60)
                return "B";
            else
                    if (Score > 60 & AttendancePercentage > 60)
                return "C";
            else
                return "F";
        }
    }
}

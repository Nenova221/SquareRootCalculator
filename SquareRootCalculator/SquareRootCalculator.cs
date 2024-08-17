using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootCalculator
{
    public class SquareRootCalculator
    {
        public static double Calculate(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot calculate square root of a negative number.");
            }
            return Math.Sqrt(number);
        }
    }
}

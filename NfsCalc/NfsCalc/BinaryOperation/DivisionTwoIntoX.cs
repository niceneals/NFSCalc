using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class DivisionTwoIntoX : IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = 2 / first;
            return result;
        }
    }
}

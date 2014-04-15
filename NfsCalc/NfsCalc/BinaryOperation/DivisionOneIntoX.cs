using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryCalculator
{
    public class DivisionOneIntoX : IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = 1/first;
            return result;
        }
    }
}

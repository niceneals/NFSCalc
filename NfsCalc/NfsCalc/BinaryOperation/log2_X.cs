using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryCalculator
{
    public class log2_X : IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Pow(first, 0.5);
            return result;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryCalculator
{
    public class log2_X : IBinaryOperation
    {
        public string Calculate(double first)
        {
            double result = Math.Pow(first, 0.5);
            return result.ToString();
        }
    }
}



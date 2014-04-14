using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryCalculator
{
    public class powXE: IBinaryOperation
    {
        public string Calculate(double first)
        {
            double e = 2.7;
            double result = Math.Pow(first, e);
            return result.ToString();
        }
    }
}


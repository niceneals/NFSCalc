using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryCalculator
{
    public class Arccosinus : IBinaryOperation
    {
        public string Calculate(double first)
        {
            double result = Math.Acos(first);
            return result.ToString();
        }
    }
}

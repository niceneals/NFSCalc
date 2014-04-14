using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryCalculator
{
    public class Arcsinus : IBinaryOperation
    {
        public string Calculate(double first)
        {
            double result = Math.Asin(first);
            return result.ToString();
        }
    }
}

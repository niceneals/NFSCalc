using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryCalculator
{
    public class DegreesToRadians : IBinaryOperation
    {
        public string Calculate(double first)
        {
            double result = first*0.01745;
            return result.ToString();
        }
    }
}
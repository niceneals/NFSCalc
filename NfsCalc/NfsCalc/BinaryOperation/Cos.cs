using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class Cos:IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Cos(first);
            return result;
        }
    }
}

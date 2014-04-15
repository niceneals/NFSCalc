using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class Powm3 : IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Pow(first, 3);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class Powm2:IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Pow(first, 2);
            return result;
        }
    }
}

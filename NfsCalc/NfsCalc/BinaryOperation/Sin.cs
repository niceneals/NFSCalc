using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class Sin:IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Sin(first);
            return result;
        }
    }
}

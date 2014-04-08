using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class Sqrt:IBinaryOperation
    {
        public string Calculate(double first)
        {
            double result = Math.Sqrt(first);
            return result.ToString();
        }
    }
}

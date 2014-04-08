using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class log:IBinaryOperation
    {
        public string Calculate(double first)
        {
            double result = Math.Log10(first);
            return result.ToString();
        }
    }
}

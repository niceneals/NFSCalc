using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class tg:IBinaryOperation
    {
        public string Calculate(double first)
        {
            double result = Math.Tan(first);
            return result.ToString();
        }
    }
}

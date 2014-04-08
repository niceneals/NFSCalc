using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class Modul:IBinaryOperation
    {
        public string Calculate(double first)
        {
            double result = Math.Abs(first);
            return result.ToString();
        }
    }
}

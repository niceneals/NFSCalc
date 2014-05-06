using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class log:IBinaryOperation
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            double result = Math.Log10(first);
            return result;
        }
    }
}

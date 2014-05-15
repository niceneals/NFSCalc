using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class Sqrt3 : IBinaryOperation
    {
        public double Calculate(double firstArgument)
        {
            int negative = 1;
            if (firstArgument < 0)
            {
                negative = -1;
            }
            return negative * Math.Pow(Math.Abs(firstArgument), (double)1 / 3);
        }
    }
}

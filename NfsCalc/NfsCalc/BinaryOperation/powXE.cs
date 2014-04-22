using System;

namespace NfsCalc.BinaryOperation
{
    public class powXE: IBinaryOperation
    {
        public double Calculate(double first)
        {
            double e = 2.7;
            double result = Math.Pow(first, e);
            return result;
        }
    }
}


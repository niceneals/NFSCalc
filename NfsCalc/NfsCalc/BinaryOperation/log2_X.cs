using System;

namespace NfsCalc.BinaryOperation
{
    public class log2_X : IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Pow(first, 0.5);
            return result;
        }
    }
}



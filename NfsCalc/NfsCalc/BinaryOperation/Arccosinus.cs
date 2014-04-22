using System;

namespace NfsCalc.BinaryOperation
{
    public class Arccosinus : IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Acos(first);
            return result;
        }
    }
}

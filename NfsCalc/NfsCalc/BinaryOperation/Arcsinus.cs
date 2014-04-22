using System;

namespace NfsCalc.BinaryOperation
{
    public class Arcsinus : IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Asin(first);
            return result;
        }
    }
}

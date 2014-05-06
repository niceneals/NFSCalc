using System;

namespace NfsCalc.BinaryOperation
{
    public class log2_X : IBinaryOperation
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            double result = Math.Pow(first, 0.5);
            return result;
        }
    }
}



using System;

namespace NfsCalc.BinaryOperation
{
    public class powXE: IBinaryOperation
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            double e = 2.7;
            double result = Math.Pow(first, e);
            return result;
        }
    }
}


namespace NfsCalc.BinaryCalculator
{
    public class Adder:IBinaryCalculator
    {
        public double Calculate(double first, double second)
        {
            double result = first + second;
            return result;
        }

    }
}

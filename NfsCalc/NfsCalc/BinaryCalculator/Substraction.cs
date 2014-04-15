namespace NfsCalc.BinaryCalculator
{
    public class Substraction:IBinaryCalculator
    {
        public double Calculate(double first, double second)
        {
            double result = first - second;
            return result;

        }
    }
}

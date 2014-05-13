namespace NfsCalc.BinaryCalculator
{
    public class Division:IBinaryCalculator
    {
        public double Calculate(double first, double second)
        {
            double result = first / second;
            return result;

        }
    }
}

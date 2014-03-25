namespace NfsCalc.BinaryCalculator
{
    public class Substraction:IBinaryCalculator
    {
        public string Calculate(double first, double second)
        {
            double result = first - second;
            return result.ToString();

        }
    }
}

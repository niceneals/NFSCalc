namespace NfsCalc.BinaryCalculator
{
    public class Adder:IBinaryCalculator
    {
        public string Calculate(double first, double second)
        {
            double result = first + second;
            return result.ToString();
        }

    }
}

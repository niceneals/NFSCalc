namespace NfsCalc.BinaryOperation
{
    public class DivisionOneIntoX : IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = 1/first;
            return result;
        }
    }
}

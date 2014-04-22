namespace NfsCalc.BinaryOperation
{
    public class DegreesToRadians : IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = first*0.01745;
            return result;
        }
    }
}
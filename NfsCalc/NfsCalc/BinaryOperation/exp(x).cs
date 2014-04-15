using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public class exp_x_:IBinaryOperation
    {
        public double Calculate(double first)
        {
            double result = Math.Exp(first);
            return result;
        }
    }
}

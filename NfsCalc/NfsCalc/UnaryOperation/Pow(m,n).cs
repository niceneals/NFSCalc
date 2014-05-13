using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryCalculator
{
    public class Pow_m_n_:IBinaryCalculator
    {
        public double Calculate(double first,double second)
        {
            double result = Math.Pow(first, second);
            return result;
        }
    }
}

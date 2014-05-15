using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{

    public class PidivN : IBinaryOperation
    {
        public double Calculate(double first)
        {
            return 3.14159 / first;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
       public class Factorial:IBinaryOperation
    {
            public double Calculate(double first)
            {
             return (first == 0) ? 1 : first * Calculate(first - 1);
            }
        }
    }

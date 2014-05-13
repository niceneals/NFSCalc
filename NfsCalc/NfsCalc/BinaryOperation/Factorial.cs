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
                if (first <= 0)
                {
                    throw new Exception("Не может быть отрицательным и равным нулю");
                }
                double i;
                double result=1;
                for (i = first; i > 0; i--)
                {
                    result = result * i;
                }
                return result;
            }
        }
    }

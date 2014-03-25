using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryCalculator
{
    public static class BinaryCalculatorFactory
    {
        public static  IBinaryCalculator CreateBinaryCalculator(string name)
        {
            switch (name)
            {
                case "Adder":
                    return new Adder();
                case "Division":
                    return new Division();
                case "Substraction":
                    return new Substraction();
                case "Multiplayer":
                    return new Multiplayer();
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }

        }
        
            
        

    }
}

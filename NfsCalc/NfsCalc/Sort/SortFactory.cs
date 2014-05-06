using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.Sort
{
    public static class SortFactory
    {
        public static ISortOperation CreateBinaryCalculator(string name)
        {
            switch (name)
            {
                case "Gnom":
                    return new Gnom();
                case "BubbleSort":
                    return new BubbleSort();
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }

        }
        
            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfsCalc.BinaryOperation
{
    public static class  MonoFactory
    {
        public static IBinaryOperation CreateBinaryOperation(string name)
        {
            switch(name)
            {
                case "Sqrt": return new Sqrt();
                case "Sin" : return new Sin();
                case "log": return new log();
                case "tg": return new tg();
                case "Cos": return new Cos();
                case "Modul": return new Modul();
                case "Powm2": return new Powm2();
                case "exp(x)": return new exp_x_();
                case "ctg": return new ctg();
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }

        }
    }
}

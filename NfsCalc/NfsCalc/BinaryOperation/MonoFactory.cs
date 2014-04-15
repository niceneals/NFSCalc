using NfsCalc.BinaryCalculator;
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
                case "Powm3": return new Powm3();
                case "exp(x)": return new exp_x_();
                case "ctg": return new ctg();
                case "Arcsinus": return new Arcsinus();
                case "Arccosinus": return new Arccosinus();
                case "DegreesToRadians": return new DegreesToRadians();
                case "DivisionOneIntoX": return new DivisionOneIntoX();
                case "DivisionTwoIntoX": return new DivisionTwoIntoX();
                case "powXE": return new powXE();
                case "log2_X": return new log2_X();
                case "Factorial": return new Factorial();
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NfsCalc.BinaryCalculator;
using NfsCalc.BinaryOperation;

namespace NfsCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryCalculator("Adder");
        }

        private void button2_Click(object sender, EventArgs e)
        {
          BinaryCalculator("Substraction");
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            BinaryCalculator("Multiplayer");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           BinaryCalculator("Division");
        }
        private void BinaryCalculator(string name)
        {
            double firstArgument = Convert.ToDouble(Argument1.Text);
            double secondArgument = Convert.ToDouble(Argument2.Text);
            IBinaryCalculator calculator = BinaryCalculatorFactory.CreateBinaryCalculator(name);
            Result.Text = calculator.Calculate(firstArgument, secondArgument);
        }
        private void BinaryOperation(string name)
        {double firstArgument=Convert.ToDouble(Argument1.Text);
        IBinaryOperation calculator = MonoFactory.CreateBinaryOperation(name);
        Result.Text = calculator.Calculate(firstArgument);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BinaryOperation("Sqrt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BinaryOperation("Sin");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BinaryOperation("log");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BinaryCalculator("Pow(m,n)");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BinaryOperation("tg");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BinaryOperation("Cos");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BinaryOperation("Modul");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BinaryOperation("Powm2");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BinaryOperation("exp(x)");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BinaryOperation("ctg");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BinaryOperation("Arcsinus");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            BinaryOperation("Arccosinus");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            BinaryOperation("powXE");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            BinaryOperation("DegreesToRadians");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            BinaryOperation("DivisionOneIntoX");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            BinaryOperation("log2_X");
        }
    }
}

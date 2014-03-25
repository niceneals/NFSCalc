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
    }
}

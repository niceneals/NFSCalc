using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            double firstArgument = Convert.ToDouble(Argument1.Text);
            double secondArgument = Convert.ToDouble(Argument2.Text);
            Adder adder=new Adder();
            Result.Text = adder.Calculate(firstArgument,secondArgument);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(Argument1.Text);
            double secondArgument = Convert.ToDouble(Argument2.Text);
            Substraction adder=new Substraction();
            Result.Text = adder.Calculate(firstArgument, secondArgument);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(Argument1.Text);
            double secondArgument = Convert.ToDouble(Argument2.Text);
            Multiplayer adder = new Multiplayer();
            Result.Text = adder.Calculate(firstArgument, secondArgument);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(Argument1.Text);
            double secondArgument = Convert.ToDouble(Argument2.Text);
            devision adder = new devision();
            Result.Text = adder.Calculate(firstArgument, secondArgument);
        }
    }
}

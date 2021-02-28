using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_windowsform
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double result_num;
        string oper;
        string result;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case "+":
                    result_num = num1 + num2;
                    break;
                case "-":
                    result_num = num1 - num2;
                    break;
                case "*":
                    result_num = num1 * num2;
                    break;
                case "/":
                    result_num = num1 / num2;
                    break;

            }
            result = result_num.ToString();
            textBox3.Text = result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            oper = comboBox1.Text;
        }
    }
}

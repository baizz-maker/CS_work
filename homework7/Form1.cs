using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(graphics == null)
            {
                graphics = panel2.CreateGraphics();
               
            }
            drawCayleyTree(n, 200, 310, length, -Math.PI / 2);
        }

        private Graphics graphics ;
        string color = "default";
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        double length = 100;
        int n = 10;

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawline(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }

        void drawline(double x0, double y0, double x1, double y1)
        {
            switch (color)
            {
                case "blue":
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "red":
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "yellow":
                    graphics.DrawLine(Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "green":
                    graphics.DrawLine(Pens.Green , (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "black":
                    graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "default":
                    graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            color = (string)comboBox1.SelectedItem;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            per1 = double.Parse(textBox4.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            per2 = double.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            th1 = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            th2 = double.Parse(textBox3.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            length = double.Parse(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            n = int.Parse(textBox6.Text);
        }
    }
}

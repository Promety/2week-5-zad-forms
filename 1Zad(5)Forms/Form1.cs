using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Zad_5_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            try
            {
                if (x <= 1) throw new Exception();
                else return Math.Log(x - 1);
            }
            catch
            {
                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(numericUpDown1.Text);  
                double b = double.Parse(numericUpDown2.Text);
                double h = double.Parse(numericUpDown3.Text);
                for (double i = a; i <= b; i += h)
                    try
                    {
                        if (i == 1)
                        {
                            textBox1.Text += ($"y({i})=error") + Environment.NewLine;
                            continue;
                        }
                        textBox1.Text += ($"y({i})", Math.Round(f(i), 4)) + Environment.NewLine;
                    }
                    catch
                    {
                        textBox1.Text += ($"y({i})=error") + Environment.NewLine; 
                    }
            }
            catch (FormatException)
            {
                textBox1.Text = ("Неверный формат ввода данных");
            }
            catch
            {
                textBox1.Text = ("Неизвестная ошибка");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace задание_9
{
    public partial class Form1 :Form
    {
        
        public class Figure
        {
            public string objecd;
            double p, s;
            
        }
        public Form1 ()
        {
            InitializeComponent();
            groupBox1.Visible = false;  
        }
        Figure figure1 = new Figure();

        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
        { 
            figure1.objecd = comboBox1.Text;
            if (figure1.objecd == "Треугольник")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
            if (figure1.objecd == "Прямоугольник")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
            if (figure1.objecd == "Круг")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
            
            MessageBox.Show($"{figure1.objecd}");

        }

        private void button1_Click (object sender, EventArgs e)
        {
            Exercise_1 figure = new Exercise_1();
            
                if (figure1.objecd == "Треугольник")
                {
                    double h = Convert.ToDouble(textBox1.Text);
                    double o = Convert.ToDouble(textBox2.Text);
                    double r = Convert.ToDouble(textBox3.Text);
                    if (h > 0 && o > 0 && r > 0)
                    {
                        if (r < o)
                           MessageBox.Show(figure.Triangl(h, o, r));
                        else
                            MessageBox.Show("радиус окружности не должен быть больше основания");
                    }
                    else
                        MessageBox.Show("все значения должны быть положительны");

                }
                if (figure1.objecd == "Прямоугольник")
                {
                    double a = Convert.ToDouble(textBox4.Text);
                    double b = Convert.ToDouble(textBox5.Text);
                    if (a > 0 && b > 0)
                    MessageBox.Show(figure.Rectangl(a, b));
                    else
                        MessageBox.Show("все числа должны быть положительны");
                }
                if (figure1.objecd == "Круг")
                {
                    double r = Convert.ToDouble(textBox6.Text);
                    if (r > 0)
                    MessageBox.Show(figure.Circl(r));
                    else
                        MessageBox.Show("радиус должен быть положительным");
                }
            
           
        }

    }
}

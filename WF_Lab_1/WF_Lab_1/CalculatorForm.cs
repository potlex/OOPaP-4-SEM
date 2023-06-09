using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Lab_1
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private double buf;

        Calculator calculator = new Calculator();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 int varAI = Convert.ToInt32(textBox1.Text);
                 int varBI = Convert.ToInt32(textBox2.Text);

                 switch (comboBox1.Text)
                 {
                    case "+":
                        textBox3.Text = Convert.ToString(calculator.Sum(varAI, varBI));
                        break;
                    case "-":
                        textBox3.Text = Convert.ToString(calculator.Difference(varAI, varBI));
                        break;
                    case "x":
                        textBox3.Text = Convert.ToString(calculator.Multiplication(varAI, varBI));
                        break;
                    case "÷":
                        textBox3.Text = Convert.ToString(calculator.Division(varAI, varBI));
                        break;
                    case "%":
                        textBox3.Text = Convert.ToString(calculator.Whole(varAI, varBI));
                        break;
                    case "D":
                        textBox3.Text = Convert.ToString(calculator.Fraction(varAI, varBI));
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не все текстовые поля заполнены!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buf = Convert.ToDouble(textBox3.Text);
            bool varBD = calculator.Buf(buf);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(calculator.GetVar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}

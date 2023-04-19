using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_CALCULADORA
{
    public partial class FormCALCULO : Form
    {
        double valor1 = 0, valor2 = 0, resultado;
        string operacao = "";
        public FormCALCULO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox2.Text += "1";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox2.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox2.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox2.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox2.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            textBox2.Text += ".";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operacao = "sub";
            textBox1.Text = "";
            textBox2.Text += "  -  ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operacao = "multi";
            textBox1.Text = "";
            textBox2.Text += "  x  ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operacao = "divi";
            textBox1.Text = "";
            textBox2.Text += "  ÷  ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox1.Text);
            operacao = "soma";
            textBox1.Text = "";
            textBox2.Text += "  +  ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(textBox1.Text);

            if (operacao == "soma")
            {
                resultado = valor1 + valor2;
                textBox1.Text = "";
                textBox1.Text = resultado.ToString();
            }
            if (operacao == "sub")
            {
                resultado = valor1 - valor2;
                textBox1.Text = "";
                textBox1.Text = resultado.ToString();
            }
            if (operacao == "multi")
            {
                resultado = valor1 * valor2;
                textBox1.Text = "";
                textBox1.Text = resultado.ToString();
            }
            if (operacao == "divi")
            {
                resultado = valor1 / valor2;
                textBox1.Text = "";
                textBox1.Text = resultado.ToString();
            }

        }
    }
}

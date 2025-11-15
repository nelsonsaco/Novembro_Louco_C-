using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_C_
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op = textBox1.Text;
            double n1 = double.Parse(textBox2.Text);
            double n2 = double.Parse(textBox3.Text);
            double resultado = 0;

            if (op == "+")
            {
                resultado = n1 + n2;
            }
            else if (op == "-")
            {
                resultado = n1 - n2;
            }
            else if (op == "*")
            {
                resultado = n1 * n2;
            }
            else if (op == "/")
            {
                if (n2 != 0)
                    resultado = n1 / n2;
                else
                {
                    label4.Text = "Erro: divisão por zero!";
                    return;
                }
            }
            else
            {
                label4.Text = "Operação inválida!";
                return;
            }

            label4.Text = "Resultado: " + resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
        }
    }
}

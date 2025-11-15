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
    public partial class Form100 : Form
    {
        public Form100()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int num1) || !int.TryParse(textBox2.Text, out int num2))
            {
                MessageBox.Show("Digite números válidos!");
                return;
            }

            int Soma(int a, int b)
            {
                while (b != 0)
                {
                    int carry = a & b;
                    a = a ^ b;
                    b = carry << 1;
                }
                return a;
            }

            int resultado = Soma(num1, num2);
            string tipo = (resultado % 2 == 0) ? "Par" : "Ímpar";

            listBox1.Items.Add($"Resultado: {resultado} → {tipo}");
        }
    }
}

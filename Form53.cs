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
    public partial class Form53 : Form
    {
       
        public Form53()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(textBox1.Text, out n) || n < 0)
            {
                MessageBox.Show("Digite um número inteiro positivo.");
                return;
            }

            double valor_e = 1;
            double fatorial = 1;

            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
                valor_e += 1.0 / fatorial;
            }

            MessageBox.Show($"O valor de E é: {valor_e}");
        }
    }
}

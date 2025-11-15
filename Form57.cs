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
    public partial class Form57 : Form
    {
        public Form57()
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

            int i = 1;
            while ((i + 1) * (i + 1) <= n)
            {
                i++;
            }

            MessageBox.Show($"Maior quadrado menor ou igual a {n} é {i * i}");
        }
    }
}

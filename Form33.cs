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
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add($"Execução {i}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int contador = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    contador++;
                    listBox1.Items.Add($"Execução {contador}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n;
            if (int.TryParse(textBox1.Text, out n) && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    listBox1.Items.Add($"Execução {i}");
                }
            }
            else
            {
                MessageBox.Show("Digite um número válido maior que zero.");
            }
        }
    }
}

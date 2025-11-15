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
    public partial class Form55 : Form
    {
        public Form55()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            double a1, r;

            if (!int.TryParse(textBox1.Text, out n) || n <= 0)
            {
                MessageBox.Show("Digite um n válido.");
                return;
            }
            if (!double.TryParse(textBox2.Text, out a1) || !double.TryParse(textBox3.Text, out r))
            {
                MessageBox.Show("Digite a1 e r válidos.");
                return;
            }

            listBox1.Items.Clear();
            double soma = 0;
            double termo = a1;

            for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(termo);
                soma += termo;
                termo += r;
            }

            MessageBox.Show($"Soma dos termos: {soma}");
        }
    }
}

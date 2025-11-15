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
    public partial class Form98 : Form
    {
        public Form98()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string texto = textBox1.Text;
            string[] partes = texto.Split(',');

            if (partes.Length != 15)
            {
                MessageBox.Show("Digite exatamente 15 números separados por vírgula.");
                return;
            }

            int soma = 0;

            foreach (string p in partes)
            {
                if (int.TryParse(p.Trim(), out int num))
                    soma += num;
                else
                {
                    MessageBox.Show("Um dos valores não é número!");
                    return;
                }
            }

            listBox1.Items.Add($"Soma = {soma}");
        }
    }
}

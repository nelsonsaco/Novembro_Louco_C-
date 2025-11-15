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
    public partial class Form36 : Form
    {
        public Form36()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text;
            double salario;

            if (double.TryParse(textBox3.Text, out salario))
            {
                listBox1.Items.Add(nome + " - " + salario.ToString("F2"));
                textBox2.Clear();
                textBox3.Clear();
                textBox2.Focus();
            }
            else
            {
                MessageBox.Show("Digite um salário válido!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Nenhum funcionário cadastrado!");
                return;
            }

            double soma = 0;
            double maior = double.MinValue;
            double menor = double.MaxValue;

            foreach (var item in listBox1.Items)
            {
                string[] partes = item.ToString().Split('-');
                double salario = double.Parse(partes[1].Trim());

                soma += salario;

                if (salario > maior) maior = salario;
                if (salario < menor) menor = salario;
            }

            double media = soma / listBox1.Items.Count;

            label1.Text = "Média: " + media.ToString("F2");
            label2.Text = "Maior salário: " + maior.ToString("F2");
            label3.Text = "Menor salário: " + menor.ToString("F2");
        }
    }
}

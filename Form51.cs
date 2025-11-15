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
    public partial class Form51 : Form
    {
        public Form51()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            if (nome.ToLower() == "fim")
            {
                MessageBox.Show("Fim da entrada de dados.");
                return;
            }

            double salario;
            if (!double.TryParse(textBox2.Text, out salario))
            {
                MessageBox.Show("Digite um salário válido.");
                return;
            }

            listBox1.Items.Add($"{nome} - {salario}");
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Nenhum funcionário inserido.");
                return;
            }

            double soma = 0;
            double maior = double.MinValue;
            double menor = double.MaxValue;

            foreach (string item in listBox1.Items)
            {
                string[] partes = item.Split('-');
                double salario = double.Parse(partes[1].Trim());

                soma += salario;
                if (salario > maior) maior = salario;
                if (salario < menor) menor = salario;
            }

            double media = soma / listBox1.Items.Count;

            MessageBox.Show($"Média salarial: {media}\nMaior salário: {maior}\nMenor salário: {menor}");
        }
    }
}

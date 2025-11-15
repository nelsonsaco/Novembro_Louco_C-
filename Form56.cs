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
    public partial class Form56 : Form
    {
        public Form56()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade;
            double salario;
            string sexo = textBox2.Text.ToUpper();

            if (!int.TryParse(textBox1.Text, out idade))
            {
                MessageBox.Show("Idade inválida.");
                return;
            }
            if (idade < 0) return; // fim da entrada
            if (!double.TryParse(textBox3.Text, out salario))
            {
                MessageBox.Show("Salário inválido.");
                return;
            }
            if (sexo != "M" && sexo != "F")
            {
                MessageBox.Show("Sexo deve ser M ou F.");
                return;
            }

            listBox1.Items.Add($"{idade} - {sexo} - {salario}");
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Nenhum dado inserido.");
                return;
            }

            double somaSalarios = 0;
            int count = 0;
            int maiorIdade = int.MinValue;
            int menorIdade = int.MaxValue;
            int mulheres100 = 0;

            foreach (string item in listBox1.Items)
            {
                string[] partes = item.Split('-');
                int idade = int.Parse(partes[0].Trim());
                string sexo = partes[1].Trim();
                double salario = double.Parse(partes[2].Trim());

                somaSalarios += salario;
                count++;
                if (idade > maiorIdade) maiorIdade = idade;
                if (idade < menorIdade) menorIdade = idade;
                if (sexo == "F" && salario <= 100) mulheres100++;
            }

            double media = somaSalarios / count;
            MessageBox.Show($"Média salarial: {media}\nMaior idade: {maiorIdade}\nMenor idade: {menorIdade}\nMulheres com salário ≤100: {mulheres100}");

        }
    }
}

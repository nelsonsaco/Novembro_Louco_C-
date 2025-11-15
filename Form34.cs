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
    public partial class Form34 : Form
    {
        List<int> idades = new List<int>();
        List<double> alturas = new List<double>();
        public Form34()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int idade) && double.TryParse(textBox2.Text, out double altura))
            {
                idades.Add(idade);
                alturas.Add(altura);
                listBox1.Items.Add($"Aluno {idades.Count}: Idade = {idade}, Altura = {altura}");

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Digite valores válidos!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idades.Count == 0)
            {
                MessageBox.Show("Nenhum aluno adicionado!");
                return;
            }

            // Idade média dos alunos com altura < 1.70
            var alunosAlturaMenor170 = idades.Zip(alturas, (idade, altura) => new { idade, altura })
                                             .Where(a => a.altura < 1.70)
                                             .ToList();
            double idadeMedia = alunosAlturaMenor170.Count > 0 ? alunosAlturaMenor170.Average(a => a.idade) : 0;

            // Altura média dos alunos com idade > 20
            var alunosIdadeMaior20 = idades.Zip(alturas, (idade, altura) => new { idade, altura })
                                           .Where(a => a.idade > 20)
                                           .ToList();
            double alturaMedia = alunosIdadeMaior20.Count > 0 ? alunosIdadeMaior20.Average(a => a.altura) : 0;

            label1.Text = $"Idade média (<1.70m): {idadeMedia:F2}";
            label2.Text = $"Altura média (>20 anos): {alturaMedia:F2}";
        }
    }
}

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
    public partial class Form61 : Form
    {
        private int totalAndares;
        private int andarAtual = 1;
        private int pessoasNoElevador = 0;

        public Form61()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (andarAtual == 1)
            {
                if (!int.TryParse(textBox1.Text, out totalAndares) || totalAndares <= 0)
                {
                    MessageBox.Show("Digite um número válido de andares!");
                    return;
                }
            }

            int entrou, saiu;
            if (int.TryParse(textBox2.Text, out entrou) && int.TryParse(textBox3.Text, out saiu))
            {
                pessoasNoElevador += entrou - saiu;

                if (pessoasNoElevador > 15)
                {
                    int excesso = pessoasNoElevador - 15;
                    listBox1.Items.Add($"Andar {andarAtual}: EXCESSO DE PASSAGEIROS. Devem sair {excesso} pessoas.");
                    pessoasNoElevador = 15;
                }
                else if (pessoasNoElevador < 0)
                {
                    listBox1.Items.Add($"Andar {andarAtual}: Número de pessoas inválido (menos de 0). Corrigido para 0.");
                    pessoasNoElevador = 0;
                }
                else
                {
                    listBox1.Items.Add($"Andar {andarAtual}: Pessoas no elevador = {pessoasNoElevador}");
                }

                // Se for o último andar, mostrar quantas pessoas irão descer
                if (andarAtual == totalAndares)
                {
                    listBox1.Items.Add($"Último andar: {pessoasNoElevador} pessoas vão descer.");
                }

                andarAtual++;
                textBox2.Clear();
                textBox3.Clear();

                if (andarAtual > totalAndares)
                {
                    MessageBox.Show("Todos os andares processados!");
                }
            }
            else
            {
                MessageBox.Show("Digite números válidos de entrada e saída!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Total de andares processados: {totalAndares}");
            listBox1.Items.Add($"Pessoas no elevador ao final: {pessoasNoElevador}");
        }
    }
}

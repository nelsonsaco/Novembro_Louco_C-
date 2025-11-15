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
    public partial class Form23 : Form
    {
        List<int> vetor = new List<int>();
        int tamanhoMax = 20;
        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text.Trim(), out int valor))
            {
                if (valor <= 0)
                {
                    MessageBox.Show("Digite apenas números positivos!");
                    return;
                }

                if (vetor.Count < tamanhoMax)
                {
                    vetor.Add(valor);
                    listBox1.Items.Add(valor);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Vetor já está cheio!");
                }
            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vetor.Count == 0)
            {
                MessageBox.Show("O vetor está vazio!");
                return;
            }

            int maior = vetor[0];
            int posicao = 0;

            for (int i = 1; i < vetor.Count; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    posicao = i;
                }
            }

            label1.Text = $"Maior valor: {maior} na posição {posicao}";
        }
    }
}

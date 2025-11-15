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

    public partial class Form13 : Form
    {
        int[] numeros = new int[10];
        int indice = 0;
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (indice < 10)
            {
                int valor;
                if (int.TryParse(textBox1.Text, out valor))
                {
                    numeros[indice] = valor;
                    listBox1.Items.Add(valor);
                    indice++;
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Digite um número válido!");
                }
            }
            else
            {
                MessageBox.Show("Você já digitou 10 números!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int comparacao;
            if (int.TryParse(textBox2.Text, out comparacao))
            {
                int count = 0;
                for (int i = 0; i < indice; i++) // usar 'indice' para contar apenas números adicionados
                {
                    if (numeros[i] < comparacao)
                        count++;
                }
                MessageBox.Show($"Existem {count} números menores que {comparacao}");
            }
            else
            {
                MessageBox.Show("Digite um número válido para comparação!");
            }
        }
    }
}
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
    public partial class Form37 : Form
    {
        public Form37()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrada = textBox1.Text;
            string[] partes = entrada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numeros = new int[partes.Length];

            for (int i = 0; i < partes.Length; i++)
            {
                numeros[i] = int.Parse(partes[i]);
            }

            int soma = 0;
            int maior = numeros[0];
            int menor = numeros[0];

            foreach (int n in numeros)
            {
                soma += n;
                if (n > maior) maior = n;
                if (n < menor) menor = n;
            }

            double media = soma / (double)numeros.Length;

            label1.Text = "Média: " + media;
            label2.Text = "Maior: " + maior;
            label3.Text = "Menor: " + menor;
        }
    }
}

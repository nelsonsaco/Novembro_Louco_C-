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
    public partial class Form68 : Form
    {
        public Form68()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text.Trim();
            string palavraProcurada = textBox2.Text.Trim();
            listBox1.Items.Clear();

            if (string.IsNullOrEmpty(palavraProcurada))
            {
                MessageBox.Show("Digite uma palavra para procurar!");
                return;
            }

            string[] palavras = frase.Split(' '); // split simples
            for (int i = 0; i < palavras.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(palavras[i]) &&
                    palavras[i].Equals(palavraProcurada, StringComparison.OrdinalIgnoreCase))
                {
                    listBox1.Items.Add($"Palavra: {palavras[i]} - Índice: {i}");
                }
            }

            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add("Palavra não encontrada!");
            }
        }
    }
}

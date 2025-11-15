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
    public partial class Form70 : Form
    {
        public Form70()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text.Trim();
            int totalCaracteres = texto.Length;

            
            string[] palavras = texto.Split(' ');
            int totalPalavras = 0;
            foreach (string palavra in palavras)
            {
                if (!string.IsNullOrWhiteSpace(palavra))
                    totalPalavras++;
            }

            listBox1.Items.Clear();
            listBox1.Items.Add("Total de caracteres: " + totalCaracteres);
            listBox1.Items.Add("Total de palavras: " + totalPalavras);
        }
    }
}

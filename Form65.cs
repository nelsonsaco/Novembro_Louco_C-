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
    public partial class Form65 : Form
    {
        public Form65()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text;
            listBox1.Items.Clear();

            // Forma compatível para qualquer versão
            string[] palavras = frase.Split(' '); // apenas split simples
            foreach (string palavra in palavras)
            {
                if (!string.IsNullOrWhiteSpace(palavra)) // ignora strings vazias
                {
                    listBox1.Items.Add(new string('*', palavra.Length));
                }
            }
        }
    }
}

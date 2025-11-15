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
    public partial class Form78 : Form
    {
        public Form78()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text;
            string palavraAntiga = textBox2.Text;
            string palavraNova = textBox3.Text;

            int lastIndex = frase.LastIndexOf(palavraAntiga);
            if (lastIndex != -1)
            {
                string resultado = frase.Substring(0, lastIndex) + palavraNova + frase.Substring(lastIndex + palavraAntiga.Length);
                listBox1.Items.Clear();
                listBox1.Items.Add(resultado);
            }
            else
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Palavra antiga não encontrada.");
            }
        }
    }
}

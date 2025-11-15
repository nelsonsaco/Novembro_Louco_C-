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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p1 = textBox1.Text.Trim();
            string p2 = textBox2.Text.Trim();

            listBox1.Items.Clear();

            // a) Verificar se são iguais (ignora maiúsc/minúsc)
            if (p1.Equals(p2, StringComparison.OrdinalIgnoreCase))
            {
                listBox1.Items.Add("As palavras são iguais.");
            }
            else
            {
                listBox1.Items.Add("As palavras são diferentes.");

                // b) Qual é maior?
                if (p1.Length > p2.Length)
                {
                    listBox1.Items.Add("A palavra 1 é maior.");
                }
                else if (p2.Length > p1.Length)
                {
                    listBox1.Items.Add("A palavra 2 é maior.");
                }
                else
                {
                    listBox1.Items.Add("As duas palavras têm o mesmo tamanho.");
                }
            }

            // c) Verificar substring (compatível com versões mais antigas do .NET)
            if (p1.IndexOf(p2, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                listBox1.Items.Add("A palavra 2 É uma substring da palavra 1.");
            }
            else
            {
                listBox1.Items.Add("A palavra 2 NÃO é substring da palavra 1.");
            }
        }
    }
}

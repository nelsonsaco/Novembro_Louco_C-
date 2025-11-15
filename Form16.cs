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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();

            if (nome == "")
            {
                MessageBox.Show("Digite um nome.");
                return;
            }

            listBox1.Items.Add(nome);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Copiar itens do ListBox para uma lista normal
            List<string> nomes = new List<string>();

            foreach (var item in listBox1.Items)
            {
                nomes.Add(item.ToString());
            }

            // Ordenar de forma segura (sem métodos modernos)
            nomes.Sort(StringComparer.OrdinalIgnoreCase);

            // Atualizar o ListBox
            listBox1.Items.Clear();
            foreach (string n in nomes)
            {
                listBox1.Items.Add(n);
            }
        }
    }
}

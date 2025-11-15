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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        List<string> nomes = new List<string>();
        int maxNomes = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(nome))
                return;

            if (nomes.Count < maxNomes)
            {
                nomes.Add(nome);
                listBox1.Items.Add(nome);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Já foram adicionados 10 nomes.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(nome))
                return;

            if (nomes.Contains(nome, StringComparer.OrdinalIgnoreCase))
                label1.Text = "ACHEI";
            else
                label1.Text = "NÃO ACHEI";
        }
    }
}

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
    public partial class Form85 : Form
    {
        Dictionary<string, int> nomesContagem = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        public Form85()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(nome)) return;

            if (nomesContagem.ContainsKey(nome))
                nomesContagem[nome]++;
            else
                nomesContagem[nome] = 1;

            listBox1.Items.Clear();
            foreach (var item in nomesContagem)
                listBox1.Items.Add($"{item.Key} - {item.Value}");

            // Encontrar mais e menos inseridos
            var max = nomesContagem.Aggregate((l, r) => l.Value > r.Value ? l : r);
            var min = nomesContagem.Aggregate((l, r) => l.Value < r.Value ? l : r);

            label1.Text = $"Mais inserido: {max.Key} ({max.Value}x)";
            label2.Text = $"Menos inserido: {min.Key} ({min.Value}x)";

        }
    }
}

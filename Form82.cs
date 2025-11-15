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
    public partial class Form82 : Form
    {
        public Form82()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n;
            if (!int.TryParse(textBox1.Text, out n) || n <= 0)
            {
                listBox1.Items.Add("Número de linhas inválido.");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                listBox1.Items.Add("Escolha o tipo de figura.");
                return;
            }

            string tipo = comboBox1.SelectedItem.ToString();

            if (tipo == "Triângulo")
            {
                for (int i = 1; i <= n; i++)
                {
                    string linha = new string('%', i);
                    listBox1.Items.Add(linha);
                }
            }
            else if (tipo == "Losango")
            {
                // parte superior
                for (int i = 1; i <= n; i++)
                {
                    string linha = new string(' ', n - i) + new string('%', 2 * i - 1);
                    listBox1.Items.Add(linha);
                }
                // parte inferior
                for (int i = n - 1; i >= 1; i--)
                {
                    string linha = new string(' ', n - i) + new string('%', 2 * i - 1);
                    listBox1.Items.Add(linha);
                }
            }
        }
    }
}

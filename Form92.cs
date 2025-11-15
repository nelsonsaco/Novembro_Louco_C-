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
    public partial class Form92 : Form
    {
        public Form92()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!int.TryParse(textBox1.Text, out int numero))
            {
                MessageBox.Show("Digite um número válido!");
                return;
            }

            bool encontrado = false;
            for (int i = 1; i <= numero; i++)
            {
                int produto = i * (i + 1) * (i + 2);
                if (produto == numero)
                {
                    listBox1.Items.Add($"{numero} é triangular: {i} x {i + 1} x {i + 2} = {numero}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                listBox1.Items.Add($"{numero} não é triangular.");
        }
    }
}

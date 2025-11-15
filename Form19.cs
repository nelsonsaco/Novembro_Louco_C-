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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int inicio = int.Parse(textBox2.Text);
            int fim = int.Parse(textBox3.Text);

            if (fim < inicio)
            {
                MessageBox.Show("O valor final não pode ser menor que o inicial.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBox1.Items.Clear();

            listBox1.Items.Add($"Vou montar a tabuada de {numero} começando em {inicio} e terminando em {fim}:");

            for (int i = inicio; i <= fim; i++)
            {
                int resultado = numero * i;
                listBox1.Items.Add($"{numero} X {i} = {resultado}");
            }
        }
    }
}

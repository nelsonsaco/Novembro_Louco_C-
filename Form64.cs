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
    public partial class Form64 : Form
    {
        private double totalGanho = 0;

        public Form64()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            if (!int.TryParse(textBox2.Text, out int diarias) || diarias <= 0)
            {
                MessageBox.Show("Digite um número válido de diárias!");
                return;
            }

            double taxaServico = 0;
            if (diarias < 15) taxaServico = 4.0;
            else if (diarias == 15) taxaServico = 3.6;
            else taxaServico = 3.0;

            double total = diarias * (50 + taxaServico);
            totalGanho += total;

            listBox1.Items.Add($"{nome}: Total da conta = R$ {total:F2}");
            label3.Text = $"Total ganho pelo hotel: R$ {totalGanho:F2}";
        }
    }
}

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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox1.Text);

            
            listBox1.Items.Add(valor);

            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double soma = 0;
            int count = listBox1.Items.Count;

            foreach (var item in listBox1.Items)
            {
                soma += Convert.ToDouble(item);
            }

            double media = 0;
            if (count > 0)
            {
                media = soma / count;
            }

            MessageBox.Show("Quantidade de valores: " + count + "\nMédia: " + media.ToString("F1"));
        }
    }
}

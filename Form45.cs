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
    public partial class Form45 : Form
    {
        private List<int> numerosParImpar = new List<int>();
        public Form45()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(textBox1.Text, out valor))
            {
                if (valor == 9999)
                {
                    int pares = numerosParImpar.Count(x => x % 2 == 0);
                    int impares = numerosParImpar.Count - pares;
                    label1.Text = $"Pares: {pares} | Ímpares: {impares}";
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    numerosParImpar.Add(valor);
                    listBox1.Items.Add(valor);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}

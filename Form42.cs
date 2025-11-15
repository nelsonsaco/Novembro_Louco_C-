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
    public partial class Form42 : Form
    {
        private List<int> numeros = new List<int>();

        public Form42()
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
                    int soma = numeros.Sum();
                    double media = numeros.Count > 0 ? (double)soma / numeros.Count : 0;
                    label1.Text = $"Soma: {soma} | Média: {media:F2}";
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    numeros.Add(valor);
                    listBox1.Items.Add(valor);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }

        }
    }
}

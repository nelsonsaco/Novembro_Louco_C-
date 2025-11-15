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
    public partial class Form11 : Form
    {

        List<double> valores = new List<double>();
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor;
            if (double.TryParse(textBox1.Text, out valor))
            {
                if (valor < 0)
                {
                    if (valores.Count > 0)
                    {
                        double media = 0;
                        foreach (double v in valores)
                        {
                            media += v;
                        }
                        media /= valores.Count;
                        label2.Text = "Média: " + media.ToString("F2");
                    }
                    else
                    {
                        label2.Text = "Nenhum valor positivo foi informado.";
                    }
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    valores.Add(valor);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite um número válido!");
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}

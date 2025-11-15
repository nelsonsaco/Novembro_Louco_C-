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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int SomarDigitos(string texto)
        {
            int soma = 0;

            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    soma += int.Parse(c.ToString());
                }
            }

            return soma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrada = textBox1.Text;

            int resultado = SomarDigitos(entrada);

            label1.Text = "Soma: " + resultado;
        }
    }
}

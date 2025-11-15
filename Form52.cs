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
    public partial class Form52 : Form
    {
        public Form52()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero;
            if (!double.TryParse(textBox1.Text, out numero))
            {
                MessageBox.Show("Digite um número válido.");
                return;
            }

            int contador = 0;
            while (numero >= 1)
            {
                numero /= 2;
                contador++;
            }

            MessageBox.Show($"Resultado final: {numero}\nQuantidade de divisões: {contador}");
        }
    }
}

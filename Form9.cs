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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = "";

            for (int n = 1000; n <= 9999; n++)
            {
                int primeiraMetade = n / 100; // pega os dois primeiros dígitos
                int segundaMetade = n % 100;   // pega os dois últimos dígitos

                int soma = primeiraMetade + segundaMetade;

                if (soma * soma == n)
                {
                    resultado += n + " ";
                }
            }

            label1.Text = resultado;
        }
    }
}

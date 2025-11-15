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
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int somaPositivos = 0;
            int qtdNegativos = 0;

            
            int[] valores = new int[50] { -2, 5, 10, -1, 0, 3, -7, 4, 6, -3, 1, -5, 8, 9, -4, 2, -6, 7, -8, 11,
                                  12, -9, 13, -10, 14, -11, 15, -12, 16, -13, 17, -14, 18, -15, 19, -16, 20, -17, 21, -18,
                                  22, -19, 23, -20, 24, -21, 25, -22, 26, -23 };

            foreach (int valor in valores)
            {
                if (valor > 0)
                    somaPositivos += valor;
                else if (valor < 0)
                    qtdNegativos++;
            }

            label1.Text = "Soma dos positivos: " + somaPositivos;
            label2.Text = "Quantidade de negativos: " + qtdNegativos;
        }
    }
}

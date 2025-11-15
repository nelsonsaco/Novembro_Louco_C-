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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 15;
            int a = 0;
            int b = 1;
            string resultado = a + " " + b + " ";

            for (int i = 2; i < n; i++)
            {
                int proximo = a + b;
                resultado += proximo + " ";
                a = b;
                b = proximo;
            }

            label1.Text = resultado;
        }
    }
}

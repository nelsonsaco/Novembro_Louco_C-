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
    public partial class Form40 : Form
    {
        public Form40()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int resultado = 0;

            for (int i = 0; i < Math.Abs(b); i++)
            {
                resultado += Math.Abs(a);
            }

            if ((a < 0 && b > 0) || (a > 0 && b < 0))
                resultado = -resultado;

            label1.Text = "Resultado: " + resultado;
        }
    }
}

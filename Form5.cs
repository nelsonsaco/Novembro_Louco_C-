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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            double maior = Math.Max(a, Math.Max(b, c));
            double menor = Math.Min(a, Math.Min(b, c));
            double meio = (a + b + c) - (maior + menor);

            label4.Text =
                "Maior: " + maior +
                "\nMenor: " + menor +
                "\nIntermediário: " + meio;
        }
    }
}

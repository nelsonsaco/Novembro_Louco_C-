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
    public partial class Form39 : Form
    {
        public Form39()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double massa = double.Parse(textBox1.Text);
            double tempo = 0;

            while (massa >= 0.05)
            {
                massa /= 2;
                tempo += 50;
            }

            label1.Text = "Tempo necessário: " + tempo + " segundos";
        }
    }
}

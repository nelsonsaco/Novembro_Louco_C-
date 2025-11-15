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
    public partial class Form38 : Form
    {
        public Form38()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            long fatorial = 1;

            for (int i = 2; i <= n; i++)
            {
                fatorial *= i;
            }

            label1.Text = "Fatorial: " + fatorial;
        }
    }
}

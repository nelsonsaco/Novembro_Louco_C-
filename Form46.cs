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
    public partial class Form46 : Form
    {
        public Form46()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
            int soma = 0;

            do
            {
                soma += x;
                x++;
            }
            while (x <= 10);

            label1.Text = $"Soma = {soma}";
        }
    }
}

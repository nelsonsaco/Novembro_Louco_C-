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
    public partial class Form48 : Form
    {
        public Form48()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int termo = 3;
            int soma = 0;

            while (termo <= 6561)
            {
                soma += termo;
                termo *= 3;
            }

            label1.Text = $"Soma = {soma}";
        }
    }
}

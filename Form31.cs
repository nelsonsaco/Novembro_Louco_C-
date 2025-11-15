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
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
            int soma = 0;

            for (int i = 84; i >= 32; i -= 2) 
            {
                listBox1.Items.Add(i);
                soma += i;
            }

            label1.Text = "Soma: " + soma;
        }
    }
}

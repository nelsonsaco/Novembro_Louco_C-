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
    public partial class Form94 : Form
    {
        public Form94()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!int.TryParse(textBox1.Text, out int numero))
            {
                MessageBox.Show("Digite um número válido!");
                return;
            }

            for (int i = numero; i >= 2; i -= 2)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}

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
    public partial class Form58 : Form
    {
        public Form58()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;
            if (int.TryParse(textBox1.Text, out N) && N >= 2)
            {
                listBox1.Items.Clear();
                long a = 0, b = 1;
                listBox1.Items.Add(a);
                listBox1.Items.Add(b);

                for (int i = 3; i <= N; i++)
                {
                    long c = a + b;
                    listBox1.Items.Add(c);
                    a = b;
                    b = c;
                }
            }
            else
            {
                MessageBox.Show("Digite um número válido maior ou igual a 2!");
            }
        }
    }
}

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
    public partial class Form41 : Form
    {
        public Form41()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a = 0, b = 1;
            listBox1.Items.Add(a);
            listBox1.Items.Add(b);
            for (int i = 2; i < 20; i++)
            {
                int c = a + b;
                listBox1.Items.Add(c);
                a = b;
                b = c;
            }
        }
    }
}

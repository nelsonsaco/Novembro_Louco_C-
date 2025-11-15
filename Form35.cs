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
    public partial class Form35 : Form
    {
        public Form35()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            listBox1.Items.Clear();

            for (int i = 1; i <= 13; i++)
            {
                listBox1.Items.Add($"{n} x {i} = {n * i}");
            }
        }
    }
}

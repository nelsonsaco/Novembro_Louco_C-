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
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ulong grãos = 1; 
            ulong total = 1;
            listBox1.Items.Add("Casa 1: 1");

            for (int i = 2; i <= 64; i++)
            {
                grãos *= 2;
                total += grãos;
                listBox1.Items.Add($"Casa {i}: {grãos}");
            }

            label1.Text = "Total de grãos: " + total;
        }
    }
}

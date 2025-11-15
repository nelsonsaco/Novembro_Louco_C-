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
    public partial class Form63 : Form
    {
        public Form63()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Número  Quadrado  Cubo");

            for (int i = 0; i <= 10; i++)
            {
                int quadrado = i * i;
                int cubo = i * i * i;
                listBox1.Items.Add($"{i,6} {quadrado,9} {cubo,6}");
            }
        }
    }
}

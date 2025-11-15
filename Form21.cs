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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                string linha = i + ", ";
                for (int j = 1; j <= 10; j++)
                {
                    linha += j + " ";
                }
                listBox1.Items.Add(linha.Trim());
            }
        }
    }
}

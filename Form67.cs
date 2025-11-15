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
    public partial class Form67 : Form
    {
        public Form67()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            listBox1.Items.Clear();

            for (int i = 1; i <= 10000; i++)
            {
                if (i % 5 == 0) count++;
            }

            double perc = count * 100.0 / 10000;
            listBox1.Items.Add($"Números múltiplos de 5: {count}");
            listBox1.Items.Add($"Percentagem: {perc:F2}%");
        }
    }
}

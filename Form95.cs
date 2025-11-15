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
    public partial class Form95 : Form
    {
        public Form95()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!int.TryParse(textBox1.Text, out int n) || n < 1)
            {
                MessageBox.Show("Digite um número válido maior que 0!");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                long fat = 1;
                for (int j = 2; j <= i; j++)
                    fat *= j;
                listBox1.Items.Add($"{i}! = {fat}");
            }
        }
    }
}

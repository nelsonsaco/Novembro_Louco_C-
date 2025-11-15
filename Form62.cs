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
    public partial class Form62 : Form
    {
        public Form62()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int produto = 1;
            listBox1.Items.Clear();

            for (int i = 1; i <= 15; i += 2)
            {
                produto *= i;
            }

            listBox1.Items.Add($"Produto dos ímpares de 1 a 15 = {produto}");
        }
    }
}

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
    public partial class Form47 : Form
    {
        public Form47()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] partes = textBox1.Text.Split(' ');
            int total = partes.Length;

            int menos10 = 0;
            int entre10e15 = 0;
            int mais15 = 0;

            foreach (string p in partes)
            {
                int v = int.Parse(p);

                if (v < 10) menos10++;
                else if (v <= 15) entre10e15++;
                else mais15++;
            }

            double a = (menos10 * 100.0) / total;
            double b = (entre10e15 * 100.0) / total;
            double c = (mais15 * 100.0) / total;

            label1.Text = $"A: {a:F0}%  B: {b:F0}%  C: {c:F0}%";
        }
    }
}

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int z = int.Parse(textBox3.Text);

            // Verifica se forma triângulo
            if (x < y + z && y < x + z && z < x + y)
            {
                // Triângulo Equilátero
                if (x == y && y == z)
                {
                    label4.Text = "Triângulo Equilátero";
                }
                // Triângulo Isósceles
                else if (x == y || x == z || y == z)
                {
                    label4.Text = "Triângulo Isósceles";
                }
                // Triângulo Escaleno
                else
                {
                    label4.Text = "Triângulo Escaleno";
                }
            }
            else
            {
                label4.Text = "Não forma um triângulo";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}

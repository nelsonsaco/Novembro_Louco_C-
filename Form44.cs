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
    public partial class Form44 : Form
    {
        public Form44()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int quociente = 0;
            int restante = num1;

            while (restante >= num2)
            {
                restante -= num2;
                quociente++;
            }

            label1.Text = $"Quociente: {quociente} | Resto: {restante}";
        }
    }
}

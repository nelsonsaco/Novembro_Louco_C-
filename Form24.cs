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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text.Trim(), out int baseTri))
            {
                if (baseTri < 5 || baseTri > 15)
                {
                    MessageBox.Show("Digite um valor entre 5 e 15!");
                    return;
                }

                label2.Text = "";
                for (int i = 1; i <= baseTri; i += 2)
                {
                    int espacos = (baseTri - i) / 2;
                    string linha = new string(' ', espacos) + new string('#', i);
                    label2.Text += linha + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }
        }
    }
}

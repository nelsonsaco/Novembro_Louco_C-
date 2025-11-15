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
    public partial class Form79 : Form
    {
        public Form79()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text.Trim();
            int count = 0;

            if (!string.IsNullOrEmpty(frase))
            {
                string[] palavras = frase.Split(' ');
                foreach (string palavra in palavras)
                {
                    if (palavra.Trim() != "")
                        count++;
                }
            }

            listBox1.Items.Clear();
            listBox1.Items.Add("Número de palavras: " + count);
        }
    }
}

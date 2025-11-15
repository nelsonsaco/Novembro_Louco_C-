using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicios_C_
{
    public partial class Form86 : Form
    {
        public Form86()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(frase)) return;

            string[] palavras = frase.Split(' ');
            string resultado = "";

            foreach (var palavra in palavras)
                resultado += palavra + " " + palavra + " ";

            listBox1.Items.Clear();
            listBox1.Items.Add(resultado.Trim());
        }
    }
}

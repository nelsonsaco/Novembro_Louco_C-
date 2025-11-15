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
    public partial class Form75 : Form
    {
        public Form75()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCompleto = textBox1.Text.Trim();
            string[] palavras = nomeCompleto.Split(' ');
            string sobrenome = palavras[palavras.Length - 1];

            listBox1.Items.Clear();
            listBox1.Items.Add("Sobrenome: " + sobrenome);
        }
    }
}

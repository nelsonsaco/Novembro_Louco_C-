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
    public partial class Form71 : Form
    {
        public Form71()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim().ToUpper();
            char[] letras = nome.ToCharArray();
            Array.Reverse(letras);
            string nomeInvertido = new string(letras);

            listBox1.Items.Clear();
            listBox1.Items.Add(nomeInvertido);
        }
    }
}

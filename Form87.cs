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
    public partial class Form87 : Form
    {
        public Form87()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text;
            string resultado = "";

            foreach (char c in frase)
                resultado += new string(c, 2);

            listBox1.Items.Clear();
            listBox1.Items.Add(resultado);
        }
    }
}

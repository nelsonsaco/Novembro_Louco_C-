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
    public partial class Form101 : Form
    {
        public Form101()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string semEspacos = texto.Replace(" ", "");
            MessageBox.Show($"Texto sem espaços:\n{semEspacos}");
        }
    }
}

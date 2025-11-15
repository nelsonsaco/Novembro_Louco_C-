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
    public partial class Form76 : Form
    {
        public Form76()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            int contador = 0;

            foreach (char c in texto)
            {
                if (c == ' ')
                    contador++;
            }

            listBox1.Items.Clear();
            listBox1.Items.Add("Número de espaços em branco: " + contador);
        }
    }
}

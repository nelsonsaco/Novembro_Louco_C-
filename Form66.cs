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
    public partial class Form66 : Form
    {
        public Form66()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text;
            listBox1.Items.Clear();
            string resultado = "";

            foreach (char c in frase)
            {
                if ("AEIOUaeiou".Contains(c) || !char.IsLetter(c))
                    resultado += c;
                else
                    resultado += "&";
            }

            listBox1.Items.Add(resultado);
        }
    }
}

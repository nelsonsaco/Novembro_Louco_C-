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
    public partial class Form91 : Form
    {
        public Form91()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string frase = textBox1.Text;
            string resultado = "";

            foreach (char c in frase)
            {
                if ("aeiouAEIOU".Contains(c))
                    resultado += "!";
                else if (char.IsLetter(c))
                    resultado += char.ToUpper(c);
                else
                    resultado += c; // mantém números e símbolos
            }

        }
    }
}

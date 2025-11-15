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
    public partial class Form73 : Form
    {
        public Form73()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string textoLimpo = "";

            foreach (char c in texto)
            {
                if (char.IsLetterOrDigit(c))
                    textoLimpo += char.ToLower(c);
            }

            string textoInvertido = "";
            for (int i = textoLimpo.Length - 1; i >= 0; i--)
                textoInvertido += textoLimpo[i];

            listBox1.Items.Clear();
            listBox1.Items.Add("Texto digitado: " + texto);
            if (textoLimpo == textoInvertido)
                listBox1.Items.Add("É um palíndromo!");
            else
                listBox1.Items.Add("Não é um palíndromo.");
        }
    }
}

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
    public partial class Form80 : Form
    {
        public Form80()
        {
            InitializeComponent();
        }
        private string SubstituirEspacos(string frase)
        {
            string novaFrase = "";
            foreach (char c in frase)
            {
                if (c == ' ')
                    novaFrase += "#";
                else
                    novaFrase += c;
            }
            return novaFrase;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text;
            string resultado = SubstituirEspacos(frase);
            listBox1.Items.Clear();
            listBox1.Items.Add(resultado);
        }

        
    }
}

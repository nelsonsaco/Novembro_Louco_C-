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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            string nome = textBox1.Text.Trim();
            string[] partes = nome.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string resultado = "";

            for (int i = 0; i < partes.Length; i++)
            {
                string p = partes[i];

               
                if (p.Length <= 2)
                {
                    resultado += p + " ";
                }
                else
                {
                    resultado += p[0].ToString().ToUpper() + ". ";
                }
            }

            MessageBox.Show("Abreviatura: " + resultado.Trim());
        }
    }
}

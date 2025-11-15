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
    public partial class Form69 : Form
    {
        public Form69()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            string[] partes = nome.Split(' ');
            string[] ignorar = { "e", "do", "da", "dos", "das", "de", "di", "du" };
            string iniciais = "";

            foreach (string palavra in partes)
            {
                string p = palavra.Trim();
                if (p != "" && Array.IndexOf(ignorar, p.ToLower()) == -1)
                {
                    iniciais += char.ToUpper(p[0]);
                }
            }

            label1.Text = iniciais;
        }
    }
}

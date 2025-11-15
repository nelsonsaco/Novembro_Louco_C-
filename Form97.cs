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
    public partial class Form97 : Form
    {
        public Form97()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;

            string txt = richTextBox1.Text;

            int inicio = 0;

            while ((inicio = txt.IndexOf("/*", inicio)) != -1)
            {
                int fim = txt.IndexOf("*/", inicio + 2);
                if (fim == -1) break;

                richTextBox1.Select(inicio, (fim + 2) - inicio);
                richTextBox1.SelectionColor = Color.Red;

                inicio = fim + 2;
            }
        }
    }
}

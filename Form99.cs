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
    public partial class Form99 : Form
    {
        public Form99()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); 

            for (int i = 1; i <= 20; i++) 
            {
                if (i % 2 == 0)                 {
                    richTextBox1.SelectionColor = Color.Green;
                }
                else 
                {
                    richTextBox1.SelectionColor = Color.Red;
                }

                richTextBox1.AppendText(i.ToString() + " ");
            }

        }

       
    }
}

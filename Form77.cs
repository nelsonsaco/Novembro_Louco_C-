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
    public partial class Form77 : Form
    {
        public Form77()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palavra = textBox1.Text.Trim();
            if (palavra == "") return;

            listBox1.Items.Add($"Primeira: {palavra[0]}, Última: {palavra[palavra.Length - 1]}");

            textBox1.Clear();
            textBox1.Focus();

            
            if (palavra[0] == 'f' || palavra[0] == 'F')
            {
                MessageBox.Show("Palavra final encontrada: " + palavra);
                button1.Enabled = false; // desabilita o botão
            }
        }
    }
}

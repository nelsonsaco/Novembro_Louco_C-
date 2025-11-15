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
    public partial class Form81 : Form
    {
        public Form81()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text.Replace(" ", "").ToLower();
            string s2 = textBox2.Text.Replace(" ", "").ToLower();

            char[] arr = s2.ToCharArray();
            Array.Reverse(arr);
            string s2Invertida = new string(arr);

            listBox1.Items.Clear();
            if (s1 == s2Invertida)
                listBox1.Items.Add("São palíndromos mútuos!");
            else
                listBox1.Items.Add("Não são palíndromos mútuos.");
        }
    }
}

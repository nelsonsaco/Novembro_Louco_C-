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
    public partial class Form88 : Form
    {
        public Form88()
        {
            InitializeComponent();
        }

        private void Form88_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string verbo = textBox1.Text.Trim().ToLower();

            if (!verbo.EndsWith("er") || verbo.Length < 3)
            {
                listBox1.Items.Add("Digite um verbo regular terminado em ER!");
                return;
            }

            string raiz = verbo.Substring(0, verbo.Length - 2);

            listBox1.Items.Add("Eu " + raiz + "o");
            listBox1.Items.Add("Tu " + raiz + "es");
            listBox1.Items.Add("Ele " + raiz + "e");
            listBox1.Items.Add("Ela " + raiz + "e");
            listBox1.Items.Add("Nós " + raiz + "emos");
            listBox1.Items.Add("Vós " + raiz + "eis");
            listBox1.Items.Add("Eles " + raiz + "em");
            listBox1.Items.Add("Elas " + raiz + "em");

        }
    }
}

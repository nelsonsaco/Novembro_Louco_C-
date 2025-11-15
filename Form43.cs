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
    public partial class Form43 : Form
    {
        private List<int> valores = new List<int>();
        int num;
        public Form43()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num == 9999)
            {
                int maximo = valores.Count > 0 ? valores.Max() : 0;
                label1.Text = $"Maior: {maximo}";
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                valores.Add(num);
                listBox1.Items.Add(num);
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}

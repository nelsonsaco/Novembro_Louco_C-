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
    public partial class Form93 : Form
    {
        public Form93()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int somaPares = 0, somaPrimos = 0;

            string[] entradas = textBox1.Text.Split(' '); // separar os 10 números
            if (entradas.Length != 10)
            {
                MessageBox.Show("Digite exatamente 10 números separados por espaço!");
                return;
            }

            foreach (string s in entradas)
            {
                if (!int.TryParse(s, out int n))
                {
                    MessageBox.Show("Digite apenas números válidos!");
                    return;
                }

                if (n % 2 == 0) somaPares += n;

                if (n > 1)
                {
                    bool primo = true;
                    for (int i = 2; i <= Math.Sqrt(n); i++)
                    {
                        if (n % i == 0)
                        {
                            primo = false;
                            break;
                        }
                    }
                    if (primo) somaPrimos += n;
                }
            }

            listBox1.Items.Add($"Soma dos pares: {somaPares}");
            listBox1.Items.Add($"Soma dos primos: {somaPrimos}");
        }
    }
}

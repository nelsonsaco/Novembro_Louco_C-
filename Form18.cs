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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text); 
            int divisoes = 0;
            List<int> primos = new List<int>();

            for (int num = 2; num <= N; num++)
            {
                bool ehPrimo = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    divisoes++;

                    if (num % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }

                if (ehPrimo)
                    primos.Add(num);
            }

            MessageBox.Show(
                $"Primos até {N}:\n{string.Join(", ", primos)}\n\nTotal de divisões: {divisoes}",
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}

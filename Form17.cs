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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int paisA = 80000;
            int paisB = 200000;
            double taxaA = 0.03;
            double taxaB = 0.015;

            int anos = 0;

            while (paisA <= paisB)
            {
                paisA = (int)(paisA + paisA * taxaA);
                paisB = (int)(paisB + paisB * taxaB);
                anos++;
            }

            MessageBox.Show(
                $"Anos necessários: {anos}\nPopulação final de A: {paisA}\nPopulação final de B: {paisB}",
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}

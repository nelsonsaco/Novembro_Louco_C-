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
    public partial class Form54 : Form
    {
        public Form54()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double chico = 1.50;
            double ze = 1.10;
            double crescimentoChico = 0.02;
            double crescimentoZe = 0.03;
            int anos = 0;

            while (ze <= chico)
            {
                chico += crescimentoChico;
                ze += crescimentoZe;
                anos++;
            }

            MessageBox.Show($"Zé será maior que Chico em {anos} anos.");
        }
    }
}

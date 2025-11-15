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
    public partial class Form50 : Form
    {
        public Form50()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[] linhas = textBox1.Text.Split('\n');

            int maisDe15 = 0;
            int somaVisitantesNaoAsfalto = 0;
            int contNaoAsfalto = 0;

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] p = linha.Split(' ');

                string nome = p[0];
                double dist = double.Parse(p[1]);
                int vis = int.Parse(p[2]);
                int ac = int.Parse(p[3]); // 0 ou 1

                // A)
                if (dist > 15)
                    maisDe15++;

                // B)
                if (ac == 0)
                {
                    somaVisitantesNaoAsfalto += vis;
                    contNaoAsfalto++;
                }

                // C)
                if (ac == 1 && vis < 1000)
                    listBox1.Items.Add($"Asfalto: {nome} - {dist} km");
            }

            double media = contNaoAsfalto > 0 ? somaVisitantesNaoAsfalto / (double)contNaoAsfalto : 0;

            listBox1.Items.Add($"Mais de 15km: {maisDe15}");
            listBox1.Items.Add($"Média visitantes (não asfaltado): {media:F2}");
        }
    }
}

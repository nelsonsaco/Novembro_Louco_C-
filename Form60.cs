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
    public partial class Form60 : Form
    {
        private List<string> matriculas = new List<string>();
        private List<double> notas1 = new List<double>();
        private List<double> notas2 = new List<double>();
        private List<double> notas3 = new List<double>();

        public Form60()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mat;
            double n1, n2, n3;

            if (int.TryParse(textBox1.Text, out mat) && mat != 9999 &&
                double.TryParse(textBox2.Text, out n1) &&
                double.TryParse(textBox3.Text, out n2) &&
                double.TryParse(textBox4.Text, out n3))
            {
                matriculas.Add(mat.ToString());
                notas1.Add(n1);
                notas2.Add(n2);
                notas3.Add(n3);
                MessageBox.Show("Aluno adicionado!");
            }
            else if (mat == 9999)
            {
                MessageBox.Show("Fim da entrada de alunos!");
            }
            else
            {
                MessageBox.Show("Entrada inválida!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aprovados = 0, reprovados = 0;
            listBox1.Items.Clear();

            for (int i = 0; i < matriculas.Count; i++)
            {
                double media = ((2 * notas1[i]) + (3 * notas2[i]) + (4 * notas3[i])) / 9;
                string status = media >= 5 ? "APROVADO" : "REPROVADO";

                if (media >= 5) aprovados++; else reprovados++;

                listBox1.Items.Add($"Matricula: {matriculas[i]}, Media: {media:F2}, {status}");
            }

            listBox1.Items.Add($"Total aprovados: {aprovados}");
            listBox1.Items.Add($"Total reprovados: {reprovados}");
            listBox1.Items.Add($"Total de alunos: {matriculas.Count}");
        }
    }
}

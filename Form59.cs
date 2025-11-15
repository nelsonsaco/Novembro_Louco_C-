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
    public partial class Form59 : Form
    {
        private List<int> idades = new List<int>();
        private List<string> sexos = new List<string>();
        private List<string> olhos = new List<string>();
        private List<string> cabelos = new List<string>();

        public Form59()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade;
            if (int.TryParse(textBox1.Text, out idade) && idade != -1)
            {
                idades.Add(idade);
                sexos.Add(comboBox1.Text);
                olhos.Add(comboBox2.Text);
                cabelos.Add(comboBox3.Text);
                MessageBox.Show("Registro adicionado!");
            }
            else if (idade == -1)
            {
                MessageBox.Show("Fim da coleta de dados!");
            }
            else
            {
                MessageBox.Show("Idade inválida!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idades.Count == 0)
            {
                MessageBox.Show("Nenhum dado para calcular!");
                return;
            }

            int maiorIdade = idades.Max();
            int mulheres18_35 = 0;
            int olhosVerdesCabelosLouros = 0;

            for (int i = 0; i < idades.Count; i++)
            {
                if (sexos[i].ToUpper() == "F" && idades[i] >= 18 && idades[i] <= 35)
                    mulheres18_35++;
                if (olhos[i].ToLower() == "verdes" && cabelos[i].ToLower() == "louros")
                    olhosVerdesCabelosLouros++;
            }

            listBox1.Items.Clear();
            listBox1.Items.Add("Maior idade: " + maiorIdade);
            listBox1.Items.Add("Mulheres entre 18 e 35 anos: " + mulheres18_35);
            listBox1.Items.Add("Olhos verdes e cabelos louros: " + olhosVerdesCabelosLouros);
        }
    }
}

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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(textBox1.Text);
            if (codigo == 99999) return; // fim da leitura

            string sexo = textBox2.Text.ToUpper();
            int horas = int.Parse(textBox3.Text);

            double salarioBruto = horas * 30.0;
            double desconto = (sexo == "M") ? salarioBruto * 0.10 : salarioBruto * 0.05;
            double salarioLiquido = salarioBruto - desconto;

            listBox1.Items.Add($"Código: {codigo} - Bruto: R${salarioBruto:F2} - Líquido: R${salarioLiquido:F2} - Sexo: {sexo}");

            // Limpa os campos após adicionar
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double somaM = 0;
            double somaF = 0;
            int countM = 0;
            int countF = 0;

            foreach (string item in listBox1.Items)
            {
                string[] partes = item.Split('-');
                double salarioLiquido = double.Parse(partes[2].Split('R')[1].Replace("$", "").Trim());
                string sexo = partes[3].Split(':')[1].Trim();

                if (sexo == "M")
                {
                    somaM += salarioLiquido;
                    countM++;
                }
                else if (sexo == "F")
                {
                    somaF += salarioLiquido;
                    countF++;
                }
            }

            double mediaM = (countM > 0) ? somaM / countM : 0;
            double mediaF = (countF > 0) ? somaF / countF : 0;

            MessageBox.Show($"Média salários masculinos: R${mediaM:F2}\nMédia salários femininos: R${mediaF:F2}");
        }
    }
}

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
    public partial class Form74 : Form
    {
        public Form74()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int numero))
            {
                listBox1.Items.Add("Entrada inválida!");
                return;
            }

            if (numero < 20 || numero > 99)
            {
                listBox1.Items.Add("Número fora do intervalo 20-99!");
                return;
            }

            // Se estiver dentro do intervalo, podemos converter por extenso (opcional)
            string[] dezenas = { "", "", "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };
            string[] unidades = { "", "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove" };

            int dez = numero / 10;
            int uni = numero % 10;

            string porExtenso = dezenas[dez];
            if (uni != 0) porExtenso += " e " + unidades[uni];

            listBox1.Items.Add(porExtenso);
        }
    }
}

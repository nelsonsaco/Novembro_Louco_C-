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
    public partial class Form72 : Form
    {
        public Form72()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataInput = textBox1.Text.Trim();
            if (DateTime.TryParseExact(dataInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime data))
            {
                string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                           "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
                string dataExtenso = $"{data.Day} de {meses[data.Month - 1]} de {data.Year}";
                listBox1.Items.Clear();
                listBox1.Items.Add($"Você nasceu em {dataExtenso}");
            }
            else
            {
                MessageBox.Show("Data inválida! Digite no formato dd/mm/aaaa.");
            }
        }
    }
}

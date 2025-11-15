using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_C_
{
    public partial class Form49 : Form
    {
        public Form49()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome1 = textBox1.Text;
            double altura1 = double.Parse(textBox2.Text);
            double peso1 = double.Parse(textBox3.Text);

            string nome2 = textBox4.Text;
            double altura2 = double.Parse(textBox5.Text);
            double peso2 = double.Parse(textBox6.Text);

            // Determinar pessoa mais pesada
            string maisPesada = peso1 > peso2 ? nome1 : nome2;
            double pesoMaisPesado = peso1 > peso2 ? peso1 : peso2;

            // Determinar pessoa mais alta
            string maisAlta = altura1 > altura2 ? nome1 : nome2;
            double alturaMaisAlta = altura1 > altura2 ? altura1 : altura2;

            // Mostrar resultados
            MessageBox.Show($"Pessoa mais pesada: {maisPesada} ({pesoMaisPesado} kg)\n" +
                            $"Pessoa mais alta: {maisAlta} ({alturaMaisAlta} m)");


        }
    }
}

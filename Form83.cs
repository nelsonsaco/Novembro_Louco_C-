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
    public partial class Form83 : Form
    {
         
        public Form83()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Fatorial");
            comboBox1.Items.Add("Par/Ímpar");
            comboBox1.Items.Add("Primo");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int numero))
            {
                MessageBox.Show("Digite um número válido!");
                return;
            }

            string opcao = comboBox1.SelectedItem.ToString();

            if (opcao == "Fatorial")
            {
                long fat = 1;
                for (int i = 2; i <= numero; i++)
                    fat *= i;
                listBox1.Items.Add($"Fatorial de {numero} = {fat}");
            }
            else if (opcao == "Par/Ímpar")
            {
                string resultado = (numero % 2 == 0) ? "Par" : "Ímpar";
                listBox1.Items.Add($"O número {numero} é {resultado}");
            }

            else if(opcao == "Primo")
            {
                if (numero < 2)
                {
                    listBox1.Items.Add(numero + " não é primo");
                }
                else
                {
                    bool primo = true;
                    for (int i = 2; i <= Math.Sqrt(numero); i++)
                    {
                        if (numero % i == 0)
                        {
                            primo = false;
                            break;
                        }
                    }

                    if (primo)
                    {
                        listBox1.Items.Add(numero + " é primo");
                    }
                    else
                    {
                        listBox1.Items.Add(numero + " não é primo");
                    }
                }
            }

        }
    }

}
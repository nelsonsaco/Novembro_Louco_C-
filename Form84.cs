using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicios_C_
{
    public partial class Form84 : Form
    {
        public Form84()
        {
            InitializeComponent();
            comboBox1.Items.Add("Número");
            comboBox1.Items.Add("Texto");
            comboBox1.Items.Add("Números Pares");
            comboBox1.Items.Add("Vogais");
            comboBox1.Items.Add("Primos");
            comboBox1.Items.Add("Lista");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string entrada = textBox1.Text;
            string opcao = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(opcao))
            {
                MessageBox.Show("Escolha uma opção no ComboBox!");
                return;
            }

            if (opcao == "Número")
            {
                if (int.TryParse(entrada, out _))
                    listBox1.Items.Add("Número válido: " + entrada);
                else
                    listBox1.Items.Add("Entrada inválida! Não é um número.");
            }
            else if (opcao == "Texto")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(entrada, @"^[a-zA-Z]+$"))
                    listBox1.Items.Add("Texto válido: " + entrada);
                else
                    listBox1.Items.Add("Entrada inválida! Não é apenas texto.");
            }
            else if (opcao == "Números Pares")
            {
                if (int.TryParse(entrada, out int n) && n % 2 == 0)
                    listBox1.Items.Add("Número par válido: " + n);
                else
                    listBox1.Items.Add("Entrada inválida! Não é número par.");
            }
            else if (opcao == "Vogais")
            {
                if (entrada.Length == 1 && "aeiouAEIOU".Contains(entrada))
                    listBox1.Items.Add("Vogal válida: " + entrada);
                else
                    listBox1.Items.Add("Entrada inválida! Não é uma vogal.");
            }
            else if (opcao == "Primos")
            {
                if (int.TryParse(entrada, out int num))
                {
                    if (num < 2)
                        listBox1.Items.Add(num + " não é primo");
                    else
                    {
                        bool primo = true;
                        for (int i = 2; i <= Math.Sqrt(num); i++)
                        {
                            if (num % i == 0)
                            {
                                primo = false;
                                break;
                            }
                        }
                        listBox1.Items.Add(primo ? num + " é primo" : num + " não é primo");
                    }
                }
                else
                {
                    listBox1.Items.Add("Entrada inválida! Não é um número.");
                }
            }
            else if (opcao == "Lista")
            {
                // exemplo de lista fixa
                int[] lista = { 2, 4, 6, 8, 10 };
                if (int.TryParse(entrada, out int val) && lista.Contains(val))
                    listBox1.Items.Add("Valor válido da lista: " + val);
                else
                    listBox1.Items.Add("Entrada inválida! Não está na lista.");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            string entrada = textBox1.Text;
            string opcao = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(opcao))
            {
                MessageBox.Show("Escolha uma opção no ComboBox!");
                return;
            }

            if (opcao == "Número")
            {
                if (int.TryParse(entrada, out _))
                    listBox1.Items.Add("Número válido: " + entrada);
                else
                    listBox1.Items.Add("Entrada inválida! Não é um número.");
            }
            else if (opcao == "Texto")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(entrada, @"^[a-zA-Z]+$"))
                    listBox1.Items.Add("Texto válido: " + entrada);
                else
                    listBox1.Items.Add("Entrada inválida! Não é apenas texto.");
            }
            else if (opcao == "Números Pares")
            {
                if (int.TryParse(entrada, out int n) && n % 2 == 0)
                    listBox1.Items.Add("Número par válido: " + n);
                else
                    listBox1.Items.Add("Entrada inválida! Não é número par.");
            }
            else if (opcao == "Vogais")
            {
                if (entrada.Length == 1 && "aeiouAEIOU".Contains(entrada))
                    listBox1.Items.Add("Vogal válida: " + entrada);
                else
                    listBox1.Items.Add("Entrada inválida! Não é uma vogal.");
            }
            else if (opcao == "Primos")
            {
                if (int.TryParse(entrada, out int num))
                {
                    if (num < 2)
                        listBox1.Items.Add(num + " não é primo");
                    else
                    {
                        bool primo = true;
                        for (int i = 2; i <= Math.Sqrt(num); i++)
                        {
                            if (num % i == 0)
                            {
                                primo = false;
                                break;
                            }
                        }
                        listBox1.Items.Add(primo ? num + " é primo" : num + " não é primo");
                    }
                }
                else
                {
                    listBox1.Items.Add("Entrada inválida! Não é um número.");
                }
            }
            else if (opcao == "Lista")
            {
                // exemplo de lista fixa
                int[] lista = { 2, 4, 6, 8, 10 };
                if (int.TryParse(entrada, out int val) && lista.Contains(val))
                    listBox1.Items.Add("Valor válido da lista: " + val);
                else
                    listBox1.Items.Add("Entrada inválida! Não está na lista.");
            }
        }
    }
}

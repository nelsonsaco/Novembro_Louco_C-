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
    public partial class Form12 : Form
    {

        private int SomaDivisores(int n)
        {
            int soma = 1; // 1 sempre é divisor
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    soma += i;
            }
            return soma;
        }

        public Form12()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limpa a lista antes de começar

            await Task.Run(() =>
            {
                for (int a = 2; a <= 100000; a++)
                {
                    int b = SomaDivisores(a);

                    if (b > a && b <= 100000)
                    {
                        if (SomaDivisores(b) == a)
                        {
                            // Atualiza o ListBox no thread da UI
                            this.Invoke(new Action(() =>
                            {
                                listBox1.Items.Add($"{a} e {b}");
                            }));
                        }
                    }
                }
            });

        }
                }
            }

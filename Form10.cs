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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private Random rnd = new Random();
        private int numeroAleatorio;
        private DateTime tempoInicio;


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // para o timer

            numeroAleatorio = rnd.Next(10, 100); // número aleatório 10 a 99
            label1.Text = "Agora! " + numeroAleatorio;

            tempoInicio = DateTime.Now; // marca o início do tempo
            textBox1.Enabled = true; // permite o usuário digitar
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ""; // limpa a label
            textBox1.Enabled = false; // desabilita input
            label2.Text = ""; // limpa resultado

            // Intervalo aleatório entre 2 e 5 segundos
            timer1.Interval = rnd.Next(2000, 5000);
            timer1.Start();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int valorDigitado;
                if (int.TryParse(textBox1.Text, out valorDigitado))
                {
                    var tempoFim = DateTime.Now;
                    var tempoReacao = tempoFim - tempoInicio;

                    if (valorDigitado == numeroAleatorio)
                    {
                        label2.Text = "Acertou! Tempo de reação: "
                            + tempoReacao.TotalSeconds.ToString("F3") + " segundos.";
                    }
                    else
                    {
                        label2.Text = "Errou! O número era: " + numeroAleatorio;
                    }
                }
                textBox1.Text = "";
                textBox1.Enabled = false;
            }
        }

        
    }
}

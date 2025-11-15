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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            listBox1.Items.Clear();

            // a) Número de caracteres
            listBox1.Items.Add($"Número de caracteres: {texto.Length}");

            // b) String em maiúsculo
            listBox1.Items.Add($"Maiúsculas: {texto.ToUpper()}");

            // c) Número de vogais
            int contadorVogais = 0;
            foreach (char c in texto.ToLower())
            {
                if ("aeiou".Contains(c))
                    contadorVogais++;
            }
            listBox1.Items.Add($"Número de vogais: {contadorVogais}");

            // d) Começa com UNI
            bool comecaUNI = texto.StartsWith("UNI", StringComparison.OrdinalIgnoreCase);
            listBox1.Items.Add($"Começa com 'UNI'? {comecaUNI}");

            // e) Termina com RIO
            bool terminaRIO = texto.EndsWith("RIO", StringComparison.OrdinalIgnoreCase);
            listBox1.Items.Add($"Termina com 'RIO'? {terminaRIO}");

            // f) Número de dígitos
            int contadorDigitos = 0;
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                    contadorDigitos++;
            }
            listBox1.Items.Add($"Número de dígitos: {contadorDigitos}");

            // g) Palíndromo
            string apenasLetras = "";
            foreach (char c in texto.ToLower())
            {
                if (char.IsLetterOrDigit(c))
                    apenasLetras += c;
            }
            char[] arr = apenasLetras.ToCharArray();
            Array.Reverse(arr);
            string invertido = new string(arr);
            bool ehPalindromo = apenasLetras == invertido;
            listBox1.Items.Add($"É palíndromo? {ehPalindromo}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo._2.Programa._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string nome = "Quentin";
            int x = 3;
            x *= 17;
            double d = Math.PI / 2;
            MessageBox.Show("Nome é: " + nome + "\nx é " + x + "\nd é " + d);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int x = 5;

            if (x == 10)
            {
                MessageBox.Show("X é igual a 10");
            }
            else
            {
                MessageBox.Show("X não é igual a 10");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int valor = 4;
            string nome = "Gustavo";

            if (valor == 2 && nome == "Chrystian")
            {
                MessageBox.Show("O valor é 2 e o nome é Chrystian");
            }
            else
            {
                MessageBox.Show("Essa linha vai rodar não importa o que");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int contador = 0;

            while (contador > 5)
            {
                contador++;
            }

            for (int i = 0; i < 5; i++)
            {
                contador = contador - 1;
            }
            MessageBox.Show("A resposta é: " + contador);
        }
    }
}

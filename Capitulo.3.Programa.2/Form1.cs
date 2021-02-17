using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo._3.Programa._2
{
    public partial class Form1 : Form
    {
        Individuo joe;
        Individuo bob;
        int banco = 100;

        public Form1()
        {
            InitializeComponent();

            joe = new Individuo();
            joe.nome = "joe";
            joe.dinheiro = 50;

            bob = new Individuo() { nome = "bob", dinheiro = 100 };

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (banco >= 10)
            {
                banco -= joe.ReceberDinheiro(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("O banco não possui mais dinheiro suficiente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            banco += bob.DarDinheiro(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bob.dinheiro >= 10)
            {
                bob.DarDinheiro(joe.ReceberDinheiro(10));

                UpdateForm();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (joe.dinheiro >= 10)
            {
                joe.DarDinheiro(10);
                bob.ReceberDinheiro(10);

                UpdateForm();

            }
        }

        public void UpdateForm()
        {
            joeLabel.Text = joe.nome + " possui R$" + joe.dinheiro;
            bobLabel.Text = bob.nome + " possui R$" + bob.dinheiro;
            bancoLabel.Text = "O banco possui R$" + banco;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo._4.Programa._2
{
    public partial class Tela : Form
    {
        Elephant lucinda;
        Elephant lloyd;
        Elephant swap;

        public Tela()
        {
            InitializeComponent();

            lucinda = new Elephant()
            { nome = "Lucinda", tamanhoOrelha = 33 };

            lloyd = new Elephant()
            { nome = "Lloyd", tamanhoOrelha = 40 };

            swap = new Elephant()
            {
                nome = "", tamanhoOrelha = 0
            };
        }

        private void btnLloyd_Click(object sender, EventArgs e)
        {
            lloyd.QuemSouEu();
        }

        private void btnLucinda_Click(object sender, EventArgs e)
        {
            lucinda.QuemSouEu();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            Elephant swap;
            swap = lucinda;
            lucinda = lloyd;
            lloyd = swap;

            MessageBox.Show("Objetos trocados com sucesso!!");
        }
    }
}

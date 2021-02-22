using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo._4.Programa._2
{
    class Elephant
    {
        public int tamanhoOrelha;
        public string nome;

        public void QuemSouEu()
        {
            MessageBox.Show("Minhas orelhas tem " + tamanhoOrelha +"' de altura. " + nome + " falou...");
        }
    }
}
